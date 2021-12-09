using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanProject
{

namespace ProjetPacman // Note: actual namespace depends on the project name.
    {
        public class Game
        {
            
            public Joueur joueur;
            

            public Game(Joueur joueur)
            {
                this.joueur = joueur;
            }
            

            public void manger()
            {
                this.joueur.score++;
            }

            

            /*public bool verifieCase(int x, int y)
            {
                if (this.plateau[x, y].toString() == ".")
                {
                    this.manger();
                    return true;
                }
                else
                    return true;
            }

            public void move()
            {
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key.ToString() == "RightArrow" && this.verifieCase(joueur.Position.X, joueur.Position.Y))
                {
                    this.verifieCase(joueur.Position.X, joueur.Position.Y);
                    joueur.Position.setY(joueur.Position.Y + 1);
                    this.plateau[joueur.Position.X, joueur.Position.Y] = this.joueur;
                    this.plateau[0, 0] = new Vide(new Position(0, 0));

                }
                else if (cki.Key.ToString() == "LeftArrow")
                {
                    joueur.Position.setY(joueur.Position.Y - 1);
                    this.plateau[joueur.Position.X, joueur.Position.Y] = this.joueur;
                    this.plateau[0, 0] = new Vide(new Position(0, 0));
                }

            }
        }*/
    }
}
}
