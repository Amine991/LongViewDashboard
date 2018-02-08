using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExampleNetCoreAnJS
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }

        public int Add(int num1, int num2)
    {

      int result = num1 + num2;
      return result;
    }

    public int Sub(int num1, int num2)
    {
      int result = num1 - num2;
      return result;

    }
      
        
    }
}
