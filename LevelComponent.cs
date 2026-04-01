using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class LevelComponent : Component
    {
        
        private GameObject _levelGameObject = new GameObject("Level", game_engine);
        private LevelComponent level_component = new LevelComponent(_levelGameObject, game_engine);
        GameObject _levelGameObject.AddComponent(level_component); 
        public LevelComponent(GameObject game_object,GameEngine game_engine)
        {
            _levelGameObject = game_object;
        }

        private readonly GameEngine _gameEngine;
        private readonly Building _building;
        private readonly Generator _generator;
        private readonly Factory _factory;

        private readonly List<Enemy> _enemyTable = new List<Enemy>();

        private int _width = Console.WindowWidth;
        private int _height = Console.WindowHeight;
        private int _minHeight = 2;
        private readonly Random _random = new Random();

        private float _timer = 0f;
        private float _timeNextSpawn = 5f;
        private int _currentEnemyCount;
        private int _maxEnemyCount = 10;

        public Level(GameEngine game_engine) : base(game_engine)
        {
            _gameEngine = game_engine;

            _building = new Building(_gameEngine, _random.Next(5, 11));
            _building.SetPosition(new Vector2(10, 10));

            _generator = new Generator(10, _gameEngine);
            _generator.SetPosition(new Vector2(15, 15));

            _factory = new Factory(10, 2, 1, _gameEngine);
            _factory.SetPosition(new Vector2(50, 8));
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
            if (_enemyTable.Count < _maxEnemyCount)
            {
                _timer += fixed_elapsed_time;

                if (_timer >= _timeNextSpawn)
                {
                    _timer = 0;
                    Enemy enemy = new Enemy(_gameEngine, this);
                    enemy.SetPosition(new Vector2(_random.Next(0, _width), _height));
                    _timeNextSpawn = _random.Next(5, 11);
                    _enemyTable.Add(enemy);
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
        public float GetMinHeight()
        {
            return _minHeight;
        }



        public override void Update(float elapsed_time)
        {
        }


        public override void SetActive(bool is_active)
        {
            base.SetActive(is_active);

            foreach (Enemy enemy in _enemyTable)
            {
                enemy.SetActive(is_active);
            }

            _building.SetActive(is_active);
            _generator.SetActive(is_active);
            _factory.SetActive(is_active);
        }

    }
}
