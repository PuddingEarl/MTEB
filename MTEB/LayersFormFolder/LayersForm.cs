using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTEB.LayersFormFolder
{
    public partial class LayersForm : Form
    {
        Game1 game;
        AddLayerNameForm nameForm;

        public LayersForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;
            foreach(Layer layer in game.currentMap.layers)
            {
                listBox1.Items.Add(layer.name + "(" + layer.ID.ToString() + ")");
            }
        }

        private void LayersForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = listBox1.SelectedItem.ToString().Split('(')[1];
            temp = temp.Split(')')[0];
            foreach(Layer layer in game.currentMap.layers)
            {
                if (layer.ID == int.Parse(temp))
                {
                    game.currentPaintLayer = layer.ID;
                }
            }
        }

        public void refreshList()
        {
            listBox1.Items.Clear();
            foreach (Layer layer in game.currentMap.layers)
            {
                listBox1.Items.Add(layer.name + "(" + layer.ID.ToString() + ")");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            nameForm = new AddLayerNameForm(game.currentMap, this);
            nameForm.ShowDialog();
        }
    }
}
