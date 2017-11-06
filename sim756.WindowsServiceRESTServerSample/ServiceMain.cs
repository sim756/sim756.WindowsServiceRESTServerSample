using System.ServiceProcess;

namespace sim756.WindowsServiceRESTServerSample
{
    public partial class ServiceMain : ServiceBase
    {
        public ServiceMain()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            RESTServer.Start();
        }

        protected override void OnStop()
        {
            RESTServer.Stop();
        }
    }
}