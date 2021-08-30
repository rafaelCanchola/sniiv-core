using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_rango_salarial
	{
		[Key] public int id {get; set;}
		public Decimal rango_inicio {get; set;}
		public Decimal rango {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
