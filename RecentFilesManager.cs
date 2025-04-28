using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

public static class RecentFilesManager
{
    public static List<string> RecentFiles = new List<string>();

    private const int MaxRecentFiles = 10; // 🌟 Keep it manageable
    private static readonly string recentFilesPath = Path.Combine(Application.StartupPath, "recentfiles.txt");

    // ✨ Add a file to the recent list
    public static void AddRecentFile(string path)
    {
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            return;

        // If file already exists in the list, move it to the top
        RecentFiles.Remove(path);
        RecentFiles.Insert(0, path);

        // Limit the list to maximum allowed
        if (RecentFiles.Count > MaxRecentFiles)
            RecentFiles.RemoveAt(MaxRecentFiles);
    }

    // 🔥 Save the current recent files list to recentfiles.txt
    public static void SaveRecentFiles()
    {
        try
        {
            File.WriteAllLines(recentFilesPath, RecentFiles);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to save recent files.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // 📜 Load recent files from recentfiles.txt
    public static void LoadRecentFiles()
    {
        try
        {
            if (File.Exists(recentFilesPath))
            {
                string[] lines = File.ReadAllLines(recentFilesPath);
                RecentFiles = new List<string>();

                foreach (string line in lines)
                {
                    if (File.Exists(line))
                        RecentFiles.Add(line);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to load recent files.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
