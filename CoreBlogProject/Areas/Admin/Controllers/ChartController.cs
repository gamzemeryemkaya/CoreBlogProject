using CoreBlogProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 11
            });

            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 15
            });

            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5
            });

            list.Add(new CategoryClass
            {
                categoryname = "Sinema",
                categorycount = 3
            });

            return Json(new { jsonlist = list });
        }
    }
}
