using System;
using System.Collections.Generic;
using System.Text;

namespace ObjFormatParcer
{
    public class Vertex
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vertex(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
