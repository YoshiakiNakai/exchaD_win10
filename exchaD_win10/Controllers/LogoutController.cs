using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using exchaD.Data;

namespace exchaD.Controllers
{
	//ログアウト処理を担う
    public class LogoutController : Controller
    {
		//メンバ
		private readonly ExchaDContext5 _context;

		//コンストラクタ
		public LogoutController(ExchaDContext5 context)
		{
			_context = context;
		}

		//デフォルトのアクション
		public IActionResult Index()
		{
			return Redirect("/");
		}
	}
}