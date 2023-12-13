using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace tez.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact p)
		{
			p.ContacDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ContacStatus = true;
			cm.ContactAdd(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
