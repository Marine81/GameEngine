using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Player 
    {
        private Vector2 _position = new Vector2(0, 0);
        private string _renderGraphic = "@";
        private Vector2 _direction = new Vector2(0,0); //stocke l'intention de mouvement
        private float _speed = 10;


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
    }
}
