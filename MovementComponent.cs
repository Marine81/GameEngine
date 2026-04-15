using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class MovementComponent : Component
    {
        private int _speed;
        //private Vector2 _position = new Vector2(0, 0);
        private Vector2 _direction = new Vector2(0, 0);

        private PositionComponent _positionComponent;
        private LevelComponent _levelComponent;
        public MovementComponent(int speed,PositionComponent position_component, LevelComponent level_component) : base(game_object)
        {
            _speed = speed;
            _positionComponent = position_component;
            _levelComponent = level_component;
        }

        public override void FixedUpdate(float fixed_elapsed_time)
        {
            Vector2 new_position = new Vector2(
               _positionComponent.GetX() + _direction.GetX() * fixed_elapsed_time * _speed,
               _positionComponent.GetY() + _direction.GetY() * fixed_elapsed_time * _speed
           );

            if (new_position.GetX() < 0)
            {
                new_position.SetX(0);
            }
            else if (new_position.GetX() >= _levelComponent.GetXSize())
            {
                new_position.SetX(Console.WindowWidth - 1);
            }

            if (new_position.GetY() < 0)
            {
                new_position.SetY(0);
            }
            else if (new_position.GetY() >= _levelComponent.GetYSize())
            {
                new_position.SetY(Console.WindowHeight - 1);
            }
            _positionComponent = new_position;
            _direction = new Vector2(0, 0);
        }

        public override void OnDisable()
        {
            throw new NotImplementedException();
        }

        public override void OnEnable()
        {
            throw new NotImplementedException();
        }

        public override void Update(float elapsed_time)
        {
        }

        public override Component clone(GameObject parent_game_object)
        {
            MovementComponent movement_component = parent_game_object.GetComponent<MovementComponent>();
            if (movement_component == null)
            {
                Console.WriteLine("WARNING: movemmentComponent is null");
            }

            return new AiMovementComponent(parent_game_object, _speed, position_component);
        }
    }
}
