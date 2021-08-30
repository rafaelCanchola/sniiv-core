using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_segmento_demanda_potencial
	{
		[Key] public int id {get; set;}
		[StringLength(10)] public string nombre {get; set;}
		public int orden {get; set;}
	}
}
