namespace Assignment1_CarRental
{
    partial class Dashboard
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
            this.btnCustReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCarReg = new System.Windows.Forms.Button();
            this.btnCarReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustReg
            // 
            this.btnCustReg.Location = new System.Drawing.Point(106, 114);
            this.btnCustReg.Name = "btnCustReg";
            this.btnCustReg.Size = new System.Drawing.Size(198, 94);
            this.btnCustReg.TabIndex = 0;
            this.btnCustReg.Text = "Customer Registration";
            this.btnCustReg.UseVisualStyleBackColor = true;
            this.btnCustReg.Click += new System.EventHandler(this.btnCustReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Rental Shop";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(451, 114);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(198, 94);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCarReg
            // 
            this.btnCarReg.Location = new System.Drawing.Point(106, 283);
            this.btnCarReg.Name = "btnCarReg";
            this.btnCarReg.Size = new System.Drawing.Size(198, 94);
            this.btnCarReg.TabIndex = 0;
            this.btnCarReg.Text = "Car Registration";
            this.btnCarReg.UseVisualStyleBackColor = true;
            this.btnCarReg.Click += new System.EventHandler(this.btnCarReg_Click);
            // 
            // btnCarReturn
            // 
            this.btnCarReturn.Location = new System.Drawing.Point(451, 283);
            this.btnCarReturn.Name = "btnCarReturn";
            this.btnCarReturn.Size = new System.Drawing.Size(198, 94);
            this.btnCarReturn.TabIndex = 0;
            this.btnCarReturn.Text = "Car Return";
            this.btnCarReturn.UseVisualStyleBackColor = true;
            this.btnCarReturn.Click += new System.EventHandler(this.btnCarReturn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarReturn);
            this.Controls.Add(this.btnCarReg);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCustReg);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCarReg;
        private System.Windows.Forms.Button btnCarReturn;
    }
}

