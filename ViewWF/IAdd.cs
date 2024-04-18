using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewWF
{
    /// <summary>
    /// интерфейс формы добавления
    /// </summary>
    public interface IAdd
    {
        /// <summary>
        /// событие добавления нового студента
        /// </summary>
        event EventHandler<List<string>> AddStudentEvent;

        /// <summary>
        /// событие отображения формы
        /// </summary>
        void Show();
    }
}
