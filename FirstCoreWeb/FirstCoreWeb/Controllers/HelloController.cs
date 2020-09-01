using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreWeb.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "Hello String Index View";
        }

        public string Welcome(string name)
        {
            return $"Hello {name}";
        }
    }
}
