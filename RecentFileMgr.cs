using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SwiftEdit
{
    public class RecentFileMgr
    {
        private readonly string recentFilesPath = Path.Combine(Application.StartupPath, "recentfiles.txt");
        private readonly List<string> recentFiles = new List<string>();
        private readonly int maxRecentFiles = 10; // You can adjust this as needed

        public void LoadRecentFiles(ListBox listBox)
        {
            listBox.Items.Clear();
            recentFiles.Clear();

            try
            {
                if (File.Exists(recentFilesPath))
                {
                    var lines = File.ReadAllLines(recentFilesPath).Where(line => File.Exists(line)).ToList();
                    recentFiles.AddRange(lines);
                    listBox.Items.AddRange(recentFiles.Select(Path.GetFileName).ToArray());
                    listBox.Tag = recentFiles.ToList(); // Store full paths in Tag for reference
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load recent files: " + ex.Message);
            }
        }

        public void SaveRecentFiles()
        {
            try
            {
                File.WriteAllLines(recentFilesPath, recentFiles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save recent files: " + ex.Message);
            }
        }

        public void AddRecentFile(string filepath, ListBox listBox)
        {
            if (!File.Exists(filepath)) return;

            recentFiles.Remove(filepath);
            recentFiles.Insert(0, filepath);

            if (recentFiles.Count > maxRecentFiles)
                recentFiles.RemoveAt(recentFiles.Count - 1);

            RefreshListBox(listBox);
        }

        private void RefreshListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(recentFiles.Select(Path.GetFileName).ToArray());
            listBox.Tag = recentFiles.ToList();
        }
    }
}