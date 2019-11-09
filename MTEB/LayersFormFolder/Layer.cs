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

        // Convert most variables in classes to value property format, as shown below.
        // get and set can be configured to perform validation, calculations, call events, and throw errors.
        // Allows for far more effecient interactions between objects.

        public int Thing { get; set; }

        public Layer(int ID, int position, string name)
        {
            this.ID = ID;
            this.position = position;
            this.name = name;
        }
    }
}
