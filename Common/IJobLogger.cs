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
  public  interface IJobLogger
    {
    

        [OperationContract]

        void Logger(string status,string id,string name);

        [OperationContract]
        void LoggerProfessor(string status, string id, string name,string lastname);


        [OperationContract]
        void LoggerLesson(string status,string id, string title, DateTime dateTime, string description);


        [OperationContract]
        string Download(string uniqName);

        [OperationContract]
        List<string> Send();





    }
}
