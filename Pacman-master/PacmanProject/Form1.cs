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
using Timer = System.Windows.Forms.Timer;

namespace PacmanProject
{
    public partial class Form1 : Form
    {

        public Joueur joueur;
        public Ghost ghostRed;
        public Ghost ghostPink;
        public Ghost ghostYellow;

        public Form1()
        {
            ghostRed = new Ghost(redGhost,10);
            ghostYellow = new Ghost(yellowGhost, 10);
            ghostPink = new Ghost(pinkGhost, 10);
            joueur = new Joueur(5, pacman);
            ghostRed.moveLeft = true;
            ghostRed.moveUp = true;
            ghostYellow.moveRight = true;
            ghostYellow.moveUp = true;
            ghostPink.moveLeft = true;
            ghostPink.moveDown = true;
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            KeyUp += new KeyEventHandler(Form1_KeyUp);
            GameSetUp();
        }




        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && !joueur.blockRight)
            {
                joueur.moveLeft = joueur.moveUp = joueur.moveDown = false; 
                joueur.blockLeft = joueur.blockUp = joueur.blockDown = false;
                joueur.moveRight = true;
                
            }
            if (e.KeyCode == Keys.Left && !joueur.blockLeft)
            {
                joueur.moveRight = joueur.moveUp = joueur.moveDown = false;
                joueur.blockRight = joueur.blockUp = joueur.blockDown = false;
                joueur.moveLeft = true;
            }
            if (e.KeyCode == Keys.Up && !joueur.blockUp)
            {
                joueur.moveLeft = joueur.moveRight = joueur.moveDown = false;
                joueur.blockLeft = joueur.blockRight = joueur.blockDown = false;
                joueur.moveUp = true;

            }
            if (e.KeyCode == Keys.Down && !joueur.blockDown)
            {
                joueur.moveLeft = joueur.moveUp = joueur.moveRight = false;
                joueur.blockLeft = joueur.blockUp = joueur.blockRight = false;
                joueur.moveDown = true;
                
            }
            
        }
        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right )
            {
                joueur.moveRight = false;

            }
            if (e.KeyCode == Keys.Left )
            {
                joueur.moveLeft = false;

            }
            if (e.KeyCode == Keys.Up )
            {
                joueur.moveUp = false;

            }
            if (e.KeyCode == Keys.Down )
            {
                joueur.moveDown = false;

            }

        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (ghostRed.moveLeft == true)
            {
                ghostRed.moveRight = false;
                if (redGhost.Location.X > 50)
                {
                    redGhost.Left -= ghostRed.speed;
                    
                }
                else
                {
                    ghostRed.moveRight = true;
                }
            }
            if (ghostRed.moveRight == true)
            {
                ghostRed.moveLeft = false;
                if (redGhost.Location.X < 1100)
                {
                    redGhost.Left += ghostRed.speed;

                }
                else
                {
                    ghostRed.moveLeft = true;
                }
            }
            if (ghostRed.moveUp == true)
            {
                ghostRed.moveDown = false;
                if (redGhost.Location.Y > 80)
                {
                    redGhost.Top -= ghostRed.speed;

                }
                else
                {
                    ghostRed.moveDown = true;
                }
            }
            if (ghostRed.moveDown == true)
            {
                ghostRed.moveUp = false;
                if (redGhost.Location.Y < 550)
                {
                    redGhost.Top += ghostRed.speed;

                }
                else
                {
                    ghostRed.moveUp = true;
                }
            }
            if (ghostYellow.moveRight == true)
            {
                ghostYellow.moveLeft = false;
                if (yellowGhost.Location.X < 1100)
                {
                    yellowGhost.Left += ghostYellow.speed;

                }
                else
                {
                    ghostYellow.moveLeft = true;
                }
            }
            if (ghostYellow.moveLeft == true)
            {
                ghostYellow.moveRight = false;
                if (yellowGhost.Location.X > 50)
                {
                    yellowGhost.Left -= ghostYellow.speed;

                }
                else
                {
                    ghostYellow.moveRight = true;
                }
            }
            if (ghostYellow.moveUp == true)
            {
                ghostYellow.moveDown = false;
                if (yellowGhost.Location.Y > 80)
                {
                    yellowGhost.Top -= ghostRed.speed;

                }
                else
                {
                    ghostYellow.moveDown = true;
                }
            }
            if (ghostYellow.moveDown == true)
            {
                ghostYellow.moveUp = false;
                if (yellowGhost.Location.Y < 550)
                {
                    yellowGhost.Top += ghostYellow.speed;

                }
                else
                {
                    ghostYellow.moveUp = true;
                }
            }

            if (ghostPink.moveLeft == true)
            {
                ghostPink.moveRight = false;
                if (pinkGhost.Location.X > 50)
                {
                    pinkGhost.Left -= ghostPink.speed;

                }
                else
                {
                    ghostPink.moveRight = true;
                }
            }
            if (ghostPink.moveRight == true)
            {
                ghostPink.moveLeft = false;
                if (pinkGhost.Location.X < 1100)
                {
                    pinkGhost.Left += ghostPink.speed;

                }
                else
                {
                    ghostPink.moveLeft = true;
                }
            }
            if (ghostPink.moveDown == true)
            {
                ghostPink.moveUp = false;
                if (pinkGhost.Location.Y < 550)
                {
                    pinkGhost.Top += ghostPink.speed;

                }
                else
                {
                    ghostPink.moveUp = true;
                }
            }
            if (ghostPink.moveUp == true)
            {
                ghostPink.moveDown = false;
                if (pinkGhost.Location.Y > 80)
                {
                    pinkGhost.Top -= ghostPink.speed;

                }
                else
                {
                    ghostPink.moveDown = true;
                }
            }


            //joueur.move();
            if (joueur.moveRight)
            {

                pacman.Left += joueur.speed;
                pacman.Image = Properties.Resources.EQ1QTR;
            }
            if (joueur.moveLeft)
            {

                pacman.Left -= joueur.speed;
                pacman.Image = Properties.Resources.EQ1QTL;
            }
            if (joueur.moveUp)
            {

                pacman.Top -= joueur.speed;
                pacman.Image = Properties.Resources.EQ1QT;
            }
            if (joueur.moveDown)
            {

                pacman.Top += joueur.speed;
                pacman.Image = Properties.Resources.EQ1QTD;
            }

            foreach (Control x in this.Controls)
            {   
                if (x is PictureBox)
                {
                    if ((string)x.Tag != "wall")
                    {
                        if ((string)x.Tag == "coin" && x.Visible == true)
                        {
                            if (pacman.Bounds.IntersectsWith(x.Bounds))
                            {
                                joueur.score++;
                                txtScore.Text = "Score : " + joueur.score + " Timer : " +gameTimer.Interval;
                                x.Visible = false;
                            }
                        }
                    }
                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds) && joueur.moveLeft)
                        {
                            joueur.blockLeft = true;
                            joueur.moveLeft = false;
                        }
                        
                        if (pacman.Bounds.IntersectsWith(x.Bounds) && joueur.moveRight)
                        {
                            joueur.blockRight = true;
                            joueur.moveRight = false;
                        }
                        if (pacman.Bounds.IntersectsWith(x.Bounds) && joueur.moveUp)
                        {
                            joueur.blockUp = true;
                            joueur.moveUp = false;
                        }

                        if (pacman.Bounds.IntersectsWith(x.Bounds) && joueur.moveDown)
                        {
                            joueur.blockDown = true;
                            joueur.moveDown = false;
                        }
                    }
                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameLose();
                        }
                    }



                }
            }
            if(joueur.score == 35)
            {
                GameIsWin();
            }

        }
        private void GameSetUp()
        {
            gameTimer.Tick += GameLoop;

            //gameTimer.Interval = totalMilliseconds; 
            gameTimer.Start();
        }
        private void GameLose()
        {
            gameTimer.Stop();
            MessageBox.Show("Vous avez Perdu");
        }
        private void GameIsWin()
        {
            gameTimer.Stop();
            MessageBox.Show("Vous avez gagné");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}