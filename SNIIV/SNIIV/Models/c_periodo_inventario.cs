using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_periodo_inventario
	{
		public int anio {get; set;}
		public int mes {get; set;}
		public Boolean actual {get; set;}
	}
}
