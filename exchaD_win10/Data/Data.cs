using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

//DB用テーブル各行のデータ クラス宣言。
namespace exchaD.Data
{
	//日記データ
	public class Diary
	{
		public string Id;   //主キー	//慣例により「なんたらId」はキーとなる。注意。
		public string pass;
		public string note;
		public DateTime last;
		public int pub;
		public int excha;
		public int writa;
		public DateTime retTime;
		public string exid;

		//Navigation Property
		public List<Leaf> leaves;   //leavesは、制約される。
	}

	//日記の１ページ１ページ
	public class Leaf
	{
		public string diaryId;
		public DateTime time;
		public string title;
		public string contents;
		public string exid;
		public string comment;

		//Navigation Property
		public Diary diary;			//Diaryに、制約される。
		public List<Appli> appli;   //appliは、制約される。
	}

	//交換申し込みの記録
	public class Appli
	{
		public string diaryId;
		public DateTime leafTime;
		public string apid;
		public int accept;

		//Navigation Property
		public Leaf leaf;         //Leafに、制約される。
	}
}
