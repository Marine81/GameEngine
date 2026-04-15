using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public interface IPrototype<TYPE>
    {
        public TYPE clone();
    }
}
