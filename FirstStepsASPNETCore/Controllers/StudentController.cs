using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstStepsASPNETCore.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is the Student Controller";
        }
    }
}