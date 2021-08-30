using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class registro_vivienda
	{
		[Key] public int id { get; set; }
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string cve_ent {get; set;}
		[StringLength(10)] public string cve_mun {get; set;}
		[StringLength(10)] public string cv_oferente {get; set;}
		[StringLength(10)] public string pcu {get; set;}
		[StringLength(50)] public string segmento_conavi {get; set;}
		public string segmento_uma {get; set;}
		[StringLength(50)] public string tipo_viv {get; set;}
		[StringLength(10)] public string cv_tipo_vivienda {get; set;}
		[StringLength(50)] public string superficies {get; set;}
		[StringLength(50)] public string recamara {get; set;}
		public int viviendas {get; set;}
	}
}
