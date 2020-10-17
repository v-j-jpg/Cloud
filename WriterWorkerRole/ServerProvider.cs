using Common;
using Repository_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterWorkerRole
{
  public  class ServerProvider: IJobWriter
    {

        Repository repo = new Repository();

        public void AddSubject(Subject s)
        {

            repo.AddSubject(s);

        }

        public void AddProfessor(Professor s)
        {

            repo.AddProfessor(s);

        }
        public void AddLesson(Lesson s)
        {

            repo.AddLesson(s);

        }

        public void DeleteSubject(string RowKey)
        {
            repo.DeleteSubject(RowKey);
        }

        public void DeleteProfessor(string RowKey)
        {
            repo.DeleteProfessor(RowKey);
        }

        public void DeleteLesson(string RowKey)
        {
            repo.DeleteLesson(RowKey);
        }

        public void Edit(Subject s)
        {
            repo.EditSubject(s);
        }

        public void EditProfessor(Professor p)
        {
            repo.EditProfessor(p);
        }

        public void EditLesson(Lesson l)
        {
            repo.EditLesson(l);
        }
    }
}
