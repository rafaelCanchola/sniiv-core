using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_intermediario_financiero_habitat
	{
		[Key] public int id {get; set;}
		public string descripcion {get; set;}
	}
}
