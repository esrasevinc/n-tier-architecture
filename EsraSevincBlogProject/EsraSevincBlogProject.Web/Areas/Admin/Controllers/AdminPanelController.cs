﻿using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.Areas.Admin.Controllers
{
	public class AdminPanelController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
