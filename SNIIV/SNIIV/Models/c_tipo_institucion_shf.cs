using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_tipo_institucion_shf
	{
		[Key] public int id {get; set;}
		public string descripcion {get; set;}
	}
}
