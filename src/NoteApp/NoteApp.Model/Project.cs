using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Класс,который хранит все заметки
    /// </summary>
    class Project
    {
        /// <summary>
        /// Список с заметками
        /// </summary>
        public List<Note> Notes { get; set; }
    }
}


