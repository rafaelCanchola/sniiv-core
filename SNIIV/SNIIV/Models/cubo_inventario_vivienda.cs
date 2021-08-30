using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class cubo_inventario_vivienda
	{
		[Key] public int id { get; set; }
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string clave_estado {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_pcu {get; set;}
		public int id_avance_obra {get; set;}
		public int id_segmento {get; set;}
		public int id_segmento_uma {get; set;}
		public int id_tipo_vivienda {get; set;}
		[StringLength(10)] public string subsidio {get; set;}
		public int viviendas {get; set;}
	}
}
