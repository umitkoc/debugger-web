﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Tag_Tagid",
                table: "Blog");

            migrationBuilder.AlterColumn<int>(
                name: "Tagid",
                table: "Blog",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Tag_Tagid",
                table: "Blog",
                column: "Tagid",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Tag_Tagid",
                table: "Blog");

            migrationBuilder.AlterColumn<int>(
                name: "Tagid",
                table: "Blog",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Tag_Tagid",
                table: "Blog",
                column: "Tagid",
                principalTable: "Tag",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
