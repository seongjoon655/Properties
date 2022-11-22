﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisualAcademy.Data.Migrations
{
    public partial class SubLoactionTableAdd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sublocation_Location_LocationId",
                table: "Sublocation");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Location",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Sublocation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sublocation_Location_LocationId",
                table: "Sublocation",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sublocation_Location_LocationId",
                table: "Sublocation");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Location",
                newName: "name");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Sublocation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sublocation_Location_LocationId",
                table: "Sublocation",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
