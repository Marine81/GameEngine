using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class BuildingClosedState : IState
    {
        private readonly StateMachine _stateMachine;
        private readonly Building _building;
        private float _timeBeforeOpening;

        public BuildingClosedState(StateMachine state_machine, Building building)
        {
            _stateMachine = state_machine;
            _building = building;
        }

        public void Enter()
        {
            _timeBeforeOpening = 20;
        }

        public void ProcessInput(ConsoleKeyInfo input)
        {
        }

        public void Update(float elapsed_time)
        {
        }
        public void FixedUpdate(float fixed_elapsed_time)
        {
            _timeBeforeOpening -= fixed_elapsed_time;

            if (_timeBeforeOpening <= 0)
            {
                _stateMachine.ChangeState(new BuildingOperationalState(_stateMachine, _building));
            }
        }

        public void Exit()
        {
        }

        public void Render()
        {
            Console.SetCursorPosition((int)_building.GetPosition().GetX(), (int)_building.GetPosition().GetY());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{_building.GetRenderGraphic()}[X{_timeBeforeOpening:F1}X]");
            Console.ResetColor();
        }


    }
}
