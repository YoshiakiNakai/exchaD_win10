using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using exchaD.Models;


namespace exchaD.Data
{
	//DB定義
	public class ExchaDContext : DbContext
	{
		//コンストラクタ
		public ExchaDContext(DbContextOptions<ExchaDContext> options)
			: base(options)
		{
		}

		//テーブル定義
		public DbSet<Diary> diaries;
		public DbSet<Leaf> leaves;
		public DbSet<Appli> appli;
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//複合主キーの定義
			modelBuilder.Entity<Leaf>()
				.HasKey(o => new { o.diaryId, o.time });

			modelBuilder.Entity<Appli>()
				.HasKey(o => new { o.diaryId, o.leafTime });

			//外部制約の定義
			modelBuilder.Entity<Leaf>()	//制約される側
				.HasOne(leaf => leaf.diary) //Navigation Property（制約される側）
				.WithMany(diary => diary.leaves)	//Navigation Property（制約する側）
				.HasForeignKey(leaf => new { leaf.diaryId });   //foreign key

			modelBuilder.Entity<Appli>() //制約される側
				.HasOne(a => a.leaf) //Navigation Property（制約される側）
				.WithMany(l => l.appli)    //Navigation Property（制約する側）
				.HasForeignKey(a => new { a.diaryId, a.leafTime });   //foreign key
		}
	}
}
