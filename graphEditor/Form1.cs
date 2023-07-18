using graphEditor.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphEditor
{
    public struct MarkedVertex
    {
        public bool exists;
        public int index;
    }
    public partial class mainForm : Form
    {
        private readonly List<Vertex> vertices = new();
        private readonly List<(Vertex, Vertex)> edges = new();
        private readonly int verticesLimit = 999;
        private readonly int vertexRadius = 13;
        private MarkedVertex markedVertex;
        private (int, int) previousPosition;
        private Bitmap drawArea;
        private readonly Drawer drawer;

        public mainForm()
        {
            InitializeComponent();
            KeyPreview = true;
            drawArea = new(pictureBox.Size.Width, pictureBox.Size.Height);
            pictureBox.Image = drawArea;
            markedVertex.exists = false;
            drawer = new(pictureBox, drawArea, vertexRadius);
        }

        private bool isAreaClean(MouseEventArgs e)
        {
            foreach (var vertex in vertices)
            {
                if (Math.Pow(e.X - vertex.x, 2) + Math.Pow(e.Y - vertex.y, 2) <= Math.Pow(2 * vertexRadius, 2) + 12) return false;
            }
            return true;
        }

        private (bool, int) isAreaWithinVertex(MouseEventArgs e)
        {
            int counter = 0;
            foreach (var vertex in vertices)
            {
                if (Math.Pow(e.X - vertex.x, 2) + Math.Pow(e.Y - vertex.y, 2) <= Math.Pow(vertexRadius, 2)) return (true, counter);
                counter++;
            }
            return (false, -1);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            var areaWithinVertexResult = isAreaWithinVertex(e);
            if (e.Button == MouseButtons.Left)
            {
                if (isAreaClean(e))
                {
                    if (vertices.Count < verticesLimit)
                    {
                        Vertex newVertex = new(e.X, e.Y, vertices.Count);
                        vertices.Add(newVertex);
                        drawer.drawVertex(newVertex, false, true); 
                    }
                    else MessageBox.Show($"You've reached the limit of {verticesLimit} vertices.");
                }
                else if (areaWithinVertexResult.Item1 == true && markedVertex.exists == true && markedVertex.index != areaWithinVertexResult.Item2)
                {
                    var consideredEdge = (vertices[markedVertex.index], vertices[areaWithinVertexResult.Item2]);
                    var consideredEdgeReversed = (vertices[areaWithinVertexResult.Item2], vertices[markedVertex.index]);
                    if (edges.Contains(consideredEdge)) edges.Remove(consideredEdge);
                    else if(edges.Contains(consideredEdgeReversed)) edges.Remove(consideredEdgeReversed);
                    else edges.Add(consideredEdge);
                    drawer.drawAll(vertices, edges, markedVertex);
                }

            }

            if (e.Button == MouseButtons.Right)
            {
                if(areaWithinVertexResult.Item1 == true)
                {
                    if(markedVertex.exists == true && markedVertex.index == areaWithinVertexResult.Item2)
                    {
                        markedVertex.exists = false;
                        removeVertexButton.Enabled = false;
                        Vertex consideredVertex = vertices[areaWithinVertexResult.Item2];
                        drawer.drawVertex(consideredVertex, false, true);
                    }
                    else if (markedVertex.exists == true && markedVertex.index != areaWithinVertexResult.Item2)
                    {
                        Vertex newMarkedVertex = vertices[markedVertex.index];
                        drawer.drawVertex(newMarkedVertex, false, true);

                        markedVertex.index = areaWithinVertexResult.Item2;

                        Vertex prevMarkedVertex = vertices[markedVertex.index];
                        drawer.drawVertex(prevMarkedVertex, true, true);
                    }
                    else if(markedVertex.exists == false)
                    {
                        markedVertex.exists = true;
                        markedVertex.index = areaWithinVertexResult.Item2;
                        removeVertexButton.Enabled = true;
                        Vertex consideredVertex = vertices[areaWithinVertexResult.Item2];
                        drawer.drawVertex(consideredVertex, true, true);
                    }
                }
                else
                {
                    Vertex consideredVertex = vertices[markedVertex.index];
                    markedVertex.exists = false;
                    removeVertexButton.Enabled = false;
                    drawer.drawVertex(consideredVertex, false, true);
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Middle || markedVertex.exists != true) return;
            vertices[markedVertex.index].modifyPosition(e.X - previousPosition.Item1, e.Y - previousPosition.Item2);
            drawer.drawAll(vertices, edges, markedVertex);
            previousPosition = (e.X, e.Y);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) previousPosition = (e.X, e.Y);
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            drawArea = new(pictureBox.Size.Width, pictureBox.Size.Height);
            pictureBox.Image = drawArea;
            drawer.updateBitmap(drawArea);
            drawer.drawAll(vertices, edges, markedVertex);
        }

        private void graphColorButton_Click(object sender, EventArgs e)
        {
            graphColorDialog.ShowDialog();
            graphColorPanel.BackColor = graphColorDialog.Color;
            graphColorFramingPanel.BackColor = graphColorDialog.Color == Color.Black ? Color.White : Color.Black;
            drawer.drawAll(vertices, edges, markedVertex);
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            backgroundColorDialog.ShowDialog();
            backgroundColorPanel.BackColor = backgroundColorDialog.Color;
            backgroundColorFramingPanel.BackColor = backgroundColorDialog.Color == Color.Black ? Color.White : Color.Black;
            drawer.drawAll(vertices, edges, markedVertex);
        }

        private void removeGraphButton_Click(object sender, EventArgs e)
        {
            edges.Clear();
            vertices.Clear();
            markedVertex.exists = false;
            drawer.drawAll(vertices, edges, markedVertex);
        }

        private void removeVertex()
        {
            edges.RemoveAll(e => e.Item1.index == markedVertex.index || e.Item2.index == markedVertex.index);
            vertices.RemoveAt(markedVertex.index);
            markedVertex.exists = false;
            removeVertexButton.Enabled = false;
            for (int i = markedVertex.index; i < vertices.Count; i++) vertices[i].index--;
            drawer.drawAll(vertices, edges, markedVertex);
        }

        private void removeVertexButton_Click(object sender, EventArgs e)
        {
            removeVertex();
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) removeVertex();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.Filter = "Graph Files(*.graph)|*.graph";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                GraphConverter graphConverter = new();
                graphConverter.loadGraph(vertices, edges, fileDialog.FileName);
                markedVertex.exists = false;
                drawer.drawAll(vertices, edges, markedVertex);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new();
            fileDialog.Filter = "Graph Files(*.graph)|*.graph";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                GraphConverter graphConverter = new();
                graphConverter.storeGraph(vertices, edges, fileDialog.FileName);
            }
        }
    }
}
