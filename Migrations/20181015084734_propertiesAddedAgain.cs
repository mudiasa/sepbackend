using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace sepbackend.Migrations
{
    public partial class propertiesAddedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoAttendees",
                table: "Events",
                newName: "NumberOfAttendees");

            migrationBuilder.AddColumn<int>(
                name: "Budget",
                table: "Events",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "NumberOfAttendees",
                table: "Events",
                newName: "NoAttendees");
        }
    }
}
