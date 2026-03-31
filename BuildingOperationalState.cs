using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class BuildingOperationalState : IState
    {
        private readonly StateMachine _stateMachine;
        private readonly Building _building;
        private float _openingDuration;
        private float _openingTime;

        public BuildingOperationalState(StateMachine state_machine, Building building)
        {
            _stateMachine = state_machine;
            _building = building;
        }

        public void Enter()
        {
            _openingDuration = 30;
        }

        public void ProcessInput(ConsoleKeyInfo input)
        {

        }

        public void Update(float elapsed_time)
        {

        }

        public void FixedUpdate(float fixed_elapsed_time)
        {
            _openingTime += fixed_elapsed_time;

            if (_openingTime >= _openingDuration)
            {
                _stateMachine.ChangeState(new BuildingClosedState(_stateMachine, _building));
            }
        }

        public void Exit()
        {

        }

        public void Render()
        {
            Console.SetCursorPosition((int)_building.GetPosition().GetX(), (int)_building.GetPosition().GetY());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{_building.GetRenderGraphic()}[{_openingTime:F1}]");
            Console.ResetColor();
        }

    }
}
