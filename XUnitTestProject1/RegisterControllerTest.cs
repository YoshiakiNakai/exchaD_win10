using System;
using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.InMemory;

using exchaD.Data;
using exchaD.Controllers;

namespace XUnitTestProject1
{
	public class RegisterControllerTest
	{
		RegisterController ctr;
		ExchaDContext5 context;
		
		public RegisterControllerTest()
		{
			//DB���쐬����
			var options = new DbContextOptionsBuilder<ExchaDContext5>()
				.UseInMemoryDatabase(databaseName: "DbName")
				.Options;
			context = new ExchaDContext5(options);

			//�R���g���[������
			ctr = new RegisterController(context);
		}

		[Fact]
		public async void sample()
		{
			IActionResult r = await ctr.Index("id", "pass", "note", PUBLICITY.pub);
		}

		[Fact]
		public async void Diaries�e�[�u���ۑ��e�X�g()
		{
			Diary diary = new Diary("id", "pass", "note", DateTime.Now, PUBLICITY.pub, EXCHA.disable, WRITA.able, DateTime.Now, null);
			context.diaries.Add(diary);    //SQL���̗\��
			await context.SaveChangesAsync();  //SQL���̎��s
		}
	}
}
