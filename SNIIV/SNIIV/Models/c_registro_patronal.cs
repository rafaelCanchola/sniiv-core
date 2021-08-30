using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_registro_patronal
	{
		[Key] [StringLength(10)] public string clave {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
