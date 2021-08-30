using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_linea_apoyo_presidencia
	{
		[Key] public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
		public int id_subprograma {get; set;}
		public int id_tipo_credito {get; set;}
		[StringLength(10)] public string etiqueta {get; set;}
	}
}
