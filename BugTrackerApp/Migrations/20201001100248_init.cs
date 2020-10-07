﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTrackerApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bugs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BugName = table.Column<string>(nullable: true),
                    BugDescription = table.Column<string>(nullable: true),
                    BugCreatedBy = table.Column<string>(nullable: true),
                    BugAssignedTo = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bugs");
        }
    }
}
