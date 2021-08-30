using Microsoft.EntityFrameworkCore.Migrations;

namespace SNIIV.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cubo_conavi_bak_c_linea_subsidio_conavi_id_modalidad",
                table: "cubo_conavi_bak");

            migrationBuilder.DropForeignKey(
                name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_linea_apoyo",
                table: "cubo_conavi_bak");

            migrationBuilder.AddForeignKey(
                name: "FK_cubo_conavi_bak_c_linea_subsidio_conavi_id_linea_apoyo",
                table: "cubo_conavi_bak",
                column: "id_linea_apoyo",
                principalTable: "c_linea_subsidio_conavi",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_modalidad",
                table: "cubo_conavi_bak",
                column: "id_modalidad",
                principalTable: "c_subprograma_sniiv",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cubo_conavi_bak_c_linea_subsidio_conavi_id_linea_apoyo",
                table: "cubo_conavi_bak");

            migrationBuilder.DropForeignKey(
                name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_modalidad",
                table: "cubo_conavi_bak");

            migrationBuilder.AddForeignKey(
                name: "FK_cubo_conavi_bak_c_linea_subsidio_conavi_id_modalidad",
                table: "cubo_conavi_bak",
                column: "id_modalidad",
                principalTable: "c_linea_subsidio_conavi",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_linea_apoyo",
                table: "cubo_conavi_bak",
                column: "id_linea_apoyo",
                principalTable: "c_subprograma_sniiv",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
