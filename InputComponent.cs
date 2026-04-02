using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class InputComponent
    {
        public InputComponent(GameEngine game_engine) 
        {

        }
        public override void HandleInput(ConsoleKeyInfo player_command)
        {
            Vector2 new_direction = new Vector2(0, 0);

            if (player_command.Key == ConsoleKey.LeftArrow)
            {
                new_direction = new Vector2(-1, 0);
            }

            else if (player_command.Key == ConsoleKey.RightArrow)
            {
                new_direction = new Vector2(1, 0);
            }

            else if (player_command.Key == ConsoleKey.UpArrow)
            {
                new_direction = new Vector2(0, -1);
            }

            else if (player_command.Key == ConsoleKey.DownArrow)
            {
                new_direction = new Vector2(0, 1);
            }
            _direction = new_direction;
        }
        public void RegisterInputComponent()
        {

        }
    }
}
