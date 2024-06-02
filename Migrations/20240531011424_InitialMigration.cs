using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeaCare.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBS_Artefato",
                columns: table => new
                {
                    ArtefatoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome_artefato = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    descricao_artefato = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBS_Artefato", x => x.ArtefatoId);
                });

            migrationBuilder.CreateTable(
                name: "TBS_Localizacao",
                columns: table => new
                {
                    LocalizacaoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    uf_localizacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    cidade_localizacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    localidade_localizacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBS_Localizacao", x => x.LocalizacaoId);
                });

            migrationBuilder.CreateTable(
                name: "TBS_Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome_usuario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBS_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Reportes",
                columns: table => new
                {
                    ReporteId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LocalizacaoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ArtefatoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ReporteData = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reportes", x => x.ReporteId);
                    table.ForeignKey(
                        name: "FK_Reportes_TBS_Artefato_ArtefatoId",
                        column: x => x.ArtefatoId,
                        principalTable: "TBS_Artefato",
                        principalColumn: "ArtefatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reportes_TBS_Localizacao_LocalizacaoId",
                        column: x => x.LocalizacaoId,
                        principalTable: "TBS_Localizacao",
                        principalColumn: "LocalizacaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reportes_TBS_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TBS_Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_ArtefatoId",
                table: "Reportes",
                column: "ArtefatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_LocalizacaoId",
                table: "Reportes",
                column: "LocalizacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_UsuarioId",
                table: "Reportes",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reportes");

            migrationBuilder.DropTable(
                name: "TBS_Artefato");

            migrationBuilder.DropTable(
                name: "TBS_Localizacao");

            migrationBuilder.DropTable(
                name: "TBS_Usuario");
        }
    }
}
