using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class inventario_vivienda
	{
		[Key] public int id { get; set; }
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string cve_ent {get; set;}
		[StringLength(10)] public string cve_mun {get; set;}
		public int cv_gpo_conavi {get; set;}
		[StringLength(25)] public string cv_oferente {get; set;}
		[StringLength(25)] public string cv_oferta {get; set;}
		public int tipo_viv {get; set;}
		[StringLength(10)] public string cv_tipo_vivienda {get; set;}
		[StringLength(10)] public string pcu {get; set;}
		public string nodo {get; set;}
		public string segmento {get; set;}
		public string segmento_uma {get; set;}
		[StringLength(10)] public string subsidio {get; set;}
		public int Inventario_real {get; set;}
		public string superficie {get; set;}
		public int viviendas {get; set;}
	}
}
