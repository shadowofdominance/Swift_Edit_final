using System;
using System.IO;
using System.Windows.Forms;
using Swift_Edit;

public static class fileoperations
{
    public static void CreateNewTab(TabControl tabControl, TextBox referenceTextArea, string fileName = "Untitled", string fileContent = "")
    {
        TabPage newTab = new TabPage
        {
            Text = Path.GetFileName(fileName)
        };

        TextBox newTextBox = new TextBox
        {
            Multiline = true,
            Dock = DockStyle.Fill,
            ScrollBars = ScrollBars.Both,
            Font = referenceTextArea.Font,
            ForeColor = referenceTextArea.ForeColor,
            BackColor = referenceTextArea.BackColor,
            AcceptsTab = true,
            WordWrap = referenceTextArea.WordWrap,
            Text = fileContent
        };

        newTextBox.TextChanged += (s, e) =>
        {
            if (tabControl.FindForm() is defaultmode_form mainForm)
            {
                mainForm.UpdateFooter();
            }
        };

        newTab.Tag = fileName;
        newTab.Controls.Add(newTextBox);
        tabControl.TabPages.Add(newTab);
        tabControl.SelectedTab = newTab;
    }

    public static void NewFile(TabControl tabControl, TextBox referenceTextArea)
    {
        CreateNewTab(tabControl, referenceTextArea);
    }

    public static string OpenFile(TabControl tabControl, TextBox referenceTextArea)
    {
        using (OpenFileDialog ofd = new OpenFileDialog())
        {
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName; // Capture the file path
                string fileContent = File.ReadAllText(filePath);

                // Call your tab creation method (you may not need this part if you already have tab management)
                CreateNewTab(tabControl, referenceTextArea, filePath, fileContent);

                // Return the file path after opening the file
                return filePath;
            }
        }

        // If no file was selected, return an empty string
        return string.Empty;
    }


    public static void OpenFile(string filepath, TabControl tabControl, TextBox referenceTextArea)
    {
        if (File.Exists(filepath))
        {
            string content = File.ReadAllText(filepath);

            // ✅ Pass the file name and content so the tab can use it
            CreateNewTab(tabControl, referenceTextArea, filepath, content);
        }
        else
        {
            MessageBox.Show("File not found: " + filepath);
        }
    }


    /*public static void OpenFile(string filePath, TabControl tabControl, TextBox referenceTextArea)
    {
        if (File.Exists(filePath))
        {
            string fileContent = File.ReadAllText(filePath);
            CreateNewTab(tabControl, referenceTextArea, filePath, fileContent);

            // Update recent files list
            RecentFilesManager.AddRecentFile(filePath);
            RecentFilesManager.SaveRecentFiles();
        }
        else
        {
            MessageBox.Show("That file doesn't exist anymore! \n" + filePath,
                            "File Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }
    }*/


    public static void SaveFile(TabControl tabControl)
    {
        if (tabControl.SelectedTab == null) return;

        if (tabControl.SelectedTab.Controls[0] is not TextBox currentTextBox) return;

        string filePath = tabControl.SelectedTab.Tag as string;

        if (filePath == "Untitled" || string.IsNullOrEmpty(filePath))
        {
            SaveFileAs(tabControl);
        }
        else
        {
            File.WriteAllText(filePath, currentTextBox.Text);
            MessageBox.Show("File saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public static void SaveFileAs(TabControl tabControl)
    {
        if (tabControl.SelectedTab == null) return;

        if (tabControl.SelectedTab.Controls[0] is not TextBox currentTextBox) return;

        using SaveFileDialog sfd = new SaveFileDialog
        {
            Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
            FileName = tabControl.SelectedTab.Text
        };

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllText(sfd.FileName, currentTextBox.Text);
            tabControl.SelectedTab.Text = Path.GetFileName(sfd.FileName);
            tabControl.SelectedTab.Tag = sfd.FileName;

            MessageBox.Show("File saved successfully!", "Save As", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public static void CloseCurrentFile(TabControl tabControl)
    {
        if (tabControl.SelectedTab == null) return;

        if (tabControl.SelectedTab.Controls[0] is not TextBox currentTextBox) return;

        string filePath = tabControl.SelectedTab.Tag as string;

        if (IsTextChanged(currentTextBox, filePath))
        {
            DialogResult result = MessageBox.Show("This file has unsaved changes. Do you want to close it without saving?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;
        }

        tabControl.TabPages.Remove(tabControl.SelectedTab);
    }

    public static void CloseApplication(TabControl tabControl)
    {
        foreach (TabPage tab in tabControl.TabPages)
        {
            if (tab.Controls[0] is not TextBox textBox) continue;

            string filePath = tab.Tag as string;

            if (IsTextChanged(textBox, filePath))
            {
                DialogResult result = MessageBox.Show("There are unsaved files. Are you sure you want to exit?", "Unsaved Files", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;
                break;
            }
        }

        Application.Exit();
    }

    private static bool IsTextChanged(TextBox textBox, string filePath)
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            return true;

        string savedText = File.ReadAllText(filePath);
        return savedText != textBox.Text;
    }
}