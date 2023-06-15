using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Cowake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Position pozice = new Position();
            pozice.x = pictureBox1.Location.X;
            pozice.y = pictureBox1.Location.Y;
            bool alive = true;

            Cow cow = new Cow(alive);
        }

    }
}
