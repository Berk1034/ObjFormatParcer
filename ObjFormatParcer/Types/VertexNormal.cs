using System;
using System.Collections.Generic;
using System.Text;

namespace ObjFormatParcer.Types
{
    public class VertexNormal
    {
        public float I { get; set; }
        public float J { get; set; }
        public float K { get; set; }

        public VertexNormal(float i, float j, float k)
        {
            this.I = i;
            this.J = j;
            this.K = k;
        }
    }
}
