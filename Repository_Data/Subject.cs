using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Data
{
  public  class Subject:TableEntity
    {
        public string IDSubject { get; set; }
        public String Name { get; set; }

        public Subject(string IDSubject)
        {
            PartitionKey = "Subject";
            RowKey = IDSubject;
            this.Name = Name;
        }

           public Subject() { }

    }
}
