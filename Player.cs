using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Player : GameObject
    {
        private Vector2 _position = new Vector2(0, 0);
        private string _renderGraphic = "@";
        private Vector2 _direction = new Vector2(0,0); //stocke l'intention de mouvement
        private float _speed = 10;

        public Player(GameEngine game_engine) : base(game_engine)
        {
            game_engine.AddGameObject(this);
        }

        public void Render()
        {
            Console.SetCursorPosition((int)_position.GetX(), (int)_position.GetY());
            Console.Write(_renderGraphic);
        }
        public Vector2 GetDirection()
        {
            return _direction;
        }
        public void SetDirection(Vector2 new_direction)
        {
            _direction = new_direction;
        }

        public Vector2 GetPosition()
        {
            return _position;
        }

        public void SetPosition(Vector2 new_position)
        {
            _position = new_position;
        }
        
        public float GetSpeed()
        {
            return _speed;
        }

        public override void Update(float elapsed_time)
        {
            throw new NotImplementedException();
        }

        public override void FixedUpdate(float elapsed_time)
        {
            Vector2 player_position = GetPosition();
            Vector2 player_direction = GetDirection();
            float player_speed = GetSpeed();

            Vector2 new_position = new Vector2(player_position.GetX() + player_direction.GetX() * elapsed_time * player_speed,
                player_position.GetY() + player_direction.GetY() * elapsed_time * player_speed);

            SetPosition(new_position);

            if (new_position.GetX() < 0)
            {
                new_position.SetX(0);
            }
            else if (new_position.GetX() >= Console.WindowWidth)
            {
                new_position.SetX(Console.WindowWidth - 1);
            }

            if (new_position.GetY() < 0)
            {
                new_position.SetY(0);
            }
            else if (new_position.GetY() >= Console.WindowHeight)
            {
                new_position.SetY(Console.WindowHeight - 1);
            }

            _player.SetPosition(new_position);

            _player.SetDirection(new Vector2(0, 0));
        }

        public override void HandleInput(ConsoleKeyInfo player_command)
        {
            if (player_command.Key == ConsoleKey.LeftArrow)
            {
                SetDirection(new Vector2(-1, 0));
            }

            else if (player_command.Key == ConsoleKey.RightArrow)
            {
               SetDirection(new Vector2(1, 0));
            }

            else if (player_command.Key == ConsoleKey.UpArrow)
            {
                SetDirection(new Vector2(0, -1));
            }

            else if (player_command.Key == ConsoleKey.DownArrow)
            {
                SetDirection(new Vector2(0, 1));
            }
        }
    }
}
