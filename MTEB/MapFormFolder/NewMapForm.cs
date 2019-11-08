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
    public partial class NewMapForm : Form
    {
        public Campaign campaign;
        Game1 game;

        public NewMapForm(Campaign campaign, Game1 game)
        {
            InitializeComponent();
            this.campaign = campaign;
            this.game = game;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            bool broken = false;
            foreach(Map map in campaign.ownedMaps)
            {
                if(map.name == textBoxMapName.Text)
                {
                    //HANDLE ERROR CODE HERE
                    broken = true;
                }
            }
            int a = 5;
            int b = 5;
            int c = 50;
            bool check2 = false;
            if(int.TryParse(textBoxXSize.Text, out a) && int.TryParse(textBoxYSize.Text, out b) && int.TryParse(textBoxTileSize.Text, out c))
            {
                check2 = true;
            }
            if(broken == false && check2 == true)
            {
                campaign.ownedMaps.Add(new Map(a, b, textBoxMapName.Text, c));
                game.mapSelectForm.updateList();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
