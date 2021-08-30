using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_valor_vivienda
	{
		[Key] public int id {get; set;}
		public int rango {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
