using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Admin.Migrations
{
    public partial class ta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sepets_Products_ProductId",
                table: "Sepets");

            migrationBuilder.DropIndex(
                name: "IX_Sepets_ProductId",
                table: "Sepets");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Sepets");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Sepets");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Sepets");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Sepets");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Sepets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Sepets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Sepets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Sepets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Sepets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Sepets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Sepets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Sepets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sepets_ProductId",
                table: "Sepets",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sepets_Products_ProductId",
                table: "Sepets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
