using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_avance_de_obra
	{
		public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
