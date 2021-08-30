using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_modalidad_presidencia
	{
		[Key] public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
		[StringLength(50)] public string nombre {get; set;}
	}
}
