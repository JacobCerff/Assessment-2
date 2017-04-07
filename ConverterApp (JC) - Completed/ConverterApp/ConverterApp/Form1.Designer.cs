namespace ConverterApp
{
    partial class frm_Main
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
            this.lbl_UofM = new System.Windows.Forms.Label();
            this.txt_Cm_To_Inhces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clr = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Meters_To_Feet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cm_To_Feet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Km_To_Miles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Celsuis_To_Fahrenheit = new System.Windows.Forms.TextBox();
            this.btn_Covert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UofM
            // 
            this.lbl_UofM.AutoSize = true;
            this.lbl_UofM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UofM.Location = new System.Drawing.Point(11, 20);
            this.lbl_UofM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UofM.Name = "lbl_UofM";
            this.lbl_UofM.Size = new System.Drawing.Size(150, 18);
            this.lbl_UofM.TabIndex = 0;
            this.lbl_UofM.Text = "Unit of Measurement:";
            // 
            // txt_Cm_To_Inhces
            // 
            this.txt_Cm_To_Inhces.Location = new System.Drawing.Point(14, 57);
            this.txt_Cm_To_Inhces.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cm_To_Inhces.Name = "txt_Cm_To_Inhces";
            this.txt_Cm_To_Inhces.Size = new System.Drawing.Size(112, 20);
            this.txt_Cm_To_Inhces.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Converter Results:";
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(204, 249);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(80, 23);
            this.btn_clr.TabIndex = 13;
            this.btn_clr.Text = "Clear Results";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(185, 51);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(120, 186);
            this.lstBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Centimeters to Inches:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Meters to Feet:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Meters_To_Feet
            // 
            this.txt_Meters_To_Feet.Location = new System.Drawing.Point(14, 100);
            this.txt_Meters_To_Feet.Name = "txt_Meters_To_Feet";
            this.txt_Meters_To_Feet.Size = new System.Drawing.Size(112, 20);
            this.txt_Meters_To_Feet.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Centimeters to Feet:";
            // 
            // txt_Cm_To_Feet
            // 
            this.txt_Cm_To_Feet.Location = new System.Drawing.Point(14, 143);
            this.txt_Cm_To_Feet.Name = "txt_Cm_To_Feet";
            this.txt_Cm_To_Feet.Size = new System.Drawing.Size(112, 20);
            this.txt_Cm_To_Feet.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kilometers to Miles:";
            // 
            // txt_Km_To_Miles
            // 
            this.txt_Km_To_Miles.Location = new System.Drawing.Point(14, 187);
            this.txt_Km_To_Miles.Name = "txt_Km_To_Miles";
            this.txt_Km_To_Miles.Size = new System.Drawing.Size(112, 20);
            this.txt_Km_To_Miles.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Celsius to Fahrenheit:";
            // 
            // txt_Celsuis_To_Fahrenheit
            // 
            this.txt_Celsuis_To_Fahrenheit.Location = new System.Drawing.Point(14, 228);
            this.txt_Celsuis_To_Fahrenheit.Name = "txt_Celsuis_To_Fahrenheit";
            this.txt_Celsuis_To_Fahrenheit.Size = new System.Drawing.Size(112, 20);
            this.txt_Celsuis_To_Fahrenheit.TabIndex = 23;
            // 
            // btn_Covert
            // 
            this.btn_Covert.Location = new System.Drawing.Point(14, 265);
            this.btn_Covert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Covert.Name = "btn_Covert";
            this.btn_Covert.Size = new System.Drawing.Size(125, 30);
            this.btn_Covert.TabIndex = 24;
            this.btn_Covert.Text = "Covert";
            this.btn_Covert.UseVisualStyleBackColor = true;
            this.btn_Covert.Click += new System.EventHandler(this.btn_Covert_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 315);
            this.Controls.Add(this.btn_Covert);
            this.Controls.Add(this.txt_Celsuis_To_Fahrenheit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Km_To_Miles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cm_To_Feet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Meters_To_Feet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cm_To_Inhces);
            this.Controls.Add(this.lbl_UofM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UofM;
        private System.Windows.Forms.TextBox txt_Cm_To_Inhces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Meters_To_Feet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cm_To_Feet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Km_To_Miles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Celsuis_To_Fahrenheit;
        private System.Windows.Forms.Button btn_Covert;
    }
}

