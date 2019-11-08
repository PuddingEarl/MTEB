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
    public partial class ConfirmMapDeletionForm : Form
    {
        Campaign campaign;
        Map map;
        MapManagementForm form;

        public ConfirmMapDeletionForm(Campaign campaign, Map map, MapManagementForm form)
        {
            InitializeComponent();
            this.campaign = campaign;
            this.map = map;
            this.form = form;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if(campaign.ownedMaps.Count != 1)
            {
                if (campaign.currentMap == map)
                {
                    campaign.RandomizeMap();
                }
                campaign.ownedMaps.Remove(map);
                form.updateList();
            }
            Close();
        }

        private void ConfirmMapDeletionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
