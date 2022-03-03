using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class create_database_and_table_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhoneNumber = table.Column<short>(type: "smallint", nullable: false),
                    ContactSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactContents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "GeneralAudiences",
                columns: table => new
                {
                    GeneralAudienceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralAudienceImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralAudienceStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralAudiences", x => x.GeneralAudienceID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieHorizontalImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieCast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieDirector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeEmbed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "MovieTheaters",
                columns: table => new
                {
                    MovieTheaterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTheaterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieTheaterStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTheaters", x => x.MovieTheaterID);
                });

            migrationBuilder.CreateTable(
                name: "NewsLetters",
                columns: table => new
                {
                    MailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetters", x => x.MailID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "GeneralAudiences");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "MovieTheaters");

            migrationBuilder.DropTable(
                name: "NewsLetters");
        }
    }
}
