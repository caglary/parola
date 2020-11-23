﻿using System.Windows.Forms;
namespace parola.Utilities
{
    public static class FileOperation
    {
        public static string FolderPath()
        {
          
            FolderBrowserDialog _folder = new FolderBrowserDialog();
            DialogResult result = _folder.ShowDialog();
            string _folderPath=string.Empty;
            if (result == DialogResult.OK)
            {
                _folderPath = _folder.SelectedPath;
            }
            return _folderPath;
        }
        public static string FilePath()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            return opf.FileName;
        }
    }
}
