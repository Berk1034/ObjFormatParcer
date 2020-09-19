using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ObjFormatParcer.Types
{
    public class VertexTexture
    {
        public float U { get; set; }
        public float V { get; set; } = 0;
        public float W { get; set; } = 0;

        public VertexTexture() { }

        public VertexTexture(float u, float v, float w)
        {
            this.U = u;
            this.V = v;
            this.W = w;
        }

        public void LoadCoordinates(string[] coords, CultureInfo cultureInfo)
        {
            int length = coords.Length;
            this.U = float.Parse(coords[0], cultureInfo);
            if (length < 3)
            {
                this.V = float.Parse(coords[1], cultureInfo);
            }
            else
            {
                this.V = float.Parse(coords[1], cultureInfo);
                this.W = float.Parse(coords[2], cultureInfo);
            }
        }
    }
}
