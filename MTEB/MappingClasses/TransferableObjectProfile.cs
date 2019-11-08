using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTEB.MappingClasses
{
    [Serializable]
    public class TransferableObjectProfile
    {
        public int ID;
        public byte[] texture;
        public string name = "";
        public Image image;

        static public TransferableObjectProfile compressProfile(ObjectProfile givenProfile)
        {
            TransferableObjectProfile profile = new TransferableObjectProfile();

            profile.ID = givenProfile.ID;
            profile.name = givenProfile.name;
            profile.image = givenProfile.image;
            givenProfile.texture.GetData(profile.texture);

            return profile;
        }

        public ObjectProfile expandProfile()
        {
            ObjectProfile profile = new ObjectProfile();
            profile.name = name;
            profile.ID = ID;
            profile.image = image;
            profile.texture.SetData(texture);
            return profile;
        }

    }
}
