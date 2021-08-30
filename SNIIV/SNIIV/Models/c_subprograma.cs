using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_subprograma
	{
		public int id_programa {get; set;}
		[Key] public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
		public int id_destino_credito {get; set;}
		public int id_subprograma_sniiv {get; set;}
	}
}
