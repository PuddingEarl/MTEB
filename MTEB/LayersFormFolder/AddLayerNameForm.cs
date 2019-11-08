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

namespace MTEB.LayersFormFolder
{
    public partial class AddLayerNameForm : Form
    {
        public Map map;
        public LayersForm parent;

        public AddLayerNameForm(Map map, LayersForm parent)
        {
            InitializeComponent();
            this.map = map;
            this.parent = parent;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxLayerName.Text.Contains('(') == false && textBoxLayerName.Text.Contains(')') == false)
            {
                map.layers.Add(new Layer(map.layers.Count - 1, map.layers.Count - 1, textBoxLayerName.Text));
                parent.refreshList();
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
