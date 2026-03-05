using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Level : GameObject
    {
        private int _xSize = Console.WindowWidth;
        private int _ySize = Console.WindowHeight;

        private float _timer = 0f;
        private float _timeNextSpawn = 5f;

        public Level(GameEngine game_engine) : base(game_engine)
        {
            for (int enemy_index = 0; enemy_index < 5; enemy_index++)
            {
                new Enemy(game_engine, this);
            }

            Building building = new Building(game_engine);
            building.SetPosition(new Vector2(10, 10));
            Generator generator = new Generator(10, game_engine);
            generator.SetPosition(new Vector2(15, 15));
            Factory factory = new Factory(10, 2, 1, game_engine);
            factory.SetPosition(new Vector2(50, 8));
        }

        public int GetXSize()
        {
            return _xSize;
        }
        public int GetYSize()
        {
            return _ySize;
        }

        public override void FixedUpdate(float elapsed_time)
        {
            _timer += elapsed_time;

            if(_timer >= _timeNextSpawn)
            {
                new Enemy(game_engine, this);
                _timer = 0f;
                Random random = new Random();
                _timeNextSpawn = (float)(random.NextDouble()*5.0+5.0);
            }
        }

        public override void HandleInput(ConsoleKeyInfo player_command)
        {
            throw new NotImplementedException();
        }

        public override void Update(float elapsed_time)
        {
            throw new NotImplementedException();
        }
    }
}
