namespace The_returner___CPT
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.House = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.House)).BeginInit();
            this.SuspendLayout();
            // 
            // House
            // 
            this.House.BackColor = System.Drawing.Color.Transparent;
            this.House.Image = ((System.Drawing.Image)(resources.GetObject("House.Image")));
            this.House.Location = new System.Drawing.Point(12, 12);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(138, 88);
            this.House.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.House.TabIndex = 0;
            this.House.TabStop = false;
            this.House.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 622);
            this.Controls.Add(this.House);
            this.Name = "Form3";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.House)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox House;
    }
}