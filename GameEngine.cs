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
    public class GameEngine
    {
        private List<GameObject> _gameObjectTable = new List<GameObject>();

        private List<GameObject> _gameObjectToAddTable = new List<GameObject>();
        private List<GameObject> _gameObjectToRemoveTable = new List<GameObject>();

        private float _playerSpeed = 10;
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
                    Update(FIXED_FRAME_TIME); 
                    lag -= FIXED_FRAME_TIME;
                }

                Render();

                last_time = loop_start_time;
            }
        }

        public void AddGameObject(GameObject game_object)
        {
            _gameObjectToAddTable.Add(game_object);
        }

        public void RemoveGameObject(GameObject game_object)
        {
            _gameObjectToRemoveTable.Add(game_object);
        }

        private void UpdateGameObjectTable()
        {
            foreach (GameObject game_object in _gameObjectToAddTable)
            {
                _gameObjectTable.Add(game_object); //liste principale
            }

            foreach (GameObject game_object in _gameObjectToRemoveTable)
            {
                _gameObjectTable.Remove(game_object); // retire les obj de la liste principale
            }

            _gameObjectToAddTable.Clear();
            _gameObjectToRemoveTable.Clear();
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
        
        private void FixedUpdate(float fixed_elapsed_time)
        {
            /*Vector2 player_position = _player.GetPosition();
            Vector2 player_direction = _player.GetDirection();
            Vector2 new_position = new Vector2();
            // Calcul de la nouvelle position 
            new_position.SetX(player_position.GetX() + player_direction.GetX() * fixed_elapsed_time * _playerSpeed);
            new_position.SetY(player_position.GetY() + player_direction.GetY() * fixed_elapsed_time * _playerSpeed);
            _player.SetPosition(new_position); */
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
            return _stopwatch.ElapsedMilliseconds / 1000.0f; 
        }
    }
}
