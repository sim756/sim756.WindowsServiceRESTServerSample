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
            return new List<string>
            {
                "example 0",
                "example 1",
                "example 2",
                "example 3",
                "example 4"
            };
        }
    }
}