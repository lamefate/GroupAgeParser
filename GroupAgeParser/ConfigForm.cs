using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace GroupAgeParser
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            SetListViewPosition(keyListView);
            SetTextBoxPosition(valueInput);
            FillKeyListView(keyListView);
        }

        public void FillKeyListView(ListView actualListView)
        {
            actualListView.View = View.List;
            foreach(SettingsProperty sp in Properties.Settings.Default.Properties)
            {
                if (sp.Name != "parseMode")
                {
                    ListViewItem newItem = new ListViewItem
                    {
                        Text = sp.Name
                    };
                    actualListView.Items.Add(newItem);
                }
            }
        }

        public void UpdateKey(string Key, string nValue)
        {

            Properties.Settings.Default[Key] = Convert.ChangeType(nValue, Properties.Settings.Default[Key].GetType());
            Properties.Settings.Default.Save();
        }

        public void SetListViewPosition(ListView actualListView)
        {
            int x = (ClientSize.Width - actualListView.Width) / 2;
            actualListView.Location = new Point(x, actualListView.Location.Y);
        }

        public void SetTextBoxPosition(TextBox actualTextBox)
        {
            int x = (ClientSize.Width - actualTextBox.Width) / 2;
            actualTextBox.Location = new Point(x, actualTextBox.Location.Y);
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            string KeyInput = keyListView.SelectedItems[0].Text;
            string ValueInput = valueInput.Text;
            try
            {
                UpdateKey(KeyInput, ValueInput);
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
                string KeyInput = keyListView.SelectedItems[0].Text;
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
