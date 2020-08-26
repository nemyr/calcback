using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcBack.Classes;
using CalcBack.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {

        //[HttpPost("{param1}/{param2}/{act}")]
        [HttpGet("[action]/{param1}/{param2}/{act}")]
        public ActionResult<float> Count(float param1, float param2, string act)
        {

            ICounterFactory cFactory = new CounterFactory();
            ICounter counter = cFactory.GetCounter(act);
            
            return counter.Count(param1, param2);
        }

    }
}
