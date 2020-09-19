﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ObjFormatParcer
{
    public class ObjFormat
    {
        private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        private char lineSeparator = ' ';

        public List<Vertex> Vertices { get; private set; } = new List<Vertex>();
        public List<VertexTexture> VertexTextures { get; private set; } = new List<VertexTexture>();
        public List<VertexNormal> VertexNormals { get; private set; } = new List<VertexNormal>();
        public List<Face> Faces { get; private set; } = new List<Face>();

        public void ProcessLine(string line)
        {
            var parts = line.Split(lineSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 0)
            {
                switch (parts[0])
                {
                    case "v":
                        double w = parts.Length > 4 ? Convert.ToDouble(parts[4], cultureInfo) : 1.0;
                        Vertex vertex = new Vertex(Convert.ToDouble(parts[1], cultureInfo), Convert.ToDouble(parts[2], cultureInfo), Convert.ToDouble(parts[3], cultureInfo), w);
                        Vertices.Add(vertex);
                        break;
                    case "vt":
                        VertexTexture vertexTexture = new VertexTexture();
                        vertexTexture.LoadCoordinates(parts[1..], cultureInfo);
                        VertexTextures.Add(vertexTexture);
                        break;
                    case "vn":
                        VertexNormal vertexNormal = new VertexNormal(Convert.ToDouble(parts[1], cultureInfo), Convert.ToDouble(parts[2], cultureInfo), Convert.ToDouble(parts[3], cultureInfo));
                        VertexNormals.Add(vertexNormal);
                        break;
                    case "f":
                        Face face = new Face();
                        face.LoadIndexes(parts[1..]);
                        //Face face = new Face(Array.ConvertAll(parts[1].Split(indexesSeparator), int.Parse), Array.ConvertAll(parts[2].Split(indexesSeparator), int.Parse), Array.ConvertAll(parts[3].Split(indexesSeparator), int.Parse));
                        Faces.Add(face);
                        break;
                }
            }
        }
    }
}
