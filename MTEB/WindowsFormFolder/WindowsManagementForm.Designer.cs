namespace MTEB.WindowsFormFolder
{
    partial class WindowsManagementForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCampaignAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAssetWindow = new System.Windows.Forms.Button();
            this.buttonLayersForm = new System.Windows.Forms.Button();
            this.buttonTileEdit = new System.Windows.Forms.Button();
            this.buttonMapSelect = new System.Windows.Forms.Button();
            this.buttonConnections = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCampaignToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveCampaignToolStripMenuItem,
            this.saveCampaignAsToolStripMenuItem,
            this.toolStripSeparator1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCampaignToolStripMenuItem
            // 
            this.newCampaignToolStripMenuItem.Name = "newCampaignToolStripMenuItem";
            this.newCampaignToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newCampaignToolStripMenuItem.Text = "New Campaign...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.openToolStripMenuItem.Text = "Open Campaign...";
            // 
            // saveCampaignToolStripMenuItem
            // 
            this.saveCampaignToolStripMenuItem.Name = "saveCampaignToolStripMenuItem";
            this.saveCampaignToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveCampaignToolStripMenuItem.Text = "Save Campaign";
            this.saveCampaignToolStripMenuItem.Click += new System.EventHandler(this.saveCampaignToolStripMenuItem_Click);
            // 
            // saveCampaignAsToolStripMenuItem
            // 
            this.saveCampaignAsToolStripMenuItem.Name = "saveCampaignAsToolStripMenuItem";
            this.saveCampaignAsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveCampaignAsToolStripMenuItem.Text = "Save Campaign As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // buttonAssetWindow
            // 
            this.buttonAssetWindow.Location = new System.Drawing.Point(12, 27);
            this.buttonAssetWindow.Name = "buttonAssetWindow";
            this.buttonAssetWindow.Size = new System.Drawing.Size(122, 23);
            this.buttonAssetWindow.TabIndex = 1;
            this.buttonAssetWindow.Text = "Asset Window";
            this.buttonAssetWindow.UseVisualStyleBackColor = true;
            this.buttonAssetWindow.Click += new System.EventHandler(this.buttonAssetWindow_Click);
            // 
            // buttonLayersForm
            // 
            this.buttonLayersForm.Location = new System.Drawing.Point(140, 27);
            this.buttonLayersForm.Name = "buttonLayersForm";
            this.buttonLayersForm.Size = new System.Drawing.Size(122, 23);
            this.buttonLayersForm.TabIndex = 2;
            this.buttonLayersForm.Text = "Layers Window";
            this.buttonLayersForm.UseVisualStyleBackColor = true;
            this.buttonLayersForm.Click += new System.EventHandler(this.buttonLayersForm_Click);
            // 
            // buttonTileEdit
            // 
            this.buttonTileEdit.Location = new System.Drawing.Point(268, 27);
            this.buttonTileEdit.Name = "buttonTileEdit";
            this.buttonTileEdit.Size = new System.Drawing.Size(122, 23);
            this.buttonTileEdit.TabIndex = 3;
            this.buttonTileEdit.Text = "Tile Edit Window";
            this.buttonTileEdit.UseVisualStyleBackColor = true;
            this.buttonTileEdit.Click += new System.EventHandler(this.buttonTileEdit_Click);
            // 
            // buttonMapSelect
            // 
            this.buttonMapSelect.Location = new System.Drawing.Point(12, 56);
            this.buttonMapSelect.Name = "buttonMapSelect";
            this.buttonMapSelect.Size = new System.Drawing.Size(122, 23);
            this.buttonMapSelect.TabIndex = 4;
            this.buttonMapSelect.Text = "Map Selection";
            this.buttonMapSelect.UseVisualStyleBackColor = true;
            this.buttonMapSelect.Click += new System.EventHandler(this.buttonMapSelect_Click);
            // 
            // buttonConnections
            // 
            this.buttonConnections.Location = new System.Drawing.Point(140, 56);
            this.buttonConnections.Name = "buttonConnections";
            this.buttonConnections.Size = new System.Drawing.Size(122, 23);
            this.buttonConnections.TabIndex = 5;
            this.buttonConnections.Text = "Connection Window";
            this.buttonConnections.UseVisualStyleBackColor = true;
            this.buttonConnections.Click += new System.EventHandler(this.buttonConnections_Click);
            // 
            // WindowsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 109);
            this.Controls.Add(this.buttonConnections);
            this.Controls.Add(this.buttonMapSelect);
            this.Controls.Add(this.buttonTileEdit);
            this.Controls.Add(this.buttonLayersForm);
            this.Controls.Add(this.buttonAssetWindow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WindowsManagementForm";
            this.Text = "WindowsManagementForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCampaignAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonAssetWindow;
        private System.Windows.Forms.Button buttonLayersForm;
        private System.Windows.Forms.Button buttonTileEdit;
        private System.Windows.Forms.Button buttonMapSelect;
        private System.Windows.Forms.Button buttonConnections;
    }
}