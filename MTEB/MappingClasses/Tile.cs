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
    public class Tile
    {
        public int xValue;
        public int yValue;
        public int zValue;
        public List<Object> presentObjects = new List<Object>();
        public List<Token> presentTokens = new List<Token>();

        public bool checkMouse(Vector2 mousePosition, int size, Camera camera)
        {
            if ((xValue * size) + size - camera.area.X >= mousePosition.X && (xValue * size) - camera.area.X <= mousePosition.X &&
                (yValue * size) + size - camera.area.Y >= mousePosition.Y && (yValue * size) - camera.area.Y <= mousePosition.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
