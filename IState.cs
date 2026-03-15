using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal interface IState
    {
        public void Enter();
        public void Exit();

        public void Update(float elapsed_time);
        public void FixedUpdate(float fixed_elapsed_time);

        public void ProcessInput(ConsoleKeyInfo input);

        public void Render();

    }
}
