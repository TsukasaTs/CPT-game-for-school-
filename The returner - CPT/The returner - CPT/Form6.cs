using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_returner___CPT
{
    public partial class Form6 : Form
    {
        int PLAYERHP = 100;

        int ENEMYHP = 100;


        Random rand = new Random();

        public Form6()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Text.Text = "";

            Text.Text = "Pick a move";

            playerHP.Text = "HP: " + PLAYERHP + "/100";
            enemyHP.Text = "HP: " + ENEMYHP + "/100";

            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show Form2
            Form2 form2 = new Form2();
            form2.Show();
                
            //Close Form6
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int PlayerDAM = rand.Next(5, 17);
            ENEMYHP -= PlayerDAM;
            enemyHP.Text = "HP: " + ENEMYHP + "/100";

            //------------------------------------------------------------------------------------------

            int EnemyDam = rand.Next(1, 11);
            PLAYERHP -= EnemyDam;
            playerHP.Text = "HP: " + PLAYERHP + "/100";


            Text.Text = "You've done " + PlayerDAM + " damage to the enemy";


            // Checks if enemy is dead
            if (ENEMYHP <= 0)
            {
                enemyHP.Text = "HP: 0/500";
                Text.Text = "You've killed the enemy.\nEnemy has droppped a shard";

                button1.Visible = true;
            }
            // Checks if the player died
            if (PLAYERHP <= 0)
            {
                playerHP.Text = "HP: 0/100";
                Text.Text = "You have been killed";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show Form7
            Form7 form7 = new Form7();
            form7.Show();
            //Close Form
            this.Close();
        }
    }
}