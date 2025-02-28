namespace Assignment1_CarRental
{
    partial class Booking
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCustomerList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnPersonal = new System.Windows.Forms.RadioButton();
            this.rbtnChartered = new System.Windows.Forms.RadioButton();
            this.cbCartype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCarnumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(917, 192);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(813, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 39);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(451, 389);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 39);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbCustomerList
            // 
            this.cbCustomerList.FormattingEnabled = true;
            this.cbCustomerList.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Mdm"});
            this.cbCustomerList.Location = new System.Drawing.Point(63, 231);
            this.cbCustomerList.Name = "cbCustomerList";
            this.cbCustomerList.Size = new System.Drawing.Size(167, 28);
            this.cbCustomerList.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Booking Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Booking Information";
            // 
            // rbtnPersonal
            // 
            this.rbtnPersonal.AutoSize = true;
            this.rbtnPersonal.Location = new System.Drawing.Point(362, 144);
            this.rbtnPersonal.Name = "rbtnPersonal";
            this.rbtnPersonal.Size = new System.Drawing.Size(96, 24);
            this.rbtnPersonal.TabIndex = 31;
            this.rbtnPersonal.TabStop = true;
            this.rbtnPersonal.Text = "Personal";
            this.rbtnPersonal.UseVisualStyleBackColor = true;
            // 
            // rbtnChartered
            // 
            this.rbtnChartered.AutoSize = true;
            this.rbtnChartered.Location = new System.Drawing.Point(469, 144);
            this.rbtnChartered.Name = "rbtnChartered";
            this.rbtnChartered.Size = new System.Drawing.Size(105, 24);
            this.rbtnChartered.TabIndex = 31;
            this.rbtnChartered.TabStop = true;
            this.rbtnChartered.Text = "Chartered";
            this.rbtnChartered.UseVisualStyleBackColor = true;
            // 
            // cbCartype
            // 
            this.cbCartype.FormattingEnabled = true;
            this.cbCartype.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Mdm"});
            this.cbCartype.Location = new System.Drawing.Point(701, 227);
            this.cbCartype.Name = "cbCartype";
            this.cbCartype.Size = new System.Drawing.Size(167, 28);
            this.cbCartype.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Car Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Car Number";
            // 
            // cbCarnumber
            // 
            this.cbCarnumber.FormattingEnabled = true;
            this.cbCarnumber.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Mdm"});
            this.cbCarnumber.Location = new System.Drawing.Point(701, 145);
            this.cbCarnumber.Name = "cbCarnumber";
            this.cbCarnumber.Size = new System.Drawing.Size(167, 28);
            this.cbCarnumber.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Booking ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(63, 144);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(102, 26);
            this.txtBookID.TabIndex = 18;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 688);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rbtnChartered);
            this.Controls.Add(this.rbtnPersonal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCarnumber);
            this.Controls.Add(this.cbCartype);
            this.Controls.Add(this.cbCustomerList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCustomerList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnPersonal;
        private System.Windows.Forms.RadioButton rbtnChartered;
        private System.Windows.Forms.ComboBox cbCartype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCarnumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookID;
    }
}