using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTEB.MappingClasses
{
    [Serializable]
    public class Campaign
    {
        public Map currentMap;
        public List<Map> ownedMaps = new List<Map>();
        public List<TransferableObjectProfile> profiles = new List<TransferableObjectProfile>();

        public void RandomizeMap()
        {
            Random rand = new Random();
            if(ownedMaps.Count != 1)
            {
                Map tempMap = currentMap;
                while(tempMap != currentMap)
                {
                    tempMap = ownedMaps[rand.Next(0, ownedMaps.Count - 1)];
                }
            }
        }

    }
}
