using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Permissions;

namespace ScreenSaver
{
    public partial class SettingsForm : Form
    {
        private string sources = string.Empty;

        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\PhosphorusScreenSaver");
                if (registryKey != null)
                {
                    sources = (string)registryKey.GetValue("source");
                    foreach (string source in sources.Split('|'))
                        sourcesListBox.Items.Add(source.Split(':').Last().Split('\\').Last());
                    separatorTextBox.Text = (string)registryKey.GetValue("separator");
                    minSpeedTextBox.Text = (string)registryKey.GetValue("minSpeed");
                    maxSpeedTextBox.Text = (string)registryKey.GetValue("maxSpeed");
                    fontTextBox.Text = (string)registryKey.GetValue("font");
                    colorTextBox.Text = (string)registryKey.GetValue("color");
                    canvasTextBox.Text = (string)registryKey.GetValue("canvas");
                    trimCheckBox.Checked = Convert.ToBoolean((string)registryKey.GetValue("trim"));
                    dividerTextBox.Text = (string)registryKey.GetValue("divider");
                    caretCheckBox.Checked = Convert.ToBoolean((string)registryKey.GetValue("caret"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (sources == string.Empty)
            {
                MessageBox.Show("Sources value cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (separatorTextBox.Text == string.Empty)
            {
                MessageBox.Show("Separators value cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (minSpeedTextBox.Text == string.Empty || maxSpeedTextBox.Text == string.Empty)
            {
                MessageBox.Show("Speed values cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Convert.ToInt32(minSpeedTextBox.Text) == 0 || Convert.ToInt32(maxSpeedTextBox.Text) == 0)
            {
                MessageBox.Show("Speed values must be greater than 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (Convert.ToInt32(minSpeedTextBox.Text) > Convert.ToInt32(maxSpeedTextBox.Text))
            {
                MessageBox.Show("Maximum speed must be equal to or greater than the minimum speed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\PhosphorusScreenSaver");
            registryKey.SetValue("source", sources);
            registryKey.SetValue("separator", separatorTextBox.Text);
            registryKey.SetValue("minSpeed", minSpeedTextBox.Text);
            registryKey.SetValue("maxSpeed", maxSpeedTextBox.Text);
            registryKey.SetValue("font", fontTextBox.Text);
            registryKey.SetValue("color", colorTextBox.Text);
            registryKey.SetValue("canvas", canvasTextBox.Text);
            registryKey.SetValue("trim", trimCheckBox.Checked.ToString());
            registryKey.SetValue("divider", dividerTextBox.Text);
            registryKey.SetValue("caret", caretCheckBox.Checked.ToString());

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    if (sources.Length > 0)
                        sources += "|";
                    sources += file;
                    sourcesListBox.Items.Add(file.Split(':').Last().Split('\\').Last());
                }
            }
        }

        private void removeSourceButton_Click(object sender, EventArgs e)
        {
            if (sourcesListBox.SelectedItems.Count == 1)
            {
                string tempSources = sources;
                sources = string.Empty;
                int sourceIndex = 0;
                foreach (string source in tempSources.Split('|'))
                {
                    if (sourceIndex != sourcesListBox.SelectedIndex)
                    {
                        if (sources != string.Empty)
                            sources += "|";
                        sources += source;
                    }
                    sourceIndex++;
                }
                sourcesListBox.Items.Remove(sourcesListBox.SelectedItems[0]);
            }
            else
                MessageBox.Show("Select an item from the list!", "Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void clearSourcesButton_Click(object sender, EventArgs e)
        {
            sources = string.Empty;
            sourcesListBox.Items.Clear();
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            if (sourcesListBox.SelectedItems.Count == 1)
                MessageBox.Show(sources.Split('|')[sourcesListBox.SelectedIndex], "Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Select an item from the list!", "Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                var fcv = new FontConverter();
                fontTextBox.Text = fcv.ConvertToString(fontDialog.Font);
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorTextBox.Text = colorDialog.Color.Name;
            }
        }

        private void canvasButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                canvasTextBox.Text = colorDialog.Color.Name;
            }
        }

        private void SpeedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void defaultsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to restore default values?", "Defaults", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                minSpeedTextBox.Text = "5";
                maxSpeedTextBox.Text = "100";
                fontTextBox.Text = "Consolas; 24pt";
                colorTextBox.Text = "Lime";
                canvasTextBox.Text = "Black";
                trimCheckBox.Checked = true;
                dividerTextBox.Clear();
                caretCheckBox.Checked = false;

                MessageBox.Show("Default values restored!", "Defaults", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
