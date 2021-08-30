using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_programa
	{
		[Key] public int id {get; set;}
		public int id_modalidad {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
