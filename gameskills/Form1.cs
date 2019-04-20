using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameskills
{
    public partial class Form1 : Form
    {
        int score = 0;
        int dropFireBall;
        bool fireballisdropping = false;
        Random rnd = new Random();
        PictureBox[] ring = new PictureBox[4];
        int fireMissile;//used to store an integer where the Missile will be fired from
        bool missileFired = false;//set to true if the missile has been fired
    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ring[0] = picRing1;
            ring[1] = picRing2;
            ring[2] = picRing3;
            ring[3] = picRing4;
            timDragon.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picDragon.Left -= 1;
           
            for(int index=0; index < 4;index ++)
            {
                if (picDragon.Bounds.IntersectsWith(ring[index].Bounds) && ring[index].Visible)
                {
                    ring[index].Hide();
                    score += 1;
                    lblScore.Text = score.ToString();
                }
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picDragon_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    picTank.Left += 1;
                    break;
                case Keys.Left:
                    picTank.Left -= 1;
                    break;
                case Keys.Space:
                    if(!missileFired)
                    {
                        timMissile.Start();
                        picMissile.SendToBack();
                        picMissile.Show();
                        picMissile.Left = picTank.Left + 25;
                        picMissile.Top = picTank.Top;
                        missileFired = true;
                    }
                    break;
            }
        }

        private void timMissile_Tick(object sender, EventArgs e)
        {
            picMissile.Top -= 5;
            if(picMissile.Bounds.IntersectsWith(picDragon.Bounds) && picDragon.Visible)
            {
                picDragon.Hide();
                timDragon.Stop();
                picMissile.Hide();
                missileFired = false;
                timMissile.Stop();
                score += 50;
            }
            if (picMissile.Top <0)
            {
                picMissile.Hide();
                missileFired = false;
                timMissile.Stop();
            }
        }
    }
}
