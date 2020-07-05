using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Microsoft;

    namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        //UserId, password, and database to connect to 
        String connectionStr = "User Id = homeuser;password=password;Data Source =localhost:1521/xe;";

        //The form used to modify a current record
        Form2 modifyCurrentRowForm = new Form2();

        public Form1()
        {
            InitializeComponent();
            //Pre-sets the dateadded when adding new desserts to the current date by default
            SetControls();   
        }


        private void btn_action_Click(object sender, EventArgs e)
        {
            RunQuery("SELECT * FROM DESSERTS");
        }




        public void RunQuery(string query)
        {
            //Object for Oracle database connection (creating new connection instance)
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionStr;


            string results = "";

            try
            {
                //Opens that database connection as created above
                con.Open();

                //new Oracle command to query the database
                OracleCommand cmd = new OracleCommand();
                //SQL Query to run (the text in the command)
                cmd.CommandText = query;
                cmd.Connection = con;

                //Executing the database command
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();


                //This will get the column names and display them at the start of the print
                /*for (int j = 0; j < dr.FieldCount; j++)
                {
                    MessageBox.Show(dr.GetName(j));
                    queryResultsList.Add(dr.GetName(j));
                }*/
                

                //Loops to read the query results
                while (dr.Read())
                {
                    //The reader will have read the entire row (this will find the number of columns)
                    int numOfColumns = dr.FieldCount;
                    string[] columnValues = new string[numOfColumns];

                    //loops through each column and retrieves the value 
                    for (int r = 0; r < numOfColumns; r++)
                    {
                        //if the reader is not NULL (if there is a value to read then proceeed to add the value to the results string
                        if (!dr.IsDBNull(r))
                        {
                            //MessageBox.Show(Convert.ToString(dr.GetFieldType(r)));    //USED TO DISPLAY THE DATATYPE OF A CURRENT COLUMN
                            if (Convert.ToString(dr.GetFieldType(r)) == "System.String")
                            {
                                results += dr.GetString(r) + " ";
                            }
                            else if (Convert.ToString(dr.GetFieldType(r)) == "System.Decimal")
                            {
                                //MessageBox.Show("This is the number" + dr.GetDecimal(r));
                                results += Convert.ToString(dr.GetDecimal(r)) + " ";
                            }
                        }
                        else
                            results += "NULL ";
                    }
                    results = "";
                }

                //Method 1:
                OracleDataAdapter sqlData = new OracleDataAdapter(query, con);
                DataTable gridViewResults = new DataTable();
                sqlData.Fill(gridViewResults);
                dgv_Results.DataSource = gridViewResults;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read from database");
            }

            //Closes the database connection once done
            con.Close();

        }

        private void dgv_Results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //check in place to prevent code from running if user clicks on header
            if (e.RowIndex >= 0)
            {
                //will get the value of the cell that is clicked on
                String cell = Convert.ToString(dgv_Results.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                //takes the value of each column in the row and stores it
                string[] selectedRow = new string[6];
                for (int i = 0; i < selectedRow.Length; i++)
                {
                    selectedRow[i] = Convert.ToString(dgv_Results.Rows[e.RowIndex].Cells[i].Value);
                    //MessageBox.Show(selectedRow[i]);
                }

                modifyCurrentRowForm.PopulateFields(selectedRow);
                modifyCurrentRowForm.ShowDialog();
            }
        }

        private void btnAddDessert_Click(object sender, EventArgs e)
        {
            string record = "'" + txtDessert.Text + "'" + "," + "'" + txtSweet.Text + "'" + "," + txtPopularity.Text + "," + "'" + txtNotes.Text + "'" + "," + "'" + txtDate.Text + "'" + "," + txtPrice.Text;
            string queryAdd = "INSERT INTO DESSERTS VALUES(" + record + ")";
            InsertIntoTable(queryAdd);
            modifyCurrentRowForm.Hide();
        }

        private void InsertIntoTable(String insertStatement)
        {
            //Task 1: Check if dessertype being inserted already exists in database
            //2: Make sure that the NOT NULL columns (DessertType, Price) have data in the textboxes
            //3: Make sure all data in the textboxes is valid (Popularity is a number)
            //4: MessageBox showing what you are trying to add in and ask user to confirm

            //Object for Oracle database connection (creating new connection instance)
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionStr;

            //Step1: Ensure that the primary key: desserttype does not already exist in the database
            //This is done in the try-catch while inserting. The exception error is checked to determine if it was due to a primary key duplicate


            //Step2: Ensure NOT NULL columns have filled in data (DessertType, Price)
            try
            {
                if(string.IsNullOrWhiteSpace(txtDessert.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    throw new ArgumentException("Dessert and Price fields cannot be empty");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            //Step3: Validates the data to ensure datatypes are correct
            try
            { 
                bool[] validateData = new bool[3];
                validateData[0] = char.TryParse(txtSweet.Text, out char tOrF);
                validateData[1] = Int32.TryParse(txtPopularity.Text, out int popularLevel);
                validateData[2] = float.TryParse(txtPrice.Text, out float priceInput);

                for (int i = 0; i < validateData.Length; i++)
                {
                    if (validateData[i] == false)
                    {
                        throw new ArgumentException("Invalid datatype inputted in insert fields");
                    }
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            //Step4: Reads the user entered data from the text fields and then inserts the new record into the database
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = insertStatement;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) { }
                con.Close();

                MessageBox.Show("Successfully Added Record to Database:\n" + "Dessert:" + txtDessert.Text + "\nIs it Sweet:" + txtSweet.Text + "\nPopularity:" + txtPopularity.Text + "\nNotes:" + txtNotes.Text + "\nDate Added:" + txtDate.Text + "\nPrice:" + txtPrice.Text);

                txtDessert.Clear();
                txtSweet.Clear();
                txtPopularity.Clear();
                txtNotes.Clear();
                txtPrice.Clear();

            }
            catch (Exception ex)
            {
                //Checks if the insert error is due to an already existing desserttype (primary key in database)
                if (ex.Message.Contains("unique constraint")) //Message = "ORA-00001: unique constraint (HOMEUSER.SYS_C009071) violated"
                {
                    MessageBox.Show("This dessert already exists");
                }
                else
                {
                    MessageBox.Show("Could not add entry to database");
                }
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void SetControls()
        {
            txtDate.Text = DateTime.UtcNow.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //first item is the search field and the second is the data in the textbox
            List<Tuple<string,string>> searchCriteria = new List<Tuple<string,string>>();

            //if a textbox has data entered for search criteria use it for the select query
            if(!string.IsNullOrWhiteSpace(txtDessertSearch.Text))
            {
                Tuple<string, string> dessertCriteria = new Tuple<string, string>("dessertType", txtDessertSearch.Text);
                searchCriteria.Add(dessertCriteria);
            }
            if (!string.IsNullOrWhiteSpace(txtSweetSearch.Text))
            {
                Tuple<string, string> sweetCriteria = new Tuple<string, string>("isSweet", txtSweetSearch.Text);
                searchCriteria.Add(sweetCriteria);
            }
            if (!string.IsNullOrWhiteSpace(txtPopularSearch.Text))
            {
                Tuple<string, string> popularCriteria = new Tuple<string, string>("popularity", txtPopularSearch.Text);
                searchCriteria.Add(popularCriteria);
            }
            if (!string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                Tuple<string, string> notesCriteria = new Tuple<string, string>("notes", txtNotesSearch.Text);
                searchCriteria.Add(notesCriteria);
            }
            if (!string.IsNullOrWhiteSpace(txtDateSearch.Text))
            {
                Tuple<string, string> dateCriteria = new Tuple<string, string>("dateadded", txtDateSearch.Text);
                searchCriteria.Add(dateCriteria);
            }
            if (!string.IsNullOrWhiteSpace(txtPriceSearch.Text))
            {
                Tuple<string, string> priceCriteria = new Tuple<string, string>("price", txtPriceSearch.Text);
                searchCriteria.Add(priceCriteria);
            }

            //builds the select query based on the search criteria entered by the user
            string searchQuery = "SELECT * FROM DESSERTS WHERE ";
            for(int i = 0; i < searchCriteria.Count; i++)
            {
                searchQuery += "upper(" + searchCriteria[i].Item1 + ") " + " like " + "CAST(upper('%" + searchCriteria[i].Item2 + "%') AS varchar(100))";

                if (i != searchCriteria.Count - 1)
                {
                    searchQuery += " AND ";
                }
            }
            if(searchCriteria.Count == 0)
            {
                MessageBox.Show("Please enter search criteria before clicking Search");
            }
            else
            {
                MessageBox.Show(searchQuery);
                RunQuery(searchQuery);
            }

        }

        private void searchResults()
        {
            string dessertSearch = txtDessertSearch.Text;

        }

        private void ExportToExcel()
        {
            //Opens MS Excel application
            Microsoft.Office.Interop.Excel.Application excelFile = new Microsoft.Office.Interop.Excel.Application();
            //initialize workbook and worksheet to write data to
            Microsoft.Office.Interop.Excel.Workbook workbook = excelFile.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets["Sheet1"];
            //set created worksheet as the active sheet in the workbook
            worksheet = workbook.ActiveSheet;
            //change worksheet name
            worksheet.Name = "DessertList";

            //Excel worksheet cells use non-zero indexing so the cells start at (1,1)
            //Retrieve column names and write to excel worksheet
            for (int i = 0; i < dgv_Results.ColumnCount; i++)
            {
                worksheet.Cells[1, i+1] = dgv_Results.Columns[i].HeaderText;
            }

            //loop through results table and write it to excel worksheet
            for (int i = 0; i < dgv_Results.RowCount; i++)
            {
                for (int j = 0; j < dgv_Results.ColumnCount; j++)
                {
                    worksheet.Cells[i+2, j+1] = dgv_Results.Rows[i].Cells[j].Value.ToString();
                }
            }
            excelFile.Columns.AutoFit();

            //Prompt user if they want to save the file
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "BakeryDessertList";
            saveFile.DefaultExt = ".xlsx";

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Excel file successfully saved");
            }
            excelFile.Quit();

        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
 