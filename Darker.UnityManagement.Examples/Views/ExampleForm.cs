using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Darker.UnityManagement.Examples
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _ctrl = new ExamplesController(this);
            txt_projects.Text = path;
            _ctrl.Refresh();
  
      
        }

       

        private readonly ExamplesController _ctrl;

        public string VersionPath => txt_versions.Text;

        public string ProjectPath => txt_projects.Text;

        public void SetVersions(List<UnityVersion> versions)
        {
           ColorTextField(txt_versions,versions?.Count ?? -1);

            list_versions.DataSource = versions;
        }

        public void SetProjects(List<UnityProject> projects)
        {
            ColorTextField(txt_projects, projects?.Count ?? -1);
            list_projects.DataSource = projects;
        }

        private void txt_versions_TextChanged(object sender, System.EventArgs e)
        {
            _ctrl.Refresh();
        }

        private void txt_projects_TextChanged(object sender, System.EventArgs e)
        {
            _ctrl.Refresh();
        }

        void ColorTextField(TextBox box, int amount)
        {
            if (amount <= -1)
            {
                box.BackColor = Color.IndianRed;
            }
            else if (amount == 0)
            {
                box.BackColor = Color.CornflowerBlue;
            }
            else
            {
                box.BackColor = Color.DarkSeaGreen;
            }
        }

        private void list_projects_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var project = (UnityProject) list_projects.Rows[e.RowIndex].DataBoundItem;
            new ProjectModal(project, list_versions.DataSource as List<UnityVersion>).ShowDialog(this);
        }

        private void list_versions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var version = (UnityVersion)list_versions.Rows[e.RowIndex].DataBoundItem;
            new VersionModal(version).ShowDialog(this);
        }
    }
}
