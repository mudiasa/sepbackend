using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace sepbackend.Migrations
{
    public partial class requestModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "numberOfAttendees",
                table: "Requests",
                newName: "NumberOfAttendees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfAttendees",
                table: "Requests",
                newName: "numberOfAttendees");
        }
    }
}
