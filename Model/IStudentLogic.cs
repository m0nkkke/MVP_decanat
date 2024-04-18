using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IStudentLogic
    {
        /// <summary>
        /// Метод добавления студента
        /// </summary>
        /// <param name="newStudentParams">данные студента</param>
        void AddStudent(List<string> newStudentParams);

        /// <summary>
        /// Метод удаления студента
        /// </summary>
        /// <param name="id">айди студента</param>
        void DeleteStudent(int id);

        /// <summary>
        /// Метод получения информации о всех студентов
        /// </summary>
        void GetAllStudents();

        /// <summary>
        /// Событие получения о всех студентов
        /// </summary>
        event EventHandler<GetStudentArgs> EventStudentsGet;
    }
}
