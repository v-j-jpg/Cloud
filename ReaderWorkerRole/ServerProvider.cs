using Common;
using Repository_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderWorkerRole
{
   public class ServerProvider:IJobReader
    {
        Repository repo = new Repository();

        public bool Exists(Subject s)
        {
            return repo.Exists(s);
        }

        public bool ExistsLesson(Lesson s)
        {
            return repo.ExistsLesson(s);
        }

        public bool ExistsProfessor(Professor p)
        {
            return repo.ExistsProfessor(p);
        }

        public List<Subject> ReadFromDatabase()
        {
           return repo.ReadAllSubjects().ToList();
        }

        List<Professor> IJobReader.ReadFromDatabase1()
        {
            return repo.ReadAllProfessor().ToList();
        }

        List<Lesson> IJobReader.ReadFromDatabase2()
        {
            return repo.ReadAllLesson().ToList();
        }

    }
}
