using System.Windows.Forms;

namespace Prism.Forms.Plugin.Wizard
{
    public partial class PluginNewProjectDialog : Form
    {
        public PluginNewProjectDialogResult Result { get; set; }
        public PluginNewProjectDialog()
        {
            InitializeComponent();

            Result = new PluginNewProjectDialogResult();

        }

        private void PluginNewProjectDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Result.CreateAndroid = chkDroid.Checked;

            Result.CreateiOS = chkiOS.Checked;

            Result.CreateUwp = chkUWP.Checked;

            Result.CreateNuspec = chkNuget.Checked;
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Result.Cancelled = true;
            Close();
        }
    }
    public class PluginNewProjectDialogResult
    {
        public bool CreateAndroid { get; set; }
        public bool CreateiOS { get; set; }
        public bool CreateUwp { get; set; }
        public bool CreateNuspec { get; set; }
        public bool Cancelled { get; set; }
    }
}
