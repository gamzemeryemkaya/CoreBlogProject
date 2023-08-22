using BusinessLayer.Concrete;
using BusinessLayer.ValidationsRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreBlogProject.Controllers
{
    public class RegisterController : Controller
    {
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer p)
		{
			//validasyonların geçerliliğini kontrol etmek için
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(p);

			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme Test";
				wm.TAdd(p); //parametreden gelen değeri wm içine ekler
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
