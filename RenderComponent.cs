using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class RenderComponent
    {
        private string _renderGraphic;
        
        public RenderComponent(GameObject _gameObject, string render_Graphic,PositionComponent position_component) 
        {
            _renderGraphic = render_Graphic;
        }
       
    }
}
