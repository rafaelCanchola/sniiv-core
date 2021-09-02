using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_segmento_demanda_potencial
	{
		[Key] public int id {get; set;}
		[StringLength(50)] public string nombre {get; set;}
		public int orden {get; set;}
	}
}
