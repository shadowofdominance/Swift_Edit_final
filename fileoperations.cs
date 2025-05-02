using System;
using System.IO;
using System.Windows.Forms;
using Swift_Edit;

public static class fileoperations
{
    public static void CreateNewTab(TabControl tabControl, RichTextBox referenceTextArea, string fileName = "Untitled", string fileContent = "")
    {
        string displayName = Path.GetFileName(fileName);
        string fullPath = fileName;

        TabPage newTab = new TabPage
        {
            Text = displayName,
            Tag = fullPath
        };

        RichTextBox newTextBox = new RichTextBox
        {
            Multiline = true,
            Dock = DockStyle.Fill,
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

        newTab.Controls.Add(newTextBox);
        tabControl.TabPages.Add(newTab);
        tabControl.SelectedTab = newTab;
    }

    public static void NewFile(TabControl tabControl, RichTextBox referenceTextArea)
    {
        CreateNewTab(tabControl, referenceTextArea);
    }

    public static string OpenFile(TabControl tabControl, RichTextBox referenceTextArea)
    {
        using (OpenFileDialog ofd = new OpenFileDialog())
        {
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string fileContent = File.ReadAllText(filePath);
                CreateNewTab(tabControl, referenceTextArea, filePath, fileContent);
                return filePath;
            }
        }
        return string.Empty;
    }

    public static void OpenFile(string filepath, TabControl tabControl, RichTextBox referenceTextArea)
    {
        if (File.Exists(filepath))
        {
            string content = File.ReadAllText(filepath);
            CreateNewTab(tabControl, referenceTextArea, filepath, content);
        }
        else
        {
            MessageBox.Show("File not found: " + filepath);
        }
    }

    public static void SaveFile(TabControl tabControl)
    {
        if (tabControl.SelectedTab == null) return;

        if (tabControl.SelectedTab.Controls[0] is not RichTextBox currentTextBox) return;

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

        if (tabControl.SelectedTab.Controls[0] is not RichTextBox currentTextBox) return;

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

        if (tabControl.SelectedTab.Controls[0] is not RichTextBox currentTextBox) return;

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
            if (tab.Controls[0] is not RichTextBox textBox) continue;

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

    private static bool IsTextChanged(RichTextBox textBox, string filePath)
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            return true;

        string savedText = File.ReadAllText(filePath);
        return savedText != textBox.Text;
    }

    public static void CloseAllTabs(TabControl tabControl)
    {
        List<TabPage> tabsToClose = new List<TabPage>();

        foreach (TabPage tab in tabControl.TabPages)
        {
            if (tab.Controls[0] is not RichTextBox textBox) continue;

            string filePath = tab.Tag as string;

            if (IsTextChanged(textBox, filePath))
            {
                DialogResult result = MessageBox.Show(
                    $"The file '{tab.Text}' has unsaved changes. Do you want to close it without saving?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    continue;
            }

            tabsToClose.Add(tab);
        }

        foreach (var tab in tabsToClose)
        {
            tabControl.TabPages.Remove(tab);
        }
    }
}
