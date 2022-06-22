using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле для хранения объектов заметок.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Показывать все заметки без учета категории
        /// </summary>
        private const string _allCategory = "All";

        /// <summary>
        /// отображение списка заметок
        /// </summary>
        private List<Note> _currentNotes;



        public MainForm()
        {
            _project = new Project();
            InitializeComponent();
        }

        /// <summary>
        /// Обновить список заметок.
        /// </summary>
        private void UpdateListBox()
        {
            CategoryListBox.Items.Clear();
            foreach (Note note in _project.Notes)
            {
                CategoryListBox.Items.Add(note.Title);
            }
        }

        /// <summary>
        /// Добавить заметку.
        /// </summary>
        private void AddNote()
        {
            var noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(noteForm.Note);
                CategoryListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Удалить заметку.
        /// </summary>
        /// <param name="index">Индекс заметки.</param>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }

            DialogResult result = MessageBox.Show($"Do you really want to remove {CategoryListBox.SelectedItem.ToString()}?",
                "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(index);
                CategoryListBox.SelectedItem = null;
            }
            else return;
        }

        /// <summary>
        /// Обновить поле описания заметки.
        /// </summary>
        /// <param name="index">Индекс заметки.</param>
        private void UpdateSelectedNote(int index)
        {
            if (CategoryListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
                return;
            }
            NoteTextBox.Text = _project.Notes[index].Text;
            NameLabel.Text = _project.Notes[index].Title;
            DateTimePickerCreated.Value = _project.Notes[index].CreateTime;
            DateTimePickerModified.Value = _project.Notes[index].ModifiedTime;
            TextLabel.Text = _project.Notes[index].Category.ToString();
        }

        /// <summary>
        /// Очистить поле описания заметки.
        /// </summary>
        private void ClearSelectedNote()
        {
            NoteTextBox.Text = string.Empty;
            NameLabel.Text = string.Empty;
            DateTimePickerCreated.Value = DateTime.Now;
            DateTimePickerModified.Value = DateTime.Now;
            TextLabel.Text = string.Empty;
        }

        /// <summary>
        /// Обработчик изменения выбранной заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedNote(CategoryListBox.SelectedIndex);
        }

        /// <summary>
        /// Добавление новой заметки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }
        /// <summary>
        /// Удаление заметки через меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote(CategoryListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Окно About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }
        /// <summary>
        /// Закрытие окна приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Добавление заметки через иконку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconButtonAdd_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }
        /// <summary>
        /// Удаление через иконку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconButtonDel_Click(object sender, EventArgs e)
        {
            RemoveNote(CategoryListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Добавить заметку.
        /// </summary>
        private void addRandomNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {       
                Random random = new Random();
                Note note = new Note();
                note.Title = random.Next().ToString();
                note.Text = random.Next().ToString();
                _project.Notes.Add(note);
            
        }

        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(CategoryListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование существующей заметки.
        /// </summary>
        private void EditNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            _project.Notes[index] = noteForm.Note;
            if (noteForm.DialogResult == DialogResult.OK)
            {
                currentIndex = -1;
            }
            if ((CategoryListBox.Items.Count != 0) && (currentIndex < CategoryListBox.Items.Count))
            {
                CategoryListBox.SelectedIndex = currentIndex;
            }
        }
    }
}

