using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRFVideogames.Entities
{
    public abstract class Abstract : Button
    {
        public Abstract()
        {
            AutoSize = false;
            Width = 100;
            Height = 100;
        }
        private void Abstract_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);
    }
}
