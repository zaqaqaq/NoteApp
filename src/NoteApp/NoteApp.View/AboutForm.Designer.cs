
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
            this.NoteApplabel.Location = new System.Drawing.Point(10, 18);
            this.NoteApplabel.Name = "NoteApplabel";
            this.NoteApplabel.Size = new System.Drawing.Size(133, 32);
            this.NoteApplabel.TabIndex = 0;
            this.NoteApplabel.Text = "NoteApp";
            // 
            // Versionlabel
            // 
            this.Versionlabel.AutoSize = true;
            this.Versionlabel.Location = new System.Drawing.Point(11, 69);
            this.Versionlabel.Name = "Versionlabel";
            this.Versionlabel.Size = new System.Drawing.Size(55, 17);
            this.Versionlabel.TabIndex = 1;
            this.Versionlabel.Text = "v. 1.0.0";
            // 
            // Authorlabel
            // 
            this.Authorlabel.AutoSize = true;
            this.Authorlabel.Location = new System.Drawing.Point(10, 128);
            this.Authorlabel.Name = "Authorlabel";
            this.Authorlabel.Size = new System.Drawing.Size(164, 17);
            this.Authorlabel.TabIndex = 2;
            this.Authorlabel.Text = "Author: Denis Podushkin";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(10, 193);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(133, 17);
            this.Emaillabel.TabIndex = 3;
            this.Emaillabel.Text = "e-mail for feedback:";
            // 
            // Gitlabel
            // 
            this.Gitlabel.AutoSize = true;
            this.Gitlabel.Location = new System.Drawing.Point(10, 221);
            this.Gitlabel.Name = "Gitlabel";
            this.Gitlabel.Size = new System.Drawing.Size(56, 17);
            this.Gitlabel.TabIndex = 4;
            this.Gitlabel.Text = "GitHub:";
            // 
            // Cclabel
            // 
            this.Cclabel.AutoSize = true;
            this.Cclabel.Location = new System.Drawing.Point(12, 315);
            this.Cclabel.Name = "Cclabel";
            this.Cclabel.Size = new System.Drawing.Size(164, 17);
            this.Cclabel.TabIndex = 5;
            this.Cclabel.Text = "2022 Denis Podushkin ©";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Location = new System.Drawing.Point(149, 193);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(157, 17);
            this.EmailLinkLabel.TabIndex = 6;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "podushkin.den@mail.ru";
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Location = new System.Drawing.Point(71, 221);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(195, 17);
            this.GitLinkLabel.TabIndex = 7;
            this.GitLinkLabel.TabStop = true;
            this.GitLinkLabel.Text = "github.com/zaqaqaq/NoteApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 344);
            this.Controls.Add(this.GitLinkLabel);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.Cclabel);
            this.Controls.Add(this.Gitlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Authorlabel);
            this.Controls.Add(this.Versionlabel);
            this.Controls.Add(this.NoteApplabel);
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