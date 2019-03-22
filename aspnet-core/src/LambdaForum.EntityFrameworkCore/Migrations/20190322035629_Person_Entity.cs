using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LambdaForum.Migrations
{
    public partial class Person_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AssignedPersonId",
                table: "Tasks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AssignedPersonId",
                table: "Tasks",
                column: "AssignedPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_People_AssignedPersonId",
                table: "Tasks",
                column: "AssignedPersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_People_AssignedPersonId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AssignedPersonId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AssignedPersonId",
                table: "Tasks");
        }
    }
}
