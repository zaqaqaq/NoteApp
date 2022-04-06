
namespace NoteApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.NoteApplabel = new System.Windows.Forms.Label();
            this.Versionlabel = new System.Windows.Forms.Label();
            this.Authorlabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Gitlabel = new System.Windows.Forms.Label();
            this.Cclabel = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NoteApplabel
            // 
            this.NoteApplabel.AutoSize = true;
            this.NoteApplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteApplabel.Location = new System.Drawing.Point(8, 15);
            this.NoteApplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteApplabel.Name = "NoteApplabel";
            this.NoteApplabel.Size = new System.Drawing.Size(104, 26);
            this.NoteApplabel.TabIndex = 0;
            this.NoteApplabel.Text = "NoteApp";
            // 
            // Versionlabel
            // 
            this.Versionlabel.AutoSize = true;
            this.Versionlabel.Location = new System.Drawing.Point(8, 56);
            this.Versionlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Versionlabel.Name = "Versionlabel";
            this.Versionlabel.Size = new System.Drawing.Size(43, 13);
            this.Versionlabel.TabIndex = 1;
            this.Versionlabel.Text = "v. 1.0.0";
            // 
            // Authorlabel
            // 
            this.Authorlabel.AutoSize = true;
            this.Authorlabel.Location = new System.Drawing.Point(8, 104);
            this.Authorlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Authorlabel.Name = "Authorlabel";
            this.Authorlabel.Size = new System.Drawing.Size(124, 13);
            this.Authorlabel.TabIndex = 2;
            this.Authorlabel.Text = "Author: Denis Podushkin";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(8, 157);
            this.Emaillabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(100, 13);
            this.Emaillabel.TabIndex = 3;
            this.Emaillabel.Text = "e-mail for feedback:";
            // 
            // Gitlabel
            // 
            this.Gitlabel.AutoSize = true;
            this.Gitlabel.Location = new System.Drawing.Point(8, 180);
            this.Gitlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Gitlabel.Name = "Gitlabel";
            this.Gitlabel.Size = new System.Drawing.Size(43, 13);
            this.Gitlabel.TabIndex = 4;
            this.Gitlabel.Text = "GitHub:";
            // 
            // Cclabel
            // 
            this.Cclabel.AutoSize = true;
            this.Cclabel.Location = new System.Drawing.Point(9, 256);
            this.Cclabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cclabel.Name = "Cclabel";
            this.Cclabel.Size = new System.Drawing.Size(126, 13);
            this.Cclabel.TabIndex = 5;
            this.Cclabel.Text = "2022 Denis Podushkin ©";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Location = new System.Drawing.Point(112, 157);
            this.EmailLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(118, 13);
            this.EmailLinkLabel.TabIndex = 6;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "podushkin.den@mail.ru";
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Location = new System.Drawing.Point(53, 180);
            this.GitLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(152, 13);
            this.GitLinkLabel.TabIndex = 7;
            this.GitLinkLabel.TabStop = true;
            this.GitLinkLabel.Text = "github.com/zaqaqaq/NoteApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 280);
            this.Controls.Add(this.GitLinkLabel);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.Cclabel);
            this.Controls.Add(this.Gitlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Authorlabel);
            this.Controls.Add(this.Versionlabel);
            this.Controls.Add(this.NoteApplabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteApplabel;
        private System.Windows.Forms.Label Versionlabel;
        private System.Windows.Forms.Label Authorlabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Gitlabel;
        private System.Windows.Forms.Label Cclabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.LinkLabel GitLinkLabel;
    }
}