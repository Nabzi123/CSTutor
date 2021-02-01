using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace CSTutor
{
    class RoundedEdgeButton : Button
    {
        GraphicsPath GetRoundedPath(RectangleF pRect, int pRadius)
        {
            float mRadius = pRadius / 2f;
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddArc(pRect.X, pRect.Y, pRadius, pRadius, 180, 90);
            gPath.AddLine(pRect.X + mRadius, pRect.Y, pRect.Width - mRadius, pRect.Y);
            gPath.AddArc(pRect.X + pRect.Width - pRadius, pRect.Y, pRadius, pRadius, 270, 90);
            gPath.AddLine(pRect.Width, pRect.Y + mRadius, pRect.Width, pRect.Height - mRadius);
            gPath.AddArc(pRect.X + pRect.Width - pRadius, pRect.Y + pRect.Height - pRadius, pRadius, pRadius, 0, 90);
            gPath.AddLine(pRect.Width - mRadius, pRect.Height, pRect.X + mRadius, pRect.Height);
            gPath.AddArc(pRect.X, pRect.Y + pRect.Height - pRadius, pRadius, pRadius, 90, 90);
            gPath.AddLine(pRect.X, pRect.Height - mRadius, pRect.X, pRect.Y + mRadius);
            gPath.CloseFigure();
            return gPath;

        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            RectangleF mRect = new RectangleF(0, 0, this.Width, this.Height);
            using(GraphicsPath graphPath = GetRoundedPath(mRect, 50))
            {
                this.Region = new Region(graphPath);
                using(Pen pen = new Pen(Color.Black, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawPath(pen, graphPath);
                }
            }
        }

    }
}
