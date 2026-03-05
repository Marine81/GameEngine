using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Building : GameObject
    {
        protected float _elapsedTime;
        private string _renderGraphic = "B";
       

        public Building(GameEngine game_engine) : base(game_engine)
        {
        }

        public override void FixedUpdate(float elapsed_time)
        {
            
        }

        public override void HandleInput(ConsoleKeyInfo player_command)
        {
            
        }

        public override void Update(float elapsed_time)
        {
            
        }

        public override void Render()
        {
            Console.SetCursorPosition((int)GetPosition().GetX(), (int)GetPosition().GetY());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{_renderGraphic}[{_elapsedTime:F1}]");
            Console.ResetColor();
        
        }
    }
}
