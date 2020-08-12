using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("web")]
    public class IndexController : Controller
    {

        [Route("index")]
        public IActionResult Index()
        {
            ViewData["name"] = "韩明富";
            ViewData["sex"] = "男";
            ViewData["age"] = 18;

            ViewBag.Name = "侯静";
            ViewBag.Sex = "女";
            ViewBag.Age = 17;

            Student student = new Student() { Name = "二秃子", Age = 30, Sex = "不确定" };
            return View(student);

        }
    }


    public class Student
    {
        [DisplayName("uName")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}
