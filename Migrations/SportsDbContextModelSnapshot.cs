﻿// <auto-generated />
using System;
using A2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A2.Migrations
{
    [DbContext(typeof(SportsDbContext))]
    partial class SportsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("A2.Models.Fan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Fan", (string)null);
                });

            modelBuilder.Entity("A2.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"), 1L, 1);

                    b.Property<string>("FileName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SportClubId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsId");

                    b.HasIndex("SportClubId");

                    b.ToTable("news", (string)null);
                });

            modelBuilder.Entity("A2.Models.SportClub", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("SportClub", (string)null);
                });

            modelBuilder.Entity("A2.Models.Subscription", b =>
                {
                    b.Property<int>("FanId")
                        .HasColumnType("int");

                    b.Property<string>("SportClubId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FanId", "SportClubId");

                    b.HasIndex("SportClubId");

                    b.ToTable("Subscription", (string)null);
                });

            modelBuilder.Entity("A2.Models.News", b =>
                {
                    b.HasOne("A2.Models.SportClub", "SportsClub")
                        .WithMany("News")
                        .HasForeignKey("SportClubId");

                    b.Navigation("SportsClub");
                });

            modelBuilder.Entity("A2.Models.Subscription", b =>
                {
                    b.HasOne("A2.Models.Fan", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("FanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("A2.Models.SportClub", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("SportClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("A2.Models.Fan", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("A2.Models.SportClub", b =>
                {
                    b.Navigation("News");

                    b.Navigation("Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
