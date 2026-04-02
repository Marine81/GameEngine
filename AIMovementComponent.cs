using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class AIMovementComponent : Component
    {
        private LevelComponent _levelComponent;

        private readonly Random _random = new Random();
        private Vector2 _position = new Vector2(0, 0);
        private Vector2 _direction = new Vector2(0, 0);
        private float _timeSinceLastDirectionChange = 0;
        private float _timeToNextDirectionChange = 1.0f;
        private float _speed = 10;

        public AIMovementComponent(LevelComponent levelComponent) : base(game_object)
        {
            _levelComponent = levelComponent;
        }
        public override void FixedUpdate(float fixed_elapsed_time)
        {
            Vector2 new_position = new Vector2(
               _position.GetX() + _direction.GetX() * fixed_elapsed_time * _speed,
               _position.GetY() + _direction.GetY() * fixed_elapsed_time * _speed
           );

            if (new_position.GetX() < 0)
            {
                new_position.SetX(0);
                _direction = new Vector2(1, 0);
            }
            else if (new_position.GetX() >= _levelComponent.GetWidth())
            {
                new_position.SetX(Console.WindowWidth - 1);
                _direction = new Vector2(-1, 0);
            }

            if (new_position.GetY() < 0)
            {
                new_position.SetY(0);
                _direction = new Vector2(0, -1);
            }
            else if (new_position.GetY() >= _levelComponent.GetHeight())
            {
                new_position.SetY(Console.WindowHeight - 1);
                _direction = new Vector2(0, 1);
            }

            _position = new_position;

            TryToChangeDirection(fixed_elapsed_time);
        }
        private void TryToChangeDirection(float elapsed_time)
        {
            _timeSinceLastDirectionChange += elapsed_time;

            if (_timeSinceLastDirectionChange >= _timeToNextDirectionChange)
            {
                _direction.SetX(_random.Next(-1, 2));
                _direction.SetY(_random.Next(-1, 2));
                _timeToNextDirectionChange = _random.Next(10, 21);
                _timeSinceLastDirectionChange = 0;
            }
        }
        public override void Update(float elapsed_time)
        {
            throw new NotImplementedException();
        }
    }
}
