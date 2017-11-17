namespace Darker.UnityManagement.Examples
{
    partial class VersionModal
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
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_folder = new System.Windows.Forms.Button();
            this.btn_releaseNotes = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.Location = new System.Drawing.Point(16, 9);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(260, 37);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.Text = "MY UNITY VERSION";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(197, 226);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(52, 49);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(187, 27);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "OPEN";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(52, 82);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(187, 30);
            this.btn_folder.TabIndex = 4;
            this.btn_folder.Text = "OPEN FOLDER";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // btn_releaseNotes
            // 
            this.btn_releaseNotes.Location = new System.Drawing.Point(52, 118);
            this.btn_releaseNotes.Name = "btn_releaseNotes";
            this.btn_releaseNotes.Size = new System.Drawing.Size(187, 29);
            this.btn_releaseNotes.TabIndex = 5;
            this.btn_releaseNotes.Text = "RELEASE NOTES";
            this.btn_releaseNotes.UseVisualStyleBackColor = true;
            this.btn_releaseNotes.Click += new System.EventHandler(this.btn_releaseNotes_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(52, 153);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(187, 29);
            this.btn_download.TabIndex = 6;
            this.btn_download.Text = "DOWNLOAD";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // VersionModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_releaseNotes);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_version);
            this.Name = "VersionModal";
            this.Text = "VersionModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Button btn_releaseNotes;
        private System.Windows.Forms.Button btn_download;
    }
}