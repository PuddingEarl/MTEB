using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MTEB.MappingClasses
{
    public class ObjectProfile
    {
        static public List<ObjectProfile> profiles = new List<ObjectProfile>();
        public int ID;
        public Texture2D texture;
        public string name = "";
        public Image image;
        static public Game1 game;

        static public Object checkProfiles(Texture2D checkedObject)
        {
            Object toBeReturned;
            foreach(ObjectProfile profile in profiles)
            {
                if(profile.texture == checkedObject)
                {
                    toBeReturned = new Object(profile);
                    return toBeReturned;
                }
            }
            ObjectProfile toBeAdded = new ObjectProfile();
            toBeAdded.ID = profiles.Count;
            toBeAdded.texture = checkedObject;
            toBeAdded.image = game.paintImage;
            toBeAdded.name = game.selectedPaintName;
            profiles.Add(toBeAdded);
            toBeReturned = new Object(toBeAdded);
            return toBeReturned;
        
        }

        static public Token checkProfilesToken(Texture2D checkedObject)
        {
            Token toBeReturned;
            foreach (ObjectProfile profile in profiles)
            {
                if (profile.texture == checkedObject)
                {
                    toBeReturned = new Token(profile);
                    return toBeReturned;
                }
            }
            ObjectProfile toBeAdded = new ObjectProfile();
            toBeAdded.ID = profiles.Count;
            toBeAdded.texture = checkedObject;
            profiles.Add(toBeAdded);
            toBeReturned = new Token(toBeAdded);
            return toBeReturned;

        }
    }
}
