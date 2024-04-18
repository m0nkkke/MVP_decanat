using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewWF;

namespace Presenter
{
    /// <summary>
    /// Presenter для формы добавления
    /// </summary>
    public class PresenterAdd
    {
        private IStudentLogic StudentLogic = null;
        private IAdd AddForm = null;

        public PresenterAdd(StudentLogic studentLogic, IAdd addForm)
        {
            StudentLogic = studentLogic;
            AddForm = addForm;

            AddForm.AddStudentEvent += ViewAddStudent; 
        }

        private void ViewAddStudent(object sender, List<string> e)
        {
            StudentLogic.AddStudent(e);
        }
    }
}
