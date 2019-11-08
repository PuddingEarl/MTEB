using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTEB.AssetFormFolder;
using MTEB.LayersFormFolder;
using MTEB.TileEditFormFolder;
using MTEB.MapFormFolder;
using MTEB.ServerConnectionFormFolder;

namespace MTEB.WindowsFormFolder
{
    public partial class WindowsManagementForm : Form
    {
        Game1 game;

        public WindowsManagementForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void saveCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonAssetWindow_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<AssetLoadingForm>().Contains(game.assetForm) == false)
            {
                game.assetForm = new AssetLoadingForm(game);
                game.assetForm.Show();
            }
        }

        private void buttonLayersForm_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LayersForm>().Contains(game.layersForm) == false)
            {
                game.layersForm = new LayersForm(game);
                game.layersForm.Show();
            }
        }

        private void buttonTileEdit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TileEditForm>().Contains(game.tileEditForm) == false)
            {
                game.tileEditForm = new TileEditForm(game);
                game.tileEditForm.Show();
            }
        }

        private void buttonMapSelect_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MapManagementForm>().Contains(game.mapSelectForm) == false)
            {
                game.mapSelectForm = new MapManagementForm(game);
                game.mapSelectForm.Show();
            }
        }

        private void buttonConnections_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ServerConnectionForm>().Contains(game.connectionForm) == false)
            {
                game.connectionForm = new ServerConnectionForm(game);
                game.connectionForm.Show();
            }
        }
    }
}
