using System.Drawing;
using System.Windows.Forms;

namespace Doggo.GameThingy.Objects
{
    class Player : IVisualObject
    {
        int x;
        int y;
        int width;
        int height;

        public Player(int startX, int startY)
        {
            x = startX;
            y = startY;
            height = width = 20;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.HotPink, 1), new Rectangle(x, y, width, height));
        }

        public void PlayerMove(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                y -= 20;
            else if (e.KeyCode == Keys.Right)
                x += 20;
            else if (e.KeyCode == Keys.Down)
                y += 20;
            else if (e.KeyCode == Keys.Left)
                x -= 20;
        }
    }
}
