using System.Text.RegularExpressions;

namespace TemplateRewriterTool
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> keyReplacements = new Dictionary<string, string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(ofd.FileName);
                rtxPreview.Text = content;

                // Tìm tất cả các key dạng {{Ten}}
                var matches = Regex.Matches(content, @"{{(.*?)}}");

                lstKeys.Items.Clear();
                foreach (Match match in matches)
                {
                    string key = match.Groups[1].Value;
                    if (!lstKeys.Items.Contains(key))
                        lstKeys.Items.Add(key);
                }
            }
        }

        private void lstKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKeys.SelectedItem != null)
            {
                string selectedKey = lstKeys.SelectedItem.ToString();

                if (keyReplacements.ContainsKey(selectedKey))
                    txtReplaceValue.Text = keyReplacements[selectedKey];
                else
                    txtReplaceValue.Clear();
            }
        }

        private void txtReplaceValue_TextChanged(object sender, EventArgs e)
        {
            if (lstKeys.SelectedItem != null)
            {
                string key = lstKeys.SelectedItem.ToString();
                keyReplacements[key] = txtReplaceValue.Text;
            }

        }
    }
}
