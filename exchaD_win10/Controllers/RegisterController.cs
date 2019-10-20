using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


using exchaD.Data;

namespace exchaD.Controllers
{
	//登録処理を担う
    public class RegisterController : Controller
    {
		//メンバ
		private readonly ExchaDContext5 _context;

		//コンストラクタ
		public RegisterController(ExchaDContext5 context)
		{
			_context = context;
		}

		//デフォルトのアクション
		public IActionResult Index()
		{
			return Redirect("/Pages/my/");
		}

		//日記の作成
		[HttpPost]
		[AutoValidateAntiforgeryToken]
//		public async Task<IActionResult> Index([Bind("Id, pass, note, pub")] Diary 
		public async Task<IActionResult> Index(string Id, string pass, string note, PUBLICITY pub)
		{
			//有効か
			if (ModelState.IsValid)
			{
				Diary diary = new Diary(Id, pass, note, DateTime.Now, pub, EXCHA.disable, WRITA.able, DateTime.Now, null);

				_context.diaries.Add(diary);	//SQL文の予約
				await _context.SaveChangesAsync();	//SQL文の実行
				return View("~/Views/Pages/login.cshtml");
			}//無効のとき
			else
			{
				return View("~/Views/Pages/register.cshtml");
			}
		}
	}
}