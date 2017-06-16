using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doggo.GameThingy
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        int x = 50;
        int y = 50;
        public Form1()
        {
            InitializeComponent();
        }

        public void GameLoop()
        {
            while(Created)
            {
                timer.Reset();
                GameLogic();
                RenderScene();
                Application.DoEvents();
                while (timer.GetTicks() < 50);
            }
        }

        private void RenderScene()
        {
            Graphics graphics = CreateGraphics();
            graphics.Clear(Color.White);
            Rectangle rectangle = new Rectangle(x, y, 50, 50);
            graphics.DrawRectangle(Pens.Red, rectangle);
        }

        private void GameLogic()
        {
            //throw new NotImplementedException();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                y -= 10;
            else if (e.KeyCode == Keys.Right)
                x += 10;
            else if (e.KeyCode == Keys.Down)
                y += 10;
            else if (e.KeyCode == Keys.Left)
                x -= 10;
        }
    }
}
