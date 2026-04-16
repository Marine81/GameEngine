using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class GameManager : IPrototype<TYPE>
    {
        private EntityDatabase _entityDatabase;
        //_playerGameObject.AddComponent(new RenderComponent(_playerGameObject, "@", position_component));

        public GameManager(GameEngine game_engine)
        {
            _entityDatabase = new EntityDatabase();

            LevelComponent level_component = new LevelComponent(_levelGameObject, game_engine);
            PositionComponent position_component = new PositionComponent(new Vector2(5, 5), _playerGameObject);

            GameObject _levelGameObject = new GameObject("Level", game_engine);
             GameObject _playerGameObject = new GameObject("Player", game_engine);
            GameObject _enemy = new GameObject("enemy", game_engine);
            GameObject _building = new GameObject("building", game_engine);
            GameObject _factory = new GameObject("factory", game_engine);
            GameObject _generatot = new GameObject("generator", game_engine);
    }

        public TYPE clone()
        {
            
        }
    }

    
}
