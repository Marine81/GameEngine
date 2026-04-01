using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class GameManager
    {
        private GameObject _levelGameObject = new GameObject("Level", game_engine);
        private GameObject _playerGameObject = new GameObject("Player", game_engine);


        public GameManager(GameEngine game_engine)
        {
            LevelComponent level_component = new LevelComponent(_levelGameObject, game_engine);
            PositionComponent position_component = new PositionComponent(new Vector2(5, 5), _playerGameObject);
        }
        

            
        }

    
}
