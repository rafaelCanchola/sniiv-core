using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_linea_subsidio_conavi
	{
		[Key] public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
		public int id_subprograma {get; set;}
	}
}
