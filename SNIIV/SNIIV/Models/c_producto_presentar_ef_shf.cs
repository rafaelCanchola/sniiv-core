using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_producto_presentar_ef_shf
	{
		[Key] public int id {get; set;}
		public int id_producto_parametrizar_t24 {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
