using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_linea_credito_fovissste2
	{
		[Key] public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
		public int id_subprograma {get; set;}
	}
}
