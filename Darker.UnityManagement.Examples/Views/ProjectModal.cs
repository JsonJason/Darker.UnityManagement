using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Darker.UnityManagement.Examples
{
    public partial class ProjectModal : Form
    {


        public ProjectModal(UnityProject project,IEnumerable<UnityVersion> possibleVersions)
        {
            _project = project;
            InitializeComponent();
            _launcher = new UnityLauncher();
            _possibleVersions = possibleVersions.ToList();
            lbl_projectName.Text = _project.Name;
        }

        private readonly UnityProject _project;
        private List<UnityVersion> _possibleVersions;
        private UnityLauncher _launcher;

        private void button1_Click(object sender, System.EventArgs e)
        {
            new VersionPicker(_possibleVersions, VersionPicked).ShowDialog(this);
        }

        void VersionPicked(UnityVersion version)
        {
            if (string.IsNullOrEmpty(version.Path))
            {
                var downloadSuccessful = _launcher.DownloadAndRun(version);
                if (!downloadSuccessful)
                    MessageBox.Show(this, "Failed to find download url for missing unity version", "Oops",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _launcher.Launch(version, _project);
                this.Close();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            _launcher.OpenFolder(_project);
            this.Close();
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}