namespace MTEB.MapFormFolder
{
    partial class NewMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMapName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxXSize = new System.Windows.Forms.TextBox();
            this.textBoxYSize = new System.Windows.Forms.TextBox();
            this.labelTileSize = new System.Windows.Forms.Label();
            this.textBoxTileSize = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMapName
            // 
            this.textBoxMapName.Location = new System.Drawing.Point(73, 12);
            this.textBoxMapName.Name = "textBoxMapName";
            this.textBoxMapName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMapName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(12, 41);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(55, 13);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Size (X/Y)";
            // 
            // textBoxXSize
            // 
            this.textBoxXSize.Location = new System.Drawing.Point(73, 38);
            this.textBoxXSize.Name = "textBoxXSize";
            this.textBoxXSize.Size = new System.Drawing.Size(47, 20);
            this.textBoxXSize.TabIndex = 3;
            this.textBoxXSize.Text = "10";
            // 
            // textBoxYSize
            // 
            this.textBoxYSize.Location = new System.Drawing.Point(126, 38);
            this.textBoxYSize.Name = "textBoxYSize";
            this.textBoxYSize.Size = new System.Drawing.Size(47, 20);
            this.textBoxYSize.TabIndex = 5;
            this.textBoxYSize.Text = "10";
            // 
            // labelTileSize
            // 
            this.labelTileSize.AutoSize = true;
            this.labelTileSize.Location = new System.Drawing.Point(12, 67);
            this.labelTileSize.Name = "labelTileSize";
            this.labelTileSize.Size = new System.Drawing.Size(47, 13);
            this.labelTileSize.TabIndex = 6;
            this.labelTileSize.Text = "Tile Size";
            // 
            // textBoxTileSize
            // 
            this.textBoxTileSize.Location = new System.Drawing.Point(73, 64);
            this.textBoxTileSize.Name = "textBoxTileSize";
            this.textBoxTileSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxTileSize.TabIndex = 7;
            this.textBoxTileSize.Text = "50";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(12, 90);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Create Map";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 120);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxTileSize);
            this.Controls.Add(this.labelTileSize);
            this.Controls.Add(this.textBoxYSize);
            this.Controls.Add(this.textBoxXSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxMapName);
            this.Name = "NewMapForm";
            this.Text = "NewMapForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMapName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox textBoxXSize;
        private System.Windows.Forms.TextBox textBoxYSize;
        private System.Windows.Forms.Label labelTileSize;
        private System.Windows.Forms.TextBox textBoxTileSize;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button button2;
    }
}