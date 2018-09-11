using SnakeGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Game
    {

        private int _score;
        private int _speedSeed = 5;

        public int Score
        {
            get { return _score; }
            set
            {
                if (value < 0)
                    _score = 0;
                else
                    _score = value;
                Speed -= (value / _speedSeed);
            }
        }

        public State State { get; set; }

        public Timer Timer { get; private set; }

        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value < 10)
                    _speed = 10;

                else
                    _speed = value;

                Timer.Interval = _speed;
            }
        }

        public Game()
        {
            Timer = new Timer();
            _speed = 100;
            Score = 0;
            Timer.Interval = _speed;
            Timer.Enabled = true;
            State = State.Paused;
        }

        public void Reset()
        {
            _speed = 100;
            Score = 0;
            Timer.Interval = _speed;
        }

    }
}
