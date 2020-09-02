using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ObjFormatParcer
{
    public class VertexTexture
    {
        public double U { get; set; }
        public double V { get; set; } = 0;
        public double W { get; set; } = 0;

        public VertexTexture() { }

        public VertexTexture(double u, double v, double w)
        {
            this.U = u;
            this.V = v;
            this.W = w;
        }

        public void LoadCoordinates(string[] coords, CultureInfo cultureInfo)
        {
            int length = coords.Length;
            this.U = Convert.ToDouble(coords[0], cultureInfo);
            if (length < 3)
            {
                this.V = Convert.ToDouble(coords[1], cultureInfo);
            }
            else
            {
                this.V = Convert.ToDouble(coords[1], cultureInfo);
                this.W = Convert.ToDouble(coords[2], cultureInfo);
            }
        }
    }
}
