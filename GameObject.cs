using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public abstract class GameObject
    {
        
       protected Vector2 _position = new Vector2(0, 0);
        private Vector2 _direction = new Vector2(0, 0); //stocke l'intention de mouvement

        public GameObject(GameEngine game_engine)
        {
            game_engine.AddGameObject(this);
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

        public abstract void Update(float elapsed_time);
        public abstract void FixedUpdate(float elapsed_time);

        public abstract void HandleInput(ConsoleKeyInfo player_command);

        public abstract void Render();

    }
}
