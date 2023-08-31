using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {

        Message2Manager mm2 = new Message2Manager(new EfMessage2Repository());
        public IActionResult InBox()
        {
            int id = 1;
            var values = mm2.GetInboxByWriter(id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = mm2.GetByID(id);
            return View(value);
        }
    }
}
