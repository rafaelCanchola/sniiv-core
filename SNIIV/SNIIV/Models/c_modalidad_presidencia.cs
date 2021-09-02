using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_modalidad_presidencia
	{
		[Key] public int id {get; set;}
		public string descripcion {get; set;}
		public string nombre {get; set;}
	}
}
