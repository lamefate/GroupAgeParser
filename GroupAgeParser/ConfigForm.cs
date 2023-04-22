using System;
using System.Configuration;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace GroupAgeParser
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            AllDesignChanges();
            SetTextBoxPosition(valueInput);
            FillKeyComboBox(keysBoxList);
        }

        public void AllDesignChanges()
        {
            this.BackColor = Color.FromArgb(93, 93, 93);
            foreach (Control childControl in this.Controls)
            {
                int x = (ClientSize.Width - childControl.Width) / 2;
                childControl.Location = new Point(x, childControl.Location.Y);
            }
        }

        public void FillKeyComboBox(ComboBox actualComboBox)
        {
            foreach(SettingsProperty sp in Properties.Settings.Default.Properties)
            {
                if (sp.Name != "parseMode")
                {
                    actualComboBox.Items.Add(sp.Name);
                }
            }
            actualComboBox.SelectedIndex = 0;
        }

        public void UpdateKey(string Key, string nValue)
        {

            Properties.Settings.Default[Key] = Convert.ChangeType(nValue, Properties.Settings.Default[Key].GetType());
            Properties.Settings.Default.Save();
        }

        public void SetTextBoxPosition(TextBox actualTextBox)
        {
            int x = (ClientSize.Width - actualTextBox.Width) / 2;
            actualTextBox.Location = new Point(x, actualTextBox.Location.Y);
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            string KeyInput = keysBoxList.SelectedItem.ToString();
            string ValueInput = valueInput.Text;
            try
            {
                if (keysBoxList.SelectedIndex != -1)
                {
                    UpdateKey(KeyInput, ValueInput);
                }
            }
            catch (SettingsPropertyNotFoundException)
            {
                MessageBox.Show($"Error: the key '{KeyInput}' does not exists", "Error Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkConfig_Click(object sender, EventArgs e)
        {
            try
            {
                string KeyInput = keysBoxList.SelectedItem.ToString();
                valueInput.Clear();
                valueInput.Text = Properties.Settings.Default[KeyInput].ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show($"Error: select the desired key from the list", "Error Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
