using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class cubo_semanal
	{
		[Key] public int id {get; set;}
		public int anio {get; set;}
		[StringLength(10)] public string clave_estado {get; set;}
		[StringLength(10)] public string clave_organismo {get; set;}
		public int id_tipo_modalidad {get; set;}
		public int id_modalidad {get; set;}
		public int semana {get; set;}
		public int id_region {get; set;}
		public Decimal monto {get; set;}
		public int acciones {get; set;}
	}
}
