using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_relationship_between_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_GeneralAudiences_GeneralAudienceID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieTheaters_MovieTheaterID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GeneralAudienceID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieTheaterID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "GeneralAudienceID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieTheaterID",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "MovieTheaters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "GeneralAudiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovieTheaters_MovieID",
                table: "MovieTheaters",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAudiences_MovieID",
                table: "GeneralAudiences",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralAudiences_Movies_MovieID",
                table: "GeneralAudiences",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTheaters_Movies_MovieID",
                table: "MovieTheaters",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralAudiences_Movies_MovieID",
                table: "GeneralAudiences");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieTheaters_Movies_MovieID",
                table: "MovieTheaters");

            migrationBuilder.DropIndex(
                name: "IX_MovieTheaters_MovieID",
                table: "MovieTheaters");

            migrationBuilder.DropIndex(
                name: "IX_GeneralAudiences_MovieID",
                table: "GeneralAudiences");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "MovieTheaters");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "GeneralAudiences");

            migrationBuilder.AddColumn<int>(
                name: "GeneralAudienceID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieTheaterID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GeneralAudienceID",
                table: "Movies",
                column: "GeneralAudienceID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieTheaterID",
                table: "Movies",
                column: "MovieTheaterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_GeneralAudiences_GeneralAudienceID",
                table: "Movies",
                column: "GeneralAudienceID",
                principalTable: "GeneralAudiences",
                principalColumn: "GeneralAudienceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieTheaters_MovieTheaterID",
                table: "Movies",
                column: "MovieTheaterID",
                principalTable: "MovieTheaters",
                principalColumn: "MovieTheaterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
