using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public abstract class GameObject
    {
        public abstract void Update(float elapsed_time);
        public abstract void FixedUpdate(float elapsed_time);

        public GameObject(GameEngine game_engine)
        {
            game_engine.AddGameObject(this);
        }
    }
}
