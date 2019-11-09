using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MTEB.LayersFormFolder;

namespace MTEB.MappingClasses
{
    [Serializable]
    public class Map
    {
        static public int IDCount = 0;
        public string name;
        public int internalID;
        // A list of a list of tiles? I assume this represents the tiles on the map.
        // Not really neccessary when the Tile class already has an X and Y value, which I assume represents its location on the map also
        public List<List<Tile>> XAxis = new List<List<Tile>>();
        public static Camera camera;
        public int[] cameraLocation = new int[2] { 0, 0 };
        public int tileSize;
        static public Game1 game;
        public List<Layer> layers = new List<Layer>();
        public Object selectedObject;
        public Tile targetTile;
        public Tile originTile;
        public Tile selectedTile;

        public Map(int x, int y, string name, int tileSize)
        {
            internalID = IDCount;
            IDCount += 1;
            this.tileSize = tileSize;
            int listCount1 = 0;
            int listCount2 = 0;
            while(listCount1 != x)
            {
                List<Tile> tempList = new List<Tile>();
                listCount2 = 0;
                while (listCount2 != y)
                {
                    Tile tempTile = new Tile();
                    tempTile.xValue = listCount1;
                    tempTile.yValue = listCount2;
                    tempList.Add(tempTile);
                    listCount2 += 1;
                }
                XAxis.Add(tempList);
                listCount1 += 1;
            }
            this.name = name;
            layers.Add(new Layer(-1, -1, "Token Layer"));
            layers.Add(new Layer(0, 0, "Base Layer")); 
        }

        public void updateMap(MouseState currentMouse, MouseState pastMouse)
        {
            if(currentMouse.LeftButton == ButtonState.Pressed && pastMouse.LeftButton == ButtonState.Released)
            {
                foreach(List<Tile> givenList in XAxis) // a double foreach, oh boy we gonna learn events.
                {
                    foreach(Tile tile in givenList)
                    {
                        if(tile.checkMouse(currentMouse.Position.ToVector2(), tileSize, camera))
                        {
                            if (game.paintTool != null)
                            {
                                if (game.currentPaintLayer != -1)
                                {
                                    Object toBeAdded = ObjectProfile.checkProfiles(game.paintTool);
                                    toBeAdded.paintLayer = game.currentPaintLayer;
                                    toBeAdded.zLayer = game.currentZLayer;
                                    tile.presentObjects.Add(toBeAdded);
                                }
                                else
                                {
                                    Token toBeAdded = ObjectProfile.checkProfilesToken(game.paintTool);
                                    toBeAdded.paintLayer = -1;
                                    toBeAdded.zLayer = game.currentZLayer;
                                    tile.presentTokens.Add(toBeAdded);
                                }
                            }
                            else if(game.currentPaintLayer == -1)
                            {
                                if(tile.presentTokens.Count > 0)
                                {
                                     selectedObject = tile.presentTokens.Last();
                                    originTile = tile;
                                }
                            }
                            else
                            {
                                selectedTile = tile;
                                if(game.tileEditForm != null)
                                {
                                    game.tileEditForm.updateTable(selectedTile, game.currentPaintLayer, game.currentZLayer);
                                }
                            }
                        }
                    }
                }
            }
            else if(currentMouse.LeftButton == ButtonState.Pressed && pastMouse.LeftButton == ButtonState.Pressed && selectedObject != null)
            {
                foreach (List<Tile> givenList in XAxis)
                {
                    foreach (Tile tile in givenList)
                    {
                        if (tile.checkMouse(currentMouse.Position.ToVector2(), tileSize, camera))
                        {
                            targetTile = tile;
                        }
                    }
                }
            }
            else if(currentMouse.LeftButton == ButtonState.Released && pastMouse.LeftButton == ButtonState.Pressed && selectedObject != null)
            {
                if(targetTile != originTile)
                {
                    if(originTile.presentObjects.Contains(selectedObject))
                    {
                        targetTile.presentObjects.Add(selectedObject);
                        originTile.presentObjects.Remove(selectedObject);
                    }
                    else if(originTile.presentTokens.Contains(selectedObject))
                    {
                        targetTile.presentTokens.Add((Token)selectedObject);
                        originTile.presentTokens.Remove((Token)selectedObject);
                    }
                }
                selectedObject = null;
                targetTile = null;
                originTile = null;
            }
            else if(currentMouse.RightButton == ButtonState.Pressed)
            {
                camera.area.X -= currentMouse.Position.X - pastMouse.Position.X;
                camera.area.Y -= currentMouse.Position.Y - pastMouse.Position.Y;
            }
        }

        public void displayMap(SpriteBatch spriteBatch)
        {
            foreach(List<Tile> list in XAxis)
            {
                foreach(Tile tile in list)
                {
                    if ((tile.xValue * tileSize) + tileSize >= camera.area.X && (tile.xValue * tileSize) <= camera.area.X + camera.area.Width &&
                    (tile.yValue * tileSize) + tileSize >= camera.area.Y && (tile.yValue * tileSize) <= camera.area.Y + camera.area.Height)
                    {
                        foreach(Object displayedObject in tile.presentObjects)
                        {
                            spriteBatch.Draw(ObjectProfile.profiles[displayedObject.ID].texture, new Rectangle(tile.xValue - camera.area.X+ (tile.xValue * tileSize), tile.yValue - camera.area.Y+ (tile.yValue * tileSize), tileSize, tileSize), Color.White);
                        }
                        foreach (Token displayedToken in tile.presentTokens)
                        {
                            spriteBatch.Draw(ObjectProfile.profiles[displayedToken.ID].texture, new Rectangle(tile.xValue - camera.area.X + (tile.xValue * tileSize), tile.yValue - camera.area.Y + (tile.yValue * tileSize), tileSize, tileSize), Color.White);
                        }
                    }
                }
            }
        }
    }
}
