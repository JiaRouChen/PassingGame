using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passinggame
{
    public partial class Form1 : Form
    {
        private readonly object _pictureBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1_Tick(sender, e, pictureBox2);
        }

        bool game_state= false;


        private void timer1_Tick(object sender, EventArgs e, PictureBox pictureBox2)
        {
            pictureBox2.Left = pictureBox2.Left - 5;

            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                game_state= true;
                label1.Visible = true;
                timer1.Stop();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if(game_state == false)
            {
                if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left += 45;
            }
            }
#pragma warning restore CS0665 // 條件運算式中的指派一律是常數

            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top += 45;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top -= 45;
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left -= 45;
            }
        }

        

        }
    }
    

