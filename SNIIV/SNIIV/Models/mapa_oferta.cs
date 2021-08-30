using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class mapa_oferta
	{
		[Key] public int id { get; set; }
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string cve_ent {get; set;}
		[StringLength(10)] public string cve_mun {get; set;}
		public string mun {get; set;}
		[StringLength(25)] public string cv_oferta {get; set;}
		public string nom_oferta {get; set;}
		public string cv_oferente {get; set;}
		[StringLength(25)] public string tx_oferente {get; set;}
		public int cv_gpo_conavi {get; set;}
		public string gpo_conavi {get; set;}
		public Decimal latitud_of {get; set;}
		public Decimal longitud_of {get; set;}
		public Decimal avg_precio {get; set;}
		public Decimal max_precio {get; set;}
		public Decimal min_precio {get; set;}
		public Decimal desv_precio {get; set;}
		public int num_viv {get; set;}
		public int subsidio_si {get; set;}
		public int subsidio_no {get; set;}
		public int u1 {get; set;}
		public int u2 {get; set;}
		public int u3 {get; set;}
		public int fuera_contorno {get; set;}
		public int nd {get; set;}
		public int avance_1_19 {get; set;}
		public int avance_20_39 {get; set;}
		public int avance_40_59 {get; set;}
		public int avance_60_79 {get; set;}
		public int avance_80_99 {get; set;}
		public int sin_hab {get; set;}
		public int hab_men_5 {get; set;}
		public int hab_may_5 {get; set;}
		public int sin_rep {get; set;}
		public int srep_a_0_39 {get; set;}
		public int a_40_99 {get; set;}
		public int shab_hab5 {get; set;}
		public int viv_proc_avlt50 {get; set;}
		public int viv_proc_50_99 {get; set;}
		public int viv_term_rec {get; set;}
		public int viv_term_ant {get; set;}
	}
}
