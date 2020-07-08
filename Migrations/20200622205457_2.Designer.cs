﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project.Models;

namespace project.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200622205457_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("project.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("MessageId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("project.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("project.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserLevel");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("project.Models.Comment", b =>
                {
                    b.HasOne("project.Models.Message", "Maker")
                        .WithMany("Comments")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("project.Models.User", "Writer")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("project.Models.Message", b =>
                {
                    b.HasOne("project.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
