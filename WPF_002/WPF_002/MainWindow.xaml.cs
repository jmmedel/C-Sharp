using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace WPF_002
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Contructor
        /// <summary>
        /// Default Contructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            
        }
        #endregion
        #region Loaded
        /// <summary>
        /// when the apllication first open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {      
            // Get Every logical drive on the machine
            // Directory is on system.io
             foreach (var drive in Directory.GetLogicalDrives())
            {
                // create a new item for it

                var item = new TreeViewItem()
                {
                    // Set the header
                    Header = drive,
                    // and the full path
                    Tag = drive
                };
               
                // is the name of FolderView carefull to remember the folder
                item.Items.Add(null);
                // listen out for item being expanded
                item.Expanded += Folder_Expanded;
                // Add it to the main tree-view !!!!!!
                FolderView.Items.Add(item);
            }
        }
        #endregion


        #region FolderExpanded
        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            #region Initial Check

           
            // sender get the sender
            var item = (TreeViewItem)sender;
            // if the item only contains the dummy data

            if (item.Items.Count != 1 && item.Items[0] != null)
                return;
            // Clear dummy data
            item.Items.Clear();

            var fullPath = (string)item.Tag;
            // Create a Black list for directories
            // Try abd get Directories from the folder
            # endregion 

            #region Get Folder

            // Create a black lisr for files
            var files = new List<string>();
            // try and get files from the folder
            // ignoring any issue doing so
            try
            {
                var fs = Directory.GetFiles(fullPath);

                if (fs.Length > 0)
                    files.AddRange(fs);

            }
            catch { } // create a catch here

          // for each file ....

            files.ForEach(filePath => 
            {   // create file item
                var Subitem = new TreeViewItem()
                {   // Set header as file name
                    Header = GetFileFolderName(filePath),
                    // and tag as full path
                    Tag = filePath
                };

               
                // Add this item to the parent
                item.Items.Add(Subitem);
            });
            #endregion
        }
        #region Get_File

        
        /// <summary>
        /// Find the file or folder name from a full path
        /// </summary>
        /// <param name="directorypath"> The Full Path</param>
        /// <returns></returns>
        private object GetFileFolderName(string path)
        {
           
            if (string.IsNullOrEmpty(path))
                return string.Empty;
            // make all slashes back slashes
            var normalizedPath = path.Replace('/', '\\');
            // find the last backslash in the path
            var lastIndex = normalizedPath.LastIndexOf('\\');
            //if we dont Find a BackSlash return the path itself
            if (lastIndex <= 0)
                return path;
            // Return the name after the last back slash
            return path.Substring(lastIndex + 1);


        }
        #endregion
        #endregion
        //44.31

    }
}
