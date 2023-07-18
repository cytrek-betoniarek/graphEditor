using System.Collections.Generic;
using System.IO;

namespace graphEditor.Entities
{
    class GraphConverter
    {
        public void storeGraph(List<Vertex> vertices, List<(Vertex, Vertex)> edges, string path)
        {
            using (StreamWriter writer = new(path))
            {
                foreach (var vertex in vertices) writer.WriteLine($"{vertex.x},{vertex.y}");
                writer.WriteLine();
                foreach (var edge in edges) writer.WriteLine($"{edge.Item1.index},{edge.Item2.index}");
            }
        }

        internal void loadGraph(List<Vertex> vertices, List<(Vertex, Vertex)> edges, string path)
        {
            vertices.Clear();
            edges.Clear();
            using (StreamReader reader = new(path))
            {
                string line;
                string[] parts;
                int part1, part2;
                while ((line = reader.ReadLine()) != string.Empty)
                {
                    parts = line.Split(',');
                    part1 = int.Parse(parts[0]);
                    part2 = int.Parse(parts[1]);
                    vertices.Add(new(part1, part2, vertices.Count));
                }
                while ((line = reader.ReadLine()) != null)
                {
                    parts = line.Split(',');
                    part1 = int.Parse(parts[0]);
                    part2 = int.Parse(parts[1]);
                    edges.Add(new(vertices[part1], vertices[part2]));
                }
            }
        }
    }
}
