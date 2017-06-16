using System.Drawing;

namespace Doggo.GameThingy.Objects
{
    class Wall : IVisualObject
    {
        int x;
        int y;
        int width;
        int height;
        public Wall(int startX, int startY)
        {
            x = startX;
            y = startY;
            height = width = 20;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Orange), new Rectangle(x, y, width, height));
            g.DrawRectangle(new Pen(Color.Black,3), new Rectangle(x, y, width, height));
            g.DrawLine(Pens.Black, new Point(x, y), new Point(x + width, y + height));
            g.DrawLine(Pens.Black, new Point(x + width, y), new Point(x, y + height));
        }
    }
}
