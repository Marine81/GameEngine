using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Generator : Building
    {
        private float _production;
        private int _ressourceCount = 0;
        private string OutputCount = "G";
        
        public Generator(float production,GameEngine game_engine) : base(game_engine)
        {
            _production = production;
        }

        public override void FixedUpdate(float fixed_elapsed_time)
        {
            base.FixedUpdate(fixed_elapsed_time);

            if (_elapsedTime >= _production)
            {
                _ressourceCount++;
            }

            _elapsedTime -= _production;
        }

        public override void Render()
        {
            Console.SetCursorPosition((int)GetPosition().GetX(), (int)GetPosition().GetY());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"G[{_ressourceCount}]");
            Console.ResetColor();

        }
    }
}
