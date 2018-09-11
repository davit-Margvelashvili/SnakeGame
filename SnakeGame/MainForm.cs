using SnakeGame.Enums;
using SnakeGame.GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class MainForm : Form
    {

        Snake snake;
        Graphics graphics;
        Game game;
        Food food;

        public MainForm()
        {
            InitializeComponent();
            graphics = DrawingPanel.CreateGraphics();

            var startingPosition = new Point(DrawingPanel.Width / 2, DrawingPanel.Height / 2);
            var margin = new Margin(1, DrawingPanel.Width, 1, DrawingPanel.Height);

            snake = new Snake(startingPosition, margin);
            game = new Game();
            game.Timer.Tick += GameTimer_Tick;

            food = new Food(margin);

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            switch (game.State)
            {
                case State.Running:
                    graphics.Clear(DrawingPanel.BackColor);
                    snake.Move();
                    DrawSnakeBody();
                    DrawFood();
                    CheckIfFoodIsEaten();

                    break;
                case State.Paused:
                    break;
                case State.Over:
                    break;
                default:
                    break;
            }

        }

        private void CheckIfFoodIsEaten()
        {
            if (snake.Found(food.Position))
            {
                snake.Eat();
                food.IsEaten = true;
                game.Score += 10;
                scoreValueLabel.Text = game.Score.ToString();
            }
        }

        private void DrawFood()
        {
            graphics.DrawRectangle(food.Shape, food.Position.X, food.Position.Y, 10, 10);
        }

        private void DrawSnakeBody()
        {
            foreach (var body in snake.Body)
            {
                graphics.DrawRectangle(snake.Shape, body.X, body.Y, 10, 10);
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            snake.Direction = Direction.Up;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            snake.Direction = Direction.Right;
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            snake.Direction = Direction.Down;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            snake.Direction = Direction.Left;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            game.State = State.Running;
            gameStatusValueLabel.Text = "Playing";
            gameStatusValueLabel.ForeColor = Color.ForestGreen;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            game.State = State.Paused;
            gameStatusValueLabel.Text = "Paused";
            gameStatusValueLabel.ForeColor = Color.Orange;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            game.State = State.Over;
            gameStatusValueLabel.Text = "Game Over";
            gameStatusValueLabel.ForeColor = Color.Red;
            game.Reset();
            snake.Reset();
            scoreValueLabel.Text = game.Score.ToString();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    snake.Direction = Direction.Up;
                    break;

                case Keys.A:
                case Keys.Left:
                    snake.Direction = Direction.Left;
                    break;

                case Keys.S:
                case Keys.Down:
                    snake.Direction = Direction.Down;
                    break;

                case Keys.D:
                case Keys.Right:
                    snake.Direction = Direction.Right;
                    break;

                default:
                    break;
            }
        }
    }
}
