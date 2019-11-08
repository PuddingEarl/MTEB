using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MTEB.AssetFormFolder;
using MTEB.MappingClasses;
using MTEB.LayersFormFolder;
using MTEB.WindowsFormFolder;
using MTEB.TileEditFormFolder;
using MTEB.MapFormFolder;
using MTEB.ServerConnectionFormFolder;
using MTEB.NetworkClasses;

namespace MTEB
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public Campaign currentCampaign;
        public AssetLoadingForm assetForm;
        public LayersForm layersForm;
        public WindowsManagementForm windowsForm;
        public TileEditForm tileEditForm;
        public MapManagementForm mapSelectForm;
        public ServerConnectionForm connectionForm;
        public Texture2D paintTool;
        public System.Drawing.Image paintImage;
        public string selectedPaintName;
        public Map currentMap;
        public int currentPaintLayer;
        public int currentZLayer;
        MouseState currentMouseState;
        MouseState previousMouseState;
        KeyboardState currentKeyboardState;
        KeyboardState previousKeyboardState;

        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> connectionSockets = new List<Socket>();
        int port;
        int bufferSize = 2048;
        byte[] buffer = new byte[2048];
        public string name;
        public List<string> connectedPlayerNames = new List<string>();

        //IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
        //TcpListener listener;
        //TcpClient client;

        public bool isServer = false;
        public bool online = false;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this.Window.AllowUserResizing = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
            Map.game = this;
            Camera.game = this;
            Map.camera = new Camera();
            currentCampaign = new Campaign();
            currentMap = new Map(10, 10, "Default", 50);
            windowsForm = new WindowsManagementForm(this);
            windowsForm.Show();
            currentCampaign.currentMap = currentMap;
            currentCampaign.ownedMaps.Add(currentMap);
            ObjectProfile.game = this;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            previousMouseState = currentMouseState;
            currentMouseState = Mouse.GetState();
            previousKeyboardState = currentKeyboardState;
            currentKeyboardState = Keyboard.GetState();

            currentMap.updateMap(currentMouseState, previousMouseState);
            if(currentKeyboardState.IsKeyDown(Keys.Escape))
            {
                paintTool = null;
                selectedPaintName = null;
            }

            if(online == true)
            {
                if(isServer == true)
                {
                    //PUT SERVER CODE HERE
                }
                else
                {
                    //PUT CLIENT CODE HERE
                }
            }

            if(connectionForm != null)
            {
                connectionForm.updateList();
            }

            //This code is meant to detect double clicks. Fuck with it when it's relevant. 
            //It needs System.Windows.Forms added but that fucks with ButtonState for now.
            //Form form = (Form)Control.FromHandle(this.Window.Handle);
            //form.MouseDoubleClick += new MouseEventHandler(form_MouseDoubleClick);


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            currentMap.displayMap(spriteBatch);
            if(paintTool != null)
            {
                spriteBatch.Draw(paintTool, new Rectangle(GraphicsDevice.PresentationParameters.BackBufferWidth - 75, GraphicsDevice.PresentationParameters.BackBufferHeight - 75, 50, 50), Color.White);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void updateMapPaint(string name, System.Drawing.Image image)
        {
            Stream stram = File.OpenRead(name);
            paintTool = FromStream(GraphicsDevice, stram);
            stram.Close();
            selectedPaintName = name;
            paintImage = image;
        }

        public static Texture2D FromStream(GraphicsDevice graphicsDevice, Stream stream)
        {
            Texture2D texture = Texture2D.FromStream(graphicsDevice, stream);
            Color[] data = new Color[texture.Width * texture.Height];
            texture.GetData(data);
            for (int i = 0; i != data.Length; ++i)
                data[i] = Color.FromNonPremultiplied(data[i].ToVector4());
            texture.SetData(data);
            return texture;
        }

        //public void beginServer(int portValue)
        //{
        //    listener = new TcpListener(ip, portValue);
        //    try
        //    {
        //        listener.Start();
        //        online = true;
        //        isServer = true;
        //    } catch(Exception e)
        //    {

        //    }
        //}
        public void beginServer(int portValue, string name)
        {
            this.name = name;
            connectedPlayerNames.Add(name);
            connectionForm.updateQueued = true;
            port = portValue;
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
            serverSocket.Listen(0);
            serverSocket.BeginAccept(acceptCallback, null);
        }

        public void acceptCallback(IAsyncResult AR)
        {
            Socket socket;
            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch(ObjectDisposedException)
            {
                return;
            }

            connectionSockets.Add(socket);
            socket.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, receiveCallback, socket);
            serverSocket.BeginAccept(acceptCallback, null);
        }

        public void receiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int recieved;

            try
            {
                recieved = current.EndReceive(AR);
            }
            catch(SocketException)
            {
                current.Close();
                connectionSockets.Remove(current);
                return;
            }

            byte[] recBuffer = new byte[recieved];
            Array.Copy(buffer, recBuffer, recieved);
            string name = Encoding.ASCII.GetString(recBuffer);
            connectedPlayerNames.Add(name);

            if(System.Windows.Forms.Application.OpenForms.OfType<ServerConnectionForm>().Contains(connectionForm))
            {
                connectionForm.updateQueued = true;
            }

            serverSend(currentCampaign, current);


        }

        //public void connectServer(string address, int portValue)
        //{
        //    client = new TcpClient(address, portValue);
        //}

        public void connectServer(IPAddress address, int port, string name)
        {
            if(serverSocket.Connected == false)
            {
                //serverSocket.Connect(address, port);
                try
                {
                    serverSocket.Connect(address, port);
                }
                catch(SocketException)
                {

                }

                if(serverSocket.Connected == true)
                {
                    byte[] toBeSent = Encoding.ASCII.GetBytes(name);
                    serverSocket.Send(toBeSent, 0, toBeSent.Length, SocketFlags.None);

                    currentCampaign = receiveData<Campaign>(serverSocket);

                    //byte[] receiving = new byte[2048];
                    //int recieved = serverSocket.Receive(receiving, SocketFlags.None);
                    //if(recieved == 0)
                    //{
                    //    return;
                    //}
                }
            }
        }

        public void serverSend<T>(T objectToWrite, Socket socket)
        {
            string name = "sendingCampaign";
            using (Stream stream = File.Open(name, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
            socket.SendFile(name);
            File.Delete(name);
        }

        public T receiveData<T>(Socket socket)
        {
            var output = File.Create("receivingCampaign");
            byte[] buffer = new byte[1024];
            int bytesRead = socket.Receive(buffer);
            //output.Write(buffer, 0, bytesRead);
            while ((bytesRead = socket.Receive(buffer)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
            output = null;

            using (Stream stream = File.OpenRead("receivingCampaign"))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
            File.Delete("receivingCampaign");

         }

    }
}
