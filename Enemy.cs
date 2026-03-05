using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Enemy : GameObject
    {
        private Level _level;
        private string _renderGraphic = "E";
        private float _speed = 10;

        private static Random _random = new Random();
        public Enemy(GameEngine game_engine, Level level) : base(game_engine)
        {
            _level = level;
            //initialiser position direction aléatoire
            int randomX = _random.Next(0, _level.GetXSize());
            int randomY = _random.Next(0, _level.GetYSize());
            SetPosition(new Vector2(randomX, randomY));

            int dirX = 0;
            int dirY = 0;
            while(dirX == 0 &&  dirY == 0)
            {
                dirX = _random.Next(-1,2);
                dirY = _random.Next(-1,2);
            }
        }
        public float GetSpeed()
        {
            return _speed;
        }

        
        public override void FixedUpdate(float elapsed_time)
        {
            Vector2 enemy_position = GetPosition();
            Vector2 enemy_direction = GetDirection();
            float enemy_speed = GetSpeed();

            Vector2 new_position = new Vector2(enemy_position.GetX() + enemy_direction.GetX() * elapsed_time * enemy_speed,
                enemy_position.GetY() + enemy_direction.GetY() * elapsed_time * enemy_speed);

           

            if (new_position.GetX() < 0)
            {
                new_position.SetX(0);
                SetDirection(new Vector2(-enemy_direction.GetX(), enemy_direction.GetY()));
            }
            else if (new_position.GetX() >= _level.GetXSize())
            {
                new_position.SetX(_level.GetXSize() - 1);
                SetDirection(new Vector2(-enemy_direction.GetX(), enemy_direction.GetY()));
            }

            if (new_position.GetY() < 0)
            {
                new_position.SetY(0);
                SetDirection(new Vector2(enemy_direction.GetX(), -enemy_direction.GetY()));
            }
            else if (new_position.GetY() >= _level.GetYSize())
            {
                new_position.SetY(_level.GetYSize() - 1);
                SetDirection(new Vector2(enemy_direction.GetX(), -enemy_direction.GetY()));
            }

            SetPosition(new_position);
        }

        public override void HandleInput(ConsoleKeyInfo player_command)
        {
            throw new NotImplementedException();
        }

        public override void Update(float elapsed_time)
        {
            throw new NotImplementedException();
        }

        public override void Render()
        {
            Console.SetCursorPosition((int)_position.GetX(), (int)_position.GetY());
            Console.Write(_renderGraphic);
        }
    }
}
