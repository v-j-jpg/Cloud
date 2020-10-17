using Common;
using Repository_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerWorkerRole
{
    public class ServerProvider : IJobLogger
    {
        BlobHelper blobHelper = new BlobHelper();
       

        public string Download(string uniqName)
        {
            return blobHelper.DownloadFromBlob(uniqName);
        }

        public void Logger(string status, string id, string name)
        {
            blobHelper.UploadToBlob(id + name, status + "|" + id + "|" + name);
        }

        public void LoggerLesson(string status, string id, string title, DateTime dateTime, string description)
        {
            blobHelper.UploadToBlob(id + title, status + "|" + title + "|" + dateTime + "|" + description);
        }

        public void LoggerProfessor(string status, string id, string name, string lastname)
        {
            blobHelper.UploadToBlob(id + name, status + "|" + id + "|" + name + "|" + lastname);
        }

        public List<string> Send()
        {
            return blobHelper.ListBlobsFlatListing();
        }

    }
}
