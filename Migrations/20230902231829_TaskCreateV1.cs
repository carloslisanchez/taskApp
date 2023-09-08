using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApp.Migrations
{
    public partial class TaskCreateV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Create_at",
                table: "Tasks",
                newName: "Updated_at");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Tasks",
                type: "TEXT",
                nullable: true,
                defaultValue:"Pendiente"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "Tasks",
                newName: "Create_at");
        }
    }
}
