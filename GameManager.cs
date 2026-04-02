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
        private GameObject _enemy = new GameObject("enemy", game_engine);
        private GameObject _building = new GameObject("building", game_engine);
        private GameObject _factory = new GameObject("factory", game_engine);
        private GameObject _generatot = new GameObject("generator", game_engine);
        //_playerGameObject.AddComponent(new RenderComponent(_playerGameObject, "@", position_component));

        public GameManager(GameEngine game_engine)
        {
            LevelComponent level_component = new LevelComponent(_levelGameObject, game_engine);
            PositionComponent position_component = new PositionComponent(new Vector2(5, 5), _playerGameObject);
        }
        

            
    }

    
}
