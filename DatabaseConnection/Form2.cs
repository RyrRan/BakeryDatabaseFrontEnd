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

namespace DatabaseConnection
{
    public partial class Form2 : Form
    {
        string primaryKey;
        int numOfColumns;
        string[] previousValues = new string[6];
        string currentDessert;

        String connectionStr = "User Id = homeuser;password=password;Data Source =localhost:1521/xe;";

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void PopulateFields(string [] fields)
        {
            primaryKey = fields[0];
            txtCurrentDessertType.Text = fields[0];
            txtCurrentIsSweet.Text = fields[1];
            txtCurrentIsPopular.Text = fields[2];
            txtCurrentNotes.Text = fields[3];
            txtCurrentDateAdded.Text = Convert.ToDateTime(fields[4]).ToShortDateString();
            txtCurrentPrice.Text = fields[5];

            previousValues[0] = fields[0];
            previousValues[1] = fields[1];
            previousValues[2] = fields[2];
            previousValues[3] = fields[3];
            previousValues[4] = Convert.ToDateTime(fields[4]).ToShortDateString();
            previousValues[5] = fields[5];

            numOfColumns = fields.Length;

            //this keeps track of the name of the dessert pulled up even if the user changes the text 
            currentDessert = txtCurrentDessertType.Text;
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            bool isSame = true;

            //See if the data you are modifying is different than what is already in the table
            if(previousValues[0] != txtCurrentDessertType.Text)
            {
                isSame = false;
            }
            else if (previousValues[1] != txtCurrentIsSweet.Text)
            {
                isSame = false;
            }
            else if (previousValues[2] != txtCurrentIsPopular.Text)
            {
                isSame = false;
            }
            else if (previousValues[3] != txtCurrentNotes.Text)
            {
                isSame = false;
            }
            else if (previousValues[4] != txtCurrentDateAdded.Text)
            {
                isSame = false;
            }
            else if (previousValues[5] != txtCurrentPrice.Text)
            {
                isSame = false;
            }

            if (isSame == true)
            {
                MessageBox.Show("New information required in order to update record");
                return;
            }
            else
            {
                InsertIntoTable("UPDATE DESSERTS SET DESSERTTYPE = '" + txtCurrentDessertType.Text + "'," + "ISSWEET='" + txtCurrentIsSweet.Text + "'," + "POPULARITY='" + txtCurrentIsPopular.Text
                    + "'," + "NOTES='" + txtCurrentNotes.Text + "'," + "DATEADDED='" + txtCurrentDateAdded.Text + "'," + "PRICE='" + txtCurrentPrice.Text + "'" + " WHERE DESSERTTYPE='" + primaryKey + "'");
            }
                
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
                if (string.IsNullOrWhiteSpace(txtCurrentDessertType.Text) || string.IsNullOrWhiteSpace(txtCurrentPrice.Text))
                {
                    throw new ArgumentException("Dessert and Price fields cannot be empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            //Step3: Validates the data to ensure datatypes are correct
            try
            {
                bool[] validateData = new bool[3];
                validateData[0] = char.TryParse(txtCurrentIsSweet.Text, out char tOrF);
                validateData[1] = Int32.TryParse(txtCurrentIsPopular.Text, out int popularLevel);
                validateData[2] = float.TryParse(txtCurrentPrice.Text, out float priceInput);

                for (int i = 0; i < validateData.Length; i++)
                {
                    if (validateData[i] == false)
                    {
                        throw new ArgumentException("Invalid datatype inputted in insert fields");
                    }
                }
            }
            catch (ArgumentException ex)
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

                MessageBox.Show("Successfully Updated Record in Database:\n" + "Dessert:" + txtCurrentDessertType.Text + "\nIs it Sweet:" + txtCurrentIsSweet.Text + "\nPopularity:" + txtCurrentIsPopular.Text + "\nNotes:" + txtCurrentNotes.Text + "\nDate Added:" + txtCurrentDateAdded.Text + "\nPrice:" + txtCurrentPrice.Text);

                txtCurrentDessertType.Clear();
                txtCurrentIsSweet.Clear();
                txtCurrentIsPopular.Clear();
                txtCurrentNotes.Clear();
                txtCurrentPrice.Clear();

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

            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult userAction = MessageBox.Show("Are you sure you want to delete " + currentDessert + "?", "Delete Record", MessageBoxButtons.YesNo);

            if (userAction == DialogResult.Yes)
            {
                //Object for Oracle database connection (creating new connection instance)
                OracleConnection con = new OracleConnection();
                con.ConnectionString = connectionStr;

                string deleteStatement = "DELETE FROM desserts WHERE desserttype = '" + txtCurrentDessertType.Text + "'";

                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = deleteStatement;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    int rowsAffected = cmd.ExecuteNonQuery(); //ExecuteNonQuery will return the number of rows affected by executing the delete query
                    con.Close();

                    if (rowsAffected == 1) //if the record was successfully deleted
                    {
                        MessageBox.Show("Successfully Deleted Record in Database:\n" + "Dessert:" + txtCurrentDessertType.Text + "\nIs it Sweet:" + txtCurrentIsSweet.Text + "\nPopularity:" + txtCurrentIsPopular.Text + "\nNotes:" + txtCurrentNotes.Text + "\nDate Added:" + txtCurrentDateAdded.Text + "\nPrice:" + txtCurrentPrice.Text);
                        txtCurrentDessertType.Clear();
                        txtCurrentIsSweet.Clear();
                        txtCurrentIsPopular.Clear();
                        txtCurrentNotes.Clear();
                        txtCurrentPrice.Clear();

                        this.Close();

                    }
                    else if (rowsAffected == 0)
                    {
                        MessageBox.Show("Could not delete record from database. Please close window and retry.");
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete record from database. Please close window and retry.");
                }
            }
        }
    }
}
