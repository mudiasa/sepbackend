using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace sepbackend.Migrations
{
    public partial class propertiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Preferences",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoAttendees",
                table: "Events",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Preferences");

            migrationBuilder.DropColumn(
                name: "NoAttendees",
                table: "Events");
        }
    }
}
