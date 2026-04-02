using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class PositionComponent 
    {
        private GameObject _gameObject;
        public PositionComponent(Vector2 position, GameObject game_object)
        {
            _gameObject = game_object;
        }
    }
}
