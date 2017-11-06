using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace sim756.WindowsServiceRESTServerSample
{

    public static class RESTServer
    {
        private static HttpSelfHostConfiguration _httpSelfHostConfiguration;
        private static HttpSelfHostServer _httpSelfHostServer;
        private static bool _stopRequested = false;

        public static void Start()
        {
            _stopRequested = false;
            _httpSelfHostConfiguration = new HttpSelfHostConfiguration("http://localhost:10000");
            _httpSelfHostConfiguration.Routes.MapHttpRoute("Windows Service REST Server Sample", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            new Task(() =>
            {
                _httpSelfHostServer = new HttpSelfHostServer(_httpSelfHostConfiguration);
                _httpSelfHostServer.OpenAsync().Start();

                //change this ASAP!!
                while (!_stopRequested)
                {
                    Thread.Sleep(1000);
                }

                _httpSelfHostServer.CloseAsync();
            }).Start();
        }

        public static void Stop()
        {
            _stopRequested = true;
        }
    }
}