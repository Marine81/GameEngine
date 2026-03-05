using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Building : GameObject
    {
        private float _time;
        private string _renderGraphic = "B";
       

        public Building(GameEngine game_engine) : base(game_engine)
        {
        }

        public override void FixedUpdate(float elapsed_time)
        {
            Console.Write($"{_renderGraphic}[{_elapsedTime:F1}]");
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
