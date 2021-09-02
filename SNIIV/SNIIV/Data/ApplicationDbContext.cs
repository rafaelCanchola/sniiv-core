using System;
using Microsoft.EntityFrameworkCore;
using SNIIV.Models;
namespace SNIIV.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<banjercito>().HasKey(entity => new { entity.clave_entidad_federativa, entity.clave_municipio, entity.id_linea_credito, entity.anio, entity.mes, entity.id });
            modelBuilder.Entity<c_localidad>().HasKey(entity => new { entity.clave_entidad_federativa, entity.clave_municipio, entity.clave });
            modelBuilder.Entity<c_municipio>().HasKey(entity => new {entity.clave_entidad_federativa,entity.clave_mun });
            modelBuilder.Entity<c_municipio_imss>().HasKey(entity => new { entity.clave, entity.id_delegacion });
            modelBuilder.Entity<c_periodo_cnbv>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_demanda_potencial>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_financiamientos>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_fovissste>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_imss>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_infonavit>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_inventario>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_issste>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_presidencia>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_registro_vivienda>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<c_periodo_renaret>().HasKey(entity => new { entity.anio, entity.mes });
            modelBuilder.Entity<carga_renaret>().HasKey(entity => new { entity.anio, entity.id, entity.mes });
            modelBuilder.Entity<cnbv>().HasKey(entity => new { entity.id, entity.anio, entity.mes });
            modelBuilder.Entity<conavi_06100_fte_his>().HasKey(entity => new { entity.periodo_rep, entity.id });
            modelBuilder.Entity<conavi_semanal>().HasKey(entity => new { entity.folio, entity.anio });
            modelBuilder.Entity<cubo_cnbv_bak>().HasKey(entity => new { entity.id, entity.anio, entity.mes });
            modelBuilder.Entity<cubo_conavi_bak>().HasKey(entity => new { entity.folio, entity.anio, entity.clave_estado, entity.clave_municipio });
            modelBuilder.Entity<cubo_financiamientos>().HasKey(entity => new { entity.id, entity.anio, entity.mes, entity.clave_organismo });
            modelBuilder.Entity<cubo_fovissste_bak>().HasKey(entity => new { entity.folio, entity.anio });
            modelBuilder.Entity<cubo_imss>().HasKey(entity => new { entity.id, entity.anio, entity.mes });
            modelBuilder.Entity<cubo_imss_rpt>().HasKey(entity => new { entity.id, entity.anio, entity.mes });
            modelBuilder.Entity<cubo_issste>().HasKey(entity => new { entity.id, entity.anio, entity.mes, entity.id_nombramiento, entity.id_genero, entity.id_rango_salarial, entity.id_rango_antiguedad, entity.id_sector, entity.trabajadores });
            modelBuilder.Entity<cubo_infonavit_bak>().HasKey(entity => new { entity.id, entity.anio});
            modelBuilder.Entity<desarrollador_fovissste>().HasKey(entity => new { entity.folio, entity.anio });
            modelBuilder.Entity<financiamientos>().HasKey(entity => new { entity.id, entity.anio, entity.mes, entity.clave_organismo });
            modelBuilder.Entity<fovissste>().HasKey(entity => new { entity.folio, entity.anio });
            modelBuilder.Entity<fovissste_00621_fte_his>().HasKey(entity => new { entity.periodo_rep, entity.id });
            modelBuilder.Entity<habitat>().HasKey(entity => new { entity.id, entity.anio, entity.mes});
            modelBuilder.Entity<imss>().HasKey(entity => new { entity.id, entity.anio, entity.mes });
            modelBuilder.Entity<infonavit>().HasKey(entity => new { entity.id, entity.anio });
            modelBuilder.Entity<quintil_fovissste>().HasKey(entity => new { entity.consecutivo, entity.anio });
            modelBuilder.Entity<quintil_infonavit>().HasKey(entity => new { entity.consecutivo, entity.anio });

            modelBuilder.Entity<banjercito>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<banjercito>().HasOne<c_linea_credito_banjercito>().WithMany().HasForeignKey(entity => entity.id_linea_credito);
            modelBuilder.Entity<c_entidad_federativa>().HasOne<c_region>().WithMany().HasForeignKey(entity => entity.id_region);
            modelBuilder.Entity<c_linea_apoyo_presidencia>().HasOne<c_subprograma>().WithMany().HasForeignKey(entity => entity.id_subprograma);
            modelBuilder.Entity<c_linea_apoyo_presidencia>().HasOne<c_tipo_credito>().WithMany().HasForeignKey(entity => entity.id_tipo_credito);
            modelBuilder.Entity<c_linea_credito_banjercito>().HasOne<c_tipo_credito>().WithMany().HasForeignKey(entity => entity.id_tipo_credito);
            modelBuilder.Entity<c_linea_credito_cnbv>().HasOne<c_subprograma>().WithMany().HasForeignKey(entity => entity.id_subprograma);
            modelBuilder.Entity<c_linea_credito_fovissste2>().HasOne<c_subprograma>().WithMany().HasForeignKey(entity => entity.id_subprograma);
            modelBuilder.Entity<c_linea_credito_infonavit_bak>().HasOne<c_subprograma>().WithMany().HasForeignKey(entity => entity.id_subprograma);
            modelBuilder.Entity<c_linea_credito_shf>().HasOne<c_producto_presentar_ef_shf>().WithMany().HasForeignKey(entity => entity.id_producto_presentar_ef_shf);
            modelBuilder.Entity<c_linea_credito_shf>().HasOne<c_tipo_vivienda_fonhapo>().WithMany().HasForeignKey(entity => entity.id_tipo_vivienda);
            modelBuilder.Entity<c_linea_credito_shf>().HasOne<c_subprograma>().WithMany().HasForeignKey(entity => entity.id_subprograma);
            modelBuilder.Entity<c_linea_credito_shf>().HasOne<c_tipo_credito>().WithMany().HasForeignKey(entity => entity.id_tipo_credito);
            modelBuilder.Entity<c_linea_subsidio_conavi>().HasOne<c_subprograma>().WithMany().HasForeignKey(entity => entity.id_subprograma);
            modelBuilder.Entity<c_modalidad_semanal>().HasOne<c_tipo_modalidad>().WithMany().HasForeignKey(entity => entity.id_tipo_modalidad);
            modelBuilder.Entity<c_municipio>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<c_organismo>().HasOne<c_grupo_organismo>().WithMany().HasForeignKey(entity => entity.id_grupo_organismo);
            modelBuilder.Entity<c_producto_presentar_ef_shf>().HasOne<c_producto_parametrizar_t24_shf>().WithMany().HasForeignKey(entity => entity.id_producto_parametrizar_t24);
            modelBuilder.Entity<c_programa>().HasOne<c_modalidad>().WithMany().HasForeignKey(entity => entity.id_modalidad);
            modelBuilder.Entity<c_sector_economico_2>().HasOne<c_sector_economico_1>().WithMany().HasForeignKey(entity => entity.id_sector_economico_1);
            modelBuilder.Entity<c_sector_economico_4>().HasOne<c_sector_economico_2>().WithMany().HasForeignKey(entity => entity.id_sector_economico_2);
            modelBuilder.Entity<c_subprograma>().HasOne<c_programa>().WithMany().HasForeignKey(entity => entity.id_programa);
            modelBuilder.Entity<c_subprograma>().HasOne<c_destino_credito>().WithMany().HasForeignKey(entity => entity.id_destino_credito);
            modelBuilder.Entity<c_subprograma>().HasOne<c_subprograma_sniiv>().WithMany().HasForeignKey(entity => entity.id_subprograma_sniiv);
            modelBuilder.Entity<c_tipo_ee>().HasOne<c_tipo_ee_sniiv>().WithMany().HasForeignKey(entity => entity.id_tipo_ee_sniiv);
            modelBuilder.Entity<carga_renaret>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.cve_edo);
            modelBuilder.Entity<cnbv>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<cnbv>().HasOne<c_linea_credito_cnbv>().WithMany().HasForeignKey(entity => entity.id_linea_credito);
            modelBuilder.Entity<cnbv>().HasOne<c_moneda>().WithMany().HasForeignKey(entity => entity.id_moneda);
            modelBuilder.Entity<cnbv>().HasOne<c_sector_laboral>().WithMany().HasForeignKey(entity => entity.id_sector_laboral);
            modelBuilder.Entity<cnbv>().HasOne<c_entidad_cofinanciamiento>().WithMany().HasForeignKey(entity => entity.clave_entidad_cofinanciamiento);
            modelBuilder.Entity<cnbv>().HasOne<c_producto_hipotecario>().WithMany().HasForeignKey(entity => entity.clave_producto_hipotecario);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_genero>().WithMany().HasForeignKey(entity => entity.id_genero);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_linea_subsidio_conavi>().WithMany().HasForeignKey(entity => entity.id_modalidad);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_ee>().WithMany().HasForeignKey(entity => entity.id_ee);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_tipo_vivienda>().WithMany().HasForeignKey(entity => entity.id_tipo_vivienda);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_oeo>().WithMany().HasForeignKey(entity => entity.id_oeo);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_esquema_conavi>().WithMany().HasForeignKey(entity => entity.id_esquema);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_tipo_ee>().WithMany().HasForeignKey(entity => entity.id_tipo_ee);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_mes>().WithMany().HasForeignKey(entity => entity.mes);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_vivienda_sustentable>().WithMany().HasForeignKey(entity => entity.id_vivienda_sustentable);
            modelBuilder.Entity<conavi_semanal>().HasOne<c_pcu>().WithMany().HasForeignKey(entity => entity.id_pcu);
            modelBuilder.Entity<demanda_potencial_5_10>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.cve_ent);
            modelBuilder.Entity<demanda_potencial_infonavit>().HasOne<c_salario_infonavit>().WithMany().HasForeignKey(entity => entity.id_salario_infonavit);
            modelBuilder.Entity<demanda_potencial_m10>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.cve_ent);
            modelBuilder.Entity<ee_tipo>().HasOne<c_ee>().WithMany().HasForeignKey(entity => entity.id_ee);
            modelBuilder.Entity<ee_tipo>().HasOne<c_tipo_ee>().WithMany().HasForeignKey(entity => entity.id_tipo_ee);
            modelBuilder.Entity<financiamientos>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<financiamientos>().HasOne<c_organismo>().WithMany().HasForeignKey(entity => entity.clave_organismo);
            modelBuilder.Entity<financiamientos>().HasOne<c_subprograma>().WithMany().HasForeignKey(entity => entity.id_subprograma);
            modelBuilder.Entity<financiamientos>().HasOne<c_tipo_credito>().WithMany().HasForeignKey(entity => entity.id_tipo_credito);
            modelBuilder.Entity<financiamientos>().HasOne<c_genero>().WithMany().HasForeignKey(entity => entity.id_genero);
            modelBuilder.Entity<financiamientos>().HasOne<c_rango_edad>().WithMany().HasForeignKey(entity => entity.id_rango_edad);
            modelBuilder.Entity<financiamientos>().HasOne<c_rango_salarial>().WithMany().HasForeignKey(entity => entity.id_rango_salarial);
            modelBuilder.Entity<financiamientos>().HasOne<c_valor_vivienda>().WithMany().HasForeignKey(entity => entity.id_valor_vivienda);
            modelBuilder.Entity<financiamientos>().HasOne<c_vivienda_sustentable>().WithMany().HasForeignKey(entity => entity.id_vivienda_sustentable);
            modelBuilder.Entity<fovissste>().HasOne<c_modalidad_fovissste>().WithMany().HasForeignKey(entity => entity.id_modalidad);
            modelBuilder.Entity<fovissste>().HasOne<c_linea_credito_fovissste>().WithMany().HasForeignKey(entity => entity.id_linea_credito);
            modelBuilder.Entity<fovissste>().HasOne<c_esquema_fovissste>().WithMany().HasForeignKey(entity => entity.id_esquema);
            modelBuilder.Entity<fovissste>().HasOne<c_intermediario_financiero_fovissste>().WithMany().HasForeignKey(entity => entity.id_intermediario);
            modelBuilder.Entity<grupo_esquema_cnbv>().HasOne<c_producto_hipotecario>().WithMany().HasForeignKey(entity => entity.clave_producto_hipotecario);
            modelBuilder.Entity<grupo_esquema_cnbv>().HasOne<c_entidad_cofinanciamiento>().WithMany().HasForeignKey(entity => entity.clave_entidad_cofinanciamiento);
            modelBuilder.Entity<grupo_esquema_cnbv>().HasOne<c_esquema_cnbv>().WithMany().HasForeignKey(entity => entity.id_esquema_cnbv);
            modelBuilder.Entity<habitat>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<habitat>().HasOne<c_linea_credito_habitat>().WithMany().HasForeignKey(entity => entity.id_linea_credito);
            modelBuilder.Entity<habitat>().HasOne<c_intermediario_financiero_habitat>().WithMany().HasForeignKey(entity => entity.id_intermediario);
            modelBuilder.Entity<habitat>().HasOne<c_mes>().WithMany().HasForeignKey(entity => entity.mes);
            modelBuilder.Entity<imss>().HasOne<c_registro_patronal>().WithMany().HasForeignKey(entity => entity.clave_registro_patronal);
            modelBuilder.Entity<imss>().HasOne<c_genero>().WithMany().HasForeignKey(entity => entity.id_genero);
            modelBuilder.Entity<imss>().HasOne<c_rango_edad_imss>().WithMany().HasForeignKey(entity => entity.clave_rango_edad);
            modelBuilder.Entity<imss>().HasOne<c_rango_salarial_imss>().WithMany().HasForeignKey(entity => entity.clave_rango_vsm);
            modelBuilder.Entity<imss>().HasOne<c_rango_uma_imss>().WithMany().HasForeignKey(entity => entity.clave_rango_uma);
            modelBuilder.Entity<infonavit>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<infonavit>().HasOne<c_esquema_infonavit>().WithMany().HasForeignKey(entity => entity.id_esquema);
            modelBuilder.Entity<infonavit>().HasOne<c_intermediario_financiero_infonavit>().WithMany().HasForeignKey(entity => entity.id_intermediario_financiero);
            modelBuilder.Entity<infonavit>().HasOne<c_estado_civil>().WithMany().HasForeignKey(entity => entity.estado_civil);
            modelBuilder.Entity<infonavit>().HasOne<c_tipo_credito_infonavit>().WithMany().HasForeignKey(entity => entity.tipo_credito);
            modelBuilder.Entity<infonavit>().HasOne<c_genero>().WithMany().HasForeignKey(entity => entity.id_genero);
            modelBuilder.Entity<infonavit>().HasOne<c_linea_infonavit>().WithMany().HasForeignKey(entity => entity.id_linea);
            modelBuilder.Entity<infonavit>().HasOne<c_linea_credito_infonavit_bak>().WithMany().HasForeignKey(entity => entity.id_linea_credito);
            modelBuilder.Entity<inventario_estatal>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<linea_credito_esquema_cnbv>().HasOne<c_linea_credito_cnbv>().WithMany().HasForeignKey(entity => entity.id_linea_credito_cnbv);
            modelBuilder.Entity<linea_credito_esquema_cnbv>().HasOne<c_esquema_cnbv>().WithMany().HasForeignKey(entity => entity.id_esquema_cnbv);
            modelBuilder.Entity<linea_credito_esquema_cnbv>().HasOne<c_tipo_credito>().WithMany().HasForeignKey(entity => entity.id_tipo_credito);
            modelBuilder.Entity<linea_credito_esquema_infonavit>().HasOne<c_esquema_infonavit>().WithMany().HasForeignKey(entity => entity.id_esquema_infonavit);
            modelBuilder.Entity<linea_credito_esquema_infonavit>().HasOne<c_linea_credito_infonavit_bak>().WithMany().HasForeignKey(entity => entity.id_linea_credito_infonavit);
            modelBuilder.Entity<linea_credito_esquema_infonavit>().HasOne<c_tipo_credito>().WithMany().HasForeignKey(entity => entity.id_tipo_credito);
            modelBuilder.Entity<linea_subsidio_tipo_ee>().HasOne<c_linea_subsidio_conavi>().WithMany().HasForeignKey(entity => entity.id_linea_subsidio);
            modelBuilder.Entity<linea_subsidio_tipo_ee>().HasOne<c_tipo_ee>().WithMany().HasForeignKey(entity => entity.id_tipo_ee);
            modelBuilder.Entity<linea_subsidio_tipo_ee>().HasOne<c_tipo_credito>().WithMany().HasForeignKey(entity => entity.id_tipo_credito);
            modelBuilder.Entity<programas_conavi>().HasOne<c_programa_presupuestal>().WithMany().HasForeignKey(entity => entity.id_programa_presupuestal);
            modelBuilder.Entity<programas_conavi>().HasOne<c_modalidad_presidencia>().WithMany().HasForeignKey(entity => entity.id_modalidad);
            modelBuilder.Entity<programas_conavi>().HasOne<c_linea_apoyo_presidencia>().WithMany().HasForeignKey(entity => entity.id_linea_apoyo);
            modelBuilder.Entity<programas_conavi>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<programas_conavi>().HasOne<c_genero>().WithMany().HasForeignKey(entity => entity.id_genero);
            modelBuilder.Entity<programas_conavi>().HasOne<c_derechohabiente_presidencia>().WithMany().HasForeignKey(entity => entity.id_derechohabiente);
            modelBuilder.Entity<programas_conavi>().HasOne<c_estatus_programas_conavi>().WithMany().HasForeignKey(entity => entity.id_status);
            modelBuilder.Entity<reporte_presidencia>().HasOne<c_programa_presupuestal>().WithMany().HasForeignKey(entity => entity.id_programa_presupuestal);
            modelBuilder.Entity<reporte_presidencia>().HasOne<c_modalidad_presidencia>().WithMany().HasForeignKey(entity => entity.id_modalidad);
            modelBuilder.Entity<reporte_presidencia>().HasOne<c_linea_apoyo_presidencia>().WithMany().HasForeignKey(entity => entity.id_linea_apoyo);
            modelBuilder.Entity<reporte_presidencia>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<reporte_presidencia>().HasOne<c_genero>().WithMany().HasForeignKey(entity => entity.id_genero);
            modelBuilder.Entity<reporte_presidencia>().HasOne<c_derechohabiente_presidencia>().WithMany().HasForeignKey(entity => entity.id_derechohabiente);
            modelBuilder.Entity<shf>().HasOne<c_producto_presentar_ef_shf>().WithMany().HasForeignKey(entity => entity.id_producto_presentar_ef);
            modelBuilder.Entity<shf>().HasOne<c_tipo_institucion_shf>().WithMany().HasForeignKey(entity => entity.id_tipo_institucion);
            modelBuilder.Entity<shf>().HasOne<c_tipo_vivienda_fonhapo>().WithMany().HasForeignKey(entity => entity.id_tipo_vivienda);
            modelBuilder.Entity<shf>().HasOne<c_genero>().WithMany().HasForeignKey(entity => entity.id_genero);
            modelBuilder.Entity<shf>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<shf>().HasOne<c_tipo_ingreso_shf>().WithMany().HasForeignKey(entity => entity.id_tipo_ingreso);
            modelBuilder.Entity<sisevive>().HasOne<c_entidad_federativa>().WithMany().HasForeignKey(entity => entity.clave_entidad_federativa);
            modelBuilder.Entity<sisevive>().HasOne<c_estatus_vivienda>().WithMany().HasForeignKey(entity => entity.id_estatus_vivienda);
            modelBuilder.Entity<sisevive>().HasOne<c_tipologia_ruv>().WithMany().HasForeignKey(entity => entity.id_tipologia_ruv);
            modelBuilder.Entity<sisevive>().HasOne<c_clima>().WithMany().HasForeignKey(entity => entity.id_clima);
            modelBuilder.Entity<sisevive>().HasOne<c_pcu>().WithMany().HasForeignKey(entity => entity.id_pcu);
            modelBuilder.Entity<sisevive>().HasOne<c_grupo_sisevive>().WithMany().HasForeignKey(entity => entity.id_grupo_sisevive);
            modelBuilder.Entity<sisevive>().HasOne<c_tipologia_sisevive>().WithMany().HasForeignKey(entity => entity.id_tipologia_sisevive);
            modelBuilder.Entity<sisevive>().HasOne<c_region_hidrica>().WithMany().HasForeignKey(entity => entity.id_region_hidrica);
            modelBuilder.Entity<subprograma_fovissste>().HasOne<c_esquema_fovissste>().WithMany().HasForeignKey(entity => entity.id_esquema);
            modelBuilder.Entity<subprograma_fovissste>().HasOne<c_linea_credito_fovissste>().WithMany().HasForeignKey(entity => entity.id_linea_credito);
            modelBuilder.Entity<subprograma_fovissste>().HasOne<c_modalidad_fovissste>().WithMany().HasForeignKey(entity => entity.id_modalidad);
            modelBuilder.Entity<subprograma_fovissste>().HasOne<c_subprograma>().WithMany().HasForeignKey(entity => entity.id_subprograma);
            modelBuilder.Entity<subprograma_fovissste>().HasOne<c_tipo_credito>().WithMany().HasForeignKey(entity => entity.id_tipo_credito);

            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_programa_presupuestal>().WithMany().HasForeignKey(entity => entity.id_programa_presupuestal);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_municipio>().WithMany().HasForeignKey(entity => new {entity.clave_estado, entity.clave_municipio});
            // modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_linea_subsidio_conavi>().WithMany().HasForeignKey(entity => entity.id_linea_apoyo);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_subprograma_sniiv>().WithMany().HasForeignKey(entity => entity.id_modalidad);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_esquema_conavi>().WithMany().HasForeignKey(entity => entity.id_esquema);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_tipo_ee>().WithMany().HasForeignKey(entity => entity.id_tipo_ee);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_ee>().WithMany().HasForeignKey(entity => entity.id_ee);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_oeo>().WithMany().HasForeignKey(entity => entity.id_oeo);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_genero>().WithMany().HasForeignKey(entity => entity.id_genero);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_rango_edad>().WithMany().HasForeignKey(entity => entity.id_rango_edad);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_rango_salarial>().WithMany().HasForeignKey(entity => entity.id_rango_salarial);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_valor_vivienda>().WithMany().HasForeignKey(entity => entity.id_valor_vivienda);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_tipo_vivienda>().WithMany().HasForeignKey(entity => entity.id_tipo_vivienda);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_vivienda_sustentable>().WithMany().HasForeignKey(entity => entity.id_vivienda_sustentable);
            modelBuilder.Entity<cubo_conavi_bak>().HasOne<c_pcu>().WithMany().HasForeignKey(entity => entity.id_pcu);

            
        }

        public DbSet<banjercito> banjercito { get; set; }
        public DbSet<c_avance_obra> c_avance_obra { get; set; }
        public DbSet<c_clima> c_clima { get; set; }
        public DbSet<c_derechohabiente_presidencia> c_derechohabiente_presidencia { get; set; }
        public DbSet<c_destino_credito> c_destino_credito { get; set; }
        public DbSet<c_ee> c_ee { get; set; }
        public DbSet<c_entidad_cofinanciamiento> c_entidad_cofinanciamiento { get; set; }
        public DbSet<c_entidad_federativa> c_entidad_federativa { get; set; }
        public DbSet<c_esquema_cnbv> c_esquema_cnbv { get; set; }
        public DbSet<c_esquema_conavi> c_esquema_conavi { get; set; }
        public DbSet<c_esquema_fovissste> c_esquema_fovissste { get; set; }
        public DbSet<c_esquema_infonavit> c_esquema_infonavit { get; set; }
        public DbSet<c_estado_civil> c_estado_civil { get; set; }
        public DbSet<c_estatus_programas_conavi> c_estatus_programas_conavi { get; set; }
        public DbSet<c_estatus_vivienda> c_estatus_vivienda { get; set; }
        public DbSet<c_genero> c_genero { get; set; }
        public DbSet<c_grupo_organismo> c_grupo_organismo { get; set; }
        public DbSet<c_grupo_sisevive> c_grupo_sisevive { get; set; }
        public DbSet<c_intermediario_financiero_cnbv> c_intermediario_financiero_cnbv { get; set; }
        public DbSet<c_intermediario_financiero_fovissste> c_intermediario_financiero_fovissste { get; set; }
        public DbSet<c_intermediario_financiero_habitat> c_intermediario_financiero_habitat { get; set; }
        public DbSet<c_intermediario_financiero_infonavit> c_intermediario_financiero_infonavit { get; set; }
        public DbSet<c_linea_apoyo_presidencia> c_linea_apoyo_presidencia { get; set; }
        public DbSet<c_linea_credito_banjercito> c_linea_credito_banjercito { get; set; }
        public DbSet<c_linea_credito_cnbv> c_linea_credito_cnbv { get; set; }
        public DbSet<c_linea_credito_fovissste> c_linea_credito_fovissste { get; set; }
        public DbSet<c_linea_credito_fovissste2> c_linea_credito_fovissste2 { get; set; }
        public DbSet<c_linea_credito_habitat> c_linea_credito_habitat { get; set; }
        public DbSet<c_linea_credito_infonavit_bak> c_linea_credito_infonavit_bak { get; set; }
        public DbSet<c_linea_credito_shf> c_linea_credito_shf { get; set; }
        public DbSet<c_linea_infonavit> c_linea_infonavit { get; set; }
        public DbSet<c_linea_subsidio_conavi> c_linea_subsidio_conavi { get; set; }
        public DbSet<c_localidad> c_localidad { get; set; }
        public DbSet<c_mes> c_mes { get; set; }
        public DbSet<c_modalidad> c_modalidad { get; set; }
        public DbSet<c_modalidad_fovissste> c_modalidad_fovissste { get; set; }
        public DbSet<c_modalidad_issste> c_modalidad_issste { get; set; }
        public DbSet<c_modalidad_presidencia> c_modalidad_presidencia { get; set; }
        public DbSet<c_modalidad_semanal> c_modalidad_semanal { get; set; }
        public DbSet<c_modalidad_sniiv> c_modalidad_sniiv { get; set; }
        public DbSet<c_moneda> c_moneda { get; set; }
        public DbSet<c_municipio> c_municipio { get; set; }
        public DbSet<c_municipio_imss> c_municipio_imss { get; set; }
        public DbSet<c_nombramiento> c_nombramiento { get; set; }
        public DbSet<c_oeo> c_oeo { get; set; }
        public DbSet<c_organismo> c_organismo { get; set; }
        public DbSet<c_pcu> c_pcu { get; set; }
        public DbSet<c_periodo_cnbv> c_periodo_cnbv { get; set; }
        public DbSet<c_periodo_conavi_semanal> c_periodo_conavi_semanal { get; set; }
        public DbSet<c_periodo_demanda_potencial> c_periodo_demanda_potencial { get; set; }
        public DbSet<c_periodo_financiamientos> c_periodo_financiamientos { get; set; }
        public DbSet<c_periodo_fovissste> c_periodo_fovissste { get; set; }
        public DbSet<c_periodo_imss> c_periodo_imss { get; set; }
        public DbSet<c_periodo_infonavit> c_periodo_infonavit { get; set; }
        public DbSet<c_periodo_inventario> c_periodo_inventario { get; set; }
        public DbSet<c_periodo_issste> c_periodo_issste { get; set; }
        public DbSet<c_periodo_presidencia> c_periodo_presidencia { get; set; }
        public DbSet<c_periodo_registro_vivienda> c_periodo_registro_vivienda { get; set; }
        public DbSet<c_periodo_renaret> c_periodo_renaret { get; set; }
        public DbSet<c_periodo_semanal> c_periodo_semanal { get; set; }
        public DbSet<c_periodo_sisevive> c_periodo_sisevive { get; set; }
        public DbSet<c_producto_hipotecario> c_producto_hipotecario { get; set; }
        public DbSet<c_producto_parametrizar_t24> c_producto_parametrizar_t24 { get; set; }
        public DbSet<c_producto_parametrizar_t24_shf> c_producto_parametrizar_t24_shf { get; set; }
        public DbSet<c_producto_presentar_ef_shf> c_producto_presentar_ef_shf { get; set; }
        public DbSet<c_programa> c_programa { get; set; }
        public DbSet<c_programa_presupuestal> c_programa_presupuestal { get; set; }
        public DbSet<c_programa_sisevive> c_programa_sisevive { get; set; }
        public DbSet<c_ramo> c_ramo { get; set; }
        public DbSet<c_rango_edad> c_rango_edad { get; set; }
        public DbSet<c_rango_edad_imss> c_rango_edad_imss { get; set; }
        public DbSet<c_rango_salarial> c_rango_salarial { get; set; }
        public DbSet<c_rango_salarial_imss> c_rango_salarial_imss { get; set; }
        public DbSet<c_rango_uma_imss> c_rango_uma_imss { get; set; }
        public DbSet<c_recamara> c_recamara { get; set; }
        public DbSet<c_region> c_region { get; set; }
        public DbSet<c_region_hidrica> c_region_hidrica { get; set; }
        public DbSet<c_registro_patronal> c_registro_patronal { get; set; }
        public DbSet<c_salario_infonavit> c_salario_infonavit { get; set; }
        public DbSet<c_salario_minimo> c_salario_minimo { get; set; }
        public DbSet<c_sector> c_sector { get; set; }
        public DbSet<c_sector_economico_1> c_sector_economico_1 { get; set; }
        public DbSet<c_sector_economico_2> c_sector_economico_2 { get; set; }
        public DbSet<c_sector_economico_4> c_sector_economico_4 { get; set; }
        public DbSet<c_sector_laboral> c_sector_laboral { get; set; }
        public DbSet<c_segmento_demanda_potencial> c_segmento_demanda_potencial { get; set; }
        public DbSet<c_subprograma> c_subprograma { get; set; }
        public DbSet<c_subprograma_sniiv> c_subprograma_sniiv { get; set; }
        public DbSet<c_superficie> c_superficie { get; set; }
        public DbSet<c_tipo_credito> c_tipo_credito { get; set; }
        public DbSet<c_tipo_credito_infonavit> c_tipo_credito_infonavit { get; set; }
        public DbSet<c_tipo_ee> c_tipo_ee { get; set; }
        public DbSet<c_tipo_ee_sniiv> c_tipo_ee_sniiv { get; set; }
        public DbSet<c_tipo_ingreso_shf> c_tipo_ingreso_shf { get; set; }
        public DbSet<c_tipo_institucion_shf> c_tipo_institucion_shf { get; set; }
        public DbSet<c_tipo_modalidad> c_tipo_modalidad { get; set; }
        public DbSet<c_tipo_vivienda> c_tipo_vivienda { get; set; }
        public DbSet<c_tipo_vivienda_fonhapo> c_tipo_vivienda_fonhapo { get; set; }
        public DbSet<c_tipologia_ruv> c_tipologia_ruv { get; set; }
        public DbSet<c_tipologia_sisevive> c_tipologia_sisevive { get; set; }
        public DbSet<c_valor_vivienda> c_valor_vivienda { get; set; }
        public DbSet<c_valor_vivienda_uma> c_valor_vivienda_uma { get; set; }
        public DbSet<c_vivienda_sustentable> c_vivienda_sustentable { get; set; }
        public DbSet<carga_renaret> carga_renaret { get; set; }
        public DbSet<cnbv> cnbv { get; set; }
        public DbSet<cnbv_coofinanciamiento> cnbv_coofinanciamiento { get; set; }
        public DbSet<conavi_06100_fte_his> conavi_06100_fte_his { get; set; }
        public DbSet<conavi_semanal> conavi_semanal { get; set; }
        public DbSet<cubo_cnbv_bak> cubo_cnbv_bak { get; set; }
        public DbSet<cubo_conavi_bak> cubo_conavi_bak { get; set; }
        public DbSet<cubo_financiamientos> cubo_financiamientos { get; set; }
        public DbSet<cubo_fovissste_bak> cubo_fovissste_bak { get; set; }
        public DbSet<cubo_imss> cubo_imss { get; set; }
        public DbSet<cubo_imss_rpt> cubo_imss_rpt { get; set; }
        public DbSet<cubo_infonavit_bak> cubo_infonavit_bak { get; set; }
        public DbSet<cubo_inventario_vivienda> cubo_inventario_vivienda { get; set; }
        public DbSet<cubo_issste> cubo_issste { get; set; }
        public DbSet<cubo_registro_vivienda_bak> cubo_registro_vivienda_bak { get; set; }
        public DbSet<cubo_semanal> cubo_semanal { get; set; }
        public DbSet<cubo_sisevive> cubo_sisevive { get; set; }
        public DbSet<demanda_potencial_5_10> demanda_potencial_5_10 { get; set; }
        public DbSet<demanda_potencial_infonavit> demanda_potencial_infonavit { get; set; }
        public DbSet<demanda_potencial_m10> demanda_potencial_m10 { get; set; }
        public DbSet<desarrollador_fovissste> desarrollador_fovissste { get; set; }
        public DbSet<ee_tipo> ee_tipo { get; set; }
        public DbSet<financiamientos> financiamientos { get; set; }
        public DbSet<fovissste> fovissste { get; set; }
        public DbSet<fovissste_00621_fte_his> fovissste_00621_fte_his { get; set; }
        public DbSet<grupo_esquema_cnbv> grupo_esquema_cnbv { get; set; }
        public DbSet<habitat> habitat { get; set; }
        public DbSet<imss> imss { get; set; }
        public DbSet<infonavit> infonavit { get; set; }
        public DbSet<infonavit_00635_fte_his> infonavit_00635_fte_his { get; set; }
        public DbSet<inventario_estatal> inventario_estatal { get; set; }
        public DbSet<inventario_municipal> inventario_municipal { get; set; }
        public DbSet<inventario_vivienda> inventario_vivienda { get; set; }
        public DbSet<issste> issste { get; set; }
        public DbSet<linea_credito_esquema_cnbv> linea_credito_esquema_cnbv { get; set; }
        public DbSet<linea_credito_esquema_infonavit> linea_credito_esquema_infonavit { get; set; }
        public DbSet<linea_subsidio_tipo_ee> linea_subsidio_tipo_ee { get; set; }
        public DbSet<mapa_oferta> mapa_oferta { get; set; }
        public DbSet<programas_conavi> programas_conavi { get; set; }
        public DbSet<quintil_fovissste> quintil_fovissste { get; set; }
        public DbSet<quintil_infonavit> quintil_infonavit { get; set; }
        public DbSet<registro_vivienda> registro_vivienda { get; set; }
        public DbSet<renaret> renaret { get; set; }
        public DbSet<reporte_presidencia> reporte_presidencia { get; set; }
        public DbSet<shf> shf { get; set; }
        public DbSet<sisevive> sisevive { get; set; }
        public DbSet<sisevive_ruv> sisevive_ruv { get; set; }
        public DbSet<subprograma_fovissste> subprograma_fovissste { get; set; }

    }
}
