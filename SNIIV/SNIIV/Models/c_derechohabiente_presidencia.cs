using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_derechohabiente_presidencia
	{
		[Key] public int id {get; set;}
		public string descripcion {get; set;}
		public int id_destino {get; set;}
	}
}
