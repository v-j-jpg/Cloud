using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Data
{
   public class Professor:TableEntity
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string surname;

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}
		private string idProfessor;

		public string IDProfessor
		{
			get { return idProfessor; }
			set { idProfessor = value; }
		}

		public Professor()
		{
		}

		public Professor(string idProfessor)
		{

			PartitionKey = "Professor";
			RowKey = idProfessor;
			this.Name = Name;
			this.Surname = Surname;

		}
	}
}
