﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class updateMovieCastTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCast_Movies_MovieId",
                table: "MovieCast");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_Movies_MovieId",
                table: "MovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_Movies_MovieId",
                table: "Trailer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "MovieCrew",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Character",
                table: "MovieCast",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePath",
                table: "Cast",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2084)",
                oldMaxLength: 2084,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cast",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Role_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_MovieId1",
                table: "Review",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_MovieId",
                table: "Purchase",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_UserId",
                table: "Purchase",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCrew_CrewId",
                table: "MovieCrew",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCrew_MovieId1",
                table: "MovieCrew",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_MovieId",
                table: "Favorite",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_Movie_MovieId",
                table: "Favorite",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_User_UserId",
                table: "Favorite",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCast_Movie_MovieId",
                table: "MovieCast",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCrew_Crew_CrewId",
                table: "MovieCrew",
                column: "CrewId",
                principalTable: "Crew",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCrew_Movie_MovieId1",
                table: "MovieCrew",
                column: "MovieId1",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_Movie_MovieId",
                table: "MovieGenre",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Movie_MovieId",
                table: "Purchase",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_User_UserId",
                table: "Purchase",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Movie_MovieId1",
                table: "Review",
                column: "MovieId1",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_Movie_MovieId",
                table: "Trailer",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_Movie_MovieId",
                table: "Favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_User_UserId",
                table: "Favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCast_Movie_MovieId",
                table: "MovieCast");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCrew_Crew_CrewId",
                table: "MovieCrew");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCrew_Movie_MovieId1",
                table: "MovieCrew");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_Movie_MovieId",
                table: "MovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Movie_MovieId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_User_UserId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movie_MovieId1",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_UserId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_Movie_MovieId",
                table: "Trailer");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropIndex(
                name: "IX_Review_MovieId1",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_UserId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_MovieId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_UserId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_MovieCrew_CrewId",
                table: "MovieCrew");

            migrationBuilder.DropIndex(
                name: "IX_MovieCrew_MovieId1",
                table: "MovieCrew");

            migrationBuilder.DropIndex(
                name: "IX_Favorite_MovieId",
                table: "Favorite");

            migrationBuilder.DropIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "MovieCrew");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "Character",
                table: "MovieCast",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePath",
                table: "Cast",
                type: "nvarchar(2084)",
                maxLength: 2084,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cast",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCast_Movies_MovieId",
                table: "MovieCast",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_Movies_MovieId",
                table: "MovieGenre",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_Movies_MovieId",
                table: "Trailer",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
