using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class fovissste_00621_fte_his
	{
		[StringLength(50)] public string CUV {get; set;}
		public string entidad_federativa {get; set;}
		public string municipio {get; set;}
		public string modalidad {get; set;}
		public string linea_credito {get; set;}
		public string producto {get; set;}
		public string subproducto {get; set;}
		public string intermediario_financiero {get; set;}
		public int acciones {get; set;}
		public Decimal inversion {get; set;}
		public Decimal valor_vivienda {get; set;}
		[StringLength(10)] public string genero {get; set;}
		[StringLength(10)] public string edad {get; set;}
		public Decimal ingreso_VSMMDF {get; set;}
		[StringLength(50)] public string mes_corte {get; set;}
		public DateTime fecha_de_firma {get; set;}
		[StringLength(10)] public string observaciones {get; set;}
		[StringLength(10)] public string desarrollador {get; set;}
		public int folio {get; set;}
		[StringLength(10)] public string mes {get; set;}
		[Key][StringLength(10)] public string PERIODO_REP {get; set;}
		public int contador {get; set;}
		public int id {get; set;}
	}
}
