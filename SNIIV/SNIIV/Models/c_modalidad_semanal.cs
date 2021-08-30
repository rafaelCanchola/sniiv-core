using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_modalidad_semanal
	{
		[Key] public int id {get; set;}
		public int id_tipo_modalidad {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
