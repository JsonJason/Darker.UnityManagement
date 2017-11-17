using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Darker.UnityManagement.Examples
{
    public partial class VersionPicker : Form
    {
        private readonly Action<UnityVersion> _callback;
        private readonly List<UnityVersion> _versions;

        public VersionPicker(IEnumerable<UnityVersion> versions,Action<UnityVersion> callback)
        {
            _callback = callback;
            _versions = versions.ToList();
            InitializeComponent();

            foreach (var unityVersion in _versions)
            {
                var btn = new Button {Text = unityVersion.Number};
                btn.Click += BtnOnClick;
                flowLayoutPanel1.Controls.Add(btn);


            }

        }

        private void BtnOnClick(object sender, EventArgs eventArgs)
        {
            var version = _versions.FirstOrDefault(x => x.Number == ((Button) sender).Text);
            _callback(version);
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
