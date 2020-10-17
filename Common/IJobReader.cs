using Repository_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
 public   interface IJobReader
    {
        [OperationContract]
        List<Subject> ReadFromDatabase();

        [OperationContract]
        List<Professor> ReadFromDatabase1();

        [OperationContract]
        List<Lesson> ReadFromDatabase2();

        [OperationContract]
        bool Exists(Subject s);

        [OperationContract]
        bool ExistsProfessor(Professor p);

        [OperationContract]
        bool ExistsLesson(Lesson s);


    }
}
