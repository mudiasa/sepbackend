using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace sepbackend.Migrations
{
    public partial class eventBooleansUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isSentToProdManager",
                table: "Events",
                newName: "isSentToSubTeams");

            migrationBuilder.RenameColumn(
                name: "isSentToAdminManager",
                table: "Events",
                newName: "isSentToProdManagers");

            migrationBuilder.RenameColumn(
                name: "isSentBackToSubTeams",
                table: "Events",
                newName: "isSentToCSManager");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isSentToSubTeams",
                table: "Events",
                newName: "isSentToProdManager");

            migrationBuilder.RenameColumn(
                name: "isSentToProdManagers",
                table: "Events",
                newName: "isSentToAdminManager");

            migrationBuilder.RenameColumn(
                name: "isSentToCSManager",
                table: "Events",
                newName: "isSentBackToSubTeams");
        }
    }
}
