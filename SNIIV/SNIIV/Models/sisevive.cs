using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNIIV.Models
{
	public class sisevive
	{
		[Key]
		[Column(TypeName = "bigint")]
		public int id { get; set; }
		[StringLength(50)] public string cuv {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_estatus_vivienda {get; set;}
		public int id_prototipo {get; set;}
		public int id_tipologia_ruv {get; set;}
		public int id_clima {get; set;}
		public int id_pcu {get; set;}
		[StringLength(10)] public string idg {get; set;}
		public Decimal co2 {get; set;}
		public int id_programas {get; set;}
		public DateTime fecha {get; set;}
		public int id_grupo_sisevive {get; set;}
		public Decimal latitud_vivienda {get; set;}
		public Decimal longitud_vivienda {get; set;}
		public Decimal latitud_oferta {get; set;}
		public Decimal longitud_oferta {get; set;}
		public int id_tipologia_sisevive {get; set;}
		public int id_region_hidrica {get; set;}
		public int demanda_especifica {get; set;}
		public int demanda_energia {get; set;}
		public int emisiones_co2 {get; set;}
		public int ahorro_energia {get; set;}
		public int norma_020 {get; set;}
		public int cv_idg {get; set;}
		public int cv_estatus_idg {get; set;}
		public Decimal cpa {get; set;}
		public DateTime fecha_documento {get; set;}
		public int clave_oferta {get; set;}
		public int id_vivienda {get; set;}
		public int clave_oferente {get; set;}
		public int clave_ov {get; set;}
		public int clave_verificador {get; set;}
		public DateTime fecha_inicio_ov {get; set;}
		public DateTime fecha_fin_ov {get; set;}
		public int avance {get; set;}
		[StringLength(10)] public string tipo_vivienda {get; set;}
		public Decimal superficie_habitable {get; set;}
		public Decimal precio_vivienda {get; set;}
	}
}
