using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using exchaD.Data;

namespace exchaD.Controllers
{
	//ページ表示処理を担う
    public class PagesController : Controller
    {
		//メンバ
		private readonly ExchaDContext5 _context;
		
		//コンストラクタ
		public PagesController(ExchaDContext5 context)
		{
			_context = context;
		}

		//デフォルトのアクション----------------------------------------
		public IActionResult Index()
		{
			return View("~/Views/Pages/top.cshtml");
		}
		//---------------------------------------------------------------
		public IActionResult diaries()
		{
			return View();
		}
		//---------------------------------------------------------------
		public IActionResult diary()
		{
			return View();
		}
		//---------------------------------------------------------------
		public IActionResult elect()
		{
			return View();
		}
		//---------------------------------------------------------------
		public IActionResult login()
		{
			return View();
		}
		//---------------------------------------------------------------
		public IActionResult my()
		{
			return View();
		}
		//---------------------------------------------------------------
		public IActionResult register()
		{
			return View();
		}
		//---------------------------------------------------------------
		public IActionResult top()
		{
			return View();
		}
		//---------------------------------------------------------------
		public IActionResult wr()
		{
			return View();
		}
	}
}