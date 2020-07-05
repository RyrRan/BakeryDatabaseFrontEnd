namespace DatabaseConnection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPopularity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtSweet = new System.Windows.Forms.TextBox();
            this.txtDessert = new System.Windows.Forms.TextBox();
            this.btnAddDessert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPriceHeader = new System.Windows.Forms.Label();
            this.lblDateAddedHeader = new System.Windows.Forms.Label();
            this.lblNotesHeader = new System.Windows.Forms.Label();
            this.lblPopularHeader = new System.Windows.Forms.Label();
            this.lblSweetHeader = new System.Windows.Forms.Label();
            this.lblDessertHeader = new System.Windows.Forms.Label();
            this.txtPriceSearch = new System.Windows.Forms.TextBox();
            this.txtDateSearch = new System.Windows.Forms.TextBox();
            this.txtNotesSearch = new System.Windows.Forms.TextBox();
            this.txtPopularSearch = new System.Windows.Forms.TextBox();
            this.txtSweetSearch = new System.Windows.Forms.TextBox();
            this.txtDessertSearch = new System.Windows.Forms.TextBox();
            this.dgv_Results = new System.Windows.Forms.DataGridView();
            this.btn_action = new System.Windows.Forms.Button();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPopularity);
            this.tabPage2.Controls.Add(this.txtPrice);
            this.tabPage2.Controls.Add(this.txtDate);
            this.tabPage2.Controls.Add(this.txtNotes);
            this.tabPage2.Controls.Add(this.txtSweet);
            this.tabPage2.Controls.Add(this.txtDessert);
            this.tabPage2.Controls.Add(this.btnAddDessert);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1470, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Dessert";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPopularity
            // 
            this.txtPopularity.Location = new System.Drawing.Point(135, 121);
            this.txtPopularity.Name = "txtPopularity";
            this.txtPopularity.Size = new System.Drawing.Size(274, 20);
            this.txtPopularity.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(135, 239);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(274, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(135, 203);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(274, 20);
            this.txtDate.TabIndex = 4;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(135, 162);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(274, 20);
            this.txtNotes.TabIndex = 3;
            // 
            // txtSweet
            // 
            this.txtSweet.Location = new System.Drawing.Point(135, 82);
            this.txtSweet.Name = "txtSweet";
            this.txtSweet.Size = new System.Drawing.Size(274, 20);
            this.txtSweet.TabIndex = 1;
            // 
            // txtDessert
            // 
            this.txtDessert.Location = new System.Drawing.Point(135, 40);
            this.txtDessert.Name = "txtDessert";
            this.txtDessert.Size = new System.Drawing.Size(274, 20);
            this.txtDessert.TabIndex = 0;
            // 
            // btnAddDessert
            // 
            this.btnAddDessert.Location = new System.Drawing.Point(12, 298);
            this.btnAddDessert.Name = "btnAddDessert";
            this.btnAddDessert.Size = new System.Drawing.Size(397, 23);
            this.btnAddDessert.TabIndex = 13;
            this.btnAddDessert.Text = "Add Dessert";
            this.btnAddDessert.UseVisualStyleBackColor = true;
            this.btnAddDessert.Click += new System.EventHandler(this.btnAddDessert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Notes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Popularity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Is it Sweet (T or F):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name of Dessert:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Dessert to Records";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.lblPriceHeader);
            this.tabPage1.Controls.Add(this.lblDateAddedHeader);
            this.tabPage1.Controls.Add(this.lblNotesHeader);
            this.tabPage1.Controls.Add(this.lblPopularHeader);
            this.tabPage1.Controls.Add(this.lblSweetHeader);
            this.tabPage1.Controls.Add(this.lblDessertHeader);
            this.tabPage1.Controls.Add(this.txtPriceSearch);
            this.tabPage1.Controls.Add(this.txtDateSearch);
            this.tabPage1.Controls.Add(this.txtNotesSearch);
            this.tabPage1.Controls.Add(this.txtPopularSearch);
            this.tabPage1.Controls.Add(this.txtSweetSearch);
            this.tabPage1.Controls.Add(this.txtDessertSearch);
            this.tabPage1.Controls.Add(this.dgv_Results);
            this.tabPage1.Controls.Add(this.btn_action);
            this.tabPage1.Controls.Add(this.btnExportToCSV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1470, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(837, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(456, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NOTE: Click on the value of a row in the resulting table to open editing window t" +
    "o modify record";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(840, 359);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(268, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPriceHeader
            // 
            this.lblPriceHeader.AutoSize = true;
            this.lblPriceHeader.Location = new System.Drawing.Point(840, 290);
            this.lblPriceHeader.Name = "lblPriceHeader";
            this.lblPriceHeader.Size = new System.Drawing.Size(34, 13);
            this.lblPriceHeader.TabIndex = 23;
            this.lblPriceHeader.Text = "Price:";
            // 
            // lblDateAddedHeader
            // 
            this.lblDateAddedHeader.AutoSize = true;
            this.lblDateAddedHeader.Location = new System.Drawing.Point(840, 234);
            this.lblDateAddedHeader.Name = "lblDateAddedHeader";
            this.lblDateAddedHeader.Size = new System.Drawing.Size(67, 13);
            this.lblDateAddedHeader.TabIndex = 22;
            this.lblDateAddedHeader.Text = "Date Added:";
            // 
            // lblNotesHeader
            // 
            this.lblNotesHeader.AutoSize = true;
            this.lblNotesHeader.Location = new System.Drawing.Point(840, 182);
            this.lblNotesHeader.Name = "lblNotesHeader";
            this.lblNotesHeader.Size = new System.Drawing.Size(38, 13);
            this.lblNotesHeader.TabIndex = 21;
            this.lblNotesHeader.Text = "Notes:";
            // 
            // lblPopularHeader
            // 
            this.lblPopularHeader.AutoSize = true;
            this.lblPopularHeader.Location = new System.Drawing.Point(840, 124);
            this.lblPopularHeader.Name = "lblPopularHeader";
            this.lblPopularHeader.Size = new System.Drawing.Size(86, 13);
            this.lblPopularHeader.TabIndex = 20;
            this.lblPopularHeader.Text = "Popularity (1-10):";
            // 
            // lblSweetHeader
            // 
            this.lblSweetHeader.AutoSize = true;
            this.lblSweetHeader.Location = new System.Drawing.Point(840, 71);
            this.lblSweetHeader.Name = "lblSweetHeader";
            this.lblSweetHeader.Size = new System.Drawing.Size(96, 13);
            this.lblSweetHeader.TabIndex = 19;
            this.lblSweetHeader.Text = "Is it Sweet (T or F):";
            // 
            // lblDessertHeader
            // 
            this.lblDessertHeader.AutoSize = true;
            this.lblDessertHeader.Location = new System.Drawing.Point(840, 21);
            this.lblDessertHeader.Name = "lblDessertHeader";
            this.lblDessertHeader.Size = new System.Drawing.Size(73, 13);
            this.lblDessertHeader.TabIndex = 18;
            this.lblDessertHeader.Text = "Dessert Type:";
            // 
            // txtPriceSearch
            // 
            this.txtPriceSearch.Location = new System.Drawing.Point(840, 306);
            this.txtPriceSearch.Name = "txtPriceSearch";
            this.txtPriceSearch.Size = new System.Drawing.Size(268, 20);
            this.txtPriceSearch.TabIndex = 17;
            // 
            // txtDateSearch
            // 
            this.txtDateSearch.Location = new System.Drawing.Point(840, 250);
            this.txtDateSearch.Name = "txtDateSearch";
            this.txtDateSearch.Size = new System.Drawing.Size(268, 20);
            this.txtDateSearch.TabIndex = 16;
            // 
            // txtNotesSearch
            // 
            this.txtNotesSearch.Location = new System.Drawing.Point(840, 198);
            this.txtNotesSearch.Name = "txtNotesSearch";
            this.txtNotesSearch.Size = new System.Drawing.Size(268, 20);
            this.txtNotesSearch.TabIndex = 15;
            // 
            // txtPopularSearch
            // 
            this.txtPopularSearch.Location = new System.Drawing.Point(840, 140);
            this.txtPopularSearch.Name = "txtPopularSearch";
            this.txtPopularSearch.Size = new System.Drawing.Size(268, 20);
            this.txtPopularSearch.TabIndex = 14;
            // 
            // txtSweetSearch
            // 
            this.txtSweetSearch.Location = new System.Drawing.Point(840, 87);
            this.txtSweetSearch.Name = "txtSweetSearch";
            this.txtSweetSearch.Size = new System.Drawing.Size(268, 20);
            this.txtSweetSearch.TabIndex = 13;
            // 
            // txtDessertSearch
            // 
            this.txtDessertSearch.Location = new System.Drawing.Point(840, 40);
            this.txtDessertSearch.Name = "txtDessertSearch";
            this.txtDessertSearch.Size = new System.Drawing.Size(268, 20);
            this.txtDessertSearch.TabIndex = 12;
            // 
            // dgv_Results
            // 
            this.dgv_Results.AllowUserToAddRows = false;
            this.dgv_Results.AllowUserToDeleteRows = false;
            this.dgv_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Results.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Results.Location = new System.Drawing.Point(8, 40);
            this.dgv_Results.Name = "dgv_Results";
            this.dgv_Results.ReadOnly = true;
            this.dgv_Results.Size = new System.Drawing.Size(798, 443);
            this.dgv_Results.TabIndex = 5;
            this.dgv_Results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Results_CellContentClick);
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(840, 398);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(275, 23);
            this.btn_action.TabIndex = 0;
            this.btn_action.Text = "Display All Dessert Details";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Location = new System.Drawing.Point(8, 509);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(274, 23);
            this.btnExportToCSV.TabIndex = 6;
            this.btnExportToCSV.Text = "Export Report to Excel";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1478, 599);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 603);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Desserts System";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPopularity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtSweet;
        private System.Windows.Forms.TextBox txtDessert;
        private System.Windows.Forms.Button btnAddDessert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPriceHeader;
        private System.Windows.Forms.Label lblDateAddedHeader;
        private System.Windows.Forms.Label lblNotesHeader;
        private System.Windows.Forms.Label lblPopularHeader;
        private System.Windows.Forms.Label lblSweetHeader;
        private System.Windows.Forms.Label lblDessertHeader;
        private System.Windows.Forms.TextBox txtPriceSearch;
        private System.Windows.Forms.TextBox txtDateSearch;
        private System.Windows.Forms.TextBox txtNotesSearch;
        private System.Windows.Forms.TextBox txtPopularSearch;
        private System.Windows.Forms.TextBox txtSweetSearch;
        private System.Windows.Forms.TextBox txtDessertSearch;
        private System.Windows.Forms.DataGridView dgv_Results;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label8;
    }
}

