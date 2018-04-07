﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EmbyStat.Repositories.Migrations
{
    public partial class addedServerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServerName",
                table: "Configuration",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServerName",
                table: "Configuration");
        }
    }
}