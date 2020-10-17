using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Data
{
   public class Repository
    {
       
            private CloudStorageAccount _storageAccount;
            private CloudTable _table;

            public Repository()
            {
                _storageAccount =CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("ConnectionString"));
                CloudTableClient tableClient = new CloudTableClient(new Uri(_storageAccount.TableEndpoint.AbsoluteUri), _storageAccount.Credentials);
         
                _table = tableClient.GetTableReference("SubjectTable");

                _table.CreateIfNotExists();
            }

        public IQueryable<Subject> ReadAllSubjects()
        {
            var results = from g in _table.CreateQuery<Subject>()
                          where g.PartitionKey == "Subject"
                          select g;
            return results;

        }
        public IQueryable<Professor> ReadAllProfessor()
        {
            var results = from g in _table.CreateQuery<Professor>()
                          where g.PartitionKey == "Professor"
                          select g;
            return results;

        }
        public IQueryable<Lesson> ReadAllLesson()
        {
            var results = from g in _table.CreateQuery<Lesson>()
                          where g.PartitionKey == "Lesson"
                          select g;
            return results;

        }

        public void AddSubject(Subject newSubject)
            {
            // Samostalni rad: izmestiti tableName u konfiguraciju servisa.
            TableOperation insertOperation = TableOperation.InsertOrReplace(newSubject);
            _table.Execute(insertOperation);

        }
        public void AddProfessor(Professor professor)
        {
            // Samostalni rad: izmestiti tableName u konfiguraciju servisa.
            TableOperation insertOperation = TableOperation.InsertOrReplace(professor);
            _table.Execute(insertOperation);
        }

        public void AddLesson(Lesson lesson)
        {
            // Samostalni rad: izmestiti tableName u konfiguraciju servisa.
            TableOperation insertOperation = TableOperation.InsertOrReplace(lesson);
            _table.Execute(insertOperation);
        }

        public void DeleteSubject(string RowKey)
        {

            Subject s= ReadAllSubjects().ToList().Find(st => st.RowKey.Equals(RowKey)); 


            // Samostalni rad: izmestiti tableName u konfiguraciju servisa.
            TableOperation insertOperation = TableOperation.Delete(s);
            _table.Execute(insertOperation);


        }
        public void DeleteProfessor(string RowKey)
        {

            Professor s = ReadAllProfessor().ToList().Find(st => st.RowKey.Equals(RowKey));


            // Samostalni rad: izmestiti tableName u konfiguraciju servisa.
            TableOperation insertOperation = TableOperation.Delete(s);
            _table.Execute(insertOperation);

        }
        public void DeleteLesson(string RowKey)
        {
            Lesson s = ReadAllLesson().ToList().Find(st => st.RowKey.Equals(RowKey));


            // Samostalni rad: izmestiti tableName u konfiguraciju servisa.
            TableOperation insertOperation = TableOperation.Delete(s);
            _table.Execute(insertOperation);


        }
        public bool Exists(Subject ss)
        {
            Subject s = ReadAllSubjects().ToList().Find(st => st.RowKey.Equals(ss.RowKey));

            if (s!=null)
            {
                return true;
            }

            return false;

        }
        public bool ExistsProfessor(Professor ss)
        {
            Professor s = ReadAllProfessor().ToList().Find(st => st.RowKey.Equals(ss.RowKey));

            if (s != null)
            {
                return true;
            }

            return false;

        }
        public bool ExistsLesson(Lesson ss)
        {
            Lesson s = ReadAllLesson().ToList().Find(st => st.RowKey.Equals(ss.RowKey));

            if (s != null)
            {
                return true;
            }

            return false;

        }
        public void EditSubject(Subject s)
        {
           
                AddSubject(s);
            

          

        }
        public void EditProfessor(Professor p)
        {
                AddProfessor(p);
            
        }
        public void EditLesson(Lesson l)
        {
  
          
                AddLesson(l);
            


        }

    }
}
