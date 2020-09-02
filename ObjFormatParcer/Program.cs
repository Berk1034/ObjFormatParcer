using System;
using System.IO;
using System.Text;

namespace ObjFormatParcer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the .obj filepath:");
            string filename = Console.ReadLine();
            string[] fileLines = File.ReadAllLines(filename, Encoding.UTF8);
            ObjFormat obj = new ObjFormat();
            foreach (var line in fileLines)
            {
                obj.ProcessLine(line);
            }

            Console.WriteLine($"Parsed totally: {Environment.NewLine} {obj.Vertices.Count} vertices, {Environment.NewLine} {obj.VertexTextures.Count} texture vertices, {Environment.NewLine} {obj.VertexNormals.Count} vertex normals, {Environment.NewLine} {obj.Faces.Count} faces.");
        }
    }
}
