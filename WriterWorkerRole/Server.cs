using Common;
using Microsoft.WindowsAzure.ServiceRuntime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WriterWorkerRole
{
  public  class Server
    {
        private ServiceHost _serviceHostExternal;
        private String _externalEndpointName = "InputRequest";

        public Server()
        {
            //External
            RoleInstanceEndpoint inputEndPoint = RoleEnvironment.CurrentRoleInstance.InstanceEndpoints["InputRequest"];
            string endpoint = String.Format("net.tcp://{0}/{1}", inputEndPoint.IPEndpoint, _externalEndpointName);

            _serviceHostExternal = new ServiceHost(typeof(ServerProvider));
            NetTcpBinding binding = new NetTcpBinding();
            _serviceHostExternal.AddServiceEndpoint(typeof(IJobWriter), binding, endpoint);
        }
        public void Open()
        {
            try
            {
                _serviceHostExternal.Open();
                Trace.TraceInformation(String.Format("Host for {0} endpoint type opened successfully at {1}", _externalEndpointName, DateTime.Now));
            }
            catch (Exception e)
            {
                Trace.TraceInformation("Host open error for {0} endpoint type. Error message is: {1}.", _externalEndpointName, e.Message);
            }
        }

        public void Close()
        {
            try
            {
                _serviceHostExternal.Close();

                Trace.TraceInformation(String.Format("Host for {0} endpoint type closed successfully at {1}.", _externalEndpointName, DateTime.Now));
            }
            catch (Exception e)
            {
                Trace.TraceInformation("Host close error for {0} endpoint type. Error message is: {1}.", _externalEndpointName, e.Message);
            }
        }

    }
}

