namespace DatabaseConnection
{
    partial class Form2
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
            this.txtCurrentDessertType = new System.Windows.Forms.TextBox();
            this.txtCurrentIsSweet = new System.Windows.Forms.TextBox();
            this.txtCurrentIsPopular = new System.Windows.Forms.TextBox();
            this.txtCurrentNotes = new System.Windows.Forms.TextBox();
            this.txtCurrentDateAdded = new System.Windows.Forms.TextBox();
            this.txtCurrentPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCurrentDessertType
            // 
            this.txtCurrentDessertType.Location = new System.Drawing.Point(12, 35);
            this.txtCurrentDessertType.Name = "txtCurrentDessertType";
            this.txtCurrentDessertType.Size = new System.Drawing.Size(268, 20);
            this.txtCurrentDessertType.TabIndex = 0;
            // 
            // txtCurrentIsSweet
            // 
            this.txtCurrentIsSweet.Location = new System.Drawing.Point(12, 82);
            this.txtCurrentIsSweet.Name = "txtCurrentIsSweet";
            this.txtCurrentIsSweet.Size = new System.Drawing.Size(268, 20);
            this.txtCurrentIsSweet.TabIndex = 1;
            // 
            // txtCurrentIsPopular
            // 
            this.txtCurrentIsPopular.Location = new System.Drawing.Point(12, 135);
            this.txtCurrentIsPopular.Name = "txtCurrentIsPopular";
            this.txtCurrentIsPopular.Size = new System.Drawing.Size(268, 20);
            this.txtCurrentIsPopular.TabIndex = 2;
            // 
            // txtCurrentNotes
            // 
            this.txtCurrentNotes.Location = new System.Drawing.Point(12, 193);
            this.txtCurrentNotes.Name = "txtCurrentNotes";
            this.txtCurrentNotes.Size = new System.Drawing.Size(268, 20);
            this.txtCurrentNotes.TabIndex = 3;
            // 
            // txtCurrentDateAdded
            // 
            this.txtCurrentDateAdded.Location = new System.Drawing.Point(12, 245);
            this.txtCurrentDateAdded.Name = "txtCurrentDateAdded";
            this.txtCurrentDateAdded.Size = new System.Drawing.Size(268, 20);
            this.txtCurrentDateAdded.TabIndex = 4;
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Location = new System.Drawing.Point(12, 301);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.Size = new System.Drawing.Size(268, 20);
            this.txtCurrentPrice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dessert Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Is it Sweet (T or F):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Popularity (1-10):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Notes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date Added:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price:";
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(12, 357);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRecord.TabIndex = 12;
            this.btnUpdateRecord.Text = "Save";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(205, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 403);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentPrice);
            this.Controls.Add(this.txtCurrentDateAdded);
            this.Controls.Add(this.txtCurrentNotes);
            this.Controls.Add(this.txtCurrentIsPopular);
            this.Controls.Add(this.txtCurrentIsSweet);
            this.Controls.Add(this.txtCurrentDessertType);
            this.Name = "Form2";
            this.Text = "Update or Delete";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentDessertType;
        private System.Windows.Forms.TextBox txtCurrentIsSweet;
        private System.Windows.Forms.TextBox txtCurrentIsPopular;
        private System.Windows.Forms.TextBox txtCurrentNotes;
        private System.Windows.Forms.TextBox txtCurrentDateAdded;
        private System.Windows.Forms.TextBox txtCurrentPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnDelete;
    }
}