using System.Collections.Generic;
using System.Web.Http;

namespace sim756.WindowsServiceRESTServerSample
{
    public class SampleController : ApiController
    {
        //http://localhost:10000/api/sample
        [HttpGet]
        public List<string> GetProductList()
        {
            List<string> list = new List<string>();
            list.Add("example 0");
            list.Add("example 1");
            list.Add("example 2");
            list.Add("example 3");
            list.Add("example 4");
            return list;
        }
    }
}