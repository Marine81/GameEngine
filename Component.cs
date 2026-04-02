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

        public abstract void OnEnable();
        public abstract void OnDisable();
        public abstract void Update(float elapsed_time);
        public abstract void FixedUpdate(float Fixed_elapsed_time);
    }
}
