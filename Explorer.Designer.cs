
using FileExplorer;

namespace WinFormsApp1
{
    partial class Explorer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            toolStrip1 = new ToolStrip();
            splitContainer1 = new SplitContainer();
            filesystemTreeView = new TreeView();
            smallFileSystemIcons = new ImageList(components);
            statusStrip2 = new StatusStrip();
            detailsLabel = new ToolStripStatusLabel();
            largeIconsLabel = new ToolStripStatusLabel();
            smallIconsLabel = new ToolStripStatusLabel();
            listLabel = new ToolStripStatusLabel();
            tilesLabel = new ToolStripStatusLabel();
            directoryListView = new FileSystemListView();
            largeFileSystemIcons = new ImageList(components);
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 583);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1059, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1059, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 49);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(filesystemTreeView);
            splitContainer1.Panel1.Padding = new Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(statusStrip2);
            splitContainer1.Panel2.Controls.Add(directoryListView);
            splitContainer1.Panel2.Padding = new Padding(4);
            splitContainer1.Size = new Size(1059, 534);
            splitContainer1.SplitterDistance = 353;
            splitContainer1.TabIndex = 3;
            // 
            // filesystemTreeView
            // 
            filesystemTreeView.Dock = DockStyle.Fill;
            filesystemTreeView.ImageIndex = 0;
            filesystemTreeView.ImageList = smallFileSystemIcons;
            filesystemTreeView.Location = new Point(4, 4);
            filesystemTreeView.Name = "filesystemTreeView";
            filesystemTreeView.SelectedImageIndex = 0;
            filesystemTreeView.Size = new Size(345, 526);
            filesystemTreeView.TabIndex = 0;
            // 
            // smallFileSystemIcons
            // 
            smallFileSystemIcons.ColorDepth = ColorDepth.Depth32Bit;
            smallFileSystemIcons.ImageStream = (ImageListStreamer)resources.GetObject("smallFileSystemIcons.ImageStream");
            smallFileSystemIcons.TransparentColor = Color.Transparent;
            smallFileSystemIcons.Images.SetKeyName(0, "directory_closed_cool.png");
            smallFileSystemIcons.Images.SetKeyName(1, "directory_open_cool.png");
            smallFileSystemIcons.Images.SetKeyName(2, "file_lines.png");
            smallFileSystemIcons.Images.SetKeyName(3, "network_drive.png");
            smallFileSystemIcons.Images.SetKeyName(4, "hard_disk_drive_cool.png");
            smallFileSystemIcons.Images.SetKeyName(5, "cd_drive_purple.png");
            smallFileSystemIcons.Images.SetKeyName(6, "help_question_mark.png");
            // 
            // statusStrip2
            // 
            statusStrip2.Items.AddRange(new ToolStripItem[] { detailsLabel, largeIconsLabel, smallIconsLabel, listLabel, tilesLabel });
            statusStrip2.Location = new Point(4, 508);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.RightToLeft = RightToLeft.Yes;
            statusStrip2.Size = new Size(694, 22);
            statusStrip2.SizingGrip = false;
            statusStrip2.TabIndex = 1;
            statusStrip2.Text = "statusStrip2";
            // 
            // detailsLabel
            // 
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(42, 17);
            detailsLabel.Text = "Details";
            detailsLabel.Click += detailsLabel_Click;
            // 
            // largeIconsLabel
            // 
            largeIconsLabel.Name = "largeIconsLabel";
            largeIconsLabel.Size = new Size(67, 17);
            largeIconsLabel.Text = "Large Icons";
            largeIconsLabel.Click += largeIconsLabel_Click;
            // 
            // smallIconsLabel
            // 
            smallIconsLabel.Name = "smallIconsLabel";
            smallIconsLabel.Size = new Size(67, 17);
            smallIconsLabel.Text = "Small Icons";
            smallIconsLabel.Click += smallIconsLabel_Click;
            // 
            // listLabel
            // 
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(25, 17);
            listLabel.Text = "List";
            listLabel.Click += listLabel_Click;
            // 
            // tilesLabel
            // 
            tilesLabel.Name = "tilesLabel";
            tilesLabel.Size = new Size(30, 17);
            tilesLabel.Text = "Tiles";
            tilesLabel.Click += tilesLabel_Click;
            // 
            // directoryListView
            // 
            directoryListView.Dock = DockStyle.Fill;
            directoryListView.LargeImageList = largeFileSystemIcons;
            directoryListView.Location = new Point(4, 4);
            directoryListView.MultiSelect = false;
            directoryListView.Name = "directoryListView";
            directoryListView.Size = new Size(694, 526);
            directoryListView.SmallImageList = smallFileSystemIcons;
            directoryListView.TabIndex = 0;
            directoryListView.UseCompatibleStateImageBehavior = false;
            directoryListView.View = View.Details;
            // 
            // largeFileSystemIcons
            // 
            largeFileSystemIcons.ColorDepth = ColorDepth.Depth32Bit;
            largeFileSystemIcons.ImageStream = (ImageListStreamer)resources.GetObject("largeFileSystemIcons.ImageStream");
            largeFileSystemIcons.TransparentColor = Color.Transparent;
            largeFileSystemIcons.Images.SetKeyName(0, "directory_closed_cool.png");
            largeFileSystemIcons.Images.SetKeyName(1, "directory_open_cool.png");
            largeFileSystemIcons.Images.SetKeyName(2, "file_lines.png");
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Size";
            // 
            // Explorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 605);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Explorer";
            Text = "Rudimentary File Explorer";
            Load += Explorer_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private TreeView filesystemTreeView;
        private ImageList smallFileSystemIcons;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private FileSystemListView directoryListView;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel detailsLabel;
        private ToolStripStatusLabel largeIconsLabel;
        private ToolStripStatusLabel smallIconsLabel;
        private ToolStripStatusLabel listLabel;
        private ToolStripStatusLabel tilesLabel;
        private ImageList largeFileSystemIcons;
    }
}
