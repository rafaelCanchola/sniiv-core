using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_salario_infonavit
	{
		public int Id {get; set;}
		public int anio {get; set;}
		[StringLength(10)] public string periodo {get; set;}
		public Decimal A {get; set;}
		public Decimal B {get; set;}
		public Decimal C {get; set;}
		public Decimal UMA {get; set;}
	}
}
