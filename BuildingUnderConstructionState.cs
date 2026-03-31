using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class BuildingUnderConstructionState : IState
    {
        private readonly StateMachine _stateMachine;
        private readonly int _constructionTime;
        private float _currentConstructionTime;
        private readonly Building _building;

        public BuildingUnderConstructionState(StateMachine state_machine, Building building, int construction_time)
        {
            _stateMachine = state_machine;
            _constructionTime = construction_time;
            _building = building;
        }
        public void Enter()
        {
        }

        public void ProcessInput(ConsoleKeyInfo input)
        {
        }

        public void Update(float elapsed_time)
        {
        }

        public void FixedUpdate(float fixed_elapsed_time)
        {
            _currentConstructionTime += fixed_elapsed_time;

            if (_currentConstructionTime >= _constructionTime)
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
            Console.Write($"{_building.GetRenderGraphic()}[%{_constructionTime - _currentConstructionTime:F1}%]");
            Console.ResetColor();
        }

    }
}
