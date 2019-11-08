using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MTEB.MappingClasses
{
    [Serializable]
    public class Object
    {
        public int ID;
        public int zLayer;
        public int priority;
        public int paintLayer;
        public string name;

        public Object(ObjectProfile profile)
        {
            ID = profile.ID;
            name = profile.name;
        }

    }
}
