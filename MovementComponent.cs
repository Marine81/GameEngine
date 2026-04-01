using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class MovementComponent
    {
        private PositionComponent _positionComponent = new PositionComponent();
        public MovementComponent(PositionComponent position_component) 
        {
            _positionComponent = position_component;
        }
    }
}
