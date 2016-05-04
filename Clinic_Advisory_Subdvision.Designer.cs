namespace TAR
{
    partial class Clinic_Advisory_Subdvision
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
            this.button_Clinic_Advisory = new System.Windows.Forms.Button();
            this.button_Dental_Office = new System.Windows.Forms.Button();
            this.button_Dental_Surgery_Office = new System.Windows.Forms.Button();
            this.button_Diagnostic_Study = new System.Windows.Forms.Button();
            this.button_Surdologichesky_Office = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Clinic_Advisory
            // 
            this.button_Clinic_Advisory.Location = new System.Drawing.Point(13, 13);
            this.button_Clinic_Advisory.Name = "button_Clinic_Advisory";
            this.button_Clinic_Advisory.Size = new System.Drawing.Size(325, 23);
            this.button_Clinic_Advisory.TabIndex = 0;
            this.button_Clinic_Advisory.Text = "Поликлиника консультативная";
            this.button_Clinic_Advisory.UseVisualStyleBackColor = true;
            this.button_Clinic_Advisory.Click += new System.EventHandler(this.button_Clinic_Advisory_Click);
            // 
            // button_Dental_Office
            // 
            this.button_Dental_Office.Location = new System.Drawing.Point(13, 43);
            this.button_Dental_Office.Name = "button_Dental_Office";
            this.button_Dental_Office.Size = new System.Drawing.Size(325, 23);
            this.button_Dental_Office.TabIndex = 1;
            this.button_Dental_Office.Text = "Стоматологический кабинет";
            this.button_Dental_Office.UseVisualStyleBackColor = true;
            this.button_Dental_Office.Click += new System.EventHandler(this.button_Dental_Office_Click);
            // 
            // button_Dental_Surgery_Office
            // 
            this.button_Dental_Surgery_Office.Location = new System.Drawing.Point(13, 73);
            this.button_Dental_Surgery_Office.Name = "button_Dental_Surgery_Office";
            this.button_Dental_Surgery_Office.Size = new System.Drawing.Size(325, 23);
            this.button_Dental_Surgery_Office.TabIndex = 2;
            this.button_Dental_Surgery_Office.Text = "Стоматологический-хирургический кабинет";
            this.button_Dental_Surgery_Office.UseVisualStyleBackColor = true;
            this.button_Dental_Surgery_Office.Click += new System.EventHandler(this.button_Dental_Surgery_Office_Click);
            // 
            // button_Diagnostic_Study
            // 
            this.button_Diagnostic_Study.Location = new System.Drawing.Point(13, 103);
            this.button_Diagnostic_Study.Name = "button_Diagnostic_Study";
            this.button_Diagnostic_Study.Size = new System.Drawing.Size(325, 23);
            this.button_Diagnostic_Study.TabIndex = 3;
            this.button_Diagnostic_Study.Text = "Кабинет диагностики, профилактики и лазерное терапии ретинопат.";
            this.button_Diagnostic_Study.UseVisualStyleBackColor = true;
            this.button_Diagnostic_Study.Click += new System.EventHandler(this.button_Diagnostic_Study_Click);
            // 
            // button_Surdologichesky_Office
            // 
            this.button_Surdologichesky_Office.Location = new System.Drawing.Point(13, 133);
            this.button_Surdologichesky_Office.Name = "button_Surdologichesky_Office";
            this.button_Surdologichesky_Office.Size = new System.Drawing.Size(325, 23);
            this.button_Surdologichesky_Office.TabIndex = 4;
            this.button_Surdologichesky_Office.Text = "Сурдологический кабинет";
            this.button_Surdologichesky_Office.UseVisualStyleBackColor = true;
            this.button_Surdologichesky_Office.Click += new System.EventHandler(this.button_Surdologichesky_Office_Click);
            // 
            // Clinic_Advisory_Subdvision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 178);
            this.Controls.Add(this.button_Surdologichesky_Office);
            this.Controls.Add(this.button_Diagnostic_Study);
            this.Controls.Add(this.button_Dental_Surgery_Office);
            this.Controls.Add(this.button_Dental_Office);
            this.Controls.Add(this.button_Clinic_Advisory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clinic_Advisory_Subdvision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника консультативная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Clinic_Advisory;
        private System.Windows.Forms.Button button_Dental_Office;
        private System.Windows.Forms.Button button_Dental_Surgery_Office;
        private System.Windows.Forms.Button button_Diagnostic_Study;
        private System.Windows.Forms.Button button_Surdologichesky_Office;
    }
}