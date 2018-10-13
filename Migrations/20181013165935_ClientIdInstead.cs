using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace sepbackend.Migrations
{
    public partial class ClientIdInstead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preferences_Requests_RequestId",
                table: "Preferences");

            migrationBuilder.DropIndex(
                name: "IX_Preferences_RequestId",
                table: "Preferences");

            migrationBuilder.RenameColumn(
                name: "RequestId",
                table: "Preferences",
                newName: "CliendId");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Preferences",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_ClientId",
                table: "Preferences",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preferences_Clients_ClientId",
                table: "Preferences",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preferences_Clients_ClientId",
                table: "Preferences");

            migrationBuilder.DropIndex(
                name: "IX_Preferences_ClientId",
                table: "Preferences");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Preferences");

            migrationBuilder.RenameColumn(
                name: "CliendId",
                table: "Preferences",
                newName: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_RequestId",
                table: "Preferences",
                column: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preferences_Requests_RequestId",
                table: "Preferences",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
