using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Level : GameObject
    {
        private GameEngine _gameEngine;
        private int _width = Console.WindowWidth;
        private int _height = Console.WindowHeight;

        private readonly Random _random = new Random();

        private float _timer = 0f;
        private float _timeNextSpawn = 5f;
        private int _currentEnemyCount;
        private int _maxEnemyCount = 10;

        public Level(GameEngine game_engine) : base(game_engine)
        {
            _gameEngine = game_engine;
       
            Building building = new Building(_gameEngine);
            building.SetPosition(new Vector2(10, 10));
            Generator generator = new Generator(10, _gameEngine);
            generator.SetPosition(new Vector2(15, 15));
            Factory factory = new Factory(10, 2, 1, _gameEngine);
            factory.SetPosition(new Vector2(50, 8));
        }

        public int GetXSize()
        {
            return _width;
        }
        public int GetYSize()
        {
            return _height;
        }

        public override void FixedUpdate(float fixed_elapsed_time)
        {
            if(_currentEnemyCount < _maxEnemyCount)
            {
                _timer += fixed_elapsed_time;

                if (_timer >= _timeNextSpawn)
                {
                    _timer = 0;
                    Enemy ennemy = new Enemy(_gameEngine, this);
                    ennemy.SetPosition(new Vector2(_random.Next(0, _width), _height));
                    _timeNextSpawn = _random.Next(5, 11);
                    _currentEnemyCount++;
                }
            }
        }
        public float GetWidth()
        {
            return _width;
        }

        public float GetHeight()
        {
            return _height;
        }

        public override void HandleInput(ConsoleKeyInfo player_command)
        {
            
        }

        public override void Update(float elapsed_time)
        {
            
        }

        public override void Render()
        {
           
        }
    }
}
