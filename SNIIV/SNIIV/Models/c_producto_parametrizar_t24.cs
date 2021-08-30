using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_producto_parametrizar_t24
	{
		public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
