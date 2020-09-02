using System;
using System.Collections.Generic;
using System.Text;

namespace ObjFormatParcer
{
    public class VertexTexture
    {
        public double U { get; set; }
        public double V { get; set; }
        public double W { get; set; }

        public VertexTexture(double u, double v, double w)
        {
            this.U = u;
            this.V = v;
            this.W = w;
        }
    }
}
