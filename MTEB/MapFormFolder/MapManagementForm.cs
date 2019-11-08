using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTEB.MappingClasses;

namespace MTEB.MapFormFolder
{
    public partial class MapManagementForm : Form
    {
        Game1 game;
        public MapManagementForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;
            listBoxMapNames.Items.Clear();
            foreach(Map map in game.currentCampaign.ownedMaps)
            {
                listBoxMapNames.Items.Add(map.name);
            }
        }

        public void updateList()
        {
            listBoxMapNames.Items.Clear();
            foreach (Map map in game.currentCampaign.ownedMaps)
            {
                listBoxMapNames.Items.Add(map.name);
            }
        }

        private void listBoxMapNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Map map in game.currentCampaign.ownedMaps)
            {
                if(listBoxMapNames.SelectedItem.ToString() == map.name)
                {
                    game.currentMap.cameraLocation = new int[2]{ Map.camera.area.X, Map.camera.area.Y};
                    game.currentCampaign.currentMap = map;
                    game.currentMap = map;
                    Map.camera.area.X = game.currentMap.cameraLocation[0];
                    Map.camera.area.Y = game.currentMap.cameraLocation[1];
                }
            }
        }

        private void buttonNewMap_Click(object sender, EventArgs e)
        {
            NewMapForm mapForm = new NewMapForm(game.currentCampaign, game);
            mapForm.ShowDialog();
        }

        private void buttonDeleteMap_Click(object sender, EventArgs e)
        {
            ConfirmMapDeletionForm deleteForm = new ConfirmMapDeletionForm(game.currentCampaign, game.currentMap, this);
            deleteForm.ShowDialog();
        }
    }
}
