//Jovann Contreras
//Date 10/26/2022
//Peer Reviewed by:Nicolas Acosta Looking at the code it looks very simple but works I like the code that is written because it looks easy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OddOrEven.Models;

namespace ContrerasJOddOrEvenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddEvenController : ControllerBase
    {
        [HttpGet]
        [Route("OddrEven")]

        public string OddOrEvenChallenge(OddOrEvenModel item)
        {
              if (item.num1 % 2 == 0)
            {
                return $"{item.num1} is even";
            }
            else
            {
                return $"{item.num1} is odd";
            }


        }
    }
}