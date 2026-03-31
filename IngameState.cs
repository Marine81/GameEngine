using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class IngameState : IState
    {
        private GameManager _gameManager;
        private StateMachine _stateMachine;
        private GameEngine _gameEngine;
        public IngameState(GameEngine game_engine,StateMachine state_machine, GameManager game_manager) 
        {
            _gameEngine = game_engine;
            _stateMachine = state_machine;
            _gameManager = game_manager;
        }
        public void Enter()
        {
            _gameManager.ActivateGameObjects();
        }

        public void Exit()
        {
            _gameManager.DeactivateGameObjects();
        }

        public void FixedUpdate(float fixed_elapsed_time)
        {
        }

        public void ProcessInput(ConsoleKeyInfo input)
        {
            if (input.Key == ConsoleKey.Escape)
            {
                _stateMachine.ChangeState(new PauseState(_gameManager, _gameEngine, _stateMachine));
            }

        }

        public void Render()
        {
            Console.WriteLine("Ingame State: Press Esc to pause");
        }

        public void Update(float elapsed_time)
        { }
        
    }
}
