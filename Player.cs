using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class Player
    {
        private Vector2 _position;
        private string _renderGraphic = "@";
        private Vector2 _currentDirection; //stocke l'intention de mouvement
        private float _speed = 10;

        public Player ()
        {
            
        }

        public void Render()
        {
            int x = (int)_position.GetX();
            int y = (int)_position.GetY();
            
            if( x <= 0 && y >= 0 && x < Console.WindowWidth && y < Console.WindowHeight)
            {
                Console.SetCursorPosition((int)_position.GetX(), (int)_position.GetY());
                Console.Write(_renderGraphic);
            }
            
        }
        /*public float GetDirection()
        {
            
        }*/
        public void SetDirection(Vector2 new_direction)
        {
            _currentDirection = new_direction;
        }

        public Vector2 GetPosition()
        {
            return _position;
        }
        public Vector2 SetPosition(Vector2 new_position)
        {
            return _position = new_position;
        }
    }
}
