using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ObjFormatParcer
{
    public class Face
    {
        private char indexesSeparator = '/';

        public List<int> VertexIndexes { get; private set; } = new List<int>();
        public List<int> VertexTextureIndexes { get; private set; } = new List<int>();
        public List<int> VertexNormalIndexes { get; private set; } = new List<int>();

        public Face()
        {

        }

        public Face(int[] vertexIndexes, int[] vertexTextureIndexes, int[] vertexNormalIndexes)
        {
            this.VertexIndexes.AddRange(vertexIndexes);
            this.VertexTextureIndexes.AddRange(vertexTextureIndexes);
            this.VertexNormalIndexes.AddRange(vertexNormalIndexes);
        }

        public void LoadIndexes(string[] rawIndexes)
        {
            foreach (var rawIndex in rawIndexes)
            {
                var indexes = rawIndex.Split(indexesSeparator);

                this.VertexIndexes.Add(Convert.ToInt32(indexes[0]));

                if (indexes.Length == 2)
                {
                    this.VertexTextureIndexes.Add(Convert.ToInt32(indexes[1]));
                }
                else if (indexes[1].Trim().Length == 1)
                {
                    this.VertexTextureIndexes.Add(Convert.ToInt32(indexes[1]));
                    this.VertexNormalIndexes.Add(Convert.ToInt32(indexes[2]));
                }
                else
                {
                    this.VertexNormalIndexes.Add(Convert.ToInt32(indexes[2]));
                }
            }
        }
    }
}
