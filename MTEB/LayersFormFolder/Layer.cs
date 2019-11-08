using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTEB.LayersFormFolder
{
    [Serializable]
    public class Layer
    {
        public int ID;
        public int position;
        public string name;

        public Layer(int ID, int position, string name)
        {
            this.ID = ID;
            this.position = position;
            this.name = name;
        }
    }
}
