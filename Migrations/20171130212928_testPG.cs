using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OakwoodApp.Migrations
{
    public partial class testPG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ministries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ministries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OakwoodEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EndDateTime = table.Column<DateTime>(type: "timestamp", nullable: false),
                    MinistryId = table.Column<int>(type: "int4", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    StartDateTime = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OakwoodEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OakwoodEvents_Ministries_MinistryId",
                        column: x => x.MinistryId,
                        principalTable: "Ministries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OakwoodEvents_MinistryId",
                table: "OakwoodEvents",
                column: "MinistryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OakwoodEvents");

            migrationBuilder.DropTable(
                name: "Ministries");
        }
    }
}
