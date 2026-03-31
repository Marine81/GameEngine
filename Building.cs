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
        private Vector2 _position = new Vector2(0, 0);

        private readonly StateMachine _stateMachine = new StateMachine();
        public Building(GameEngine game_engine, int construction_time) : base(game_engine)
        {
            _stateMachine.SetInitialState(new BuildingUnderConstructionState(_stateMachine, this, construction_time));
        }
        public string GetRenderGraphic()
        {
            return _renderGraphic;
        }
        public Vector2 GetPosition()
        {
            return _position;
        }

        public void SetPosition(Vector2 position)
        {
            _position = position;
        }

        public override void FixedUpdate(float fixed_elapsed_time)
        {
            _stateMachine.FixedUpdate(fixed_elapsed_time);
        }

        public override void HandleInput(ConsoleKeyInfo player_command)
        {
            
        }

        public override void Update(float elapsed_time)
        {
            _stateMachine.Update(elapsed_time);
        }

        public override void Render()
        {
            _stateMachine.Render();
        }
    }
}
