using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_producto_hipotecario
	{
		[StringLength(10)] public string id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
