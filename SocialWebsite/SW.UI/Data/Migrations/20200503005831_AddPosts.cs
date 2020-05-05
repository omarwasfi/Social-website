using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SW.UI.Migrations
{
    public partial class AddPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhotoPosts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    PhotoLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextPosts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoPosts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    VideoLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonPhotoPost",
                columns: table => new
                {
                    PersonId = table.Column<string>(nullable: false),
                    PhotoPostId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPhotoPost", x => new { x.PhotoPostId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_PersonPhotoPost_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonPhotoPost_PhotoPosts_PhotoPostId",
                        column: x => x.PhotoPostId,
                        principalTable: "PhotoPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonTextPost",
                columns: table => new
                {
                    PersonId = table.Column<string>(nullable: false),
                    TextPostId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTextPost", x => new { x.TextPostId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_PersonTextPost_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonTextPost_TextPosts_TextPostId",
                        column: x => x.TextPostId,
                        principalTable: "TextPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonVideoPost",
                columns: table => new
                {
                    PersonId = table.Column<string>(nullable: false),
                    VideoPostId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonVideoPost", x => new { x.VideoPostId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_PersonVideoPost_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonVideoPost_VideoPosts_VideoPostId",
                        column: x => x.VideoPostId,
                        principalTable: "VideoPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonPhotoPost_PersonId",
                table: "PersonPhotoPost",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonTextPost_PersonId",
                table: "PersonTextPost",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonVideoPost_PersonId",
                table: "PersonVideoPost",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonPhotoPost");

            migrationBuilder.DropTable(
                name: "PersonTextPost");

            migrationBuilder.DropTable(
                name: "PersonVideoPost");

            migrationBuilder.DropTable(
                name: "PhotoPosts");

            migrationBuilder.DropTable(
                name: "TextPosts");

            migrationBuilder.DropTable(
                name: "VideoPosts");
        }
    }
}
