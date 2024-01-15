using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProjectCF.DataAccessL.Migrations
{
    /// <inheritdoc />
    public partial class CategoryIdColumnFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Authors_CategoryId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoryId1",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoryId1",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Articles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(9050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(8866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(6833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(6508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(8500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(8253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Authors_AuthorId",
                table: "Articles",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Authors_AuthorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoryId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(8363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(8151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(6164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(5867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(7814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 17, 29, 46, 798, DateTimeKind.Local).AddTicks(7569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 15, 16, 32, 10, 663, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId1",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId1",
                table: "Articles",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Authors_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoryId1",
                table: "Articles",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
