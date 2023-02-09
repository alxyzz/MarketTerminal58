using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK_ConsoleGame.Screens
{
    class Scene
    {
        private Game gameref;

        public Scene(Game r, string title, string bottom)
        {
            gameref = r;
        }




        public void GetInput(char b)
        {
            switch (b)
            {
                case 'a':

                    break;




                default:
                    Console.WriteLine("Unrecognized command.");
                    break;
            }

        }

    }
}
