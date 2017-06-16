using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Doggo.GameThingy.Objects;

namespace Doggo.GameThingy
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        List<IVisualObject> gameObjects = new List<IVisualObject>();

        public Form1()
        {
            InitializeComponent();
        }

        public void GameLoop()
        {
            InitGameObjects();
            while(Created)
            {
                timer.Reset();
                GameLogic();
                RenderScene();
                Application.DoEvents();
                while (timer.GetTicks() < 50);
            }
        }

        private void InitGameObjects()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\tomjan\Source\Repos\Doggo.GameThingy\Doggo.GameThingy\Map.txt");
            Height = lines.Length * 20 + 40;
            Width = 220;

            for (int r = 0; r < lines.Length; r++)
            {
                for (int c = 0; c < lines[r].Length; c++)
                {
                    if (lines[r].Substring(c, 1) == "x") gameObjects.Add(new Wall(c * 20, r * 20));
                    if (lines[r].Substring(c, 1) == "o")
                    {
                        Player p = new Player(c * 20, r * 20);
                        KeyDown += new KeyEventHandler(p.PlayerMove);
                        gameObjects.Add(p);
                    }
                }
            }
        }

        private void RenderScene()
        {
            Graphics graphics = CreateGraphics();
            graphics.Clear(Color.White);
            foreach (IVisualObject obj in gameObjects) obj.Draw(graphics);
        }

        private void GameLogic()
        {
            
        }
    }
}
