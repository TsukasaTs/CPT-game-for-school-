namespace The_returner___CPT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SpawnPoint = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.Timer(this.components);
            this.upgrade = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgrade)).BeginInit();
            this.SuspendLayout();
            // 
            // SpawnPoint
            // 
            this.SpawnPoint.Location = new System.Drawing.Point(619, 323);
            this.SpawnPoint.Name = "SpawnPoint";
            this.SpawnPoint.Size = new System.Drawing.Size(79, 36);
            this.SpawnPoint.TabIndex = 0;
            this.SpawnPoint.TabStop = false;
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = ((System.Drawing.Image)(resources.GetObject("character.Image")));
            this.character.Location = new System.Drawing.Point(619, 276);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(100, 83);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character.TabIndex = 2;
            this.character.TabStop = false;
            // 
            // Player
            // 
            this.Player.Tick += new System.EventHandler(this.Player_Tick);
            // 
            // upgrade
            // 
            this.upgrade.BackColor = System.Drawing.Color.Transparent;
            this.upgrade.Image = ((System.Drawing.Image)(resources.GetObject("upgrade.Image")));
            this.upgrade.Location = new System.Drawing.Point(1195, 8);
            this.upgrade.Name = "upgrade";
            this.upgrade.Size = new System.Drawing.Size(100, 76);
            this.upgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upgrade.TabIndex = 3;
            this.upgrade.TabStop = false;
            this.upgrade.Click += new System.EventHandler(this.upgrade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find Enemy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Help.Location = new System.Drawing.Point(407, 9);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(527, 75);
            this.Help.TabIndex = 5;
            this.Help.Text = "label2";
            this.Help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 622);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upgrade);
            this.Controls.Add(this.character);
            this.Controls.Add(this.SpawnPoint);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.SpawnPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SpawnPoint;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.Timer Player;
        private System.Windows.Forms.PictureBox upgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Help;
    }
}