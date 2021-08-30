using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class inventario_estatal
	{
		[Key] public int id { get; set; }
		public int anio {get; set;}
		public int trimestre {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		public int registro {get; set;}
		public int construccion {get; set;}
		public int venta {get; set;}
		public int total {get; set;}
		public int numero_vivienda {get; set;}
	}
}
