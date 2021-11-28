using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbol.App.Persistencia.Migrations
{
    public partial class E_Migrant_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entidades_Migrantes_MigranteId",
                table: "Entidades");

            migrationBuilder.DropIndex(
                name: "IX_Entidades_MigranteId",
                table: "Entidades");

            migrationBuilder.DropColumn(
                name: "Cedula_Integrante",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "Nombre_Integrante",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "MigranteId",
                table: "Entidades");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre_Nesesidad",
                table: "Necesidades",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Novedad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dias_Activo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.AlterColumn<int>(
                name: "Nombre_Nesesidad",
                table: "Necesidades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cedula_Integrante",
                table: "Grupos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre_Integrante",
                table: "Grupos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MigranteId",
                table: "Entidades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entidades_MigranteId",
                table: "Entidades",
                column: "MigranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entidades_Migrantes_MigranteId",
                table: "Entidades",
                column: "MigranteId",
                principalTable: "Migrantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
