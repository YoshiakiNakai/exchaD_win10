using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using exchaD.Data;

namespace exchaD.Controllers
{
	//日記の設定を変更する
    public class SettingsController : Controller
    {
		//メンバ
		private readonly ExchaDContext5 _context;

		//コンストラクタ
		public SettingsController(ExchaDContext5 context)
		{
			_context = context;
		}

	}
}