using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    internal class Vector2
    {
        private float _x;
        private float _y;

        public Vector2 (float x, float y)
        {
            _x = x;
            _y = y;
        }
        public float GetX()
        {
            return _x;
        }

        public float SetX()
        {
            return _x;
        }

        public float GetY()
        {
            return _y;
        }

        public float SetY()
        {
            return _y;
        }
    }
}
