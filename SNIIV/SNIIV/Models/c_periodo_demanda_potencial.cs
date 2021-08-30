using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_periodo_demanda_potencial
	{
		public int anio {get; set;}
		public int mes {get; set;}
		public Boolean actual {get; set;}
	}
}
