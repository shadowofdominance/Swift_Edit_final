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

    public static void OpenFile(TabControl tabControl, TextBox referenceTextArea)
    {
        using OpenFileDialog ofd = new OpenFileDialog
        {
            Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        };

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            string fileContent = File.ReadAllText(ofd.FileName);
            CreateNewTab(tabControl, referenceTextArea, ofd.FileName, fileContent);
        }
    }

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