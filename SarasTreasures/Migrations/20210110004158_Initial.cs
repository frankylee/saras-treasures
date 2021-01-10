using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SarasTreasures.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 254, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    StoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Text = table.Column<string>(maxLength: 8000, nullable: false),
                    Filename = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.StoryID);
                    table.ForeignKey(
                        name: "FK_Story_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "LastName", "Username" },
                values: new object[] { 1, "srosenblum@aol.com", "Sally", "Rosenblum", "mrs.rosenblum" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "LastName", "Username" },
                values: new object[] { 2, "paula_parrot@yahoo.com", "Paula", "Parrot", "paula_parrot" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "LastName", "Username" },
                values: new object[] { 3, "winelover387@hotmail.com", "Margot", "Merlot", "margotmerlot" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryID", "Date", "Filename", "Text", "Title", "UserID" },
                values: new object[] { 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "zxyz.jpg", @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Vestibulum sed arcu non odio euismod lacinia. Sed vulputate odio ut enim. Sem et tortor consequat id porta nibh venenatis cras. Turpis egestas pretium aenean pharetra magna. Fusce id velit ut tortor. Sit amet consectetur adipiscing elit ut aliquam. Feugiat in fermentum posuere urna nec.

                        Ut morbi tincidunt augue interdum velit euismod. Duis at consectetur lorem donec massa sapien faucibus. Nisl condimentum id venenatis a condimentum vitae. Justo eget magna fermentum iaculis. Tempus iaculis urna id volutpat. Et malesuada fames ac turpis egestas. Imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper.", "Papaya", 1 });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryID", "Date", "Filename", "Text", "Title", "UserID" },
                values: new object[] { 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "zxyz.jpg", @"Est ultricies integer quis auctor elit sed vulputate. Dolor morbi non arcu risus quis varius quam quisque. Vitae congue eu consequat ac felis. Ut consequat semper viverra nam libero justo. In tellus integer feugiat scelerisque varius morbi enim nunc. Bibendum enim facilisis gravida neque convallis a cras semper auctor. Neque convallis a cras semper. Risus sed vulputate odio ut enim blandit volutpat.

                        Sagittis eu volutpat odio facilisis mauris sit amet. Quam vulputate dignissim suspendisse in est ante. Leo vel orci porta non pulvinar neque laoreet suspendisse. Auctor neque vitae tempus quam pellentesque nec. Risus nullam eget felis eget nunc lobortis mattis aliquam. Dignissim enim sit amet venenatis urna cursus eget nunc scelerisque.", "Little Bear", 2 });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryID", "Date", "Filename", "Text", "Title", "UserID" },
                values: new object[] { 3, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "xyzyg.jpg", @"Cras ornare arcu dui vivamus. Ultricies leo integer malesuada nunc vel risus commodo viverra. Mauris nunc congue nisi vitae. Donec ultrices tincidunt arcu non sodales neque sodales ut. Hac habitasse platea dictumst quisque sagittis purus. Donec ac odio tempor orci dapibus. Tellus orci ac auctor augue. Posuere lorem ipsum dolor sit. Lectus magna fringilla urna porttitor rhoncus dolor. Id velit ut tortor pretium viverra. Cursus eget nunc scelerisque viverra mauris in aliquam.

                        Velit laoreet id donec ultrices tincidunt arcu non sodales neque. Egestas integer eget aliquet nibh praesent tristique magna sit amet. Cursus risus at ultrices mi tempus imperdiet nulla. Non enim praesent elementum facilisis leo vel fringilla est. At varius vel pharetra vel.", "Big Bear", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Story_UserID",
                table: "Story",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
