using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public abstract class Component
    {
        private bool _isActive = true;
        protected GameObject _gameObject;

        public Component(GameObject game_object)
        {
            _gameObject = game_object;
        }

        public void Update(float elapsed_time) { }
        public void FixedUpdate(float Fixed_elapsed_time) { }
    }
}
