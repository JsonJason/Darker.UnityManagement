using System;
using System.Windows.Forms;

namespace Darker.UnityManagement.Examples
{
    public partial class VersionModal : Form
    {
        private readonly UnityVersion _version;

        public VersionModal(UnityVersion version)
        {
            _version = version;
            InitializeComponent();
            _launcher = new UnityLauncher();

            if (!string.IsNullOrEmpty(version.Path))
                btn_download.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            _launcher.Launch(_version);
        }

        private readonly UnityLauncher _launcher;

        private void btn_folder_Click(object sender, EventArgs e)
        {
            _launcher.OpenFolder(_version);
        }

        private void btn_releaseNotes_Click(object sender, EventArgs e)
        {
            _launcher.OpenReleaseNotes(_version);
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            _launcher.DownloadAndRun(_version);
        }
    }
}
