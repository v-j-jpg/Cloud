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
    public interface IJobWriter
    {
        [OperationContract]
        void AddSubject(Subject s);

        [OperationContract]
        void AddProfessor(Professor s);

        [OperationContract]
        void AddLesson(Lesson l);


        [OperationContract]
        void DeleteSubject(string RowKey);

        [OperationContract]
        void DeleteProfessor(string RowKey);

        [OperationContract]
        void DeleteLesson(string RowKey);


        [OperationContract]
        void Edit(Subject s);

        [OperationContract]
        void EditProfessor(Professor p);

        [OperationContract]
        void EditLesson(Lesson l);


    }
}
