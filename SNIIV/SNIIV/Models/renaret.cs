using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class renaret
	{
		[Key] public int id {get; set;}
		public int duis {get; set;}
		[StringLength(50)] public string cve_ruv {get; set;}
		public string municipio {get; set;}
		public string estado {get; set;}
		public string cd_sun {get; set;}
		public Decimal sup_ha {get; set;}
		[StringLength(10)] public string grado_desar_declarado {get; set;}
		[StringLength(10)] public string grado_desar_verificado {get; set;}
		[StringLength(10)] public string calif {get; set;}
		[StringLength(10)] public string calif_pcu {get; set;}
		[StringLength(10)] public string calif_mesa {get; set;}
		public int empl_total {get; set;}
		public int empl_no_urb {get; set;}
		public int empl_urb {get; set;}
		public int viv_total {get; set;}
		public int viv_ur {get; set;}
		public int viv_no_urb {get; set;}
		[StringLength(10)] public string r_desliz {get; set;}
		[StringLength(10)] public string r_inunda {get; set;}
		[StringLength(10)] public string r_sismo {get; set;}
		[StringLength(10)] public string atlas_riesg {get; set;}
		[StringLength(10)] public string pcu_rt {get; set;}
		[StringLength(10)] public string fc {get; set;}
		[StringLength(10)] public string cve_edo_mun {get; set;}
		[StringLength(10)] public string cve_edo {get; set;}
		[StringLength(10)] public string cve_mun {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		public int folio {get; set;}
	}
}
