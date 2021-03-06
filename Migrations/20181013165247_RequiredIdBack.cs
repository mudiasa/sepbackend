﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace sepbackend.Migrations
{
    public partial class RequiredIdBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Preferences",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preferences_Requests_RequestId",
                table: "Preferences");

            migrationBuilder.DropIndex(
                name: "IX_Preferences_RequestId",
                table: "Preferences");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Preferences");
        }
    }
}
