using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_ramo
	{
		[Key] public int id {get; set;}
		public string descripcion {get; set;}
	}
}
