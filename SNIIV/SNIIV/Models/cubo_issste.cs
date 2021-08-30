using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class cubo_issste
	{
		public int id {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		public int id_nombramiento {get; set;}
		[StringLength(50)] public string nombramiento {get; set;}
		public int id_genero {get; set;}
		public int id_rango_salarial {get; set;}
		public int id_rango_antiguedad {get; set;}
		public int id_sector {get; set;}
		[StringLength(50)] public string sector {get; set;}
		public int trabajadores {get; set;}
	}
}
