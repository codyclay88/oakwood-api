using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OakwoodApp.Migrations
{
    public partial class addedLeaderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "OakwoodEvents",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Ministries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mission",
                table: "Ministries",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "OakwoodEvents");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Ministries");

            migrationBuilder.DropColumn(
                name: "Mission",
                table: "Ministries");
        }
    }
}
