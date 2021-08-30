using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_organismo
	{
		[Key] [StringLength(10)] public string clave {get; set;}
		public int id_grupo_organismo {get; set;}
		[StringLength(10)] public string siglas {get; set;}
		public string descripcion {get; set;}
	}
}
