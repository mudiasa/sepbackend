using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace sepbackend.Migrations
{
    public partial class booleanAddedToEventAndRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isSentBackToCSManager",
                table: "Requests",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSentToAdminManager",
                table: "Requests",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSentToCSManager",
                table: "Requests",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSentToFinanceManager",
                table: "Requests",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isCreated",
                table: "Events",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSentBackToSubTeams",
                table: "Events",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSentToAdminManager",
                table: "Events",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSentToProdManager",
                table: "Events",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isSentBackToCSManager",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "isSentToAdminManager",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "isSentToCSManager",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "isSentToFinanceManager",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "isCreated",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "isSentBackToSubTeams",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "isSentToAdminManager",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "isSentToProdManager",
                table: "Events");
        }
    }
}
