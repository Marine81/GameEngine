using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class StateMachine
    {
        private IState _currentState;

        public void ChangeState(IState new_state)
        {
            _currentState.Exit();
            _currentState = new_state;
            _currentState.Enter();
        }

        public void ProcessInput()
        {

        }

        public void Update(float elapsed_time)
        {

        }

        public void Render()
        {

        }

        public void SetInitialState(IState initial_state)
        {
            _currentState = initial_state;
        }
    }
}
