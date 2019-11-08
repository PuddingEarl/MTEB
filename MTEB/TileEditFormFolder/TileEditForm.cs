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

namespace MTEB.TileEditFormFolder
{
    public partial class TileEditForm : Form
    {
        public int selectedLayer;
        public Tile selectedTile;
        public int selectedZLayer;
        Game1 game;


        public TileEditForm(Game1 game)
        {
            InitializeComponent();
            this.game = game;
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            updateTable(game.currentMap.selectedTile, game.currentPaintLayer, game.currentZLayer);
        }

        private DataTable getObjectTable()
        {
            DataTable toBeReturned = new DataTable();
            toBeReturned.Columns.Add("TileImage", typeof(int));
            toBeReturned.Columns.Add("TileName", typeof(string));
            foreach(MappingClasses.Object givenObject in selectedTile.presentObjects)
            {
                if(givenObject.paintLayer == selectedLayer && givenObject.zLayer == selectedZLayer)
                {
                    toBeReturned.Rows.Add(givenObject.ID, givenObject.name);
                }
            }
            return toBeReturned;
        }

        private DataTable getTokenTable()
        {
            DataTable toBeReturned = new DataTable();
            toBeReturned.Columns.Add("TileImage", typeof(int));
            toBeReturned.Columns.Add("TileName", typeof(string));
            foreach (Token givenToken in selectedTile.presentObjects)
            {
                if(givenToken.zLayer == selectedZLayer)
                {
                    toBeReturned.Rows.Add(givenToken.ID, givenToken.name);
                }
            }
            return toBeReturned;
        }

        public void updateTable(Tile currentTile, int currentLayer, int currentZLayer)
        {
            if(currentTile != null)
            {
                selectedLayer = currentLayer;
                selectedTile = currentTile;
                selectedZLayer = currentZLayer;
                DataTable relevantTable;
                if (currentLayer == -1)
                {
                    relevantTable = getTokenTable();
                }
                else
                {
                    relevantTable = getObjectTable();
                }
                listBox1.DataSource = relevantTable;
                listBox1.DisplayMember = "TileName";
                listBox1.ValueMember = "TileImage";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(listBox1.Items.Count != 0)
            {
                DataRowView drOfListBox = (DataRowView)listBox1.Items[e.Index];
                e.DrawBackground();
                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
                g.DrawImage(ObjectProfile.profiles[(int)drOfListBox["TileImage"]].image, rec);
                Point p = new Point(e.Bounds.X + e.Bounds.Height + 2, e.Bounds.Y + 3);
                e.Graphics.DrawString(drOfListBox["TileName"].ToString(), e.Font, new SolidBrush(Color.Black), p);
            }
        }
    }
}
