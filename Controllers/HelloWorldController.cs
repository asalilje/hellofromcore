using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloFromCore.Controllers
{
    [Route("hello")]
    public class HelloWorldController : Controller
    {
        public IActionResult Get()
        {
            return Ok("Hello world from Core on a Raspi!");
        }

    }

}
