using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arcade
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int mx, my;
        int e1x, e1y, e2x, e2y, e3x, e3y, e4x, e4y;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = false;
            button1.Visible = false;

        }

        private void enemy2_Click(object sender, EventArgs e)
        {
            


        }

        private void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;

                button1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;

                button1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;

                button1.Visible = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            button1.Visible = false;
            mx = car.Location.X;
            my = car.Location.Y;
            e1x = enemy1.Location.X;
            e1y = enemy1.Location.Y;
            e2x = enemy2.Location.X;
            e2y = enemy2.Location.Y;
            e3x = enemy3.Location.X;
            e3y = enemy3.Location.Y;
            e4x = enemy4.Location.X;
            e4y = enemy4.Location.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                mx -= 10;
                car.Location = new Point(mx, my);
                //car.Left += -10;
                //car.Image = arcade.Properties.Resources.c2l;
            }
            else if (e.KeyCode == Keys.Right)
            {
                mx += 10;
                car.Location = new Point(mx, my);
                //car.Left += 10;
                //car.Image = arcade.Properties.Resources.c2r;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(5);
            moveenemy(5);
            gameover();

        }

        private void moveenemy(int speed)
        {
            if (e1y <= 540)
            {
                
                e1y += speed;
                enemy1.Location = new Point(e1x, e1y);   
            }
            else
            {
                e1x = random.Next(40, 320);
                e1y = -100;
            }
            if (e2y <= 540)
            {
                e2y += speed;
                enemy2.Location = new Point(e2x, e2y);
            }
            else
            {
                e2x = random.Next(160, 480);
                e2y = -100;
            }
            if (e3y <= 540)
            {
                e3y += speed;
                enemy3.Location = new Point(e3x, e3y);
            }
            else
            {
                e3x = random.Next(320, 630);
                e3y = -100;
            }
            if (e4y <= 540)
            {
                e4y += speed;
                enemy4.Location = new Point(e4x, e4y);
            }
            else
            {
                e4x = random.Next(480, 630);
                e4y = -100;
            }
        }

        private void moveline(int speed)
        {
            if (line1.Top >= 540)
            {
                line1.Top = -100;
            }
            else
            {
                line1.Top += speed;
            }
            if (line2.Top >= 540)
            {
                line2.Top = -100;
            }
            else
            {
                line2.Top += speed;
            }
            if (line3.Top >= 540)
            {
                line3.Top = -100;
            }
            else
            {
                line3.Top += speed;
            }
            if (line4.Top >= 540)
            {
                line4.Top = -100;
            }
            else
            {
                line4.Top += speed;
            }
            if (line5.Top >= 540)
            {
                line5.Top = -100;
            }
            else
            {
                line5.Top += speed;
            }
            if (line6.Top >= 540)
            {
                line6.Top = -100;
            }
            else
            {
                line6.Top += speed;
            }
        }
    }
}
