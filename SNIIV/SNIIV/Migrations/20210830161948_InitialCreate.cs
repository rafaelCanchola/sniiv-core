using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SNIIV.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "c_avance_de_obra",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_avance_de_obra", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_clima",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_clima", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_derechohabiente_presidencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    id_destino = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_derechohabiente_presidencia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_destino_credito",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_destino_credito", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_ee",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_ee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_entidad_cofinanciamiento",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_entidad_cofinanciamiento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_esquema_cnbv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_esquema_cnbv", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_esquema_conavi",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_esquema_conavi", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_esquema_fovissste",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_esquema_fovissste", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_esquema_infonavit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_esquema_infonavit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_estado_civil",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_estado_civil", x => x.clave);
                });

            migrationBuilder.CreateTable(
                name: "c_estatus_programas_conavi",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_estatus_programas_conavi", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_estatus_vivienda",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_estatus_vivienda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_genero",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    alias = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_genero", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_grupo_organismo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_grupo_organismo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_grupo_sisevive",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_grupo_sisevive", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_intermediario_financiero_cnbv",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_intermediario_financiero_cnbv", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_intermediario_financiero_fovissste",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_intermediario_financiero_fovissste", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_intermediario_financiero_habitat",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_intermediario_financiero_habitat", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_intermediario_financiero_infonavit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_intermediario_financiero_infonavit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_credito_fovissste",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_credito_fovissste", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_credito_habitat",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_credito_habitat", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_infonavit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_infonavit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_localidad",
                columns: table => new
                {
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ambito = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_localidad", x => new { x.clave_entidad_federativa, x.clave_municipio, x.clave });
                });

            migrationBuilder.CreateTable(
                name: "c_mes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    abreviatura = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_mes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_modalidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_modalidad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_modalidad_fovissste",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_modalidad_fovissste", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_modalidad_issste",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_modalidad_issste", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_modalidad_presidencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_modalidad_presidencia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_modalidad_sniiv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_modalidad_sniiv", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_moneda",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_moneda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_municipio_imss",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    id_delegacion = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_municipio_imss", x => new { x.clave, x.id_delegacion });
                });

            migrationBuilder.CreateTable(
                name: "c_nombramiento",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_nombramiento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_oeo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_oeo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_pcu",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_pcu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_cnbv",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_cnbv", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_conavi_semanal",
                columns: table => new
                {
                    fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_conavi_semanal", x => x.fecha);
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_demanda_potencial",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_demanda_potencial", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_financiamientos",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_financiamientos", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_fovissste",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_fovissste", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_imss",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_imss", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_infonavit",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_infonavit", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_inventario",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_inventario", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_issste",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_issste", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_presidencia",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_presidencia", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_registro_vivienda",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_registro_vivienda", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_renaret",
                columns: table => new
                {
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_renaret", x => new { x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_semanal",
                columns: table => new
                {
                    fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_semanal", x => x.fecha);
                });

            migrationBuilder.CreateTable(
                name: "c_periodo_sisevive",
                columns: table => new
                {
                    fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    actual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_periodo_sisevive", x => x.fecha);
                });

            migrationBuilder.CreateTable(
                name: "c_producto_hipotecario",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_producto_hipotecario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_producto_parametrizar_t24",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_producto_parametrizar_t24", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_producto_parametrizar_t24_shf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_producto_parametrizar_t24_shf", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_programa_presupuestal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    nombre = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_programa_presupuestal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_programa_sisevive",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    abreviacion = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_programa_sisevive", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_ramo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_ramo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_rango_edad",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    edad_inicio = table.Column<int>(type: "integer", nullable: false),
                    edad_fin = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_rango_edad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_rango_edad_imss",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    edad_inicio = table.Column<int>(type: "integer", nullable: false),
                    edad_fin = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_rango_edad_conavi = table.Column<int>(type: "integer", nullable: false),
                    abreviacion = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_rango_edad_imss", x => x.clave);
                });

            migrationBuilder.CreateTable(
                name: "c_rango_salarial",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rango_inicio = table.Column<decimal>(type: "numeric", nullable: false),
                    rango = table.Column<decimal>(type: "numeric", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_rango_salarial", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_rango_salarial_imss",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_rango_salarial_conavi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_rango_salarial_imss", x => x.clave);
                });

            migrationBuilder.CreateTable(
                name: "c_rango_uma_imss",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    abreviacion = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_rango_uma_imss", x => x.clave);
                });

            migrationBuilder.CreateTable(
                name: "c_recamara",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_recamara", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_region",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_region", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_region_hidrica",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_region_hidrica", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_registro_patronal",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_registro_patronal", x => x.clave);
                });

            migrationBuilder.CreateTable(
                name: "c_salario_infonavit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    periodo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    A = table.Column<decimal>(type: "numeric", nullable: false),
                    B = table.Column<decimal>(type: "numeric", nullable: false),
                    C = table.Column<decimal>(type: "numeric", nullable: false),
                    UMA = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_salario_infonavit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "c_salario_minimo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_salario_minimo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_sector",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_sector", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_sector_economico_1",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    etiqueta = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_sector_economico_1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_sector_laboral",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_sector_laboral", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_segmento_demanda_potencial",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    orden = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_segmento_demanda_potencial", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_subprograma_sniiv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_subprograma_sniiv", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_superficie",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_superficie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_credito",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    descripcion_inicial = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_credito", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_credito_infonavit",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_credito_infonavit", x => x.clave);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_ee_sniiv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    leyenda = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_ee_sniiv", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_ingreso_shf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_ingreso_shf", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_institucion_shf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_institucion_shf", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_modalidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_modalidad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_vivienda",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_vivienda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_vivienda_fonhapo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_vivienda_fonhapo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipologia_ruv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipologia_ruv", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_tipologia_sisevive",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipologia_sisevive", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_valor_vivienda",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rango = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_valor_vivienda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_valor_vivienda_uma",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_valor_vivienda_uma", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_vivienda_sustentable",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_vivienda_sustentable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cnbv_coofinanciamiento",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cve_institucion = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_periodo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    numero_de_creditos = table.Column<int>(type: "integer", nullable: false),
                    Responsabilidad_total = table.Column<int>(type: "integer", nullable: false),
                    cve_marginal = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_destino_credito = table.Column<int>(type: "integer", nullable: false),
                    cve_moneda = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    monto_original_del_credito = table.Column<int>(type: "integer", nullable: false),
                    originacion_valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    Ingreso_men_bruto_acred = table.Column<int>(type: "integer", nullable: false),
                    cve_tipo_comp_ingresos = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_sec_lab_acred = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_genero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_producto_hipotecario = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_entidad_confinanciamiento = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cnbv_coofinanciamiento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "conavi_06100_fte_his",
                columns: table => new
                {
                    PERIODO_REP = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    Fecha_operacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    genero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    monto_subsidio_federal = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_solucion_habitacional = table.Column<decimal>(type: "numeric", nullable: false),
                    ingresos_VSMGV = table.Column<decimal>(type: "numeric", nullable: false),
                    ingresos_en_pesos = table.Column<decimal>(type: "numeric", nullable: false),
                    modalidad = table.Column<string>(type: "text", nullable: true),
                    linea_apoyo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_localidad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_ejecutora = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    entidad_ejecutora = table.Column<string>(type: "text", nullable: true),
                    tipo_de_vivienda = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    desarrollador = table.Column<string>(type: "text", nullable: true),
                    cuv = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    subpro = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    organo_ejecutor_de_obra = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    puntaje = table.Column<int>(type: "integer", nullable: false),
                    ubicacion = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    esquemas = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    nama = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Folio = table.Column<int>(type: "integer", nullable: false),
                    curp = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    tipo_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    municipio_indigena = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_programa_presupuestal = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conavi_06100_fte_his", x => new { x.PERIODO_REP, x.id });
                });

            migrationBuilder.CreateTable(
                name: "cubo_cnbv_bak",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_linea_credito = table.Column<int>(type: "integer", nullable: false),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    clave_intermediarios_financiero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_rango_salarial = table.Column<int>(type: "integer", nullable: false),
                    id_valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_cnbv_bak", x => new { x.id, x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "cubo_financiamientos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_organismo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_grupo_organismo = table.Column<int>(type: "integer", nullable: false),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    Id_tipo_credito = table.Column<int>(type: "integer", nullable: false),
                    id_destino_credito = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_rango_salarial = table.Column<int>(type: "integer", nullable: false),
                    id_valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_vivienda_sustentable = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_financiamientos", x => new { x.id, x.anio, x.mes, x.clave_organismo });
                });

            migrationBuilder.CreateTable(
                name: "cubo_fovissste_bak",
                columns: table => new
                {
                    folio = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    id_linea_credito = table.Column<int>(type: "integer", nullable: false),
                    id_ee = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_vivienda_sustentable = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_fovissste_bak", x => new { x.folio, x.anio });
                });

            migrationBuilder.CreateTable(
                name: "cubo_imss",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_sector_economico_1 = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    clave_rango_edad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_rango_salarial = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    trabajadores = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_imss", x => new { x.id, x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "cubo_imss_rpt",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_sector_economico_1 = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_rango_salarial = table.Column<int>(type: "integer", nullable: false),
                    trabajadores = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_imss_rpt", x => new { x.id, x.anio, x.mes });
                });

            migrationBuilder.CreateTable(
                name: "cubo_infonavit_bak",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    id_linea = table.Column<int>(type: "integer", nullable: false),
                    id_vivienda = table.Column<bool>(type: "boolean", nullable: false),
                    id_intermediarion_financiero = table.Column<int>(type: "integer", nullable: false),
                    clave_tipo_credito = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_rango_salarial = table.Column<int>(type: "integer", nullable: false),
                    clave_estado_civil = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_vivienda_sustentable = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_infonavit_bak", x => new { x.id, x.anio });
                });

            migrationBuilder.CreateTable(
                name: "cubo_inventario_vivienda",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_pcu = table.Column<int>(type: "integer", nullable: false),
                    id_avance_obra = table.Column<int>(type: "integer", nullable: false),
                    id_segmento = table.Column<int>(type: "integer", nullable: false),
                    id_segmento_uma = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_vivienda = table.Column<int>(type: "integer", nullable: false),
                    subsidio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    viviendas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_inventario_vivienda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cubo_issste",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    id_nombramiento = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_rango_salarial = table.Column<int>(type: "integer", nullable: false),
                    id_rango_antiguedad = table.Column<int>(type: "integer", nullable: false),
                    id_sector = table.Column<int>(type: "integer", nullable: false),
                    trabajadores = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    nombramiento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    sector = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_issste", x => new { x.id, x.anio, x.mes, x.id_nombramiento, x.id_genero, x.id_rango_salarial, x.id_rango_antiguedad, x.id_sector, x.trabajadores });
                });

            migrationBuilder.CreateTable(
                name: "cubo_registro_vivienda_bak",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_pcu = table.Column<int>(type: "integer", nullable: false),
                    id_segmento = table.Column<int>(type: "integer", nullable: false),
                    id_segmento_uma = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_superficie = table.Column<int>(type: "integer", nullable: false),
                    id_recamara = table.Column<int>(type: "integer", nullable: false),
                    viviendas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_registro_vivienda_bak", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cubo_semanal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_organismo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_tipo_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    semana = table.Column<int>(type: "integer", nullable: false),
                    id_region = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_semanal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cubo_sisevive",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_tipologia_ruv = table.Column<int>(type: "integer", nullable: false),
                    id_clima = table.Column<int>(type: "integer", nullable: false),
                    id_pcu = table.Column<int>(type: "integer", nullable: false),
                    idg = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_programa = table.Column<int>(type: "integer", nullable: false),
                    fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    id_tipologia_sisevive = table.Column<int>(type: "integer", nullable: false),
                    id_grupo_sisevive = table.Column<int>(type: "integer", nullable: false),
                    viviendas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_sisevive", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "desarrollador_fovissste",
                columns: table => new
                {
                    folio = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    desarrollador = table.Column<string>(type: "text", nullable: true),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desarrollador_fovissste", x => new { x.folio, x.anio });
                });

            migrationBuilder.CreateTable(
                name: "fovissste_00621_fte_his",
                columns: table => new
                {
                    PERIODO_REP = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    CUV = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    entidad_federativa = table.Column<string>(type: "text", nullable: true),
                    municipio = table.Column<string>(type: "text", nullable: true),
                    modalidad = table.Column<string>(type: "text", nullable: true),
                    linea_credito = table.Column<string>(type: "text", nullable: true),
                    producto = table.Column<string>(type: "text", nullable: true),
                    subproducto = table.Column<string>(type: "text", nullable: true),
                    intermediario_financiero = table.Column<string>(type: "text", nullable: true),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    inversion = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_vivienda = table.Column<decimal>(type: "numeric", nullable: false),
                    genero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    ingreso_VSMMDF = table.Column<decimal>(type: "numeric", nullable: false),
                    mes_corte = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    fecha_de_firma = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    observaciones = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    desarrollador = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    folio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    contador = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fovissste_00621_fte_his", x => new { x.PERIODO_REP, x.id });
                });

            migrationBuilder.CreateTable(
                name: "infonavit_00635_fte_his",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CT_CREDITO_AUTORIZADO_VSM = table.Column<decimal>(type: "numeric", nullable: false),
                    CT_EDAD = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CV_CUV = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CV_ENTIDAD_CAPTURA = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CV_ENTIDAD_FEDERATIVA_EJERCICIO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CV_ENTIDAD_VIVIENDA = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CV_MUNICIPIO_VIVIENDA = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CV_ESTADO_CIVIL = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CV_TIPO_CREDITO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CV_TIPO_MONEDA = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    FH_ENVIO_PAGO = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    NU_BIMESTRES_COTIZACION = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    ID_GENERO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    ID_SEGUNDO_CREDITO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    ID_TIPO_LINEA_CREDITO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    IM_CAPACIDAD_COMPRA_VSM = table.Column<decimal>(type: "numeric", nullable: false),
                    IM_COFINANCIAMIENTO_PESOS = table.Column<decimal>(type: "numeric", nullable: false),
                    IM_PRECIO_VENTA = table.Column<decimal>(type: "numeric", nullable: false),
                    IM_SALARIO_INTEGRADO = table.Column<decimal>(type: "numeric", nullable: false),
                    IM_SALDO_SUBCUENTA = table.Column<decimal>(type: "numeric", nullable: false),
                    IN_VIVIENDA_NUEVA = table.Column<decimal>(type: "numeric", nullable: false),
                    PC_TASA_INTERES = table.Column<decimal>(type: "numeric", nullable: false),
                    IN_SUSTENTABILIDAD = table.Column<bool>(type: "boolean", nullable: false),
                    programa = table.Column<string>(type: "text", nullable: true),
                    programa_TXT = table.Column<string>(type: "text", nullable: true),
                    sub_programa = table.Column<string>(type: "text", nullable: true),
                    sub_programa_TXT = table.Column<string>(type: "text", nullable: true),
                    entidad_financiera = table.Column<string>(type: "text", nullable: true),
                    producto = table.Column<string>(type: "text", nullable: true),
                    sub_producto = table.Column<string>(type: "text", nullable: true),
                    Inversion_Infonavit = table.Column<decimal>(type: "numeric", nullable: false),
                    estimacion_inversion_entidad_financiera = table.Column<decimal>(type: "numeric", nullable: false),
                    Derrama_Infonavit = table.Column<decimal>(type: "numeric", nullable: false),
                    Inversion_Total = table.Column<decimal>(type: "numeric", nullable: false),
                    PERIODO_REP = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infonavit_00635_fte_his", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "inventario_municipal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    trimestre = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    registro = table.Column<int>(type: "integer", nullable: false),
                    construccion = table.Column<int>(type: "integer", nullable: false),
                    venta = table.Column<int>(type: "integer", nullable: false),
                    total = table.Column<int>(type: "integer", nullable: false),
                    numero_vivienda = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventario_municipal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventario_vivienda",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    cve_ent = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cv_gpo_conavi = table.Column<int>(type: "integer", nullable: false),
                    cv_oferente = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    cv_oferta = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    tipo_viv = table.Column<int>(type: "integer", nullable: false),
                    cv_tipo_vivienda = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    pcu = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    nodo = table.Column<string>(type: "text", nullable: true),
                    segmento = table.Column<string>(type: "text", nullable: true),
                    segmento_uma = table.Column<string>(type: "text", nullable: true),
                    subsidio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Inventario_real = table.Column<int>(type: "integer", nullable: false),
                    superficie = table.Column<string>(type: "text", nullable: true),
                    viviendas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventario_vivienda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "issste",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    paterno = table.Column<string>(type: "text", nullable: true),
                    materno = table.Column<string>(type: "text", nullable: true),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    tno = table.Column<int>(type: "integer", nullable: false),
                    id_nombramiento = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    sueldo = table.Column<decimal>(type: "numeric", nullable: false),
                    mult_sdo = table.Column<int>(type: "integer", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fecha_ingreso = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    antiguedad = table.Column<int>(type: "integer", nullable: false),
                    id_ramo = table.Column<int>(type: "integer", nullable: false),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_sector = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issste", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mapa_oferta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    cve_ent = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    mun = table.Column<string>(type: "text", nullable: true),
                    cv_oferta = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    nom_oferta = table.Column<string>(type: "text", nullable: true),
                    cv_oferente = table.Column<string>(type: "text", nullable: true),
                    tx_oferente = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    cv_gpo_conavi = table.Column<int>(type: "integer", nullable: false),
                    gpo_conavi = table.Column<string>(type: "text", nullable: true),
                    latitud_of = table.Column<decimal>(type: "numeric", nullable: false),
                    longitud_of = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_precio = table.Column<decimal>(type: "numeric", nullable: false),
                    max_precio = table.Column<decimal>(type: "numeric", nullable: false),
                    min_precio = table.Column<decimal>(type: "numeric", nullable: false),
                    desv_precio = table.Column<decimal>(type: "numeric", nullable: false),
                    num_viv = table.Column<int>(type: "integer", nullable: false),
                    subsidio_si = table.Column<int>(type: "integer", nullable: false),
                    subsidio_no = table.Column<int>(type: "integer", nullable: false),
                    u1 = table.Column<int>(type: "integer", nullable: false),
                    u2 = table.Column<int>(type: "integer", nullable: false),
                    u3 = table.Column<int>(type: "integer", nullable: false),
                    fuera_contorno = table.Column<int>(type: "integer", nullable: false),
                    nd = table.Column<int>(type: "integer", nullable: false),
                    avance_1_19 = table.Column<int>(type: "integer", nullable: false),
                    avance_20_39 = table.Column<int>(type: "integer", nullable: false),
                    avance_40_59 = table.Column<int>(type: "integer", nullable: false),
                    avance_60_79 = table.Column<int>(type: "integer", nullable: false),
                    avance_80_99 = table.Column<int>(type: "integer", nullable: false),
                    sin_hab = table.Column<int>(type: "integer", nullable: false),
                    hab_men_5 = table.Column<int>(type: "integer", nullable: false),
                    hab_may_5 = table.Column<int>(type: "integer", nullable: false),
                    sin_rep = table.Column<int>(type: "integer", nullable: false),
                    srep_a_0_39 = table.Column<int>(type: "integer", nullable: false),
                    a_40_99 = table.Column<int>(type: "integer", nullable: false),
                    shab_hab5 = table.Column<int>(type: "integer", nullable: false),
                    viv_proc_avlt50 = table.Column<int>(type: "integer", nullable: false),
                    viv_proc_50_99 = table.Column<int>(type: "integer", nullable: false),
                    viv_term_rec = table.Column<int>(type: "integer", nullable: false),
                    viv_term_ant = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mapa_oferta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "quintil_fovissste",
                columns: table => new
                {
                    consecutivo = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    quintil = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quintil_fovissste", x => new { x.consecutivo, x.anio });
                });

            migrationBuilder.CreateTable(
                name: "quintil_infonavit",
                columns: table => new
                {
                    consecutivo = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    quintil = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quintil_infonavit", x => new { x.consecutivo, x.anio });
                });

            migrationBuilder.CreateTable(
                name: "registro_vivienda",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    cve_ent = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cv_oferente = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    pcu = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    segmento_conavi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    segmento_uma = table.Column<string>(type: "text", nullable: true),
                    tipo_viv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cv_tipo_vivienda = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    superficies = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    recamara = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    viviendas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registro_vivienda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "renaret",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    duis = table.Column<int>(type: "integer", nullable: false),
                    cve_ruv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    municipio = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: true),
                    cd_sun = table.Column<string>(type: "text", nullable: true),
                    sup_ha = table.Column<decimal>(type: "numeric", nullable: false),
                    grado_desar_declarado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    grado_desar_verificado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    calif = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    calif_pcu = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    calif_mesa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    empl_total = table.Column<int>(type: "integer", nullable: false),
                    empl_no_urb = table.Column<int>(type: "integer", nullable: false),
                    empl_urb = table.Column<int>(type: "integer", nullable: false),
                    viv_total = table.Column<int>(type: "integer", nullable: false),
                    viv_ur = table.Column<int>(type: "integer", nullable: false),
                    viv_no_urb = table.Column<int>(type: "integer", nullable: false),
                    r_desliz = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    r_inunda = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    r_sismo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    atlas_riesg = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    pcu_rt = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    fc = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_edo_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_edo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    folio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_renaret", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sisevive_ruv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cuv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_programa = table.Column<int>(type: "integer", nullable: false),
                    id_tipologia_ruv = table.Column<int>(type: "integer", nullable: false),
                    idg = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    co2 = table.Column<decimal>(type: "numeric", nullable: false),
                    cv_oferta = table.Column<int>(type: "integer", nullable: false),
                    latitud = table.Column<decimal>(type: "numeric", nullable: false),
                    longitud = table.Column<decimal>(type: "numeric", nullable: false),
                    lalitud_oferta = table.Column<decimal>(type: "numeric", nullable: false),
                    longitud_oferta = table.Column<decimal>(type: "numeric", nullable: false),
                    fecha_ind = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    inst_ind = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sisevive_ruv", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "c_organismo",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    id_grupo_organismo = table.Column<int>(type: "integer", nullable: false),
                    siglas = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_organismo", x => x.clave);
                    table.ForeignKey(
                        name: "FK_c_organismo_c_grupo_organismo_id_grupo_organismo",
                        column: x => x.id_grupo_organismo,
                        principalTable: "c_grupo_organismo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_programa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_programa", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_programa_c_modalidad_id_modalidad",
                        column: x => x.id_modalidad,
                        principalTable: "c_modalidad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "fovissste",
                columns: table => new
                {
                    folio = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    fecha_firma = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    genero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    ingreso = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_vivienda = table.Column<decimal>(type: "numeric", nullable: false),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_linea_credito = table.Column<int>(type: "integer", nullable: false),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    id_intermediario = table.Column<int>(type: "integer", nullable: false),
                    cuv = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    observaciones = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    desarrollador = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    vivienda_sustentable = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fovissste", x => new { x.folio, x.anio });
                    table.ForeignKey(
                        name: "FK_fovissste_c_esquema_fovissste_id_esquema",
                        column: x => x.id_esquema,
                        principalTable: "c_esquema_fovissste",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fovissste_c_intermediario_financiero_fovissste_id_intermedi~",
                        column: x => x.id_intermediario,
                        principalTable: "c_intermediario_financiero_fovissste",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fovissste_c_linea_credito_fovissste_id_linea_credito",
                        column: x => x.id_linea_credito,
                        principalTable: "c_linea_credito_fovissste",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fovissste_c_modalidad_fovissste_id_modalidad",
                        column: x => x.id_modalidad,
                        principalTable: "c_modalidad_fovissste",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "grupo_esquema_cnbv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clave_producto_hipotecario = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_entidad_cofinanciamiento = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_esquema_cnbv = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupo_esquema_cnbv", x => x.id);
                    table.ForeignKey(
                        name: "FK_grupo_esquema_cnbv_c_entidad_cofinanciamiento_clave_entidad~",
                        column: x => x.clave_entidad_cofinanciamiento,
                        principalTable: "c_entidad_cofinanciamiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_grupo_esquema_cnbv_c_esquema_cnbv_id_esquema_cnbv",
                        column: x => x.id_esquema_cnbv,
                        principalTable: "c_esquema_cnbv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_grupo_esquema_cnbv_c_producto_hipotecario_clave_producto_hi~",
                        column: x => x.clave_producto_hipotecario,
                        principalTable: "c_producto_hipotecario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "c_producto_presentar_ef_shf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_producto_parametrizar_t24 = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_producto_presentar_ef_shf", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_producto_presentar_ef_shf_c_producto_parametrizar_t24_shf~",
                        column: x => x.id_producto_parametrizar_t24,
                        principalTable: "c_producto_parametrizar_t24_shf",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_entidad_federativa",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    abreviacion = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_region = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_entidad_federativa", x => x.clave);
                    table.ForeignKey(
                        name: "FK_c_entidad_federativa_c_region_id_region",
                        column: x => x.id_region,
                        principalTable: "c_region",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imss",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    id_delegacion = table.Column<int>(type: "integer", nullable: false),
                    id_subdelegacion = table.Column<int>(type: "integer", nullable: false),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_sector_economico = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_registro_patronal = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    clave_rango_edad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_rango_vsm = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_rango_uma = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    asegurados = table.Column<int>(type: "integer", nullable: false),
                    numero_trabajadores = table.Column<int>(type: "integer", nullable: false),
                    empleo_asegurado = table.Column<int>(type: "integer", nullable: false),
                    empleo_eventual_urbano = table.Column<int>(type: "integer", nullable: false),
                    empleo_eventual_campo = table.Column<int>(type: "integer", nullable: false),
                    empleo_permanente_urbano = table.Column<int>(type: "integer", nullable: false),
                    empleo_permanente_campo = table.Column<int>(type: "integer", nullable: false),
                    empleo_asegurado_salario_asociado = table.Column<int>(type: "integer", nullable: false),
                    empleo_eventual_urbano_salario_asociado = table.Column<int>(type: "integer", nullable: false),
                    empleo_eventual_campo_salario_asociado = table.Column<int>(type: "integer", nullable: false),
                    empleo_permanente_urbano_salario_asociado = table.Column<int>(type: "integer", nullable: false),
                    empleo_permanente_campo_salario_asociado = table.Column<int>(type: "integer", nullable: false),
                    masa_salarial_asociada_empleo_asegurado = table.Column<decimal>(type: "numeric", nullable: false),
                    masa_salarial_asociada_empleo_eventual_urbano = table.Column<decimal>(type: "numeric", nullable: false),
                    masa_salarial_asociada_empleo_eventual_campo = table.Column<decimal>(type: "numeric", nullable: false),
                    masa_salarial_asociada_empleo_permanente_urbano = table.Column<decimal>(type: "numeric", nullable: false),
                    masa_salarial_asociada_empleo_permanente_campo = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imss", x => new { x.id, x.anio, x.mes });
                    table.ForeignKey(
                        name: "FK_imss_c_genero_id_genero",
                        column: x => x.id_genero,
                        principalTable: "c_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_imss_c_rango_edad_imss_clave_rango_edad",
                        column: x => x.clave_rango_edad,
                        principalTable: "c_rango_edad_imss",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_imss_c_rango_salarial_imss_clave_rango_vsm",
                        column: x => x.clave_rango_vsm,
                        principalTable: "c_rango_salarial_imss",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_imss_c_rango_uma_imss_clave_rango_uma",
                        column: x => x.clave_rango_uma,
                        principalTable: "c_rango_uma_imss",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_imss_c_registro_patronal_clave_registro_patronal",
                        column: x => x.clave_registro_patronal,
                        principalTable: "c_registro_patronal",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "demanda_potencial_infonavit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_salario_infonavit = table.Column<int>(type: "integer", nullable: false),
                    valor = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demanda_potencial_infonavit", x => x.id);
                    table.ForeignKey(
                        name: "FK_demanda_potencial_infonavit_c_salario_infonavit_id_salario_~",
                        column: x => x.id_salario_infonavit,
                        principalTable: "c_salario_infonavit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_sector_economico_2",
                columns: table => new
                {
                    id = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    id_sector_economico_1 = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_sector_economico_2", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_sector_economico_2_c_sector_economico_1_id_sector_economi~",
                        column: x => x.id_sector_economico_1,
                        principalTable: "c_sector_economico_1",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_credito_banjercito",
                columns: table => new
                {
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_credito_banjercito", x => x.id_tipo_credito);
                    table.ForeignKey(
                        name: "FK_c_linea_credito_banjercito_c_tipo_credito_id_tipo_credito",
                        column: x => x.id_tipo_credito,
                        principalTable: "c_tipo_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "linea_credito_esquema_infonavit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_esquema_Infonavit = table.Column<int>(type: "integer", nullable: false),
                    id_linea_credito_Infonavit = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linea_credito_esquema_infonavit", x => x.id);
                    table.ForeignKey(
                        name: "FK_linea_credito_esquema_infonavit_c_tipo_credito_id_tipo_cred~",
                        column: x => x.id_tipo_credito,
                        principalTable: "c_tipo_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_tipo_ee",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_tipo_ee_sniiv = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_tipo_ee", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_tipo_ee_c_tipo_ee_sniiv_id_tipo_ee_sniiv",
                        column: x => x.id_tipo_ee_sniiv,
                        principalTable: "c_tipo_ee_sniiv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_modalidad_semanal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_tipo_modalidad = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_modalidad_semanal", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_modalidad_semanal_c_tipo_modalidad_id_tipo_modalidad",
                        column: x => x.id_tipo_modalidad,
                        principalTable: "c_tipo_modalidad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_subprograma",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_programa = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_destino_credito = table.Column<int>(type: "integer", nullable: false),
                    id_subprograma_sniiv = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_subprograma", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_subprograma_c_destino_credito_id_destino_credito",
                        column: x => x.id_destino_credito,
                        principalTable: "c_destino_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_c_subprograma_c_programa_id_programa",
                        column: x => x.id_programa,
                        principalTable: "c_programa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_c_subprograma_c_subprograma_sniiv_id_subprograma_sniiv",
                        column: x => x.id_subprograma_sniiv,
                        principalTable: "c_subprograma_sniiv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_municipio",
                columns: table => new
                {
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    clave_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    ambito = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    poblacion_indigena = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    municipio_fronterizo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_municipio", x => new { x.clave_entidad_federativa, x.clave_mun });
                    table.ForeignKey(
                        name: "FK_c_municipio_c_entidad_federativa_clave_entidad_federativa",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carga_renaret",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    duis = table.Column<int>(type: "integer", nullable: false),
                    cve_ruv = table.Column<string>(type: "text", nullable: true),
                    municipio = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: true),
                    cd_sun = table.Column<string>(type: "text", nullable: true),
                    sup_ha = table.Column<decimal>(type: "numeric", maxLength: 10, nullable: false),
                    grado_desar_declarado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    grado_desar_verificado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    calif = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    calif_pcu = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    calif_mesa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    empl_total = table.Column<int>(type: "integer", nullable: false),
                    empl_no_urb = table.Column<int>(type: "integer", nullable: false),
                    empl_urb = table.Column<int>(type: "integer", nullable: false),
                    viv_total = table.Column<int>(type: "integer", nullable: false),
                    viv_ur = table.Column<int>(type: "integer", nullable: false),
                    viv_no_urb = table.Column<int>(type: "integer", nullable: false),
                    r_desliz = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    r_inunda = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    r_sismo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    atlas_riesg = table.Column<string>(type: "text", nullable: true),
                    pcu_rt = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    fc = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_edo_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_edo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carga_renaret", x => new { x.anio, x.id, x.mes });
                    table.ForeignKey(
                        name: "FK_carga_renaret_c_entidad_federativa_cve_edo",
                        column: x => x.cve_edo,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "demanda_potencial_5_10",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ent = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    hasta_2_6_uma = table.Column<int>(type: "integer", nullable: false),
                    de_2_61_a_3_0_uma = table.Column<int>(type: "integer", nullable: false),
                    de_3_1_a_4_0_uma = table.Column<int>(type: "integer", nullable: false),
                    de_4_1_a_5_0_uma = table.Column<int>(type: "integer", nullable: false),
                    de_5_1_a_10_0_uma = table.Column<int>(type: "integer", nullable: false),
                    total_general = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    cve_ent = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demanda_potencial_5_10", x => x.id);
                    table.ForeignKey(
                        name: "FK_demanda_potencial_5_10_c_entidad_federativa_cve_ent",
                        column: x => x.cve_ent,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "demanda_potencial_m10",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ent = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    hasta_2_6_uma = table.Column<int>(type: "integer", nullable: false),
                    de_2_61_a_4_0_uma = table.Column<int>(type: "integer", nullable: false),
                    de_4_1_a_5_0_uma = table.Column<int>(type: "integer", nullable: false),
                    de_5_1_a_10_0_uma = table.Column<int>(type: "integer", nullable: false),
                    mayor_a_10_0_uma = table.Column<int>(type: "integer", nullable: false),
                    total_general = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    cve_ent = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cve_mun = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demanda_potencial_m10", x => x.id);
                    table.ForeignKey(
                        name: "FK_demanda_potencial_m10_c_entidad_federativa_cve_ent",
                        column: x => x.cve_ent,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "habitat",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha_operacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_linea_credito = table.Column<int>(type: "integer", nullable: false),
                    cuv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_intermediario = table.Column<int>(type: "integer", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    recurso_propio = table.Column<decimal>(type: "numeric", nullable: false),
                    recurso_federal = table.Column<decimal>(type: "numeric", nullable: false),
                    recurso_beneficiario = table.Column<decimal>(type: "numeric", nullable: false),
                    recurso_financiero = table.Column<decimal>(type: "numeric", nullable: false),
                    genero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    ingreso_salarial = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    tipo_vivienda = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habitat", x => x.id);
                    table.ForeignKey(
                        name: "FK_habitat_c_entidad_federativa_clave_entidad_federativa",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_habitat_c_intermediario_financiero_habitat_id_intermediario",
                        column: x => x.id_intermediario,
                        principalTable: "c_intermediario_financiero_habitat",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_habitat_c_linea_credito_habitat_id_linea_credito",
                        column: x => x.id_linea_credito,
                        principalTable: "c_linea_credito_habitat",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_habitat_c_mes_mes",
                        column: x => x.mes,
                        principalTable: "c_mes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inventario_estatal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    trimestre = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    registro = table.Column<int>(type: "integer", nullable: false),
                    construccion = table.Column<int>(type: "integer", nullable: false),
                    venta = table.Column<int>(type: "integer", nullable: false),
                    total = table.Column<int>(type: "integer", nullable: false),
                    numero_vivienda = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventario_estatal", x => x.id);
                    table.ForeignKey(
                        name: "FK_inventario_estatal_c_entidad_federativa_clave_entidad_feder~",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "shf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    cuv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_microcredito = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_producto_presentar_ef = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_institucion = table.Column<int>(type: "integer", nullable: false),
                    valor_vivienda = table.Column<decimal>(type: "numeric", nullable: false),
                    id_tipo_vivienda = table.Column<int>(type: "integer", nullable: false),
                    monto_microcredito_if = table.Column<decimal>(type: "numeric", nullable: false),
                    ingresos_acreditado = table.Column<decimal>(type: "numeric", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    ingresos_coadreditado = table.Column<decimal>(type: "numeric", nullable: false),
                    genero_coacreditado = table.Column<int>(type: "integer", nullable: false),
                    edad_coacreditado = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_tipo_ingreso = table.Column<int>(type: "integer", nullable: false),
                    subsidio = table.Column<decimal>(type: "numeric", nullable: false),
                    monto_mensual = table.Column<decimal>(type: "numeric", nullable: false),
                    plazo_credito = table.Column<int>(type: "integer", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shf", x => x.id);
                    table.ForeignKey(
                        name: "FK_shf_c_entidad_federativa_clave_entidad_federativa",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_shf_c_genero_id_genero",
                        column: x => x.id_genero,
                        principalTable: "c_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shf_c_producto_presentar_ef_shf_id_producto_presentar_ef",
                        column: x => x.id_producto_presentar_ef,
                        principalTable: "c_producto_presentar_ef_shf",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shf_c_tipo_ingreso_shf_id_tipo_ingreso",
                        column: x => x.id_tipo_ingreso,
                        principalTable: "c_tipo_ingreso_shf",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shf_c_tipo_institucion_shf_id_tipo_institucion",
                        column: x => x.id_tipo_institucion,
                        principalTable: "c_tipo_institucion_shf",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shf_c_tipo_vivienda_fonhapo_id_tipo_vivienda",
                        column: x => x.id_tipo_vivienda,
                        principalTable: "c_tipo_vivienda_fonhapo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sisevive",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cuv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_estatus_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_prototipo = table.Column<int>(type: "integer", nullable: false),
                    id_tipologia_ruv = table.Column<int>(type: "integer", nullable: false),
                    id_clima = table.Column<int>(type: "integer", nullable: false),
                    id_pcu = table.Column<int>(type: "integer", nullable: false),
                    idg = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    co2 = table.Column<decimal>(type: "numeric", nullable: false),
                    id_programas = table.Column<int>(type: "integer", nullable: false),
                    fecha = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    id_grupo_sisevive = table.Column<int>(type: "integer", nullable: false),
                    latitud_vivienda = table.Column<decimal>(type: "numeric", nullable: false),
                    longitud_vivienda = table.Column<decimal>(type: "numeric", nullable: false),
                    latitud_oferta = table.Column<decimal>(type: "numeric", nullable: false),
                    longitud_oferta = table.Column<decimal>(type: "numeric", nullable: false),
                    id_tipologia_sisevive = table.Column<int>(type: "integer", nullable: false),
                    id_region_hidrica = table.Column<int>(type: "integer", nullable: false),
                    demanda_especifica = table.Column<int>(type: "integer", nullable: false),
                    demanda_energia = table.Column<int>(type: "integer", nullable: false),
                    emisiones_co2 = table.Column<int>(type: "integer", nullable: false),
                    ahorro_energia = table.Column<int>(type: "integer", nullable: false),
                    norma_020 = table.Column<int>(type: "integer", nullable: false),
                    cv_idg = table.Column<int>(type: "integer", nullable: false),
                    cv_estatus_idg = table.Column<int>(type: "integer", nullable: false),
                    cpa = table.Column<decimal>(type: "numeric", nullable: false),
                    fecha_documento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    clave_oferta = table.Column<int>(type: "integer", nullable: false),
                    id_vivienda = table.Column<int>(type: "integer", nullable: false),
                    clave_oferente = table.Column<int>(type: "integer", nullable: false),
                    clave_ov = table.Column<int>(type: "integer", nullable: false),
                    clave_verificador = table.Column<int>(type: "integer", nullable: false),
                    fecha_inicio_ov = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fecha_fin_ov = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    avance = table.Column<int>(type: "integer", nullable: false),
                    tipo_vivienda = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    superficie_habitable = table.Column<decimal>(type: "numeric", nullable: false),
                    precio_vivienda = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sisevive", x => x.id);
                    table.ForeignKey(
                        name: "FK_sisevive_c_clima_id_clima",
                        column: x => x.id_clima,
                        principalTable: "c_clima",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sisevive_c_entidad_federativa_clave_entidad_federativa",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sisevive_c_estatus_vivienda_id_estatus_vivienda",
                        column: x => x.id_estatus_vivienda,
                        principalTable: "c_estatus_vivienda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sisevive_c_grupo_sisevive_id_grupo_sisevive",
                        column: x => x.id_grupo_sisevive,
                        principalTable: "c_grupo_sisevive",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sisevive_c_pcu_id_pcu",
                        column: x => x.id_pcu,
                        principalTable: "c_pcu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sisevive_c_region_hidrica_id_region_hidrica",
                        column: x => x.id_region_hidrica,
                        principalTable: "c_region_hidrica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sisevive_c_tipologia_ruv_id_tipologia_ruv",
                        column: x => x.id_tipologia_ruv,
                        principalTable: "c_tipologia_ruv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sisevive_c_tipologia_sisevive_id_tipologia_sisevive",
                        column: x => x.id_tipologia_sisevive,
                        principalTable: "c_tipologia_sisevive",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_sector_economico_4",
                columns: table => new
                {
                    clave = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    id_sector_economico_2 = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_sector_economico_4", x => x.clave);
                    table.ForeignKey(
                        name: "FK_c_sector_economico_4_c_sector_economico_2_id_sector_economi~",
                        column: x => x.id_sector_economico_2,
                        principalTable: "c_sector_economico_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "banjercito",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_linea_credito = table.Column<int>(type: "integer", nullable: false),
                    producto = table.Column<string>(type: "text", nullable: true),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    genero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    ingreso_VSMMDF = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_vivienda_vsmmdf = table.Column<decimal>(type: "numeric", nullable: false),
                    tipo_vivienda = table.Column<string>(type: "text", nullable: true),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banjercito", x => x.id);
                    table.ForeignKey(
                        name: "FK_banjercito_c_entidad_federativa_clave_entidad_federativa",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_banjercito_c_linea_credito_banjercito_id_linea_credito",
                        column: x => x.id_linea_credito,
                        principalTable: "c_linea_credito_banjercito",
                        principalColumn: "id_tipo_credito",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ee_tipo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_ee = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_ee = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ee_tipo", x => x.id);
                    table.ForeignKey(
                        name: "FK_ee_tipo_c_ee_id_ee",
                        column: x => x.id_ee,
                        principalTable: "c_ee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ee_tipo_c_tipo_ee_id_tipo_ee",
                        column: x => x.id_tipo_ee,
                        principalTable: "c_tipo_ee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_apoyo_presidencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false),
                    etiqueta = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_apoyo_presidencia", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_linea_apoyo_presidencia_c_subprograma_id_subprograma",
                        column: x => x.id_subprograma,
                        principalTable: "c_subprograma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_c_linea_apoyo_presidencia_c_tipo_credito_id_tipo_credito",
                        column: x => x.id_tipo_credito,
                        principalTable: "c_tipo_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_credito_cnbv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false),
                    it_tipo_credito = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_credito_cnbv", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_linea_credito_cnbv_c_subprograma_id_subprograma",
                        column: x => x.id_subprograma,
                        principalTable: "c_subprograma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_credito_fovissste2",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_credito_fovissste2", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_linea_credito_fovissste2_c_subprograma_id_subprograma",
                        column: x => x.id_subprograma,
                        principalTable: "c_subprograma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_credito_infonavit_bak",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_credito_infonavit_bak", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_linea_credito_infonavit_bak_c_subprograma_id_subprograma",
                        column: x => x.id_subprograma,
                        principalTable: "c_subprograma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_credito_shf",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_producto_presentar_ef_shf = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_credito_shf", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_linea_credito_shf_c_producto_presentar_ef_shf_id_producto~",
                        column: x => x.id_producto_presentar_ef_shf,
                        principalTable: "c_producto_presentar_ef_shf",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_c_linea_credito_shf_c_subprograma_id_subprograma",
                        column: x => x.id_subprograma,
                        principalTable: "c_subprograma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_c_linea_credito_shf_c_tipo_credito_id_tipo_credito",
                        column: x => x.id_tipo_credito,
                        principalTable: "c_tipo_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_c_linea_credito_shf_c_tipo_vivienda_fonhapo_id_tipo_vivienda",
                        column: x => x.id_tipo_vivienda,
                        principalTable: "c_tipo_vivienda_fonhapo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "c_linea_subsidio_conavi",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c_linea_subsidio_conavi", x => x.id);
                    table.ForeignKey(
                        name: "FK_c_linea_subsidio_conavi_c_subprograma_id_subprograma",
                        column: x => x.id_subprograma,
                        principalTable: "c_subprograma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "financiamientos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_organismo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_rango_salarial = table.Column<int>(type: "integer", nullable: false),
                    id_valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_vivienda_sustentable = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_financiamientos", x => new { x.id, x.anio, x.mes, x.clave_organismo });
                    table.ForeignKey(
                        name: "FK_financiamientos_c_entidad_federativa_clave_entidad_federati~",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_financiamientos_c_genero_id_genero",
                        column: x => x.id_genero,
                        principalTable: "c_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_financiamientos_c_organismo_clave_organismo",
                        column: x => x.clave_organismo,
                        principalTable: "c_organismo",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_financiamientos_c_rango_edad_id_rango_edad",
                        column: x => x.id_rango_edad,
                        principalTable: "c_rango_edad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_financiamientos_c_rango_salarial_id_rango_salarial",
                        column: x => x.id_rango_salarial,
                        principalTable: "c_rango_salarial",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_financiamientos_c_subprograma_id_subprograma",
                        column: x => x.id_subprograma,
                        principalTable: "c_subprograma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_financiamientos_c_tipo_credito_id_tipo_credito",
                        column: x => x.id_tipo_credito,
                        principalTable: "c_tipo_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_financiamientos_c_valor_vivienda_id_valor_vivienda",
                        column: x => x.id_valor_vivienda,
                        principalTable: "c_valor_vivienda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_financiamientos_c_vivienda_sustentable_id_vivienda_sustenta~",
                        column: x => x.id_vivienda_sustentable,
                        principalTable: "c_vivienda_sustentable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subprograma_fovissste",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    id_linea_credito = table.Column<int>(type: "integer", nullable: false),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_subprograma = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subprograma_fovissste", x => x.id);
                    table.ForeignKey(
                        name: "FK_subprograma_fovissste_c_esquema_fovissste_id_esquema",
                        column: x => x.id_esquema,
                        principalTable: "c_esquema_fovissste",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subprograma_fovissste_c_linea_credito_fovissste_id_linea_cr~",
                        column: x => x.id_linea_credito,
                        principalTable: "c_linea_credito_fovissste",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subprograma_fovissste_c_modalidad_fovissste_id_modalidad",
                        column: x => x.id_modalidad,
                        principalTable: "c_modalidad_fovissste",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subprograma_fovissste_c_subprograma_id_subprograma",
                        column: x => x.id_subprograma,
                        principalTable: "c_subprograma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subprograma_fovissste_c_tipo_credito_id_tipo_credito",
                        column: x => x.id_tipo_credito,
                        principalTable: "c_tipo_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "programas_conavi",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    folio = table.Column<string>(type: "text", nullable: true),
                    fecha_aprobacion_comite_financiamiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    numero_comite_financiamiento = table.Column<string>(type: "text", nullable: true),
                    id_programa_presupuestal = table.Column<int>(type: "integer", nullable: false),
                    partida_presupuestal = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    unidad_medida = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_linea_apoyo = table.Column<int>(type: "integer", nullable: false),
                    id_vertiente = table.Column<int>(type: "integer", nullable: false),
                    folio_conavi = table.Column<string>(type: "text", nullable: true),
                    curp = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_localidad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    ingreso_beneficiario = table.Column<decimal>(type: "numeric", nullable: false),
                    ingreso_beneficiario_UMA = table.Column<decimal>(type: "numeric", nullable: false),
                    beneficiario_comprometidos = table.Column<int>(type: "integer", nullable: false),
                    dato_presupuestal_importe_aprobado = table.Column<decimal>(type: "numeric", nullable: false),
                    dato_presupuestal_importe_ejercido = table.Column<decimal>(type: "numeric", nullable: false),
                    fecha_dispersion_presuesto = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    colonia = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cve_asistente_oeo = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    cve_supervisor = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    cuv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    longitud = table.Column<decimal>(type: "numeric", nullable: false),
                    latitud = table.Column<decimal>(type: "numeric", nullable: false),
                    avance_obra = table.Column<int>(type: "integer", nullable: false),
                    condicion_indigena = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    discapacidad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_derechohabiente = table.Column<int>(type: "integer", nullable: false),
                    folio_sap = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    fecha_sap = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    periodo_rep = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<bool>(type: "boolean", nullable: false),
                    id_status = table.Column<int>(type: "integer", nullable: false),
                    status_pago = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programas_conavi", x => x.id);
                    table.ForeignKey(
                        name: "FK_programas_conavi_c_derechohabiente_presidencia_id_derechoha~",
                        column: x => x.id_derechohabiente,
                        principalTable: "c_derechohabiente_presidencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_programas_conavi_c_entidad_federativa_clave_entidad_federat~",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_programas_conavi_c_estatus_programas_conavi_id_status",
                        column: x => x.id_status,
                        principalTable: "c_estatus_programas_conavi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_programas_conavi_c_genero_id_genero",
                        column: x => x.id_genero,
                        principalTable: "c_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_programas_conavi_c_linea_apoyo_presidencia_id_linea_apoyo",
                        column: x => x.id_linea_apoyo,
                        principalTable: "c_linea_apoyo_presidencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_programas_conavi_c_modalidad_presidencia_id_modalidad",
                        column: x => x.id_modalidad,
                        principalTable: "c_modalidad_presidencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_programas_conavi_c_programa_presupuestal_id_programa_presup~",
                        column: x => x.id_programa_presupuestal,
                        principalTable: "c_programa_presupuestal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reporte_presidencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha_aprobacion_comite_financiamiento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    numero_comite_financiamiento = table.Column<string>(type: "text", nullable: true),
                    id_programa_presupuestal = table.Column<int>(type: "integer", nullable: false),
                    partida_presupuestal = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    unidad_medida = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_linea_apoyo = table.Column<int>(type: "integer", nullable: false),
                    id_vertiente = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_localidad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    beneficiario_meta = table.Column<int>(type: "integer", nullable: false),
                    beneficiario_comprometidos = table.Column<int>(type: "integer", nullable: false),
                    dato_presupuestal_importe_aprobado = table.Column<decimal>(type: "numeric", nullable: false),
                    colonia = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    condicion_indigena = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_derechohabiente = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<bool>(type: "boolean", nullable: false),
                    id_status = table.Column<int>(type: "integer", nullable: false),
                    dato_prespuestal_importe_modificado = table.Column<decimal>(type: "numeric", nullable: false),
                    dato_prespuestal_importe_compromiso = table.Column<decimal>(type: "numeric", nullable: false),
                    dato_prespuestal_importe_programado = table.Column<decimal>(type: "numeric", nullable: false),
                    dato_prespuestal_importe_ejercido = table.Column<decimal>(type: "numeric", nullable: false),
                    forma_pago_directo = table.Column<decimal>(type: "numeric", nullable: false),
                    forma_pago_dispersion = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reporte_presidencia", x => x.id);
                    table.ForeignKey(
                        name: "FK_reporte_presidencia_c_derechohabiente_presidencia_id_derech~",
                        column: x => x.id_derechohabiente,
                        principalTable: "c_derechohabiente_presidencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reporte_presidencia_c_entidad_federativa_clave_entidad_fede~",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_reporte_presidencia_c_genero_id_genero",
                        column: x => x.id_genero,
                        principalTable: "c_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reporte_presidencia_c_linea_apoyo_presidencia_id_linea_apoyo",
                        column: x => x.id_linea_apoyo,
                        principalTable: "c_linea_apoyo_presidencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reporte_presidencia_c_modalidad_presidencia_id_modalidad",
                        column: x => x.id_modalidad,
                        principalTable: "c_modalidad_presidencia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reporte_presidencia_c_programa_presupuestal_id_programa_pre~",
                        column: x => x.id_programa_presupuestal,
                        principalTable: "c_programa_presupuestal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cnbv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_intermediarios_financiero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_linea_credito = table.Column<int>(type: "integer", nullable: false),
                    responsabilidad_total = table.Column<int>(type: "integer", nullable: false),
                    id_moneda = table.Column<int>(type: "integer", nullable: false),
                    ingreso_VSMMDF = table.Column<int>(type: "integer", nullable: false),
                    valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    tipo_comprobacion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    id_sector_laboral = table.Column<int>(type: "integer", nullable: false),
                    genero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_cofinanciamiento = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_producto_hipotecario = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<int>(type: "integer", nullable: false),
                    cve_marginal = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cnbv", x => new { x.id, x.anio, x.mes });
                    table.ForeignKey(
                        name: "FK_cnbv_c_entidad_cofinanciamiento_clave_entidad_cofinanciamie~",
                        column: x => x.clave_entidad_cofinanciamiento,
                        principalTable: "c_entidad_cofinanciamiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cnbv_c_entidad_federativa_clave_entidad_federativa",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cnbv_c_linea_credito_cnbv_id_linea_credito",
                        column: x => x.id_linea_credito,
                        principalTable: "c_linea_credito_cnbv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cnbv_c_moneda_id_moneda",
                        column: x => x.id_moneda,
                        principalTable: "c_moneda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cnbv_c_producto_hipotecario_clave_producto_hipotecario",
                        column: x => x.clave_producto_hipotecario,
                        principalTable: "c_producto_hipotecario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cnbv_c_sector_laboral_id_sector_laboral",
                        column: x => x.id_sector_laboral,
                        principalTable: "c_sector_laboral",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "linea_credito_esquema_cnbv",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_linea_credito_cnbv = table.Column<int>(type: "integer", nullable: false),
                    id_esquema_cnbv = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linea_credito_esquema_cnbv", x => x.id);
                    table.ForeignKey(
                        name: "FK_linea_credito_esquema_cnbv_c_esquema_cnbv_id_esquema_cnbv",
                        column: x => x.id_esquema_cnbv,
                        principalTable: "c_esquema_cnbv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_linea_credito_esquema_cnbv_c_linea_credito_cnbv_id_linea_cr~",
                        column: x => x.id_linea_credito_cnbv,
                        principalTable: "c_linea_credito_cnbv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_linea_credito_esquema_cnbv_c_tipo_credito_id_tipo_credito",
                        column: x => x.id_tipo_credito,
                        principalTable: "c_tipo_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "infonavit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    cuv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    clave_entidad_captura = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_entidad_ejercicio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    id_intermediario_financiero = table.Column<int>(type: "integer", nullable: false),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    estado_civil = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    tipo_credito = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_segundo_credito = table.Column<int>(type: "integer", nullable: false),
                    id_linea = table.Column<int>(type: "integer", nullable: false),
                    precio_venta = table.Column<decimal>(type: "numeric", nullable: false),
                    salario_integrado = table.Column<decimal>(type: "numeric", nullable: false),
                    vivienda_nueva = table.Column<bool>(type: "boolean", nullable: false),
                    id_linea_credito = table.Column<int>(type: "integer", nullable: false),
                    inversion_infonavit = table.Column<decimal>(type: "numeric", nullable: false),
                    inversion_entidad_financiera = table.Column<decimal>(type: "numeric", nullable: false),
                    derrama_infonavit = table.Column<decimal>(type: "numeric", nullable: false),
                    fecha_pago = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    sustentabilidad = table.Column<bool>(type: "boolean", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infonavit", x => new { x.id, x.anio });
                    table.ForeignKey(
                        name: "FK_infonavit_c_entidad_federativa_clave_entidad_federativa",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_infonavit_c_esquema_infonavit_id_esquema",
                        column: x => x.id_esquema,
                        principalTable: "c_esquema_infonavit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_infonavit_c_estado_civil_estado_civil",
                        column: x => x.estado_civil,
                        principalTable: "c_estado_civil",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_infonavit_c_genero_id_genero",
                        column: x => x.id_genero,
                        principalTable: "c_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_infonavit_c_intermediario_financiero_infonavit_id_intermedi~",
                        column: x => x.id_intermediario_financiero,
                        principalTable: "c_intermediario_financiero_infonavit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_infonavit_c_linea_credito_infonavit_bak_id_linea_credito",
                        column: x => x.id_linea_credito,
                        principalTable: "c_linea_credito_infonavit_bak",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_infonavit_c_linea_infonavit_id_linea",
                        column: x => x.id_linea,
                        principalTable: "c_linea_infonavit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_infonavit_c_tipo_credito_infonavit_tipo_credito",
                        column: x => x.tipo_credito,
                        principalTable: "c_tipo_credito_infonavit",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conavi_semanal",
                columns: table => new
                {
                    folio = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    fech_operacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    monto_subsidio_federal = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_solucion_habitacional = table.Column<decimal>(type: "numeric", nullable: false),
                    ingreso_pesos = table.Column<decimal>(type: "numeric", nullable: false),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    clave_entidad_federativa = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    clave_localidad = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_ee = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_vivienda = table.Column<int>(type: "integer", nullable: false),
                    desarrollador = table.Column<string>(type: "text", nullable: true),
                    cuv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    acciones = table.Column<int>(type: "integer", nullable: false),
                    id_oeo = table.Column<int>(type: "integer", nullable: false),
                    puntaje = table.Column<int>(type: "integer", nullable: false),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_ee = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    id_vivienda_sustentable = table.Column<int>(type: "integer", nullable: false),
                    id_pcu = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conavi_semanal", x => new { x.folio, x.anio });
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_ee_id_ee",
                        column: x => x.id_ee,
                        principalTable: "c_ee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_entidad_federativa_clave_entidad_federativa",
                        column: x => x.clave_entidad_federativa,
                        principalTable: "c_entidad_federativa",
                        principalColumn: "clave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_esquema_conavi_id_esquema",
                        column: x => x.id_esquema,
                        principalTable: "c_esquema_conavi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_genero_id_genero",
                        column: x => x.id_genero,
                        principalTable: "c_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_linea_subsidio_conavi_id_modalidad",
                        column: x => x.id_modalidad,
                        principalTable: "c_linea_subsidio_conavi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_mes_mes",
                        column: x => x.mes,
                        principalTable: "c_mes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_oeo_id_oeo",
                        column: x => x.id_oeo,
                        principalTable: "c_oeo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_pcu_id_pcu",
                        column: x => x.id_pcu,
                        principalTable: "c_pcu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_tipo_ee_id_tipo_ee",
                        column: x => x.id_tipo_ee,
                        principalTable: "c_tipo_ee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_tipo_vivienda_id_tipo_vivienda",
                        column: x => x.id_tipo_vivienda,
                        principalTable: "c_tipo_vivienda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conavi_semanal_c_vivienda_sustentable_id_vivienda_sustentab~",
                        column: x => x.id_vivienda_sustentable,
                        principalTable: "c_vivienda_sustentable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cubo_conavi_bak",
                columns: table => new
                {
                    folio = table.Column<int>(type: "integer", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    clave_estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    clave_municipio = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    id_programa_presupuestal = table.Column<int>(type: "integer", nullable: false),
                    mes = table.Column<int>(type: "integer", nullable: false),
                    id_linea_apoyo = table.Column<int>(type: "integer", nullable: false),
                    id_modalidad = table.Column<int>(type: "integer", nullable: false),
                    id_esquema = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_ee = table.Column<int>(type: "integer", nullable: false),
                    id_ee = table.Column<int>(type: "integer", nullable: false),
                    id_oeo = table.Column<int>(type: "integer", nullable: false),
                    id_genero = table.Column<int>(type: "integer", nullable: false),
                    id_rango_edad = table.Column<int>(type: "integer", nullable: false),
                    id_rango_salarial = table.Column<int>(type: "integer", nullable: false),
                    id_valor_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_vivienda = table.Column<int>(type: "integer", nullable: false),
                    id_dc = table.Column<int>(type: "integer", nullable: false),
                    id_vivienda_sustentable = table.Column<int>(type: "integer", nullable: false),
                    id_pcu = table.Column<int>(type: "integer", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    acciones = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cubo_conavi_bak", x => new { x.folio, x.anio, x.clave_estado, x.clave_municipio });
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_ee_id_ee",
                        column: x => x.id_ee,
                        principalTable: "c_ee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_esquema_conavi_id_esquema",
                        column: x => x.id_esquema,
                        principalTable: "c_esquema_conavi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_genero_id_genero",
                        column: x => x.id_genero,
                        principalTable: "c_genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_linea_subsidio_conavi_id_modalidad",
                        column: x => x.id_modalidad,
                        principalTable: "c_linea_subsidio_conavi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_municipio_clave_estado_clave_municipio",
                        columns: x => new { x.clave_estado, x.clave_municipio },
                        principalTable: "c_municipio",
                        principalColumns: new[] { "clave_entidad_federativa", "clave_mun" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_oeo_id_oeo",
                        column: x => x.id_oeo,
                        principalTable: "c_oeo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_pcu_id_pcu",
                        column: x => x.id_pcu,
                        principalTable: "c_pcu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_programa_presupuestal_id_programa_presupu~",
                        column: x => x.id_programa_presupuestal,
                        principalTable: "c_programa_presupuestal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_rango_edad_id_rango_edad",
                        column: x => x.id_rango_edad,
                        principalTable: "c_rango_edad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_rango_salarial_id_rango_salarial",
                        column: x => x.id_rango_salarial,
                        principalTable: "c_rango_salarial",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_subprograma_sniiv_id_linea_apoyo",
                        column: x => x.id_linea_apoyo,
                        principalTable: "c_subprograma_sniiv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_tipo_ee_id_tipo_ee",
                        column: x => x.id_tipo_ee,
                        principalTable: "c_tipo_ee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_tipo_vivienda_id_tipo_vivienda",
                        column: x => x.id_tipo_vivienda,
                        principalTable: "c_tipo_vivienda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_valor_vivienda_id_valor_vivienda",
                        column: x => x.id_valor_vivienda,
                        principalTable: "c_valor_vivienda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cubo_conavi_bak_c_vivienda_sustentable_id_vivienda_sustenta~",
                        column: x => x.id_vivienda_sustentable,
                        principalTable: "c_vivienda_sustentable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "linea_subsidio_tipo_ee",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_linea_subsidio = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_ee = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_credito = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linea_subsidio_tipo_ee", x => x.id);
                    table.ForeignKey(
                        name: "FK_linea_subsidio_tipo_ee_c_linea_subsidio_conavi_id_linea_sub~",
                        column: x => x.id_linea_subsidio,
                        principalTable: "c_linea_subsidio_conavi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_linea_subsidio_tipo_ee_c_tipo_credito_id_tipo_credito",
                        column: x => x.id_tipo_credito,
                        principalTable: "c_tipo_credito",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_linea_subsidio_tipo_ee_c_tipo_ee_id_tipo_ee",
                        column: x => x.id_tipo_ee,
                        principalTable: "c_tipo_ee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_banjercito_clave_entidad_federativa",
                table: "banjercito",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_banjercito_id_linea_credito",
                table: "banjercito",
                column: "id_linea_credito");

            migrationBuilder.CreateIndex(
                name: "IX_c_entidad_federativa_id_region",
                table: "c_entidad_federativa",
                column: "id_region");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_apoyo_presidencia_id_subprograma",
                table: "c_linea_apoyo_presidencia",
                column: "id_subprograma");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_apoyo_presidencia_id_tipo_credito",
                table: "c_linea_apoyo_presidencia",
                column: "id_tipo_credito");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_credito_cnbv_id_subprograma",
                table: "c_linea_credito_cnbv",
                column: "id_subprograma");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_credito_fovissste2_id_subprograma",
                table: "c_linea_credito_fovissste2",
                column: "id_subprograma");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_credito_infonavit_bak_id_subprograma",
                table: "c_linea_credito_infonavit_bak",
                column: "id_subprograma");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_credito_shf_id_producto_presentar_ef_shf",
                table: "c_linea_credito_shf",
                column: "id_producto_presentar_ef_shf");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_credito_shf_id_subprograma",
                table: "c_linea_credito_shf",
                column: "id_subprograma");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_credito_shf_id_tipo_credito",
                table: "c_linea_credito_shf",
                column: "id_tipo_credito");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_credito_shf_id_tipo_vivienda",
                table: "c_linea_credito_shf",
                column: "id_tipo_vivienda");

            migrationBuilder.CreateIndex(
                name: "IX_c_linea_subsidio_conavi_id_subprograma",
                table: "c_linea_subsidio_conavi",
                column: "id_subprograma");

            migrationBuilder.CreateIndex(
                name: "IX_c_modalidad_semanal_id_tipo_modalidad",
                table: "c_modalidad_semanal",
                column: "id_tipo_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_c_organismo_id_grupo_organismo",
                table: "c_organismo",
                column: "id_grupo_organismo");

            migrationBuilder.CreateIndex(
                name: "IX_c_producto_presentar_ef_shf_id_producto_parametrizar_t24",
                table: "c_producto_presentar_ef_shf",
                column: "id_producto_parametrizar_t24");

            migrationBuilder.CreateIndex(
                name: "IX_c_programa_id_modalidad",
                table: "c_programa",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_c_sector_economico_2_id_sector_economico_1",
                table: "c_sector_economico_2",
                column: "id_sector_economico_1");

            migrationBuilder.CreateIndex(
                name: "IX_c_sector_economico_4_id_sector_economico_2",
                table: "c_sector_economico_4",
                column: "id_sector_economico_2");

            migrationBuilder.CreateIndex(
                name: "IX_c_subprograma_id_destino_credito",
                table: "c_subprograma",
                column: "id_destino_credito");

            migrationBuilder.CreateIndex(
                name: "IX_c_subprograma_id_programa",
                table: "c_subprograma",
                column: "id_programa");

            migrationBuilder.CreateIndex(
                name: "IX_c_subprograma_id_subprograma_sniiv",
                table: "c_subprograma",
                column: "id_subprograma_sniiv");

            migrationBuilder.CreateIndex(
                name: "IX_c_tipo_ee_id_tipo_ee_sniiv",
                table: "c_tipo_ee",
                column: "id_tipo_ee_sniiv");

            migrationBuilder.CreateIndex(
                name: "IX_carga_renaret_cve_edo",
                table: "carga_renaret",
                column: "cve_edo");

            migrationBuilder.CreateIndex(
                name: "IX_cnbv_clave_entidad_cofinanciamiento",
                table: "cnbv",
                column: "clave_entidad_cofinanciamiento");

            migrationBuilder.CreateIndex(
                name: "IX_cnbv_clave_entidad_federativa",
                table: "cnbv",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_cnbv_clave_producto_hipotecario",
                table: "cnbv",
                column: "clave_producto_hipotecario");

            migrationBuilder.CreateIndex(
                name: "IX_cnbv_id_linea_credito",
                table: "cnbv",
                column: "id_linea_credito");

            migrationBuilder.CreateIndex(
                name: "IX_cnbv_id_moneda",
                table: "cnbv",
                column: "id_moneda");

            migrationBuilder.CreateIndex(
                name: "IX_cnbv_id_sector_laboral",
                table: "cnbv",
                column: "id_sector_laboral");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_clave_entidad_federativa",
                table: "conavi_semanal",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_ee",
                table: "conavi_semanal",
                column: "id_ee");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_esquema",
                table: "conavi_semanal",
                column: "id_esquema");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_genero",
                table: "conavi_semanal",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_modalidad",
                table: "conavi_semanal",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_oeo",
                table: "conavi_semanal",
                column: "id_oeo");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_pcu",
                table: "conavi_semanal",
                column: "id_pcu");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_tipo_ee",
                table: "conavi_semanal",
                column: "id_tipo_ee");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_tipo_vivienda",
                table: "conavi_semanal",
                column: "id_tipo_vivienda");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_id_vivienda_sustentable",
                table: "conavi_semanal",
                column: "id_vivienda_sustentable");

            migrationBuilder.CreateIndex(
                name: "IX_conavi_semanal_mes",
                table: "conavi_semanal",
                column: "mes");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_clave_estado_clave_municipio",
                table: "cubo_conavi_bak",
                columns: new[] { "clave_estado", "clave_municipio" });

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_ee",
                table: "cubo_conavi_bak",
                column: "id_ee");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_esquema",
                table: "cubo_conavi_bak",
                column: "id_esquema");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_genero",
                table: "cubo_conavi_bak",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_linea_apoyo",
                table: "cubo_conavi_bak",
                column: "id_linea_apoyo");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_modalidad",
                table: "cubo_conavi_bak",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_oeo",
                table: "cubo_conavi_bak",
                column: "id_oeo");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_pcu",
                table: "cubo_conavi_bak",
                column: "id_pcu");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_programa_presupuestal",
                table: "cubo_conavi_bak",
                column: "id_programa_presupuestal");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_rango_edad",
                table: "cubo_conavi_bak",
                column: "id_rango_edad");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_rango_salarial",
                table: "cubo_conavi_bak",
                column: "id_rango_salarial");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_tipo_ee",
                table: "cubo_conavi_bak",
                column: "id_tipo_ee");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_tipo_vivienda",
                table: "cubo_conavi_bak",
                column: "id_tipo_vivienda");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_valor_vivienda",
                table: "cubo_conavi_bak",
                column: "id_valor_vivienda");

            migrationBuilder.CreateIndex(
                name: "IX_cubo_conavi_bak_id_vivienda_sustentable",
                table: "cubo_conavi_bak",
                column: "id_vivienda_sustentable");

            migrationBuilder.CreateIndex(
                name: "IX_demanda_potencial_5_10_cve_ent",
                table: "demanda_potencial_5_10",
                column: "cve_ent");

            migrationBuilder.CreateIndex(
                name: "IX_demanda_potencial_infonavit_id_salario_infonavit",
                table: "demanda_potencial_infonavit",
                column: "id_salario_infonavit");

            migrationBuilder.CreateIndex(
                name: "IX_demanda_potencial_m10_cve_ent",
                table: "demanda_potencial_m10",
                column: "cve_ent");

            migrationBuilder.CreateIndex(
                name: "IX_ee_tipo_id_ee",
                table: "ee_tipo",
                column: "id_ee");

            migrationBuilder.CreateIndex(
                name: "IX_ee_tipo_id_tipo_ee",
                table: "ee_tipo",
                column: "id_tipo_ee");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_clave_entidad_federativa",
                table: "financiamientos",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_clave_organismo",
                table: "financiamientos",
                column: "clave_organismo");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_id_genero",
                table: "financiamientos",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_id_rango_edad",
                table: "financiamientos",
                column: "id_rango_edad");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_id_rango_salarial",
                table: "financiamientos",
                column: "id_rango_salarial");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_id_subprograma",
                table: "financiamientos",
                column: "id_subprograma");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_id_tipo_credito",
                table: "financiamientos",
                column: "id_tipo_credito");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_id_valor_vivienda",
                table: "financiamientos",
                column: "id_valor_vivienda");

            migrationBuilder.CreateIndex(
                name: "IX_financiamientos_id_vivienda_sustentable",
                table: "financiamientos",
                column: "id_vivienda_sustentable");

            migrationBuilder.CreateIndex(
                name: "IX_fovissste_id_esquema",
                table: "fovissste",
                column: "id_esquema");

            migrationBuilder.CreateIndex(
                name: "IX_fovissste_id_intermediario",
                table: "fovissste",
                column: "id_intermediario");

            migrationBuilder.CreateIndex(
                name: "IX_fovissste_id_linea_credito",
                table: "fovissste",
                column: "id_linea_credito");

            migrationBuilder.CreateIndex(
                name: "IX_fovissste_id_modalidad",
                table: "fovissste",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_grupo_esquema_cnbv_clave_entidad_cofinanciamiento",
                table: "grupo_esquema_cnbv",
                column: "clave_entidad_cofinanciamiento");

            migrationBuilder.CreateIndex(
                name: "IX_grupo_esquema_cnbv_clave_producto_hipotecario",
                table: "grupo_esquema_cnbv",
                column: "clave_producto_hipotecario");

            migrationBuilder.CreateIndex(
                name: "IX_grupo_esquema_cnbv_id_esquema_cnbv",
                table: "grupo_esquema_cnbv",
                column: "id_esquema_cnbv");

            migrationBuilder.CreateIndex(
                name: "IX_habitat_clave_entidad_federativa",
                table: "habitat",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_habitat_id_intermediario",
                table: "habitat",
                column: "id_intermediario");

            migrationBuilder.CreateIndex(
                name: "IX_habitat_id_linea_credito",
                table: "habitat",
                column: "id_linea_credito");

            migrationBuilder.CreateIndex(
                name: "IX_habitat_mes",
                table: "habitat",
                column: "mes");

            migrationBuilder.CreateIndex(
                name: "IX_imss_clave_rango_edad",
                table: "imss",
                column: "clave_rango_edad");

            migrationBuilder.CreateIndex(
                name: "IX_imss_clave_rango_uma",
                table: "imss",
                column: "clave_rango_uma");

            migrationBuilder.CreateIndex(
                name: "IX_imss_clave_rango_vsm",
                table: "imss",
                column: "clave_rango_vsm");

            migrationBuilder.CreateIndex(
                name: "IX_imss_clave_registro_patronal",
                table: "imss",
                column: "clave_registro_patronal");

            migrationBuilder.CreateIndex(
                name: "IX_imss_id_genero",
                table: "imss",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_infonavit_clave_entidad_federativa",
                table: "infonavit",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_infonavit_estado_civil",
                table: "infonavit",
                column: "estado_civil");

            migrationBuilder.CreateIndex(
                name: "IX_infonavit_id_esquema",
                table: "infonavit",
                column: "id_esquema");

            migrationBuilder.CreateIndex(
                name: "IX_infonavit_id_genero",
                table: "infonavit",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_infonavit_id_intermediario_financiero",
                table: "infonavit",
                column: "id_intermediario_financiero");

            migrationBuilder.CreateIndex(
                name: "IX_infonavit_id_linea",
                table: "infonavit",
                column: "id_linea");

            migrationBuilder.CreateIndex(
                name: "IX_infonavit_id_linea_credito",
                table: "infonavit",
                column: "id_linea_credito");

            migrationBuilder.CreateIndex(
                name: "IX_infonavit_tipo_credito",
                table: "infonavit",
                column: "tipo_credito");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_estatal_clave_entidad_federativa",
                table: "inventario_estatal",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_linea_credito_esquema_cnbv_id_esquema_cnbv",
                table: "linea_credito_esquema_cnbv",
                column: "id_esquema_cnbv");

            migrationBuilder.CreateIndex(
                name: "IX_linea_credito_esquema_cnbv_id_linea_credito_cnbv",
                table: "linea_credito_esquema_cnbv",
                column: "id_linea_credito_cnbv");

            migrationBuilder.CreateIndex(
                name: "IX_linea_credito_esquema_cnbv_id_tipo_credito",
                table: "linea_credito_esquema_cnbv",
                column: "id_tipo_credito");

            migrationBuilder.CreateIndex(
                name: "IX_linea_credito_esquema_infonavit_id_tipo_credito",
                table: "linea_credito_esquema_infonavit",
                column: "id_tipo_credito");

            migrationBuilder.CreateIndex(
                name: "IX_linea_subsidio_tipo_ee_id_linea_subsidio",
                table: "linea_subsidio_tipo_ee",
                column: "id_linea_subsidio");

            migrationBuilder.CreateIndex(
                name: "IX_linea_subsidio_tipo_ee_id_tipo_credito",
                table: "linea_subsidio_tipo_ee",
                column: "id_tipo_credito");

            migrationBuilder.CreateIndex(
                name: "IX_linea_subsidio_tipo_ee_id_tipo_ee",
                table: "linea_subsidio_tipo_ee",
                column: "id_tipo_ee");

            migrationBuilder.CreateIndex(
                name: "IX_programas_conavi_clave_entidad_federativa",
                table: "programas_conavi",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_programas_conavi_id_derechohabiente",
                table: "programas_conavi",
                column: "id_derechohabiente");

            migrationBuilder.CreateIndex(
                name: "IX_programas_conavi_id_genero",
                table: "programas_conavi",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_programas_conavi_id_linea_apoyo",
                table: "programas_conavi",
                column: "id_linea_apoyo");

            migrationBuilder.CreateIndex(
                name: "IX_programas_conavi_id_modalidad",
                table: "programas_conavi",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_programas_conavi_id_programa_presupuestal",
                table: "programas_conavi",
                column: "id_programa_presupuestal");

            migrationBuilder.CreateIndex(
                name: "IX_programas_conavi_id_status",
                table: "programas_conavi",
                column: "id_status");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_presidencia_clave_entidad_federativa",
                table: "reporte_presidencia",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_presidencia_id_derechohabiente",
                table: "reporte_presidencia",
                column: "id_derechohabiente");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_presidencia_id_genero",
                table: "reporte_presidencia",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_presidencia_id_linea_apoyo",
                table: "reporte_presidencia",
                column: "id_linea_apoyo");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_presidencia_id_modalidad",
                table: "reporte_presidencia",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_reporte_presidencia_id_programa_presupuestal",
                table: "reporte_presidencia",
                column: "id_programa_presupuestal");

            migrationBuilder.CreateIndex(
                name: "IX_shf_clave_entidad_federativa",
                table: "shf",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_shf_id_genero",
                table: "shf",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_shf_id_producto_presentar_ef",
                table: "shf",
                column: "id_producto_presentar_ef");

            migrationBuilder.CreateIndex(
                name: "IX_shf_id_tipo_ingreso",
                table: "shf",
                column: "id_tipo_ingreso");

            migrationBuilder.CreateIndex(
                name: "IX_shf_id_tipo_institucion",
                table: "shf",
                column: "id_tipo_institucion");

            migrationBuilder.CreateIndex(
                name: "IX_shf_id_tipo_vivienda",
                table: "shf",
                column: "id_tipo_vivienda");

            migrationBuilder.CreateIndex(
                name: "IX_sisevive_clave_entidad_federativa",
                table: "sisevive",
                column: "clave_entidad_federativa");

            migrationBuilder.CreateIndex(
                name: "IX_sisevive_id_clima",
                table: "sisevive",
                column: "id_clima");

            migrationBuilder.CreateIndex(
                name: "IX_sisevive_id_estatus_vivienda",
                table: "sisevive",
                column: "id_estatus_vivienda");

            migrationBuilder.CreateIndex(
                name: "IX_sisevive_id_grupo_sisevive",
                table: "sisevive",
                column: "id_grupo_sisevive");

            migrationBuilder.CreateIndex(
                name: "IX_sisevive_id_pcu",
                table: "sisevive",
                column: "id_pcu");

            migrationBuilder.CreateIndex(
                name: "IX_sisevive_id_region_hidrica",
                table: "sisevive",
                column: "id_region_hidrica");

            migrationBuilder.CreateIndex(
                name: "IX_sisevive_id_tipologia_ruv",
                table: "sisevive",
                column: "id_tipologia_ruv");

            migrationBuilder.CreateIndex(
                name: "IX_sisevive_id_tipologia_sisevive",
                table: "sisevive",
                column: "id_tipologia_sisevive");

            migrationBuilder.CreateIndex(
                name: "IX_subprograma_fovissste_id_esquema",
                table: "subprograma_fovissste",
                column: "id_esquema");

            migrationBuilder.CreateIndex(
                name: "IX_subprograma_fovissste_id_linea_credito",
                table: "subprograma_fovissste",
                column: "id_linea_credito");

            migrationBuilder.CreateIndex(
                name: "IX_subprograma_fovissste_id_modalidad",
                table: "subprograma_fovissste",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_subprograma_fovissste_id_subprograma",
                table: "subprograma_fovissste",
                column: "id_subprograma");

            migrationBuilder.CreateIndex(
                name: "IX_subprograma_fovissste_id_tipo_credito",
                table: "subprograma_fovissste",
                column: "id_tipo_credito");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banjercito");

            migrationBuilder.DropTable(
                name: "c_avance_de_obra");

            migrationBuilder.DropTable(
                name: "c_intermediario_financiero_cnbv");

            migrationBuilder.DropTable(
                name: "c_linea_credito_fovissste2");

            migrationBuilder.DropTable(
                name: "c_linea_credito_shf");

            migrationBuilder.DropTable(
                name: "c_localidad");

            migrationBuilder.DropTable(
                name: "c_modalidad_issste");

            migrationBuilder.DropTable(
                name: "c_modalidad_semanal");

            migrationBuilder.DropTable(
                name: "c_modalidad_sniiv");

            migrationBuilder.DropTable(
                name: "c_municipio_imss");

            migrationBuilder.DropTable(
                name: "c_nombramiento");

            migrationBuilder.DropTable(
                name: "c_periodo_cnbv");

            migrationBuilder.DropTable(
                name: "c_periodo_conavi_semanal");

            migrationBuilder.DropTable(
                name: "c_periodo_demanda_potencial");

            migrationBuilder.DropTable(
                name: "c_periodo_financiamientos");

            migrationBuilder.DropTable(
                name: "c_periodo_fovissste");

            migrationBuilder.DropTable(
                name: "c_periodo_imss");

            migrationBuilder.DropTable(
                name: "c_periodo_infonavit");

            migrationBuilder.DropTable(
                name: "c_periodo_inventario");

            migrationBuilder.DropTable(
                name: "c_periodo_issste");

            migrationBuilder.DropTable(
                name: "c_periodo_presidencia");

            migrationBuilder.DropTable(
                name: "c_periodo_registro_vivienda");

            migrationBuilder.DropTable(
                name: "c_periodo_renaret");

            migrationBuilder.DropTable(
                name: "c_periodo_semanal");

            migrationBuilder.DropTable(
                name: "c_periodo_sisevive");

            migrationBuilder.DropTable(
                name: "c_producto_parametrizar_t24");

            migrationBuilder.DropTable(
                name: "c_programa_sisevive");

            migrationBuilder.DropTable(
                name: "c_ramo");

            migrationBuilder.DropTable(
                name: "c_recamara");

            migrationBuilder.DropTable(
                name: "c_salario_minimo");

            migrationBuilder.DropTable(
                name: "c_sector");

            migrationBuilder.DropTable(
                name: "c_sector_economico_4");

            migrationBuilder.DropTable(
                name: "c_segmento_demanda_potencial");

            migrationBuilder.DropTable(
                name: "c_superficie");

            migrationBuilder.DropTable(
                name: "c_valor_vivienda_uma");

            migrationBuilder.DropTable(
                name: "carga_renaret");

            migrationBuilder.DropTable(
                name: "cnbv");

            migrationBuilder.DropTable(
                name: "cnbv_coofinanciamiento");

            migrationBuilder.DropTable(
                name: "conavi_06100_fte_his");

            migrationBuilder.DropTable(
                name: "conavi_semanal");

            migrationBuilder.DropTable(
                name: "cubo_cnbv_bak");

            migrationBuilder.DropTable(
                name: "cubo_conavi_bak");

            migrationBuilder.DropTable(
                name: "cubo_financiamientos");

            migrationBuilder.DropTable(
                name: "cubo_fovissste_bak");

            migrationBuilder.DropTable(
                name: "cubo_imss");

            migrationBuilder.DropTable(
                name: "cubo_imss_rpt");

            migrationBuilder.DropTable(
                name: "cubo_infonavit_bak");

            migrationBuilder.DropTable(
                name: "cubo_inventario_vivienda");

            migrationBuilder.DropTable(
                name: "cubo_issste");

            migrationBuilder.DropTable(
                name: "cubo_registro_vivienda_bak");

            migrationBuilder.DropTable(
                name: "cubo_semanal");

            migrationBuilder.DropTable(
                name: "cubo_sisevive");

            migrationBuilder.DropTable(
                name: "demanda_potencial_5_10");

            migrationBuilder.DropTable(
                name: "demanda_potencial_infonavit");

            migrationBuilder.DropTable(
                name: "demanda_potencial_m10");

            migrationBuilder.DropTable(
                name: "desarrollador_fovissste");

            migrationBuilder.DropTable(
                name: "ee_tipo");

            migrationBuilder.DropTable(
                name: "financiamientos");

            migrationBuilder.DropTable(
                name: "fovissste");

            migrationBuilder.DropTable(
                name: "fovissste_00621_fte_his");

            migrationBuilder.DropTable(
                name: "grupo_esquema_cnbv");

            migrationBuilder.DropTable(
                name: "habitat");

            migrationBuilder.DropTable(
                name: "imss");

            migrationBuilder.DropTable(
                name: "infonavit");

            migrationBuilder.DropTable(
                name: "infonavit_00635_fte_his");

            migrationBuilder.DropTable(
                name: "inventario_estatal");

            migrationBuilder.DropTable(
                name: "inventario_municipal");

            migrationBuilder.DropTable(
                name: "inventario_vivienda");

            migrationBuilder.DropTable(
                name: "issste");

            migrationBuilder.DropTable(
                name: "linea_credito_esquema_cnbv");

            migrationBuilder.DropTable(
                name: "linea_credito_esquema_infonavit");

            migrationBuilder.DropTable(
                name: "linea_subsidio_tipo_ee");

            migrationBuilder.DropTable(
                name: "mapa_oferta");

            migrationBuilder.DropTable(
                name: "programas_conavi");

            migrationBuilder.DropTable(
                name: "quintil_fovissste");

            migrationBuilder.DropTable(
                name: "quintil_infonavit");

            migrationBuilder.DropTable(
                name: "registro_vivienda");

            migrationBuilder.DropTable(
                name: "renaret");

            migrationBuilder.DropTable(
                name: "reporte_presidencia");

            migrationBuilder.DropTable(
                name: "shf");

            migrationBuilder.DropTable(
                name: "sisevive");

            migrationBuilder.DropTable(
                name: "sisevive_ruv");

            migrationBuilder.DropTable(
                name: "subprograma_fovissste");

            migrationBuilder.DropTable(
                name: "c_linea_credito_banjercito");

            migrationBuilder.DropTable(
                name: "c_tipo_modalidad");

            migrationBuilder.DropTable(
                name: "c_sector_economico_2");

            migrationBuilder.DropTable(
                name: "c_moneda");

            migrationBuilder.DropTable(
                name: "c_sector_laboral");

            migrationBuilder.DropTable(
                name: "c_esquema_conavi");

            migrationBuilder.DropTable(
                name: "c_municipio");

            migrationBuilder.DropTable(
                name: "c_oeo");

            migrationBuilder.DropTable(
                name: "c_tipo_vivienda");

            migrationBuilder.DropTable(
                name: "c_salario_infonavit");

            migrationBuilder.DropTable(
                name: "c_ee");

            migrationBuilder.DropTable(
                name: "c_organismo");

            migrationBuilder.DropTable(
                name: "c_rango_edad");

            migrationBuilder.DropTable(
                name: "c_rango_salarial");

            migrationBuilder.DropTable(
                name: "c_valor_vivienda");

            migrationBuilder.DropTable(
                name: "c_vivienda_sustentable");

            migrationBuilder.DropTable(
                name: "c_intermediario_financiero_fovissste");

            migrationBuilder.DropTable(
                name: "c_entidad_cofinanciamiento");

            migrationBuilder.DropTable(
                name: "c_producto_hipotecario");

            migrationBuilder.DropTable(
                name: "c_intermediario_financiero_habitat");

            migrationBuilder.DropTable(
                name: "c_linea_credito_habitat");

            migrationBuilder.DropTable(
                name: "c_mes");

            migrationBuilder.DropTable(
                name: "c_rango_edad_imss");

            migrationBuilder.DropTable(
                name: "c_rango_salarial_imss");

            migrationBuilder.DropTable(
                name: "c_rango_uma_imss");

            migrationBuilder.DropTable(
                name: "c_registro_patronal");

            migrationBuilder.DropTable(
                name: "c_esquema_infonavit");

            migrationBuilder.DropTable(
                name: "c_estado_civil");

            migrationBuilder.DropTable(
                name: "c_intermediario_financiero_infonavit");

            migrationBuilder.DropTable(
                name: "c_linea_credito_infonavit_bak");

            migrationBuilder.DropTable(
                name: "c_linea_infonavit");

            migrationBuilder.DropTable(
                name: "c_tipo_credito_infonavit");

            migrationBuilder.DropTable(
                name: "c_esquema_cnbv");

            migrationBuilder.DropTable(
                name: "c_linea_credito_cnbv");

            migrationBuilder.DropTable(
                name: "c_linea_subsidio_conavi");

            migrationBuilder.DropTable(
                name: "c_tipo_ee");

            migrationBuilder.DropTable(
                name: "c_estatus_programas_conavi");

            migrationBuilder.DropTable(
                name: "c_derechohabiente_presidencia");

            migrationBuilder.DropTable(
                name: "c_linea_apoyo_presidencia");

            migrationBuilder.DropTable(
                name: "c_modalidad_presidencia");

            migrationBuilder.DropTable(
                name: "c_programa_presupuestal");

            migrationBuilder.DropTable(
                name: "c_genero");

            migrationBuilder.DropTable(
                name: "c_producto_presentar_ef_shf");

            migrationBuilder.DropTable(
                name: "c_tipo_ingreso_shf");

            migrationBuilder.DropTable(
                name: "c_tipo_institucion_shf");

            migrationBuilder.DropTable(
                name: "c_tipo_vivienda_fonhapo");

            migrationBuilder.DropTable(
                name: "c_clima");

            migrationBuilder.DropTable(
                name: "c_estatus_vivienda");

            migrationBuilder.DropTable(
                name: "c_grupo_sisevive");

            migrationBuilder.DropTable(
                name: "c_pcu");

            migrationBuilder.DropTable(
                name: "c_region_hidrica");

            migrationBuilder.DropTable(
                name: "c_tipologia_ruv");

            migrationBuilder.DropTable(
                name: "c_tipologia_sisevive");

            migrationBuilder.DropTable(
                name: "c_esquema_fovissste");

            migrationBuilder.DropTable(
                name: "c_linea_credito_fovissste");

            migrationBuilder.DropTable(
                name: "c_modalidad_fovissste");

            migrationBuilder.DropTable(
                name: "c_sector_economico_1");

            migrationBuilder.DropTable(
                name: "c_entidad_federativa");

            migrationBuilder.DropTable(
                name: "c_grupo_organismo");

            migrationBuilder.DropTable(
                name: "c_tipo_ee_sniiv");

            migrationBuilder.DropTable(
                name: "c_subprograma");

            migrationBuilder.DropTable(
                name: "c_tipo_credito");

            migrationBuilder.DropTable(
                name: "c_producto_parametrizar_t24_shf");

            migrationBuilder.DropTable(
                name: "c_region");

            migrationBuilder.DropTable(
                name: "c_destino_credito");

            migrationBuilder.DropTable(
                name: "c_programa");

            migrationBuilder.DropTable(
                name: "c_subprograma_sniiv");

            migrationBuilder.DropTable(
                name: "c_modalidad");
        }
    }
}
