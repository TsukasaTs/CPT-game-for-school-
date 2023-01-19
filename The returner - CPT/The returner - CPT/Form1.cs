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
    // ICS3C1 CPT: The Returner
    // Ground Members: No One
    // Mr. Conway
    // Program Description:
    // Program Details: 
    public partial class Form1 : Form
    {
        int Timer;

        private Timer formTimer;

        int deathCounter = 0;
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void GOD_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time.Start();

            GOD.Text = "";

            button1.Visible = false;
            button2.Visible = false;

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Timer++;

            Console.WriteLine(Timer);

            if (Timer == 1)
            {
                GOD.Text = "Oh Dear.....";
            }
            if (Timer == 5)
            {
                GOD.Text = "It seems like you’ve gotten lost……";
            }
            if (Timer == 11)
            {
                GOD.Text = "Let's look throught your memories……";
            }
            if (Timer == 16)
            {
                GOD.Text = "Oh my...";
            }
            if (Timer == 17)
            {
                GOD.Text = "You've lived your finest life, but it ended abruptly....";
            }
            if (Timer == 21)
            {
                GOD.Text = "Hmmm.....";
            }
            if (Timer == 23)
            {
                GOD.Text = "It seems like you were about to graduate.....";
            }
            if (Timer == 27)
            {
                GOD.Text = "Let's see....";
            }
            if (Timer == 30)
            {
                GOD.Text = "How about this....";
            }
            if (Timer == 33)
            {
                GOD.Text = "I'll summon you to a magical world where monsters and magic coexist.....";
            }
            if (Timer == 37)
            {
                GOD.Text = "In this world, I will grant you a special S Rank ability called \"Infinite Return\": Upon the Users death, the user returns back to the time before the cause of death while maintaining their memories. An ability that even Distorts the causality...";
            }
            if (Timer == 52)
            {
                GOD.Text = "and after you've vanquished the demon lord, I'll give you your life back, which entails returning you to your world just as you were about to die..\r\n";
            }
            if (Timer == 59)
            {
                GOD.Text = "Will you aceept?";
                button1.Visible = true;
                button2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GOD.Text = "Thank you lost soul for accepting";
            button2.Visible = false;

            // Initialize the Timer object
            formTimer = new Timer();
            formTimer.Interval = 10000; // 10 seconds
            formTimer.Tick += new EventHandler(MoveToNextForm);
            formTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GOD.Text = "It's alright lost soul, you might have a reason to decline, so I will bring you to the bridge between life and death so you can be judge by him";
            button1.Visible = false;

            // Initialize the Timer object
            formTimer = new Timer();
            formTimer.Interval = 10000; // 10 seconds
            formTimer.Tick += new EventHandler(CloseForm);
            formTimer.Start();
        }

        private void MoveToNextForm(object sender, EventArgs e)
        {
            formTimer.Stop();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            formTimer.Stop();
            this.Close();
        }
    }
}