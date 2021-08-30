using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_rango_uma_imss
	{
		[Key] [StringLength(10)] public string clave {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
		[StringLength(10)] public string abreviacion {get; set;}
	}
}
