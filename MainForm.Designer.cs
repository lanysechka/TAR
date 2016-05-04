namespace TAR
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_MODB = new System.Windows.Forms.Button();
            this.button_Pharmacy = new System.Windows.Forms.Button();
            this.button_Cabinet = new System.Windows.Forms.Button();
            this.button_Extra = new System.Windows.Forms.Button();
            this.pictureBox_Load = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // button_MODB
            // 
            this.button_MODB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MODB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MODB.Location = new System.Drawing.Point(13, 91);
            this.button_MODB.Name = "button_MODB";
            this.button_MODB.Size = new System.Drawing.Size(450, 33);
            this.button_MODB.TabIndex = 0;
            this.button_MODB.Text = "УЗ \"Могилевская областная детская больница\"";
            this.button_MODB.UseVisualStyleBackColor = true;
            this.button_MODB.Click += new System.EventHandler(this.button_MODB_Click);
            // 
            // button_Pharmacy
            // 
            this.button_Pharmacy.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_Pharmacy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Pharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Pharmacy.Location = new System.Drawing.Point(13, 126);
            this.button_Pharmacy.Name = "button_Pharmacy";
            this.button_Pharmacy.Size = new System.Drawing.Size(450, 33);
            this.button_Pharmacy.TabIndex = 1;
            this.button_Pharmacy.Text = "Аптека";
            this.button_Pharmacy.UseVisualStyleBackColor = true;
            this.button_Pharmacy.Click += new System.EventHandler(this.button_Pharmacy_Click);
            // 
            // button_Cabinet
            // 
            this.button_Cabinet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cabinet.Location = new System.Drawing.Point(13, 165);
            this.button_Cabinet.Name = "button_Cabinet";
            this.button_Cabinet.Size = new System.Drawing.Size(450, 33);
            this.button_Cabinet.TabIndex = 2;
            this.button_Cabinet.Text = "Кабинет вакцинопрофилактики";
            this.button_Cabinet.UseVisualStyleBackColor = true;
            this.button_Cabinet.Click += new System.EventHandler(this.button_Cabinet_Click);
            // 
            // button_Extra
            // 
            this.button_Extra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Extra.Location = new System.Drawing.Point(14, 204);
            this.button_Extra.Name = "button_Extra";
            this.button_Extra.Size = new System.Drawing.Size(449, 33);
            this.button_Extra.TabIndex = 3;
            this.button_Extra.Text = "УЗ \"Могилевская областная детская больница\" Внебюджет";
            this.button_Extra.UseVisualStyleBackColor = true;
            this.button_Extra.Click += new System.EventHandler(this.button_Extra_Click);
            // 
            // pictureBox_Load
            // 
            this.pictureBox_Load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Load.BackgroundImage")));
            this.pictureBox_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Load.InitialImage = null;
            this.pictureBox_Load.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_Load.Name = "pictureBox_Load";
            this.pictureBox_Load.Size = new System.Drawing.Size(450, 72);
            this.pictureBox_Load.TabIndex = 4;
            this.pictureBox_Load.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 265);
            this.Controls.Add(this.pictureBox_Load);
            this.Controls.Add(this.button_Extra);
            this.Controls.Add(this.button_Cabinet);
            this.Controls.Add(this.button_Pharmacy);
            this.Controls.Add(this.button_MODB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбирите учреждение";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MODB;
        private System.Windows.Forms.Button button_Pharmacy;
        private System.Windows.Forms.Button button_Cabinet;
        private System.Windows.Forms.Button button_Extra;
        private System.Windows.Forms.PictureBox pictureBox_Load;
    }
}

