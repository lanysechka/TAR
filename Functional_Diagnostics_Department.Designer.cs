﻿namespace TAR
{
    partial class Functional_Diagnostics_Department
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
            this.dataGridView_Base = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Base)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Base
            // 
            this.dataGridView_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Base.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Base.Name = "dataGridView_Base";
            this.dataGridView_Base.Size = new System.Drawing.Size(720, 238);
            this.dataGridView_Base.TabIndex = 2;
            // 
            // Functional_Diagnostics_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 262);
            this.Controls.Add(this.dataGridView_Base);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Functional_Diagnostics_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отделение функциональной диагностики";
            this.Load += new System.EventHandler(this.Functional_Diagnostics_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Base)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Base;
    }
}