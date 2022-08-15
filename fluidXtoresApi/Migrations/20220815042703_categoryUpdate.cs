using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace fluidXtoresApi.Migrations
{
    public partial class categoryUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<bool>(
                name: "allowCustomersToSelectPageSize",
                table: "Category",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "categoryTemplateId",
                table: "Category",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "createdOnUtc",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "deleted",
                table: "Category",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<List<int>>(
                name: "discountIds",
                table: "Category",
                type: "integer[]",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "displayOrder",
                table: "Category",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "hasDiscountsApplied",
                table: "Category",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "includeintopMenu",
                table: "Category",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "metaDescription",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "metaKeywords",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "metaTitle",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "pageSize",
                table: "Category",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "pageSizeOptions",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "parentCategoryId",
                table: "Category",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "priceRanges",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "published",
                table: "Category",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<List<int>>(
                name: "roleIds",
                table: "Category",
                type: "integer[]",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "seName",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "showOnHomePage",
                table: "Category",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<List<int>>(
                name: "storeIds",
                table: "Category",
                type: "integer[]",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "updatedOnUtc",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "allowCustomersToSelectPageSize",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "categoryTemplateId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "createdOnUtc",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "deleted",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "discountIds",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "displayOrder",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "hasDiscountsApplied",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "includeintopMenu",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "metaDescription",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "metaKeywords",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "metaTitle",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "pageSize",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "pageSizeOptions",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "parentCategoryId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "priceRanges",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "published",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "roleIds",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "seName",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "showOnHomePage",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "storeIds",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "updatedOnUtc",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Users",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
