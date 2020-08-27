using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet("[action]/{param1}/{param2}")]
        public ActionResult<float> Add(float param1, float param2)
        {
            return param1 + param2;
        }

        [HttpGet("[action]/{param1}/{param2}")]
        public ActionResult<float> Sub(float param1, float param2)
        {
            return param1 - param2;
        }

        [HttpGet]
        public ActionResult<string> Index() {
            return "noting here";
        }
    }
}
