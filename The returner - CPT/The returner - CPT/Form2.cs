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
    public partial class Form2 : Form
    {
        Point spawnLocation;

        int deathCounter = 0;

        bool PlayerUp, PlayerDown, PlayerLeft, PlayerRight;
        public Form2()
        {
            InitializeComponent();

            //deathCounter = death;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SpawnPoint.Visible = false;
            spawnLocation = SpawnPoint.Location;

            Player.Start();

            Help.Text = "Tower: Greetings hero, this is where you will return to after death.";

            PlayerUp = false;
            PlayerDown = false;
            PlayerLeft = false;
            PlayerRight = false;
        }

        //In the event when the character dies
        void OnDeath()
        {
            deathCounter++;
            //Move the character to the spawn location
            character.Location = spawnLocation;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            // Open Form3
            Form3 form3 = new Form3();
            form3.Show();

            // Hide Form2
            this.Hide();
        }

        private void upgrade_Click(object sender, EventArgs e)
        {
            // Open Form4
            Form4 form4 = new Form4();
            form4.Show();

            // Hide Form2
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Open Form5
            Form5 form5 = new Form5();
            form5.Show();

            // Hide Form2
            this.Hide();
        }

        private void Form2_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void Player_Tick(object sender, EventArgs e)
        {

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
