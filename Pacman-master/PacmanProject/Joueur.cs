using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PacmanProject
{
        public class Joueur : Entite
        {
            
            
            public int score;

            public Joueur(int speed , PictureBox picture) : base(picture, speed)
            {
                this.score = 0;

            }

            public void move()
        {
            if (this.moveRight&& picture != null)
            {

                this.picture.Left += 5;
            }
            if (this.moveLeft && picture != null)
            {

                this.picture.Left -= 5;
            }
            if (this.moveUp)
            {

                this.picture.Top -= 5;
            }
            if (this.moveDown)
            {

                this.picture.Top += 5;
            }
        }
        
        
    }
}
