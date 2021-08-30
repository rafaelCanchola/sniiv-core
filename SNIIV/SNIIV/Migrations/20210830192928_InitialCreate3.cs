using Microsoft.EntityFrameworkCore.Migrations;

namespace SNIIV.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_linea_apoyo",
                table: "cubo_conavi_bak");

            migrationBuilder.AlterColumn<int>(
                name: "id_linea_apoyo",
                table: "cubo_conavi_bak",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_linea_apoyo",
                table: "cubo_conavi_bak",
                column: "id_linea_apoyo",
                principalTable: "c_subprograma_sniiv",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_linea_apoyo",
                table: "cubo_conavi_bak");

            migrationBuilder.AlterColumn<int>(
                name: "id_linea_apoyo",
                table: "cubo_conavi_bak",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_linea_apoyo",
                table: "cubo_conavi_bak",
                column: "id_linea_apoyo",
                principalTable: "c_subprograma_sniiv",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
