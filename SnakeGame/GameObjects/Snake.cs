using SnakeGame.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.GameObjects
{
    public class Snake
    {
        public Pen Shape { get; private set; }
        public List<Point> Body { get; private set; }

        private Point _startingPoint;
        int _stepSize = 5;

        Margin _margin;

        public Direction Direction { get; set; }

        public Snake(Point startingPoint, Margin margin)
        {
            Body = new List<Point>(30)
            {
                startingPoint
            };
            _startingPoint = startingPoint;
            Direction = Direction.Up;

            Shape = new Pen(new SolidBrush(Color.Red), 1);
            _margin = margin;
        }

        public void Eat()
        {
            var tailPosition = Body.Last();
            Move();
            Body.Add(tailPosition);
           
        }

        public bool Found(Point food)
        {
            var foundX = Math.Abs(food.X - Body[0].X) < 10;
            var foundY = Math.Abs(food.Y - Body[0].Y) < 10;

            return foundX && foundY;
        }

        public void Move()
        {
            switch (Direction)
            {
                case Direction.Left:
                    MoveLeft();
                    break;
                case Direction.Right:
                    MoveRight();
                    break;
                case Direction.Up:
                    MoveUp();
                    break;
                case Direction.Down:
                    MoveDown();
                    break;
                default:
                    break;
            }

        }

        public void MoveLeft()
        {
            FollowHead();
            if (Body[0].X <= _margin.Left)
                Body[0] = new Point(_margin.Right - _stepSize, Body[0].Y);
            else
                Body[0] = new Point(Body[0].X - _stepSize, Body[0].Y);
        }


        public void MoveRight()
        {
            FollowHead();
            if (Body[0].X >= _margin.Right)
                Body[0] = new Point(_margin.Left + _stepSize, Body[0].Y);
            else
                Body[0] = new Point(Body[0].X + _stepSize, Body[0].Y);
        }

        public void MoveUp()
        {
            FollowHead();
            if (Body[0].Y <= _margin.Top)
                Body[0] = new Point(Body[0].X, _margin.Bottom - _stepSize);
            else
                Body[0] = new Point(Body[0].X, Body[0].Y - _stepSize);
        }

        public void MoveDown()
        {
            FollowHead();
            if (Body[0].Y >= _margin.Bottom)
                Body[0] = new Point(Body[0].X, _margin.Top + _stepSize);
            else
                Body[0] = new Point(Body[0].X, Body[0].Y + _stepSize);
        }

        private void FollowHead()
        {
            for (int i = Body.Count - 1; i > 0; i--)
            {
                var p = Body[i - 1];
                Body[i] = new Point(p.X, p.Y);
            }
        }

        public void Reset()
        {
            Body = new List<Point>(30)
            {
                _startingPoint
            };

        }
    }
}
