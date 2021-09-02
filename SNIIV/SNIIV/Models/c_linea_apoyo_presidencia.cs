using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_linea_apoyo_presidencia
	{
		[Key] public int id {get; set;}
		public string descripcion {get; set;}
		public int id_subprograma {get; set;}
		public int id_tipo_credito {get; set;}
		public string etiqueta {get; set;}
	}
}
