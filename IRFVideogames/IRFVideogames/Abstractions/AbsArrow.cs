using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRFVideogames.Abstractions
{
    public abstract class AbsArrow: Label
    {
        public AbsArrow()
        {
            Width = 50;
            Height = 50;
            
        }

        private void AbsArrow_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);
    }
}
