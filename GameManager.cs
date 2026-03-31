using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class GameManager
    {
       
            private readonly Level _level;
            private readonly Player _player;

            public GameManager(GameEngine game_engine)
            {
                _level = new Level(game_engine);
                _player = new Player(game_engine, _level);
                _player.SetPosition(new Vector2(5, 5));
            }

            public void ActivateGameObjects()
            {
                _player.SetActive(true);
                _level.SetActive(true);
            }

            public void DeactivateGameObjects()
            {
                _player.SetActive(false);
                _level.SetActive(false);
            }
        }

    
}
