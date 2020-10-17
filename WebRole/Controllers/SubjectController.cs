using Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Repository_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace WebRole.Controllers
{
    public class SubjectController : Controller
    {
    //   static NetTcpBinding binding = new NetTcpBinding();
    //static    ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
    //    IJobReader proxy = factory.CreateChannel();

    //  static  NetTcpBinding binding1 = new NetTcpBinding();
    //  static  ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding1, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
    //static    IJobWriter proxy1 = factory1.CreateChannel();



        // GET: Subject
        public ActionResult Index()
        {
         
            return View();

        }

        public ActionResult AddSubject()
        {
         
            return View("AddSubject");

        }

        [HttpPost]
        public ActionResult AddSubject(string RowKey,string Name)
        {

            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();


            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();



            Subject subject = new Subject(RowKey) { Name = Name };

            if (!proxy.Exists(subject))
            {
                proxy1.AddSubject(subject);

                proxy2.Logger("Upisano u Table", RowKey, Name);

                //proxy2.Send(RowKey + Name);

                return RedirectToAction("Index", "Subject");

            }
        

            return RedirectToAction("AddSubject", "Subject");

        }
        public ActionResult AddProfessor()
        {

            return View("AddProfessor");

        }

        [HttpPost]
        public ActionResult AddProfessor(string RowKey, string Name,string Lastname)
        {

            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();

            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();

            Professor professor = new Professor(RowKey) { Name = Name, Surname = Lastname };

            if (!proxy.ExistsProfessor(professor))
            {
                proxy1.AddProfessor(professor);
                proxy2.LoggerProfessor("Upisano u Table", RowKey, Name,Lastname);

               // proxy2.Download(RowKey + Name);

                return RedirectToAction("Index", "Subject");

            }


            return RedirectToAction("AddProfessor", "Subject");
        }


        public ActionResult AddLesson()
        {

            return View("AddLesson");

        }

        [HttpPost]
        public ActionResult AddLesson(string RowKey,string Title,DateTime PlannedDate,string Description)
        {
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();

            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();


            Lesson l = new Lesson(RowKey) { Title = Title, PlannedDate= PlannedDate, Description= Description };

            if (!proxy.ExistsLesson(l))
            {
                proxy1.AddLesson(l);
                proxy2.LoggerLesson("Upisano u Table", RowKey, Title, PlannedDate, Description);


                return RedirectToAction("Index", "Subject");

            }


            return RedirectToAction("AddLesson", "Subject");

            
        }


    

        public ActionResult GetSubject()
        {
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            List<Subject> listaSub = new List<Subject>();



            listaSub= proxy.ReadFromDatabase();



            return View(listaSub);
        }
        public ActionResult GetProfessor()
        {
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            List<Professor> listaSub = new List<Professor>();



            listaSub = proxy.ReadFromDatabase1();



            return View(listaSub);
        }
        public ActionResult GetLesson()
        {
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            List<Lesson> listaSub = new List<Lesson>();



            listaSub = proxy.ReadFromDatabase2();



            return View(listaSub);
        }

        public ActionResult DeleteSubject(string RowKey)
        {

            //NetTcpBinding binding = new NetTcpBinding();
            //ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            //IJobReader proxy = factory.CreateChannel();

            //List<Subject> listaSub = new List<Subject>();
            //listaSub = proxy.ReadFromDatabase();

            //Subject s = listaSub.Find(st => st.RowKey.Equals(RowKey));

            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding1, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();

            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding1, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();


            proxy1.DeleteSubject(RowKey);
            proxy2.Logger("Izbrisan iz tabele", RowKey,"deleted");


            return RedirectToAction("GetSubject", "Subject");

        }
        public ActionResult DeleteProfessor(string RowKey)
        {

            //NetTcpBinding binding = new NetTcpBinding();
            //ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            //IJobReader proxy = factory.CreateChannel();

            //List<Professor> listaSub = new List<Professor>();
            //listaSub = proxy.ReadFromDatabase1();

            //Professor p = listaSub.Find(st => st.RowKey.Equals(RowKey));

            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding1, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();
            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding1, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();


            proxy1.DeleteProfessor(RowKey);
            proxy2.Logger("Izbrisan iz tabele", RowKey, "deleted");




            return RedirectToAction("GetProfessor", "Subject");

        }
        public ActionResult DeleteLesson(string RowKey)
        {

            //NetTcpBinding binding = new NetTcpBinding();
            //ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            //IJobReader proxy = factory.CreateChannel();

            //List<Lesson> listaSub = new List<Lesson>();
            //listaSub = proxy.ReadFromDatabase2();

            //Lesson p = listaSub.Find(st => st.RowKey.Equals(RowKey));

            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding1, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();
            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding1, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();


            proxy1.DeleteLesson(RowKey);
            proxy2.Logger("Izbrisan iz tabele", RowKey, "deleted");



            return RedirectToAction("GetLesson", "Subject");

        }

        [HttpPost]
        public ActionResult Edit(string RowKey,string Name)
        {

            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();
            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();

            Subject subject = new Subject(RowKey) { Name = Name };

            proxy1.Edit(subject);
            proxy2.Logger("Update u tabele", RowKey, "update "+Name);


            return RedirectToAction("GetSubject", "Subject");

        }

        
        public ActionResult EditSubject(string RowKey)
        {

            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();

            List<Subject> listaSub = new List<Subject>();
            listaSub = proxy.ReadFromDatabase();

            Subject s = listaSub.Find(st => st.RowKey.Equals(RowKey));

            ViewBag.Subject = s;

            return View();
        //    return View("Edit",s); 
           
           

          

        }
        [HttpPost]
        public ActionResult Edit1(string RowKey, string Name,string Surname)
        {

            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding1, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();

            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding1, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();


            Professor professor = new Professor(RowKey) { Name = Name , Surname=Surname};

            proxy1.EditProfessor(professor);

            proxy2.Logger("Update u tabele", RowKey, "update " + Name);

            return RedirectToAction("GetProfessor", "Subject");

        }


        public ActionResult EditProfessor(string RowKey)
        {

            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            List<Professor> listaSub = new List<Professor>();
            listaSub = proxy.ReadFromDatabase1();

            Professor s = listaSub.Find(st => st.RowKey.Equals(RowKey));

            ViewBag.Professor = s;

            return View();
            //    return View("Edit",s); 





        }
        [HttpPost]
        public ActionResult Edit2(string RowKey, string Title,DateTime PlannedDate, string Description)
        {

            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IJobWriter> factory1 = new ChannelFactory<IJobWriter>(binding1, new EndpointAddress("net.tcp://localhost:10100/InputRequest"));
            IJobWriter proxy1 = factory1.CreateChannel();

            NetTcpBinding binding2 = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory2 = new ChannelFactory<IJobLogger>(binding1, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
            IJobLogger proxy2 = factory2.CreateChannel();


            Lesson lesson = new Lesson(RowKey) { Title = Title, PlannedDate=PlannedDate, Description= Description };

            proxy1.EditLesson(lesson);

            proxy2.Logger("Update u tabele", RowKey, "update " + Title);

            return RedirectToAction("GetLesson", "Subject");

        }


        public ActionResult EditLesson(string RowKey)
        {

            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IJobReader> factory = new ChannelFactory<IJobReader>(binding, new EndpointAddress("net.tcp://localhost:10101/InputRequest"));
            IJobReader proxy = factory.CreateChannel();

            List<Lesson> listaSub = new List<Lesson>();
            listaSub = proxy.ReadFromDatabase2();

            Lesson l= listaSub.Find(st => st.RowKey.Equals(RowKey));

            ViewBag.Lesson = l;

            return View();
            //    return View("Edit",s); 





        }

   
    }
}