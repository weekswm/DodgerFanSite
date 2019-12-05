﻿// <auto-generated />
using System;
using DodgersFanSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DodgersFanSite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DodgersFanSite.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<int?>("BookID1");

                    b.Property<DateTime>("PubDate");

                    b.Property<string>("Title");

                    b.HasKey("BookID");

                    b.HasIndex("BookID1");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DodgersFanSite.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText");

                    b.Property<int?>("CommenterUserID");

                    b.Property<int?>("StoryID");

                    b.HasKey("CommentID");

                    b.HasIndex("CommenterUserID");

                    b.HasIndex("StoryID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DodgersFanSite.Models.Link", b =>
                {
                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc");

                    b.Property<int?>("LinkID1");

                    b.Property<string>("Website");

                    b.HasKey("LinkID");

                    b.HasIndex("LinkID1");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("DodgersFanSite.Models.Story", b =>
                {
                    b.Property<int>("StoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("StoryTellerUserID");

                    b.Property<string>("StoryText");

                    b.Property<string>("Title");

                    b.HasKey("StoryID");

                    b.HasIndex("StoryTellerUserID");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("DodgersFanSite.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DodgersFanSite.Models.Book", b =>
                {
                    b.HasOne("DodgersFanSite.Models.Book")
                        .WithMany("Books")
                        .HasForeignKey("BookID1");
                });

            modelBuilder.Entity("DodgersFanSite.Models.Comment", b =>
                {
                    b.HasOne("DodgersFanSite.Models.User", "Commenter")
                        .WithMany("Comments")
                        .HasForeignKey("CommenterUserID");

                    b.HasOne("DodgersFanSite.Models.Story")
                        .WithMany("Comments")
                        .HasForeignKey("StoryID");
                });

            modelBuilder.Entity("DodgersFanSite.Models.Link", b =>
                {
                    b.HasOne("DodgersFanSite.Models.Link")
                        .WithMany("Links")
                        .HasForeignKey("LinkID1");
                });

            modelBuilder.Entity("DodgersFanSite.Models.Story", b =>
                {
                    b.HasOne("DodgersFanSite.Models.User", "StoryTeller")
                        .WithMany("Stories")
                        .HasForeignKey("StoryTellerUserID");
                });
#pragma warning restore 612, 618
        }
    }
}
