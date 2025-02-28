namespace Assignment1_CarRental
{
    partial class CarRegistration
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegYear = new System.Windows.Forms.NumericUpDown();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtSpec = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtCarDesc = new System.Windows.Forms.TextBox();
            this.txtCarnumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.carEngine = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(917, 192);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(856, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 39);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(619, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 39);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(349, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 39);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Car Information";
            // 
            // txtRegYear
            // 
            this.txtRegYear.Location = new System.Drawing.Point(74, 223);
            this.txtRegYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.txtRegYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txtRegYear.Name = "txtRegYear";
            this.txtRegYear.Size = new System.Drawing.Size(176, 26);
            this.txtRegYear.TabIndex = 57;
            this.txtRegYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Hatchback",
            "Sedan",
            "Wagon",
            "12-Seater Van",
            "20-Seater Van",
            "42-Seater Van",
            "5 Seaters",
            "7 Seaters"});
            this.cbType.Location = new System.Drawing.Point(774, 221);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(176, 28);
            this.cbType.TabIndex = 56;
            // 
            // txtSpec
            // 
            this.txtSpec.FormattingEnabled = true;
            this.txtSpec.Location = new System.Drawing.Point(420, 221);
            this.txtSpec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(176, 28);
            this.txtSpec.TabIndex = 55;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(420, 300);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(176, 26);
            this.txtColor.TabIndex = 54;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(74, 300);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(176, 26);
            this.txtModel.TabIndex = 53;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(774, 147);
            this.txtEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(176, 26);
            this.txtEngine.TabIndex = 52;
            // 
            // txtCarDesc
            // 
            this.txtCarDesc.Location = new System.Drawing.Point(420, 147);
            this.txtCarDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarDesc.Name = "txtCarDesc";
            this.txtCarDesc.Size = new System.Drawing.Size(225, 26);
            this.txtCarDesc.TabIndex = 51;
            // 
            // txtCarnumber
            // 
            this.txtCarnumber.Location = new System.Drawing.Point(74, 147);
            this.txtCarnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarnumber.Name = "txtCarnumber";
            this.txtCarnumber.Size = new System.Drawing.Size(176, 26);
            this.txtCarnumber.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(770, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(416, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Specification";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(416, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "Color";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 278);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 46;
            this.label16.Text = "Model";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(70, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "Register Year";
            // 
            // carEngine
            // 
            this.carEngine.AutoSize = true;
            this.carEngine.Location = new System.Drawing.Point(770, 125);
            this.carEngine.Name = "carEngine";
            this.carEngine.Size = new System.Drawing.Size(59, 20);
            this.carEngine.TabIndex = 44;
            this.carEngine.Text = "Engine";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(416, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 20);
            this.label19.TabIndex = 43;
            this.label19.Text = "Description";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(70, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 20);
            this.label20.TabIndex = 42;
            this.label20.Text = "Car Number";
            // 
            // CarRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 697);
            this.Controls.Add(this.txtRegYear);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.txtCarDesc);
            this.Controls.Add(this.txtCarnumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.carEngine);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "CarRegistration";
            this.Text = "CarRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtRegYear;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox txtSpec;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtCarDesc;
        private System.Windows.Forms.TextBox txtCarnumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label carEngine;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}