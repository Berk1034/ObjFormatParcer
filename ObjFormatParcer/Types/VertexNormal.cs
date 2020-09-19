using System;
using System.Collections.Generic;
using System.Text;

namespace ObjFormatParcer.Types
{
    public class VertexNormal
    {
        public double I { get; set; }
        public double J { get; set; }
        public double K { get; set; }

        public VertexNormal(double i, double j, double k)
        {
            this.I = i;
            this.J = j;
            this.K = k;
        }
    }
}
