﻿
namespace NoteApp.View
{
    partial class NoteForm
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
            this.TitleTextBox1 = new System.Windows.Forms.TextBox();
            this.CategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.NoteTextBox1 = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Titlelabel1 = new System.Windows.Forms.Label();
            this.Categorylabel1 = new System.Windows.Forms.Label();
            this.Modifiedlabel1 = new System.Windows.Forms.Label();
            this.Createdlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleTextBox1
            // 
            this.TitleTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox1.Location = new System.Drawing.Point(97, 31);
            this.TitleTextBox1.Multiline = true;
            this.TitleTextBox1.Name = "TitleTextBox1";
            this.TitleTextBox1.Size = new System.Drawing.Size(691, 22);
            this.TitleTextBox1.TabIndex = 0;
            // 
            // CategoryComboBox1
            // 
            this.CategoryComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryComboBox1.FormattingEnabled = true;
            this.CategoryComboBox1.Location = new System.Drawing.Point(97, 63);
            this.CategoryComboBox1.Name = "CategoryComboBox1";
            this.CategoryComboBox1.Size = new System.Drawing.Size(186, 24);
            this.CategoryComboBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(302, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(97, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // NoteTextBox1
            // 
            this.NoteTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox1.Location = new System.Drawing.Point(12, 131);
            this.NoteTextBox1.Multiline = true;
            this.NoteTextBox1.Name = "NoteTextBox1";
            this.NoteTextBox1.Size = new System.Drawing.Size(776, 278);
            this.NoteTextBox1.TabIndex = 4;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(632, 415);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(713, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Titlelabel1
            // 
            this.Titlelabel1.AutoSize = true;
            this.Titlelabel1.Location = new System.Drawing.Point(22, 34);
            this.Titlelabel1.Name = "Titlelabel1";
            this.Titlelabel1.Size = new System.Drawing.Size(39, 17);
            this.Titlelabel1.TabIndex = 7;
            this.Titlelabel1.Text = "Title:";
            // 
            // Categorylabel1
            // 
            this.Categorylabel1.AutoSize = true;
            this.Categorylabel1.Location = new System.Drawing.Point(22, 66);
            this.Categorylabel1.Name = "Categorylabel1";
            this.Categorylabel1.Size = new System.Drawing.Size(69, 17);
            this.Categorylabel1.TabIndex = 8;
            this.Categorylabel1.Text = "Category:";
            // 
            // Modifiedlabel1
            // 
            this.Modifiedlabel1.AutoSize = true;
            this.Modifiedlabel1.Location = new System.Drawing.Point(231, 103);
            this.Modifiedlabel1.Name = "Modifiedlabel1";
            this.Modifiedlabel1.Size = new System.Drawing.Size(65, 17);
            this.Modifiedlabel1.TabIndex = 10;
            this.Modifiedlabel1.Text = "Modified:";
            // 
            // Createdlabel1
            // 
            this.Createdlabel1.AutoSize = true;
            this.Createdlabel1.Location = new System.Drawing.Point(22, 103);
            this.Createdlabel1.Name = "Createdlabel1";
            this.Createdlabel1.Size = new System.Drawing.Size(62, 17);
            this.Createdlabel1.TabIndex = 11;
            this.Createdlabel1.Text = "Created:";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Createdlabel1);
            this.Controls.Add(this.Modifiedlabel1);
            this.Controls.Add(this.Categorylabel1);
            this.Controls.Add(this.Titlelabel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NoteTextBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CategoryComboBox1);
            this.Controls.Add(this.TitleTextBox1);
            this.Name = "NoteForm";
            this.Text = "NoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox1;
        private System.Windows.Forms.ComboBox CategoryComboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox NoteTextBox1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Titlelabel1;
        private System.Windows.Forms.Label Categorylabel1;
        private System.Windows.Forms.Label Modifiedlabel1;
        private System.Windows.Forms.Label Createdlabel1;
    }
}