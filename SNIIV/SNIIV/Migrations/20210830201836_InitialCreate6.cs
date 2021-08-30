using Microsoft.EntityFrameworkCore.Migrations;

namespace SNIIV.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cubo_conavi_bak_c_linea_subsidio_conavi_id_linea_apoyo",
                table: "cubo_conavi_bak");

            migrationBuilder.DropIndex(
                name: "IX_cubo_conavi_bak_id_linea_apoyo",
                table: "cubo_conavi_bak");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_linea_apoyo",
                table: "cubo_conavi_bak",
                column: "id_linea_apoyo");

            migrationBuilder.AddForeignKey(
                name: "FK_cubo_conavi_bak_c_linea_subsidio_conavi_id_linea_apoyo",
                table: "cubo_conavi_bak",
                column: "id_linea_apoyo",
                principalTable: "c_linea_subsidio_conavi",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
