using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class Level : GameObject
    {
        private int _xSize = Console.WindowWidth;
        private int _ySize = Console.WindowHeight;

        public Level(GameEngine game_engine) : base(game_engine)
        {
            
        }

        public override void FixedUpdate(float elapsed_time)
        {
            throw new NotImplementedException();
        }

        public override void Update(float elapsed_time)
        {
            throw new NotImplementedException();
        }
    }
}
