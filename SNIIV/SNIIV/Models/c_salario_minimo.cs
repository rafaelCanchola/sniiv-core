using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_salario_minimo
	{
		public int id {get; set;}
		public int anio { get; set; }
		public string periodo {get; set;}
		public Decimal a { get; set; }
		public Decimal b { get; set; }
		public Decimal c { get; set; }
		public Decimal uma { get; set; }

	}
}
