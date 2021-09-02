using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class demanda_potencial_5_10
	{
		public string ent {get; set;}
		public string mun {get; set;}
		public int hasta_2_6_uma {get; set;}
		public int de_2_61_a_3_0_uma {get; set;}
		public int de_3_1_a_4_0_uma {get; set;}
		public int de_4_1_a_5_0_uma {get; set;}
		public int de_5_1_a_10_0_uma {get; set;}
		public int total_general {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string cve_ent {get; set;}
		[StringLength(10)] public string cve_mun {get; set;}
		[Key] public int id {get; set;}
	}
}
