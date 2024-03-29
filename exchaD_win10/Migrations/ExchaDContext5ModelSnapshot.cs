﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exchaD.Data;

namespace exchaD_win10.Migrations
{
    [DbContext(typeof(ExchaDContext5))]
    partial class ExchaDContext5ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("exchaD.Data.Appli", b =>
                {
                    b.Property<string>("diaryId")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("leafTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("accept")
                        .HasColumnType("int");

                    b.Property<string>("apid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("diaryId", "leafTime");

                    b.ToTable("appli");
                });

            modelBuilder.Entity("exchaD.Data.Diary", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("excha")
                        .HasColumnType("int");

                    b.Property<string>("exid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("last")
                        .HasColumnType("datetime2");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("pub")
                        .HasColumnType("int");

                    b.Property<DateTime>("retTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("writa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("diaries");
                });

            modelBuilder.Entity("exchaD.Data.Leaf", b =>
                {
                    b.Property<string>("diaryId")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(65535);

                    b.Property<string>("contents")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(65535);

                    b.Property<string>("exid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("diaryId", "time");

                    b.ToTable("leaves");
                });

            modelBuilder.Entity("exchaD.Data.Appli", b =>
                {
                    b.HasOne("exchaD.Data.Leaf", "leaf")
                        .WithMany("appli")
                        .HasForeignKey("diaryId", "leafTime")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("exchaD.Data.Leaf", b =>
                {
                    b.HasOne("exchaD.Data.Diary", "diary")
                        .WithMany("leaves")
                        .HasForeignKey("diaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
