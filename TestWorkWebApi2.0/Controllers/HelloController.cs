using TestWorkWebApi2._0.Services.Interfaces;
using System.Web.Http;

namespace TestWorkWebApi2._0.Controllers
{
    public class HelloController : ApiController
    {
        private readonly IGreeter greeter;

        public HelloController(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        [HttpGet]
        public string Get()
        {
            string greeting = greeter.SayHello(nameof(HelloController));

            return greeting;
        }
    }
}
