using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KingFaysalUniversity.BE.API.Controllers
{
    public class TestSwaggerController : ApiController
    {
        /// <summary>
        /// this is a test summary 
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        public string test_swagger(string test)
        {
            return "SUCCESS";
        }
    }
}
