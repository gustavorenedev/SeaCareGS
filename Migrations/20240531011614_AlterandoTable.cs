using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeaCare.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reportes_TBS_Artefato_ArtefatoId",
                table: "Reportes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reportes_TBS_Localizacao_LocalizacaoId",
                table: "Reportes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reportes_TBS_Usuario_UsuarioId",
                table: "Reportes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reportes",
                table: "Reportes");

            migrationBuilder.RenameTable(
                name: "Reportes",
                newName: "TBS_Reporte");

            migrationBuilder.RenameIndex(
                name: "IX_Reportes_UsuarioId",
                table: "TBS_Reporte",
                newName: "IX_TBS_Reporte_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Reportes_LocalizacaoId",
                table: "TBS_Reporte",
                newName: "IX_TBS_Reporte_LocalizacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Reportes_ArtefatoId",
                table: "TBS_Reporte",
                newName: "IX_TBS_Reporte_ArtefatoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBS_Reporte",
                table: "TBS_Reporte",
                column: "ReporteId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBS_Reporte_TBS_Artefato_ArtefatoId",
                table: "TBS_Reporte",
                column: "ArtefatoId",
                principalTable: "TBS_Artefato",
                principalColumn: "ArtefatoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBS_Reporte_TBS_Localizacao_LocalizacaoId",
                table: "TBS_Reporte",
                column: "LocalizacaoId",
                principalTable: "TBS_Localizacao",
                principalColumn: "LocalizacaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBS_Reporte_TBS_Usuario_UsuarioId",
                table: "TBS_Reporte",
                column: "UsuarioId",
                principalTable: "TBS_Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBS_Reporte_TBS_Artefato_ArtefatoId",
                table: "TBS_Reporte");

            migrationBuilder.DropForeignKey(
                name: "FK_TBS_Reporte_TBS_Localizacao_LocalizacaoId",
                table: "TBS_Reporte");

            migrationBuilder.DropForeignKey(
                name: "FK_TBS_Reporte_TBS_Usuario_UsuarioId",
                table: "TBS_Reporte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBS_Reporte",
                table: "TBS_Reporte");

            migrationBuilder.RenameTable(
                name: "TBS_Reporte",
                newName: "Reportes");

            migrationBuilder.RenameIndex(
                name: "IX_TBS_Reporte_UsuarioId",
                table: "Reportes",
                newName: "IX_Reportes_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_TBS_Reporte_LocalizacaoId",
                table: "Reportes",
                newName: "IX_Reportes_LocalizacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_TBS_Reporte_ArtefatoId",
                table: "Reportes",
                newName: "IX_Reportes_ArtefatoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reportes",
                table: "Reportes",
                column: "ReporteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reportes_TBS_Artefato_ArtefatoId",
                table: "Reportes",
                column: "ArtefatoId",
                principalTable: "TBS_Artefato",
                principalColumn: "ArtefatoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reportes_TBS_Localizacao_LocalizacaoId",
                table: "Reportes",
                column: "LocalizacaoId",
                principalTable: "TBS_Localizacao",
                principalColumn: "LocalizacaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reportes_TBS_Usuario_UsuarioId",
                table: "Reportes",
                column: "UsuarioId",
                principalTable: "TBS_Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
