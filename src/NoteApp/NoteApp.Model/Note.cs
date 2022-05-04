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
        /// Название заметки.
        /// </summary>
        private string _title;
        /// <summary>
        /// Категория заметки.
        /// </summary>
        private NoteCategory _category { get; set; }
        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;
        /// <summary>
        /// Дата создания.
        /// </summary>
        private DateTime _createTime { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата последнего изменения.
        /// </summary>
        private DateTime _updateTime { get; set; }
        /// <summary>
        /// Ограничение длины названия.
        /// </summary>
        private int _noteTitleLimit = 50;
        /// <summary>
        /// Название по умолчанию.
        /// </summary>
        private string _defaultTitle = "Без Названия";

        /// <summary>
        /// Get и Set названия.
        /// </summary>
        public string Title
        {
            get { return _title; }

            set
            {
                if (value.Length > _noteTitleLimit)
                {
                    throw new ArgumentException("max title length = 50");
                }
                if (value == string.Empty)
                {
                    _title = _defaultTitle;
                }

                _title = value;
                _updateTime = DateTime.Now;
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
                _updateTime = DateTime.Now;
            }
        }

        

        /// <summary>
        /// Копирования объекта, интерфейс ICloneable
        /// </summary>
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

