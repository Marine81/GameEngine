using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Factory : Building
    {
        private Level _level;
        private Vector2 _position = new Vector2(0, 0);
        private string _renderGraphic = "F";
        private Vector2 _direction = new Vector2(0, 0);
      
        public Factory(GameEngine game_engine) : base(game_engine)
        { }
        public Vector2 GetPosition()
        {
            return _position;
        }

        public void SetPosition(Vector2 new_position)
        {
            _position = new_position;
        }
        public Vector2 GetDirection()
        {
            return _direction;
        }

        public void SetDirection(Vector2 new_direction)
        {
            _direction = new_direction;
        } 
    }
    
}
