using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewWF
{
    /// <summary>
    /// интерфейс главной формы
    /// </summary>
    public interface IMain
    {
        /// <summary>
        /// событие открытия формы добавления
        /// </summary>
        event EventHandler<EventArgs> showAddForm;

        /// <summary>
        /// событие удаления студента
        /// </summary>
        event EventHandler<int> deleteStudentEvent;

        /// <summary>
        /// метод загрузки списка студентов
        /// </summary>
        /// <param name="students"></param>
        void loadStudents(List<string> students);

        /// <summary>
        /// метод загрузки формы
        /// </summary>
        void Show();
    }
}
