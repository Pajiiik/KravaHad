using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cowake
{
    class Cow
    {
        private bool alive { get; set; }

        private KeyEventArgs e;
        public Cow(bool alv)
        {
            Position pozice = new Position();
            alive = alv;
            check_Move(alive, e,pozice.x,pozice.y);
        }


        public async void check_Move(bool smrt, KeyEventArgs e,int x, int y)
        {
            char Last_Clicked = ' ';bool clicked = false;
            while (smrt)
            {
                if (e.KeyValue == (char)Keys.Right)
                {
                    y += 10;
                    Last_Clicked = (char)Keys.Right;
                    clicked = true;
                }
                else if (e.KeyValue == (char)Keys.Up)
                {
                    x -= 10;
                    Last_Clicked = (char)Keys.Up;
                    clicked = true;
                }
                else if (e.KeyValue == (char)Keys.Down)
                {
                    y -= 10;
                    Last_Clicked = (char)Keys.Down;
                    clicked = true;
                }
                else if (e.KeyValue == (char)Keys.Left)
                {
                    x += 10;
                    Last_Clicked = (char)Keys.Left;
                    clicked = true;
                }

                if (!clicked && Last_Clicked != ' ')
                {
                    switch (Last_Clicked)
                    { 
                        case (Char)Keys.Right:
                            y += 10;
                            break;

                        case (Char)Keys.Up:
                            x -= 10;
                            break;

                        case (Char)Keys.Down:
                            y -= 10;
                            break;

                        case (Char)Keys.Left:
                            x += 10;
                            break;

                    }
                }
                clicked = false;
                Position pozice = new Position();
                pozice.x = x; pozice.y = y;
            }
        }
    }
}
