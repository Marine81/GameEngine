using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class MainMenuState : IState
    {
        private StateMachine _stateMachine;
        private GameEngine _gameEngine;
        public MainMenuState(GameEngine game_engine,StateMachine state_Machine)
        {
            _gameEngine = game_engine;
            _stateMachine = state_Machine;
        }

        public void Enter()
        {
        }

        public void Exit()
        {
        }

        public void FixedUpdate(float fixed_elapsed_time)
        {
        }

        public void ProcessInput(ConsoleKeyInfo input)
        {
            if (input.Key == ConsoleKey.Enter)
            {
                _stateMachine.ChangeState(new IngameState(_gameEngine, _stateMachine, new GameManager(_gameEngine)));
            }
            else if (input.Key == ConsoleKey.Escape)
            {
                _gameEngine.Quit();
            }
        }

        public void Render()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Press Enter to start");
            Console.WriteLine("Press Esc to exit");
        }



        public void Update(float elapsed_time)
        {
        }
    }
}
