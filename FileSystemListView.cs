using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class FileSystemListView : GenericListViewEx<FileSystemInfo>
    {

        private static readonly List<(string ColumnName, Func<FileSystemInfo, object> ValueLookup, Func<FileSystemInfo, string> DisplayStringLookup)> columnMapping = [
            ("Name", f => f.Name, f => f.Name),
            ("Type", f => f switch {
                    DirectoryInfo dir => "Directory",
                    FileInfo file => "File",
                    _ => "Other"
            }, f => f switch {
                    DirectoryInfo dir => "Directory",
                    FileInfo file => "File",
                    _ => "Other"

            }),
            ("Size", f => f switch {
                    DirectoryInfo dir => 0,
                    FileInfo file => file.Length,
                    _ => 0
            }, f => f switch {
                    DirectoryInfo dir => string.Empty,
                    FileInfo file => file.Length.ToString(),
                    _ => string.Empty
            })
    ];

        public FileSystemListView() : base(columnMapping, GetImageKey)
        {
            InitializeComponent();
        }

        public static string GetImageKey(FileSystemInfo info) => info switch
        {
            DirectoryInfo => "directory_closed_cool.png",
            FileInfo => "file_lines.png",
            _ => throw new Exception("Not possible")
        };
    }
}
