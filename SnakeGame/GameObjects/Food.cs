using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GameObjects
{
    public class Food
    {
        Random _random;
        public Point Position { get; set; }
        public Pen Shape { get; set; }
        Margin _margin;

        private bool _isEaten;

        public bool IsEaten
        {
            get { return _isEaten; }
            set
            {
                if (value)
                {
                    _isEaten = value;
                    SetFood();
                }
            }
        }

        public Food(Margin margin)
        {
            _margin = margin;
            Shape = new Pen(new SolidBrush(Color.Orange), 10);
            _random = new Random();
        }

        private void SetFood()
        {
            var x = _random.Next(_margin.Left + 1, _margin.Right - 1);
            var y = _random.Next(_margin.Top + 1, _margin.Bottom - 1);
            Position = new Point(x, y);
            _isEaten = false;
        }



    }
}
