using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_rango_edad
	{
		[Key] public int id {get; set;}
		public int edad_inicio {get; set;}
		public int edad_fin {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
