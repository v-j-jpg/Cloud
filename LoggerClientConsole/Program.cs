using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LoggerClientConsole
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logg initialized...");

            var binding = new NetTcpBinding();
            ChannelFactory<IJobLogger> factory = new ChannelFactory<IJobLogger>(binding, new EndpointAddress("net.tcp://localhost:10102/InputRequest"));
           // int brojac = 0;
            while (true)
            {
                IJobLogger proxy = factory.CreateChannel();//Kreiramo u while petlji da ne bi stalno nulta instanca dobijala posao
                List<string> listaBlob = proxy.Send();

                for (int i = 0; i < listaBlob.Count; i++)
                {
                    //brojac++;
                    string n = proxy.Download(listaBlob[i]);
                    Console.WriteLine(n);
                }
                


            }
        }
    }
}
