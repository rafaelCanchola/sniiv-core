using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class sisevive_ruv
	{
		[Key] public int id { get; set; }
		[StringLength(50)] public string cuv {get; set;}
		public int id_programa {get; set;}
		public int id_tipologia_ruv {get; set;}
		[StringLength(10)] public string idg {get; set;}
		public Decimal co2 {get; set;}
		public int cv_oferta {get; set;}
		public Decimal latitud {get; set;}
		public Decimal longitud {get; set;}
		public Decimal lalitud_oferta {get; set;}
		public Decimal longitud_oferta {get; set;}
		public DateTime fecha_ind {get; set;}
		[StringLength(50)] public string inst_ind {get; set;}
	}
}
