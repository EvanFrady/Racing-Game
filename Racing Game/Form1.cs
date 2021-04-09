using System;
using System.Drawing;
using System.Windows.Forms;

namespace Racing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblGameOver.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            Enemy(gamespeed);
            Coin(gamespeed);
            gameover();
            CoinCollection();
        }


        int gamespeed = 0;
        int collectedCoin = 0;
        Random r = new Random();
        int x, y;
        void Enemy(int speed)
        {
            //enemy 1
            if (Enemy1.Top >= 500)
            {
                x = r.Next(0, 200);

                Enemy1.Location = new Point(x, y);
            }
            else 
            {
               Enemy1.Top += speed;
            }
            //enemy 2
            if (Enemy2.Top >= 500)
            {
                x = r.Next(0, 200);

                Enemy2.Location = new Point(x, y);
            }
            else
            {
                Enemy2.Top += speed;
            }
            //enemy 3
            if (Enemy3.Top >= 500)
            {
                x = r.Next(0, 200);

                Enemy3.Location = new Point(x, y);
            }
            else
            {
                Enemy3.Top += speed;
            }
        }

        

        void Coin(int speed)
        {
            //Coin1
            if (Coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                Coin1.Location = new Point(x, y);
            }
            else
            {
                Coin1.Top += speed;
            }
            //Coin2
            if (Coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                Coin2.Location = new Point(x, y);
            }
            else
            {
                Coin2.Top += speed;
            }
            //Coin3
            if (Coin3.Top >= 500)
            {
                x = r.Next(50, 300);

                Coin3.Location = new Point(x, y);
            }
            else
            {
                Coin3.Top += speed;
            }
            //Coin4
            if (Coin4.Top >= 500)
            {
                x = r.Next(0, 400);

                Coin4.Location = new Point(x, y);
            }
            else
            {
                Coin4.Top += speed;
            }
        }
        //End game when hit car
        void gameover()
        {
            if (Car.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (Car.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (Car.Bounds.IntersectsWith(Enemy3.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
        }


        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;

            }
            else
            {
                pictureBox1.Top += speed;
            }
            if(pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;

            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;

            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;

            }
            else
            {
                pictureBox4.Top += speed;
            }
            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;

            }
            else
            {
                pictureBox5.Top += speed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //Collect Coints, increment counter
        void CoinCollection()
        {
            if (Car.Bounds.IntersectsWith(Coin1.Bounds))
            {
                collectedCoin++;
                lblCoin.Text = "Coins =" + collectedCoin.ToString();
                x = r.Next(50, 300);
                Coin1.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin2.Bounds))
            {
                collectedCoin++;
                lblCoin.Text = "Coins =" + collectedCoin.ToString();
                x = r.Next(50, 300);
                Coin2.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin3.Bounds))
            {
                collectedCoin++;
                lblCoin.Text = "Coins =" + collectedCoin.ToString();
                x = r.Next(50, 300);
                Coin3.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(Coin4.Bounds))
            {
                collectedCoin++;
                lblCoin.Text = "Coins =" + collectedCoin.ToString();
                x = r.Next(50, 300);
                Coin4.Location = new Point(x, 0);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(Car.Left > 0)
                Car.Left += -9;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(Car.Right < 380)
                Car.Left += 9;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                        gamespeed--;
                }
            }
            //When press R, restart form
            if (e.KeyCode == Keys.R)
            {
                Application.Restart();
            }
        }
    }
}
