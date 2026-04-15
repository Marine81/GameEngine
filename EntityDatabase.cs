using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_SaveynMarine
{
    public class EntityDatabase
    {
        private Dictionary<string,GameObject> _prototypeTable = new Dictionary<string,GameObject>();
        public void Register(string model_id, GameObject model_prototype)
        {
            _prototypeTable[model_id] = model_prototype;
        }

        public GameObject GetModelInstance(string model_id)
        {
            if (_prototypeTable.TryGetValue(model_id, out GameObject prototype))
            {
                return prototype.Clone();
            }

            else
            {
                Console.WriteLine("id invalid");
                return null;
            }
        }
    }
}
