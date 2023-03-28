using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Threading;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        private int birdY;
        private int birdYSpeed;
        private int pipeX;
        private int pipeGap;
        private int score;
        private int dead;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            birdY = bird.Location.Y;
            birdYSpeed = 0;
            pipeX = doubleBufferedPanel1.Width + 200;
            score = 1;
            pipeGap = 180;
            restartbtn.Visible = false;
            scorelb.Visible = false;
            GO.Visible = false;
            bird2.Visible = false;
            dead = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toppipe.Height = random.Next(20, doubleBufferedPanel1.Height - pipeGap - 20);
            botpipe.Height = doubleBufferedPanel1.Height - pipeGap - toppipe.Height;
            botpipe.Location = new Point(botpipe.Location.X, toppipe.Location.Y + toppipe.Height + pipeGap);
            item.Location = new Point(botpipe.Location.X, toppipe.Location.Y + toppipe.Height + pipeGap / 2);
            //pipeGap = random.Next(100, 200);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            // Move the bird
            birdYSpeed += 2;
            birdY += birdYSpeed;
            //check height
            if ((bird.Location.Y) < -40)
            {
                birdY = -40;
            }
            bird.Location = new Point(bird.Location.X, birdY);
            bird2.Location = new Point(bird.Location.X, birdY);
            // Move the pipe
            pipeX -= 4;
            botpipe.Location = new Point(pipeX, botpipe.Location.Y);
            toppipe.Location = new Point(pipeX, toppipe.Location.Y);
            item.Location = new Point(pipeX, item.Location.Y);
            if (pipeX < -50)
            {
                score++;
                pipeX = doubleBufferedPanel1.Width;
                toppipe.Height = random.Next(50, doubleBufferedPanel1.Height - pipeGap - 10);
                botpipe.Height = doubleBufferedPanel1.Height - pipeGap - toppipe.Height;
                botpipe.Location = new Point(botpipe.Location.X, toppipe.Location.Y + toppipe.Height + pipeGap);
                item.Location = new Point(botpipe.Location.X, toppipe.Location.Y + toppipe.Height + pipeGap / 2);
                //pipeGap = random.Next(100, 200);
                item.Visible = true;
            }
            // Check for collision
            if (bird.Bounds.IntersectsWith(toppipe.Bounds) ||
                bird.Bounds.IntersectsWith(botpipe.Bounds) || (bird.Location.Y >= (doubleBufferedPanel1.Height) - bird.Height))
            {
                myTimer.Stop();
                //this.KeyDown -= Form1_KeyDown;
                restartbtn.Visible = true;
                GO.Visible = true;
                dead = 1;
            }
            //Check eat item
            if (bird.Bounds.IntersectsWith(item.Bounds))
            {
                item.Visible = false;
                scorelb.Text = score.ToString();
                item.Visible = false;
                if (score > Convert.ToInt32(bestlb.Text))
                {
                    bestlb.Text = score.ToString();
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Space):
                    {
                        bird2.Visible = true;
                        myTimer.Start();
                        scorelb.Visible = true;
                        NOTE.Visible = false;
                    }
                    break;
                default:
                    break;
            }
        }
        private void Form1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Space):
                    {
                        if(dead == 1)
                        {
                            restartbtn.Visible = false;
                            GO.Visible = false;
                            item.Visible = true;
                            birdY = 228;
                            birdYSpeed = -18;
                            score = 1;
                            scorelb.Text = "0";
                            pipeX = doubleBufferedPanel1.Width + 200;
                            dead = 0;
                        }
                        else
                        birdYSpeed = -18;
                    }
                    break;
                default:
                    break;
            }
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            restartbtn.Visible = false;
            GO.Visible = false;
            item.Visible = true;
            birdY = 228;
            birdYSpeed = -18;
            score = 1;
            scorelb.Text = "0";
            pipeX = doubleBufferedPanel1.Width + 200;
            dead = 0;
            myTimer.Start();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            bird2.Visible = false;
        }
    }
}