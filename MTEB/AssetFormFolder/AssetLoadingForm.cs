using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTEB.AssetFormFolder
{
    public partial class AssetLoadingForm : Form
    {
        PictureBox selectedPictureBox = null;
        Game1 game;

        public AssetLoadingForm(Game1 game)
        {
            InitializeComponent();
            string[] availableAssets = Directory.GetFiles("Resources", "*.png");
            foreach(string name in availableAssets)
            {
                imageList1.Images.Add(Image.FromFile(name));
            }
            PictureBox pictureBox;
            int count = 0;
            foreach(Image image in imageList1.Images)
            {
                pictureBox = new PictureBox();
                pictureBox.Name = availableAssets[count];
                count += 1;
                pictureBox.Image = image;
                pictureBox.Margin = new Padding(6, 6, 6, 6);
                pictureBox.Width = 50;
                pictureBox.Height = 50;
                pictureBox.Parent = flowLayoutPanel1;
                pictureBox.Click += new EventHandler(pictureBoxClick);
            }
            this.game = game;
        }

        private void pictureBoxClick(object sender, System.EventArgs e)
        {
            selectedPictureBox = (PictureBox)sender;
            game.updateMapPaint(selectedPictureBox.Name, selectedPictureBox.Image);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
