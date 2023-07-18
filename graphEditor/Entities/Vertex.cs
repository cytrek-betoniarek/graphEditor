
namespace graphEditor.Entities
{
    class Vertex
    {
        public int x;
        public int y;
        public int index;

        public Vertex(int x, int y, int index)
        {
            this.x = x;
            this.y = y;
            this.index = index;
        }

        public void modifyPosition(int deltaX, int deltaY)
        {
            x += deltaX;
            y += deltaY;
        }
    }
}
