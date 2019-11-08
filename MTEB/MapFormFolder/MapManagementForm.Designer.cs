namespace MTEB.MapFormFolder
{
    partial class MapManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxMapNames = new System.Windows.Forms.ListBox();
            this.buttonNewMap = new System.Windows.Forms.Button();
            this.buttonDeleteMap = new System.Windows.Forms.Button();
            this.buttonCloneMap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCloneMap);
            this.panel1.Controls.Add(this.buttonDeleteMap);
            this.panel1.Controls.Add(this.buttonNewMap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 45);
            this.panel1.TabIndex = 0;
            // 
            // listBoxMapNames
            // 
            this.listBoxMapNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMapNames.FormattingEnabled = true;
            this.listBoxMapNames.Location = new System.Drawing.Point(0, 0);
            this.listBoxMapNames.Name = "listBoxMapNames";
            this.listBoxMapNames.Size = new System.Drawing.Size(264, 317);
            this.listBoxMapNames.TabIndex = 1;
            this.listBoxMapNames.SelectedIndexChanged += new System.EventHandler(this.listBoxMapNames_SelectedIndexChanged);
            // 
            // buttonNewMap
            // 
            this.buttonNewMap.Location = new System.Drawing.Point(12, 6);
            this.buttonNewMap.Name = "buttonNewMap";
            this.buttonNewMap.Size = new System.Drawing.Size(75, 23);
            this.buttonNewMap.TabIndex = 0;
            this.buttonNewMap.Text = "NewMap";
            this.buttonNewMap.UseVisualStyleBackColor = true;
            this.buttonNewMap.Click += new System.EventHandler(this.buttonNewMap_Click);
            // 
            // buttonDeleteMap
            // 
            this.buttonDeleteMap.Location = new System.Drawing.Point(93, 6);
            this.buttonDeleteMap.Name = "buttonDeleteMap";
            this.buttonDeleteMap.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMap.TabIndex = 1;
            this.buttonDeleteMap.Text = "Delete Map";
            this.buttonDeleteMap.UseVisualStyleBackColor = true;
            this.buttonDeleteMap.Click += new System.EventHandler(this.buttonDeleteMap_Click);
            // 
            // buttonCloneMap
            // 
            this.buttonCloneMap.Location = new System.Drawing.Point(174, 6);
            this.buttonCloneMap.Name = "buttonCloneMap";
            this.buttonCloneMap.Size = new System.Drawing.Size(75, 23);
            this.buttonCloneMap.TabIndex = 2;
            this.buttonCloneMap.Text = "Clone Map";
            this.buttonCloneMap.UseVisualStyleBackColor = true;
            // 
            // MapManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 362);
            this.Controls.Add(this.listBoxMapNames);
            this.Controls.Add(this.panel1);
            this.Name = "MapManagementForm";
            this.Text = "MapManagementForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCloneMap;
        private System.Windows.Forms.Button buttonDeleteMap;
        private System.Windows.Forms.Button buttonNewMap;
        private System.Windows.Forms.ListBox listBoxMapNames;
    }
}