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
    public partial class Form5 : Form
    {
        private int _elapsedTime = 0;

        Random rand = new Random();

        int deathCounter = 0;
        public Form5()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Hint.Text = "";

            int Hints = rand.Next(1, 26);

            if (Hints == 1)
            {
                Hint.Text = "Hint: Try thinking outside of the box";
            }
            if (Hints == 2)
            {
                Hint.Text = "Hint: Try not to die too much or you'll use your mind ;)";
            }
            if (Hints == 3)
            {
                Hint.Text = "Hint: Everything you keep in your inventory will not disappear if you die";
            }
            if (Hints == 4)
            {
                Hint.Text = "Hint: Use the shards you find to upgrade your weapon";
            }
            if (Hints == 5)
            {
                Hint.Text = "Hint: You can respawn if you die to a normal monster, but if you die to a demon king then that's it";
            }
            if (Hints == 6)
            {
                Hint.Text = "God of Wisdom: Instead of dreaming about a different future, be satisfied with the present time and comfort yourself";
            }
            if (Hints == 7)
            {
                Hint.Text = "God of Wisdom: Living means a series of choices. In that process one will sacrifice something or make a mistake.";
            }
            if (Hints == 8)
            {
                Hint.Text = "God of Wisdom: The longer one lives, the more mistakes will be made and the responsiblity for it will get heavier";
            }
            if (Hints == 9)
            {
                Hint.Text = "God of War: The sword is the warrior's soul, it must be wielded with skill, respect and above all, honor";
            }
            if (Hints == 10)
            {
                Hint.Text = "God of War: A true hero is defined not by their victories, but by their determination to never give up, even in the face of death.";
            }
            if (Hints == 11)
            {
                Hint.Text = "You: Each death is a new beginning, a chance to learn and grow.";
            }
            if (Hints == 12)
            {
                Hint.Text = "You: Death is not the end, it is simply a new chapter in my story.";
            }
            if (Hints == 13)
            {
                Hint.Text = "In a lifetime of death, I have found that the greatest fear is not death itself, but the fear of not living";
            }
            if (Hints == 14)
            {
                Hint.Text = "A man trapped in a never-ending cycle of death and rebirth, must make a choice between morality and freedom.";
            }
            if (Hints == 15)
            {
                Hint.Text = "A man who is willing to do whatever it takes to break the cycle, is a man who truly understands the meaning of sacrifice.";
            }
            if (Hints == 16)
            {
                Hint.Text = "A man who is willing to sacrifice everything for the sake of freedom, is a true warrior of the human spirit.";
            }
            if (Hints == 17)
            {
                Hint.Text = "The ultimate sacrifice for freedom, may require the sacrifice of the world itself.";
            }
            if (Hints == 18)
            {
                Hint.Text = "The cycle of death and rebirth, can only be broken by the ultimate sacrifice of the world.";
            }
            if (Hints == 19)
            {
                Hint.Text = "In the face of eternal suffering, the world must be sacrificed for freedom.";
            }
            if (Hints == 20)
            {
                Hint.Text = "God of Time: The actions of a mortal, in the face of eternal suffering, are but a fleeting moment in the grand scheme of time, yet they hold the power to change the course of eternity.";
            }
            if (Hints == 25)
            {
                Hint.Text = "Madara: Wake up to reality. The world is not just a dream, it's reality. And the reality is that you're nothing but a puppet on a string controlled by fate. But, I will change that. I will break the strings of fate and become the master of my own destiny. ;)";
            }


            Loading.Start();
            Timer.Start();
        }

        private void Loading_Tick(object sender, EventArgs e)
        {
            Player.Left += 10;

            if (Player.Left >= this.Width)
            {
                Player.Left = 0 - Player.Width;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime += Timer.Interval;

            if (_elapsedTime >= 10000)
            {
                Timer.Stop();
                Form6 form6 = new Form6();
                form6.Show();
                this.Close();
            }
        }
    }
}
