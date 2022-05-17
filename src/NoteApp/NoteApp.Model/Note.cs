using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Заметка.
    /// </summary>
    public class Note: ICloneable
    {

        /// <summary>
        /// Ограничение длины названия.
        /// </summary>
        private const int NOTETITLELIMIT = 50;

        /// <summary>
        /// Название по умолчанию.
        /// </summary>
        private const string DEFAULTTITLE = "Без Названия";

        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _title;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Дата последнего изменения.
        /// </summary>
        public DateTime ModifiedTime { get; set; }
        /// <summary>
        /// Категория заметки.
        /// </summary>
        public NoteCategory Category { get; set; }


        /// <summary>
        /// Get и Set названия.
        /// </summary>
        public string Title
        {
            get { return _title; }

            set
            {
                if (value.Length > NOTETITLELIMIT)
                {
                    throw new ArgumentException("max title length = 50");
                }
                if (value == string.Empty)
                {
                    _title = DEFAULTTITLE;
                }

                _title = value;
                ModifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Get и Set текста.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                ModifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Копирования объекта, интерфейс ICloneable
        /// </summary>
        public object Clone()
        {
            Note note = new Note();
            note.Title = this.Title;
            note.Text = this.Text;
            note.Category = this.Category;
            note.CreateTime = this.CreateTime;
            note.ModifiedTime = this.ModifiedTime;
            return note;
        }
    }
}

