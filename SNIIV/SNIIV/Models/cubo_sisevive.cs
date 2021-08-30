using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class cubo_sisevive
	{
		[Key] public int id { get; set; }
		public int anio {get; set;}
		[StringLength(10)] public string clave_estado {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_tipologia_ruv {get; set;}
		public int id_clima {get; set;}
		public int id_pcu {get; set;}
		[StringLength(10)] public string idg {get; set;}
		public int id_programa {get; set;}
		public DateTime fecha {get; set;}
		public int id_tipologia_sisevive {get; set;}
		public int id_grupo_sisevive {get; set;}
		public int viviendas {get; set;}
	}
}
