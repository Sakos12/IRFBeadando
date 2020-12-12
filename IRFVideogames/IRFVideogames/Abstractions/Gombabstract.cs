using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRFVideogames.Abstractions
{
    public abstract class Gombabstract : Button
    {
            public Gombabstract()
            {
                AutoSize = false;
                Width = 200;
                Height = 200;
            }
            private void Abstract_Paint(object sender, PaintEventArgs e)
            {
                DrawImage(e.Graphics);
            }

            protected abstract void DrawImage(Graphics g);
    }

}

