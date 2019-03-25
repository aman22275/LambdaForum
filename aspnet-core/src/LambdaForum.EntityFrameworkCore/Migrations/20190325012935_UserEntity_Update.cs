using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LambdaForum.Migrations
{
    public partial class UserEntity_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AbpUsers_AssignedPersonId1",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AssignedPersonId1",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AssignedPersonId1",
                table: "Tasks");

            migrationBuilder.AlterColumn<long>(
                name: "AssignedPersonId",
                table: "Tasks",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AssignedPersonId",
                table: "Tasks",
                column: "AssignedPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AbpUsers_AssignedPersonId",
                table: "Tasks",
                column: "AssignedPersonId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AbpUsers_AssignedPersonId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AssignedPersonId",
                table: "Tasks");

            migrationBuilder.AlterColumn<Guid>(
                name: "AssignedPersonId",
                table: "Tasks",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "AssignedPersonId1",
                table: "Tasks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AssignedPersonId1",
                table: "Tasks",
                column: "AssignedPersonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AbpUsers_AssignedPersonId1",
                table: "Tasks",
                column: "AssignedPersonId1",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
