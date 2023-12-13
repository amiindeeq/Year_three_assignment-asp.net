using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using Year_three_assignment.Models;

namespace Year_three_assignment.Controllers
{
    public class studController : Controller
    {
       public IActionResult assignment()
        {
            return View();
        }
        public IActionResult lists()
        {
            List<student> modalData = new List<student>();

            student obj1 = new student();
            obj1.Id = 1;
            obj1.Name = "Mohammed Deik Hussein";
            obj1.Mobile = "634117825";
            obj1.Course = "Asp.net";
            modalData.Add(obj1);

            student obj2 = new student();
            obj2.Id = 2;
            obj2.Name = "Mohammed Ahmed";
            obj2.Mobile = "634103837";
            obj2.Course = "Java";
            modalData.Add(obj2);

            
            // Add more student objects as needed

            return View(modalData);
        }
        public IActionResult Registration()
        {
            student emptymodel = new student();
            return View(emptymodel);
        }
        [HttpPost]
        public IActionResult Create(student model)
        {
            return View(model);
        }
    }
}
