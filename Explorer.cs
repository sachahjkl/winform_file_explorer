using FileExplorer;
using System;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Explorer : Form
    {

        public FileSystemInfo? SelectedEntry => filesystemTreeView.SelectedNode.Tag as FileSystemInfo;

        public List<FileSystemInfo> Entries = [];


        public Explorer()
        {
            //directoryListView = new GenericListViewEx<FileSystemInfo>(columnMapping)
            //{
            //    Dock = DockStyle.Fill,
            //    FullRowSelect = true,
            //    Location = new Point(0, 0),
            //    Name = "listView1",
            //    Size = new Size(702, 534),
            //    TabIndex = 0,
            //    UseCompatibleStateImageBehavior = false,
            //    View = View.Details
            //};
            InitializeComponent();
        }

        private void Explorer_Load(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives();

            filesystemTreeView.BeginUpdate();

            foreach (var drive in drives)
            {
                var driveImageKey = drive.DriveType switch
                {
                    DriveType.Network => "network_drive.png",
                    DriveType.Fixed => "hard_disk_drive_cool.png",
                    DriveType.Removable => "cd_drive_purple.png",
                    DriveType.Unknown => "help_question_mark.png",
                    _ => "help_question_mark.png"
                }; ;
                var node = new TreeNode(drive.Name) { Tag = drive, ImageKey = driveImageKey, SelectedImageKey = driveImageKey };
                DiscoverSubDirs(node, drive.RootDirectory);
                filesystemTreeView.Nodes.Add(node);
            }

            filesystemTreeView.EndUpdate();

            // Add event listeners 

            // Update icons and discover subdirectories when expanding a node 
            filesystemTreeView.BeforeExpand += (s, e) =>
            {
                if (e.Node == null)
                    return;

                filesystemTreeView.BeginUpdate();
                if (e.Node.Tag is DirectoryInfo)
                {
                    e.Node.ImageKey = "directory_open_cool.png";
                    e.Node.SelectedImageKey = "directory_open_cool.png";
                }

                if (e.Node.Tag is DriveInfo || e.Node.Tag is DirectoryInfo)
                    Expand(e.Node.Nodes);

                filesystemTreeView.EndUpdate();
            };

            //Update icons and remove uneeded nodes when collapsing the parent node
            filesystemTreeView.AfterCollapse += (s, e) =>
            {
                if (e.Node == null)
                    return;

                filesystemTreeView.BeginUpdate();

                if (e.Node.Tag is DirectoryInfo)
                {
                    e.Node.ImageKey = "directory_closed_cool.png";
                    e.Node.SelectedImageKey = "directory_closed_cool.png";

                }
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Nodes.Clear();
                }
                filesystemTreeView.EndUpdate();
            };

            // Update directory list view when an element in the tree view is selected
            filesystemTreeView.AfterSelect += (s, e) =>
            {
                if (e.Node == null)
                    return;

                Utils.Try(() =>
                {
                    Entries.Clear();
                    Entries.AddRange(e.Node.Tag switch
                    {
                        DirectoryInfo d => d.GetFileSystemInfos(),
                        DriveInfo drive => drive.RootDirectory.GetFileSystemInfos(),
                        _ => []
                    });
                }).Catch(e => Trace.Write(e));

                directoryListView.BeginUpdate();
                directoryListView.Items.Clear();
                //directoryListView.Items.AddRange(Entries.Select(e =>
                //    new ListViewItem(e.Name, e.GetImageKey())
                //    {
                //        Tag = e
                //    }
                //).ToArray());
                directoryListView.AddRange(Entries);
                directoryListView.EndUpdate();
            };

            // Open directory when an element in the list view is double clicked
            directoryListView.DoubleClick += (s, e) =>
            {
                if (directoryListView.SelectedItems.Count <= 0 ||
                directoryListView.SelectedItems[0] is not ListViewItem lvi)
                    return;

                if (lvi.Tag is not FileSystemInfo tag)
                    return;

                foreach (TreeNode node in filesystemTreeView.SelectedNode.Nodes)
                {
                    if (node.Tag.ToString() == tag.ToString())
                    {
                        filesystemTreeView.SelectedNode = node;
                        return;
                    }
                }

            };
        }

        public static void DiscoverSubDirs(TreeNode node, DirectoryInfo dir)
        {
            Utils.Try(() =>
            {
                var directoryNodes = dir.GetDirectories().Select(d => new TreeNode(d.Name)
                {
                    Tag = d,
                    ImageKey = "directory_closed_cool.png",
                    SelectedImageKey = "directory_closed_cool.png",
                })
                  .ToArray();
                node.Nodes.AddRange(directoryNodes);
            }).Catch((e) => Trace.Write(e));
        }

        public static void Expand(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag is not DirectoryInfo dir)
                    continue;
                DiscoverSubDirs(node, dir);
            }
        }

        private void detailsLabel_Click(object sender, EventArgs e)
        {
            directoryListView.View = View.Details;
        }

        private void largeIconsLabel_Click(object sender, EventArgs e)
        {
            directoryListView.View = View.LargeIcon;
        }

        private void smallIconsLabel_Click(object sender, EventArgs e)
        {
            directoryListView.View = View.SmallIcon;
        }

        private void listLabel_Click(object sender, EventArgs e)
        {
            directoryListView.View = View.List;
        }

        private void tilesLabel_Click(object sender, EventArgs e)
        {
            directoryListView.View = View.Tile;
        }
    }
}
