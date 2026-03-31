using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public abstract class GameObject
    {
        private List <Component> _componentTable;
        private List<Component> _componentToAddTable;
        private string _name;

        private GameEngine _gameEngine;
        public GameObject(string name,GameEngine game_engine)
        {
            _name = name;
            _gameEngine = game_engine;
            game_engine.AddGameObject(this);
        }
        public virtual void SetActive(bool is_active)
        {
            if (is_active)
            {
                _gameEngine.AddGameObject(this);
            }
            else
            {
                _gameEngine.RemoveGameObject(this);
            }
        }

        public void AddComponent(Component component)
        {
            if (!_componentTable.Contains(component))
            {
                _componentToAddTable.Add(component);
            }
        }

        public abstract void Update(float elapsed_time);
        public abstract void FixedUpdate(float fixed_elapsed_time);

        public abstract void Render();
        public abstract void HandleInput(ConsoleKeyInfo player_command);
    }
}

