using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Generator : GameObject
    {
        private float _production;
        private int _ressourceCount = 0;
        private string _renderGraphic = "G";
        private Vector2 _position = new Vector2(0, 0);
        private float _elapsedTime;


        public Generator(float production,GameEngine game_engine) : base(game_engine)
        {
            _production = production;
        }

        public void SetPosition(Vector2 position)
        {
            _position = position;
        }
        public override void Update(float elapsed_time)
        {

        }
        public override void HandleInput(ConsoleKeyInfo player_command)
        {

        }

        public override void FixedUpdate(float fixed_elapsed_time)
        {
            _elapsedTime += fixed_elapsed_time;

            if (_elapsedTime >= _production)
            {
                _ressourceCount++;
                _elapsedTime = 0;
            }
        }

        public override void Render()
        {
            Console.SetCursorPosition((int)_position.GetX(), (int)_position.GetY());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"G[{_renderGraphic}]");
            Console.ResetColor();
        }
    }
}
