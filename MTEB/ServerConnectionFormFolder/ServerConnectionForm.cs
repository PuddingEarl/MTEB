using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace MTEB.ServerConnectionFormFolder
{
    public partial class ServerConnectionForm : Form
    {
        Game1 game;
        public bool updateQueued = false;

        public ServerConnectionForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void buttonHost_Click(object sender, EventArgs e)
        {
            int z;
            if(int.TryParse(textBoxPort.Text, out z))
            {
                game.beginServer(z, textBoxName.Text);
            }
        }

        public void updateList()
        {
            if(updateQueued == true)
            {
                listBoxPlayerNames.Items.Clear();
                foreach (string name in game.connectedPlayerNames)
                {
                    listBoxPlayerNames.Items.Add(name);
                }
                updateQueued = false;
            }
        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            IPAddress convertedAddress;
            int port;
            if(int.TryParse(textBoxPort.Text, out port) && IPAddress.TryParse(textBoxAddress.Text, out convertedAddress))
            {
                game.connectServer(convertedAddress, port, textBoxName.Text);
            }
        }
    }
}
