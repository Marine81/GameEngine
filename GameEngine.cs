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

        private static readonly float FIXED_FRAME_TIME = 1.0f / 60.0f;
      
        private bool _shouldQuit = false;
        private readonly Stopwatch _stopwatch = new Stopwatch();

        public GameEngine()
        {
            Level currentLevel = new Level(this);
            new Player(this, currentLevel);
        }
        public void Run()
        {
            _stopwatch.Start();
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
                Update(elapsed_time);//realtime boucle
                Render();

                last_time = loop_start_time;
            }
            Console.WriteLine("Goodbye!");
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
           
        }
        
        private void FixedUpdate(float fixed_elapsed_time)
        {
          
        }

        
        private void Update(float elapsed_time)
        {

        }

        private void Render()
        {
           Console.Clear();
           //_player.Render();
            Thread.Sleep(10);

        }

        private float GetCurrentTime()
        {
            return _stopwatch.ElapsedMilliseconds / 1000.0f; 
        }
    }
}
