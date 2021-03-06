﻿namespace BombastEditor
{
    partial class BombastEditorForm
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
            Shutdown();
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
            this.newLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recentProjectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ContentTabControl = new System.Windows.Forms.TabControl();
            this.AssetsTabPage = new System.Windows.Forms.TabPage();
            this.AssetsTreeView = new System.Windows.Forms.TreeView();
            this.ActorsTabPage = new System.Windows.Forms.TabPage();
            this.ActorsTreeView = new System.Windows.Forms.TreeView();
            this.actorComponentsPanel = new System.Windows.Forms.Panel();
            this.EditorViewportPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ContentTabControl.SuspendLayout();
            this.AssetsTabPage.SuspendLayout();
            this.ActorsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLevelToolStripMenuItem,
            this.openLevelToolStripMenuItem,
            this.toolStripSeparator2,
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.toolStripSeparator3,
            this.recentProjectsMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newLevelToolStripMenuItem
            // 
            this.newLevelToolStripMenuItem.Name = "newLevelToolStripMenuItem";
            this.newLevelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newLevelToolStripMenuItem.Text = "New Level";
            this.newLevelToolStripMenuItem.Click += new System.EventHandler(this.NewLevelToolStripMenuItem_Click);
            // 
            // openLevelToolStripMenuItem
            // 
            this.openLevelToolStripMenuItem.Name = "openLevelToolStripMenuItem";
            this.openLevelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openLevelToolStripMenuItem.Text = "Open Level";
            this.openLevelToolStripMenuItem.Click += new System.EventHandler(this.OpenLevelToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.CloseProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // recentProjectsMenuItem
            // 
            this.recentProjectsMenuItem.Name = "recentProjectsMenuItem";
            this.recentProjectsMenuItem.Size = new System.Drawing.Size(155, 22);
            this.recentProjectsMenuItem.Text = "Recent Projects";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aboutToolStripMenuItem.Text = "About Bombast Editor";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer1.Location = new System.Drawing.Point(918, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitContainer1.Panel1.Controls.Add(this.ContentTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.actorComponentsPanel);
            this.splitContainer1.Size = new System.Drawing.Size(357, 651);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 2;
            // 
            // ContentTabControl
            // 
            this.ContentTabControl.Controls.Add(this.AssetsTabPage);
            this.ContentTabControl.Controls.Add(this.ActorsTabPage);
            this.ContentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTabControl.Location = new System.Drawing.Point(0, 0);
            this.ContentTabControl.Name = "ContentTabControl";
            this.ContentTabControl.SelectedIndex = 0;
            this.ContentTabControl.Size = new System.Drawing.Size(357, 382);
            this.ContentTabControl.TabIndex = 0;
            // 
            // AssetsTabPage
            // 
            this.AssetsTabPage.AccessibleName = "Assets Tree";
            this.AssetsTabPage.Controls.Add(this.AssetsTreeView);
            this.AssetsTabPage.Location = new System.Drawing.Point(4, 22);
            this.AssetsTabPage.Name = "AssetsTabPage";
            this.AssetsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AssetsTabPage.Size = new System.Drawing.Size(349, 356);
            this.AssetsTabPage.TabIndex = 0;
            this.AssetsTabPage.Text = "Assets Tree";
            this.AssetsTabPage.UseVisualStyleBackColor = true;
            // 
            // AssetsTreeView
            // 
            this.AssetsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssetsTreeView.Location = new System.Drawing.Point(3, 3);
            this.AssetsTreeView.Name = "AssetsTreeView";
            this.AssetsTreeView.Size = new System.Drawing.Size(343, 350);
            this.AssetsTreeView.TabIndex = 0;
            this.AssetsTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AssetsTreeView_MouseDoubleClick);
            // 
            // ActorsTabPage
            // 
            this.ActorsTabPage.Controls.Add(this.ActorsTreeView);
            this.ActorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ActorsTabPage.Name = "ActorsTabPage";
            this.ActorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ActorsTabPage.Size = new System.Drawing.Size(349, 356);
            this.ActorsTabPage.TabIndex = 1;
            this.ActorsTabPage.Text = "Actors";
            this.ActorsTabPage.UseVisualStyleBackColor = true;
            // 
            // ActorsTreeView
            // 
            this.ActorsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsTreeView.Location = new System.Drawing.Point(3, 3);
            this.ActorsTreeView.Name = "ActorsTreeView";
            this.ActorsTreeView.Size = new System.Drawing.Size(343, 350);
            this.ActorsTreeView.TabIndex = 0;
            this.ActorsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ActorsTreeView_AfterSelect);
            // 
            // actorComponentsPanel
            // 
            this.actorComponentsPanel.AutoScroll = true;
            this.actorComponentsPanel.AutoSize = true;
            this.actorComponentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorComponentsPanel.Location = new System.Drawing.Point(0, 0);
            this.actorComponentsPanel.Name = "actorComponentsPanel";
            this.actorComponentsPanel.Size = new System.Drawing.Size(357, 265);
            this.actorComponentsPanel.TabIndex = 0;
            // 
            // EditorViewportPanel
            // 
            this.EditorViewportPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditorViewportPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditorViewportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorViewportPanel.Location = new System.Drawing.Point(0, 24);
            this.EditorViewportPanel.Name = "EditorViewportPanel";
            this.EditorViewportPanel.Size = new System.Drawing.Size(918, 651);
            this.EditorViewportPanel.TabIndex = 0;
            // 
            // BombastEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 675);
            this.Controls.Add(this.EditorViewportPanel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BombastEditorForm";
            this.Text = "Bombast Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BombastEditorForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ContentTabControl.ResumeLayout(false);
            this.AssetsTabPage.ResumeLayout(false);
            this.ActorsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl ContentTabControl;
        private System.Windows.Forms.TabPage AssetsTabPage;
        private System.Windows.Forms.TabPage ActorsTabPage;
        private System.Windows.Forms.TreeView AssetsTreeView;
        private System.Windows.Forms.TreeView ActorsTreeView;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recentProjectsMenuItem;
        private System.Windows.Forms.Panel actorComponentsPanel;
        private System.Windows.Forms.Panel EditorViewportPanel;
    }
}