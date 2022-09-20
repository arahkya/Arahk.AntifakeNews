using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arahk.AntifakeNews.WebApi.Data.Migrations
{
    public partial class AddMemberandContentTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleTh = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Organize = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Members_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Members",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[] { new Guid("ac7383b1-3703-462c-89c9-d8d5534d0db1"), "Estio", "officia" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "CreatedById", "CreatedOn", "Detail", "Organize", "TitleEn", "TitleTh" },
                values: new object[] { new Guid("1a210062-d9f5-4795-922a-2aa07827eca1"), "Cupidatat", new Guid("ac7383b1-3703-462c-89c9-d8d5534d0db1"), new DateTime(2022, 6, 28, 14, 27, 0, 0, DateTimeKind.Unspecified), "Elit reprehenderit non occaecat nostrud esse et nisi nulla velit do esse proident aliqua reprehenderit. Ullamco est laboris do do duis sint. Consectetur fugiat cillum pariatur duis nisi et. Reprehenderit pariatur nulla laboris consectetur irure pariatur.Ad cillum quis sit minim commodo esse in mollit anim consequat et. Consectetur pariatur consequat proident deserunt commodo aliquip Lorem. Officia qui reprehenderit Lorem officia quis non aliquip qui officia velit ipsum. Id cupidatat nisi sint cillum dolor do est culpa exercitation voluptate aliquip. Id irure irure proident ex proident eiusmod irure deserunt deserunt excepteur veniam commodo fugiat id. Dolor consectetur in amet cupidatat mollit.", "Proident exercitation", "Anim dolor deserunt consectetur do ad deserunt.", "แล้วสอนว่าอย่าไว้ใจมนุษย์ มันแสนสุดลึกล้ำเหลือกำหนด" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "CreatedById", "CreatedOn", "Detail", "Organize", "TitleEn", "TitleTh" },
                values: new object[] { new Guid("7b5a9dec-7122-4844-983f-606a0add2e95"), "Sint incididunt", new Guid("ac7383b1-3703-462c-89c9-d8d5534d0db1"), new DateTime(2022, 9, 18, 20, 54, 0, 0, DateTimeKind.Unspecified), "Ea nisi laborum ullamco veniam ullamco nisi anim. Ad proident duis tempor sint reprehenderit nisi reprehenderit voluptate mollit veniam amet velit dolor est. Labore veniam sit dolor consectetur minim esse. Elit nisi Lorem magna ad enim elit pariatur laborum dolore deserunt esse.Tempor nulla in nisi tempor dolor Lorem. Minim mollit sunt sint aute occaecat Lorem quis incididunt adipisicing. Qui nisi consectetur occaecat eiusmod tempor ullamco minim nisi commodo est veniam sint ut fugiat. Do enim id ad irure incididunt magna consequat. Consectetur magna tempor Lorem tempor voluptate incididunt sit.", "Est exercitation", "Officia ea in elit commodo veniam.", "" });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CreatedById",
                table: "Contents",
                column: "CreatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
