﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.BookStore.Migrations
{
    public partial class Created_Cat_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCats",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCats", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCats");
        }
    }
}
