using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class GameEngine
    {
        Player _player = new Player();
        private bool _shouldQuit;
        private readonly Stopwatch _stopwatch = new Stopwatch();
        public void Run()
        {
            _stopwatch.Start();
            const float FIXED_FRAME_TIME = 20 / 1000.0f;
            float lag = 0.0f;
            float last_time = GetCurrentTime();

            while (!_shouldQuit)
            {
                float loop_start_time = GetCurrentTime();
                float elapsed_time = loop_start_time - last_time;

                lag += elapsed_time;

                ProcessInput();

                while (lag >= FIXED_FRAME_TIME)
                {
                    Update(FIXED_FRAME_TIME); // FIXED_FRAME_TIME doit être plus grand que le temps nécessaire à Update même sur les machines lentes
                    lag -= FIXED_FRAME_TIME;
                }

                Render();

                last_time = loop_start_time;
            }
        }

        private void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo player_command = Console.ReadKey(true);

                if (player_command.Key == ConsoleKey.LeftArrow)
                {
                    _player.SetDirection(new Vector2(-1, 0));
                }

                else if (player_command.Key == ConsoleKey.RightArrow)
                {
                    _player.SetDirection(new Vector2(1, 0));
                }

                else if (player_command.Key == ConsoleKey.UpArrow)
                {
                    _player.SetDirection(new Vector2(0, -1));
                }

                else if(player_command.Key == ConsoleKey.DownArrow)
                {
                    _player.SetDirection(new Vector2(0,1));
                }
                else if (player_command.Key == ConsoleKey.Escape)
                {
                    _shouldQuit = true;
                }
            }
        }
        

        private void Update(float elapsed_time)
        {

        }

        private void Render()
        {
           Console.Clear();
            _player.Render();

        }

        private float GetCurrentTime()
        {
            return _stopwatch.ElapsedMilliseconds / 1000.0f; // .0f EST IMPORTANT
        }
    }
}
