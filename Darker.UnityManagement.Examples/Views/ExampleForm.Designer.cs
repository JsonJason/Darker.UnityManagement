namespace Darker.UnityManagement.Examples
{
    partial class ExampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.list_versions = new System.Windows.Forms.DataGridView();
            this.list_projects = new System.Windows.Forms.DataGridView();
            this.lbl_versions = new System.Windows.Forms.Label();
            this.txt_versions = new System.Windows.Forms.TextBox();
            this.txt_projects = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list_versions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_projects)).BeginInit();
            this.SuspendLayout();
            // 
            // list_versions
            // 
            this.list_versions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_versions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_versions.Location = new System.Drawing.Point(12, 41);
            this.list_versions.Name = "list_versions";
            this.list_versions.Size = new System.Drawing.Size(314, 304);
            this.list_versions.TabIndex = 0;
            this.list_versions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_versions_CellDoubleClick);
            // 
            // list_projects
            // 
            this.list_projects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_projects.Location = new System.Drawing.Point(333, 41);
            this.list_projects.Name = "list_projects";
            this.list_projects.Size = new System.Drawing.Size(387, 304);
            this.list_projects.TabIndex = 1;
            this.list_projects.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_projects_CellContentDoubleClick);
            // 
            // lbl_versions
            // 
            this.lbl_versions.AutoSize = true;
            this.lbl_versions.Location = new System.Drawing.Point(22, 13);
            this.lbl_versions.Name = "lbl_versions";
            this.lbl_versions.Size = new System.Drawing.Size(47, 13);
            this.lbl_versions.TabIndex = 2;
            this.lbl_versions.Text = "Versions";
            // 
            // txt_versions
            // 
            this.txt_versions.Location = new System.Drawing.Point(74, 10);
            this.txt_versions.Name = "txt_versions";
            this.txt_versions.Size = new System.Drawing.Size(251, 20);
            this.txt_versions.TabIndex = 3;
            this.txt_versions.Text = "C:\\Program Files";
            this.txt_versions.TextChanged += new System.EventHandler(this.txt_versions_TextChanged);
            // 
            // txt_projects
            // 
            this.txt_projects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_projects.Location = new System.Drawing.Point(383, 10);
            this.txt_projects.Name = "txt_projects";
            this.txt_projects.Size = new System.Drawing.Size(337, 20);
            this.txt_projects.TabIndex = 4;
            this.txt_projects.TextChanged += new System.EventHandler(this.txt_projects_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Projects";
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_projects);
            this.Controls.Add(this.txt_versions);
            this.Controls.Add(this.lbl_versions);
            this.Controls.Add(this.list_projects);
            this.Controls.Add(this.list_versions);
            this.Name = "ExampleForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.list_versions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_projects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView list_versions;
        private System.Windows.Forms.DataGridView list_projects;
        private System.Windows.Forms.Label lbl_versions;
        private System.Windows.Forms.TextBox txt_versions;
        private System.Windows.Forms.TextBox txt_projects;
        private System.Windows.Forms.Label label1;
    }
}

