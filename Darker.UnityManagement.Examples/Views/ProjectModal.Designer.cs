namespace Darker.UnityManagement.Examples
{
    partial class ProjectModal
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
            this.lbl_projectName = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_projectName
            // 
            this.lbl_projectName.AutoSize = true;
            this.lbl_projectName.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_projectName.Location = new System.Drawing.Point(12, 27);
            this.lbl_projectName.Name = "lbl_projectName";
            this.lbl_projectName.Size = new System.Drawing.Size(199, 28);
            this.lbl_projectName.TabIndex = 0;
            this.lbl_projectName.Text = "MY UNITY PROJECT";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(352, 243);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "OPEN PROJECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "OPEN FOLDER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProjectModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_projectName);
            this.Name = "ProjectModal";
            this.Text = "ProjectModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_projectName;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}