using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreempty.Controllers
{
    // /about

    [Route("[controller]/[action]")]
    public class AboutController
    {   
        public String Name()
        {
            return "Ander Conal";
        }

        public String Company()
        {
            return "Plain Concepts";
        }
    }
}
