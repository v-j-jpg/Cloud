using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Data
{
  public  class Lesson:TableEntity
    {
		private string idLesson;

		public string IDLesson
		{
			get { return idLesson; }
			set { idLesson = value; }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}
		private DateTime plannedDate;

		public DateTime PlannedDate
		{
			get { return plannedDate; }
			set { plannedDate = value; }
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		public Lesson()
		{
		}

		public Lesson(string iDLesson)
		{
			PartitionKey = "Lesson";
			RowKey = iDLesson;
			this.description = Description;
			this.title = Title;
			this.plannedDate = PlannedDate;
		}
	}
}
