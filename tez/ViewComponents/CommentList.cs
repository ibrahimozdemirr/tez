using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tez.Models;

namespace tez.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					Id = 1,
					UserName = "İbrahim"
				},
				new UserComment
				{
					Id = 2,
					UserName = "Bilal",
				},
				new UserComment
				{
					Id = 3,
					UserName = "Saku",
				},
			};
			return View(commentValues);
		}
	}
}
