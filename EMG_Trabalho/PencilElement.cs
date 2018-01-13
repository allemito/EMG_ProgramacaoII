using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMG_Trabalho
{
    
    class PencilElement : DesignElement
    {
        List<PointF> points = new List<PointF>();

        public void addPoint(PointF pointF)
        {
            points.Add(pointF);
        }

        public PencilElement(Pen pen, Graphics g) : base(pen, g)
        {
            base.Pen = pen;
            base.G = g;
        }

        public override void draw()
        {
            G.DrawLines(Pen, points.ToArray());
        }
    }
}
