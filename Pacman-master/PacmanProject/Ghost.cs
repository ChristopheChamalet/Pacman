using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanProject
{
    public class Ghost : Entite
    {
        public int maxrange_X;
        public int maxrange_Y;
        public Ghost(PictureBox picture, int speed) : base(picture, speed)
        {


        }
        public void changeDirection()
        {

        }

    }
}
