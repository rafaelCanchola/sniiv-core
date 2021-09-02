using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_producto_hipotecario
	{
		[StringLength(10)] public string id {get; set;}
		public string descripcion {get; set;}
	}
}
