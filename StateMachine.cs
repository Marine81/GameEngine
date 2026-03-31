using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class StateMachine
    {
        private IState _currentState;


        public void ChangeState(IState new_state)
        {
            _currentState.Exit();
            _currentState = new_state;
            _currentState.Enter();
        }

        public void ProcessInput(ConsoleKeyInfo input)
        {
            _currentState.ProcessInput(input);
        }

        public void Update(float elapsed_time)
        {
            _currentState.Update(elapsed_time);
        }

        public void Render()
        {
            _currentState.Render();
        }

        public void SetInitialState(IState initial_state)
        {
            _currentState = initial_state;
            _currentState.Render();
        }
        public void FixedUpdate(float fixed_elapsed_time)
        {
            _currentState.FixedUpdate(fixed_elapsed_time);
        }

    }
}
