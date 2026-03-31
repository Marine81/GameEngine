using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class PauseState : IState
    {
        private  StateMachine _stateMachine;
        private GameEngine _gameEngine;
        private GameManager _gameManager;
        public PauseState(GameManager game_manager,GameEngine game_engine,StateMachine state_machine) 
        {
            _gameEngine = game_engine;
            _gameManager = game_manager;
            _stateMachine = state_machine;
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
                _stateMachine.ChangeState(new IngameState(_gameEngine, _stateMachine, _gameManager));
            }
            else if (input.Key == ConsoleKey.Q)
            {
                _stateMachine.ChangeState(new MainMenuState(_gameEngine, _stateMachine));
            }
        }

        public void Render()
        {
            Console.WriteLine("Pause Menu");
            Console.WriteLine("Press Enter to resume the game");
            Console.WriteLine("Press Q to return to main menu");

        }

        public void Update(float elapsed_time)
        {
        }
    }
}
