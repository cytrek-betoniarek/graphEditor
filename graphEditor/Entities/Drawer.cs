using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphEditor.Entities
{
    class Drawer
    {
        private readonly PictureBox pictureBox;
        private readonly int vertexRadius;
        private const int brushThickness = 3;
        private Bitmap drawArea;
        private Color backgroundColor = Color.White;
        private SolidBrush backgroundSolidBrush = new(Color.White);
        private readonly (int, int) dashPattern = (2, 1);
        private Pen pen = new(Brushes.Black, brushThickness);
        private Pen dashedPen = new(Brushes.Black, brushThickness);
        private readonly Font font = new("Arial", 10);
        private readonly StringFormat stringFormat = new();
        private SolidBrush solidBrush = new(Color.Black);

        public Drawer(PictureBox pictureBox, Bitmap drawArea, int vertexRadius)
        {
            this.pictureBox = pictureBox;
            this.drawArea = drawArea;
            this.vertexRadius = vertexRadius;
            dashedPen.DashPattern = new float[] { dashPattern.Item1, dashPattern.Item2 };
        }

        internal void updateBitmap(Bitmap drawArea) { this.drawArea = drawArea; }

        internal void drawVertex(Vertex v, bool markedVertex, bool refresh)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.FillEllipse(backgroundSolidBrush, v.x - vertexRadius - 2, v.y - vertexRadius - 2, 2 * vertexRadius + 4, 2 * vertexRadius + 4);
                g.DrawEllipse(markedVertex ? dashedPen : pen, v.x - vertexRadius, v.y - vertexRadius, 2 * vertexRadius, 2 * vertexRadius);
                int shift = v.index + 1 < 10 ? 8 : v.index + 1 < 100 ? 4 : 0;
                g.DrawString((v.index + 1).ToString(), font, solidBrush, v.x - vertexRadius + shift, v.y - vertexRadius + 5, stringFormat);
            }
            if (refresh) pictureBox.Refresh();
        }

        internal void drawEdge(Vertex v1, Vertex v2)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.DrawLine(pen, v1.x, v1.y, v2.x, v2.y);
            }
        }

        internal void drawAll(List<Vertex> vertices, List<(Vertex, Vertex)> edges, MarkedVertex markedVertex)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(backgroundColor);
            }
            foreach (var edge in edges) drawEdge(edge.Item1, edge.Item2);
            foreach (var vertex in vertices) drawVertex(vertex, false, false);
            if (markedVertex.exists == true) drawVertex(vertices[markedVertex.index], true, false);
            pictureBox.Refresh();
        }

        internal void changeGraphColor(Color color)
        {
            pen = new(color, brushThickness);
            dashedPen = new(color, brushThickness);
            dashedPen.DashPattern = new float[] { dashPattern.Item1, dashPattern.Item2 };
            solidBrush = new(color);
        }

        internal void changeBackgroundColor(Color color)
        {
            backgroundColor = color;
            backgroundSolidBrush = new(backgroundColor);
        }
    }
}
