using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class quintil_fovissste
	{
		public int consecutivo {get; set;}
		public int anio {get; set;}
		[StringLength(10)] public string clave_estado {get; set;}
		public int id_rango_edad {get; set;}
		public int id_genero {get; set;}
		public int acciones {get; set;}
		[StringLength(10)] public string quintil {get; set;}
	}
}
