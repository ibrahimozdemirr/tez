using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace tez.ViewComponents.Blog
{
	public class WriterLastBlog: ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogByWriter(1);
			return View(values);
		}
	}
}
