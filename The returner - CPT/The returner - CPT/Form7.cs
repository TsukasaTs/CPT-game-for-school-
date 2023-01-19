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
    public partial class Form7 : Form
    {
        int Timer;
        Random rand = new Random();

        private Timer formTimer;

        public Form7()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Chat.Text = "";

            PlayerHP.Text = "";

            Home.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chat.Text = "";
            Time.Start();
            button3.Visible = false;
            button4.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Timer++;
            if (Timer == 1)
            {
                Chat.Text = "You: What the hell is that ";
            }
            if (Timer == 3)
            {
                Chat.Text = "Unknown: Your language is quite offensive, young man.";
            }
            if (Timer == 5)
            {
                Chat.Text = "Unknown: is that what you say when you first meet someone?";
            }
            if (Timer == 8)
            {
                Chat.Text = "You: I apologize for my rudeness, it's just, ive never encountered someone like you before.";
            }
            if (Timer == 12)
            {
                Chat.Text = "UnKnown: It's alright. It's not a common occurrence to see someone whose body appears to be like a fog.";
            }
            if (Timer == 16)
            {
                Chat.Text = "UnKnown: I have a question for you, young lost one, what brings you to this hellish place?";
            }
            if (Timer == 22)
            {
                Chat.Text = "You: Why do you refer to it as a hellish place? This is a one-of-a-kind experience, something that can only be found in mangas and anime";
            }
            if (Timer == 30)
            {
                Chat.Text = "UnKnown: Others may speak of this place with a false sense of security, but let me tell you, this place is a nightmare beyond imagination, a fate worse than death itself. A place where even the gates of hell would seem like a sanctuary in comparison. This is a breeding ground for demonic overlords, a factory of evil where lost souls are harvested and twisted into monstrous beings of darkness. The god you thought you knew, the one you believed in, is nothing but a monster who feeds on the suffering of the damned. Welcome to a living hell where escape is not an option, and the only fate that awaits you is eternal damnation.";
            }
            if (Timer == 55)
            {
                Chat.Text = "You: But the god told me once I defeat the demon lord he will bring me back to life.";
            }
            if (Timer == 59)
            {
                Chat.Text = "UnKnown: Ahahaha! You pitiful lost soul, or should I say 'the returner'? But let me impart some wisdom upon you. Do not rely too heavily on your powers. It's true that death may not claim you, as your powers will transport you back to your spawn point, but the toll it takes on your mind may be irreversible. And I implore you, do not make the mistake of underestimating the demon lord. Make sure to defeat it in one swift strike, for your powers are useless against its might.";
            }
            if (Timer == 79)
            {
                Chat.Text = "UnKnown: Before I depart, I shall bestow upon you a weapon. Look in your inventory upon your return to your spawn point, and may fortune favor you, lost soul.";
            }
            if (Timer == 86)
            {
                pictureBox2.Visible = false;
                Chat.Text = "";
                Home.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chat.Text = "";

            Chat.Text = "You can't attack a ......";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chat.Text = "";

            Chat.Text = "You can't run away from .....";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chat.Text = "";

            Chat.Text = "You can't leave from .....";
        }

        private void Home_Click(object sender, EventArgs e)
        {
            // Show Form2
            Form2 form2 = new Form2();
            form2.Show();
            //Close Form
            this.Close();
        }
    }   
}
