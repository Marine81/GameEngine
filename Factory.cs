using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class Factory : Building
    {
      
        private string _renderGraphic = "F";
        private float _conversion;
        private int _requiredRessources;
        private int _producedRessources;

        private int _stockRessources = 100;
        private int _stockProduct = 0;


        public Factory(float conversion, int required_ressources, int produced_ressources, GameEngine game_engine) : base(game_engine)
        {
            _conversion = conversion;
            _requiredRessources = required_ressources;
            _producedRessources = produced_ressources;
        }

        public override void FixedUpdate(float elapsed_time)
        {
            base.FixedUpdate(elapsed_time);

            if(_elapsedTime >= _conversion)
            {
                if(_stockRessources >= _requiredRessources)
                {
                    _stockRessources -= _requiredRessources; //consomation ressources
                    _stockProduct += _producedRessources; // creation produis fini
                }
                _elapsedTime -= _conversion;
            }
        }

        public override void Render()
        {
            Console.SetCursorPosition((int)GetPosition().GetX(), (int)GetPosition().GetY());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"F[{_stockRessources} ->{_stockProduct}]");
            Console.ResetColor();

        }
    }
    
}
