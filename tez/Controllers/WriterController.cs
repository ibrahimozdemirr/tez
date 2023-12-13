using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace tez.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult WriterProfile() {

			return View();
		}
		public IActionResult WriterMail()
		{
			return View();
		}
		public IActionResult Test()
		{
			return View();
		}
		public PartialViewResult WriterNavBarPartial()
		{
			return PartialView();
		}
		public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}
		[AllowAnonymous]
		[HttpGet]
		public IActionResult WriterEditProfile()
		{
			var writervalues = wm.TGetById(1);
			return View(writervalues);
		}
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
		{
			WriterValidator vl = new WriterValidator();
			ValidationResult results = vl.Validate(p);
			if (results.IsValid)
			{
				wm.TUpdate(p);
				return RedirectToAction("Index", "Dashboard");

			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

            return View();
			
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(Writer p)
        {
			wm.TAdd(p);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
