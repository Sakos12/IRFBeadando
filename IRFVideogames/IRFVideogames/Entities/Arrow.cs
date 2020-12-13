using IRFVideogames.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRFVideogames.Entities
{
    public class Arrow : AbsArrow
    {

        public Arrow()
        {
           
        }

        private void Arrow_Paint1(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
       
        }

        protected override void DrawImage(Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 8);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            g.DrawLine(pen, 20, 175, 300, 175);
        }
        private void Arrow_Paint(object sender, PaintEventArgs e)
        {
           
        }
       
    }
}
