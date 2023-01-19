namespace The_returner___CPT
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Goblin = new System.Windows.Forms.PictureBox();
            this.PicPlayer = new System.Windows.Forms.PictureBox();
            this.Text = new System.Windows.Forms.Label();
            this.playerHP = new System.Windows.Forms.Label();
            this.enemyHP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Goblin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Slash";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Inventory";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Goblin
            // 
            this.Goblin.BackColor = System.Drawing.Color.Transparent;
            this.Goblin.Image = ((System.Drawing.Image)(resources.GetObject("Goblin.Image")));
            this.Goblin.Location = new System.Drawing.Point(868, 353);
            this.Goblin.Name = "Goblin";
            this.Goblin.Size = new System.Drawing.Size(179, 163);
            this.Goblin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Goblin.TabIndex = 4;
            this.Goblin.TabStop = false;
            // 
            // PicPlayer
            // 
            this.PicPlayer.BackColor = System.Drawing.Color.Transparent;
            this.PicPlayer.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayer.Image")));
            this.PicPlayer.Location = new System.Drawing.Point(249, 393);
            this.PicPlayer.Name = "PicPlayer";
            this.PicPlayer.Size = new System.Drawing.Size(99, 87);
            this.PicPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayer.TabIndex = 5;
            this.PicPlayer.TabStop = false;
            // 
            // Text
            // 
            this.Text.BackColor = System.Drawing.Color.Transparent;
            this.Text.ForeColor = System.Drawing.Color.White;
            this.Text.Location = new System.Drawing.Point(292, 528);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(979, 85);
            this.Text.TabIndex = 6;
            this.Text.Text = "label1";
            this.Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHP
            // 
            this.playerHP.BackColor = System.Drawing.Color.Transparent;
            this.playerHP.ForeColor = System.Drawing.Color.White;
            this.playerHP.Location = new System.Drawing.Point(12, 9);
            this.playerHP.Name = "playerHP";
            this.playerHP.Size = new System.Drawing.Size(100, 23);
            this.playerHP.TabIndex = 7;
            this.playerHP.Text = "label1";
            this.playerHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyHP
            // 
            this.enemyHP.BackColor = System.Drawing.Color.Transparent;
            this.enemyHP.ForeColor = System.Drawing.Color.White;
            this.enemyHP.Location = new System.Drawing.Point(1195, 9);
            this.enemyHP.Name = "enemyHP";
            this.enemyHP.Size = new System.Drawing.Size(100, 23);
            this.enemyHP.TabIndex = 8;
            this.enemyHP.Text = "label1";
            this.enemyHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enemyHP);
            this.Controls.Add(this.playerHP);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.PicPlayer);
            this.Controls.Add(this.Goblin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Goblin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox Goblin;
        private System.Windows.Forms.PictureBox PicPlayer;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Label playerHP;
        private System.Windows.Forms.Label enemyHP;
        private System.Windows.Forms.Button button1;
    }
}