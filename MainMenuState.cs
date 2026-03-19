using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class MainMenuState : IState
    {
        StateMachine _stateMachine;
        GameEngine _gameEngine;
        public MainMenuState(StateMachine _stateMachine)
        {
            
        }

        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void FixedUpdate(float fixed_elapsed_time)
        {
            throw new NotImplementedException();
        }

        public void ProcessInput(ConsoleKeyInfo input)
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo player_command = Console.ReadKey(true);

                if (player_command.Key == ConsoleKey.Escape)
                {
                   // _shouldQuit = true;
                }
                else if (player_command.Key == ConsoleKey.Enter)
                {
                    _stateMachine.ChangeState(new IngameState(_stateMachine));
                }
            }
        }

        public void Render()
        {
            throw new NotImplementedException();
        }



        public void Update(float elapsed_time)
        {
            
        }
    }
}
