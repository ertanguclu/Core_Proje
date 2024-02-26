using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Core_Proje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager userManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(liste);
            return Json(values);
        }
        private static List<class0> liste = new List<class0>()
        {
            new class0{ID=1,Ad="Ali"},
            new class0{ID=1,Ad="Ayşe"},
            new class0{ID=1,Ad="Esra"},
        };
    }

    public class class0
    {
        public int ID { get; set; }
        public string Ad { get; set; }
    }
}
