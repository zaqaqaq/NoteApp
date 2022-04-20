using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// Заметка.
    public class Note : ICloneable
    {
        /// Название заметки
        private string _title;
        /// Категория заметки
        private NoteCategory _category { get; set; }
        /// Текст заметки
        private string _text;
        /// Дата создания
        private DateTime _createTime { get; set; } = DateTime.Now;
        ///Дата последнего изменения
        private DateTime _updateTime { get; set; }
        ///Ограничение длины названия
        private int _noteTitleLimit = 50;
        ///Название по умолчанию
        private string _defaultTitle = "Без Названия";

        /// Get и Set названия
        public string Title
        {
            get { return _title; }

            set
            {
                if (value.Length > _noteTitleLimit)
                {
                    throw new ArgumentException();
                }
                if (value == string.Empty)
                {
                    _title = _defaultTitle;
                }

                _title = value;
                _updateTime = DateTime.Now;
            }
        }

        ///Get и Set текста
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                _updateTime = DateTime.Now;
            }
        }

        /// Копирования объекта, интерфейс ICloneable
        public Object Clone()
        {
            Note note = new Note();
            note.Title = this.Title;
            note.Text = this.Text;
            note._category = this._category;
            note._createTime = this._createTime;
            note._updateTime = this._updateTime;
            return note;
        }
    }
}

