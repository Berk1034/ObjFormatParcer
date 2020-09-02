using System;
using System.Collections.Generic;
using System.Text;

namespace ObjFormatParcer
{
    public class Face
    {
        public List<int> VertexIndexes { get; private set; } = new List<int>();
        public List<int> VertexTextureIndexes { get; private set; } = new List<int>();
        public List<int> VertexNormalIndexes { get; private set; } = new List<int>();

        public Face(int[] vertexIndexes, int[] vertexTextureIndexes, int[] vertexNormalIndexes)
        {
            this.VertexIndexes.AddRange(vertexIndexes);
            this.VertexTextureIndexes.AddRange(vertexTextureIndexes);
            this.VertexNormalIndexes.AddRange(vertexNormalIndexes);
        }
    }
}
