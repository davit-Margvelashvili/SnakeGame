using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Margin
    {
        public int Left { get; private set; }
        public int Right { get; private set; }
        public int Top { get; private set; }
        public int Bottom { get; private set; }

        public Margin(int left, int right, int up, int down)
        {
            Left = left;
            Right = right;
            Top = up;
            Bottom = down;
        }
    }
}
