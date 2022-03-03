﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220303120900_create_database_and_table_mig")]
    partial class create_database_and_table_mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutID"), 1L, 1);

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactID"), 1L, 1);

                    b.Property<string>("ContactContents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("ContactPhoneNumber")
                        .HasColumnType("smallint");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.GeneralAudience", b =>
                {
                    b.Property<int>("GeneralAudienceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GeneralAudienceID"), 1L, 1);

                    b.Property<string>("GeneralAudienceImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GeneralAudienceStatus")
                        .HasColumnType("bit");

                    b.HasKey("GeneralAudienceID");

                    b.ToTable("GeneralAudiences");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"), 1L, 1);

                    b.Property<string>("MovieCast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieHorizontalImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("MovieStatus")
                        .HasColumnType("smallint");

                    b.Property<string>("YoutubeEmbed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MovieTheater", b =>
                {
                    b.Property<int>("MovieTheaterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieTheaterID"), 1L, 1);

                    b.Property<string>("MovieTheaterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MovieTheaterStatus")
                        .HasColumnType("bit");

                    b.HasKey("MovieTheaterID");

                    b.ToTable("MovieTheaters");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewsLetter", b =>
                {
                    b.Property<int>("MailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MailID"), 1L, 1);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MailStatus")
                        .HasColumnType("bit");

                    b.HasKey("MailID");

                    b.ToTable("NewsLetters");
                });
#pragma warning restore 612, 618
        }
    }
}