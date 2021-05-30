using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.Application.MVC.Controllers
{
    public class CarrinhoController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
