using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class cubo_cnbv_bak
	{
		public int id {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string clave_estado {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_modalidad {get; set;}
		public int id_linea_credito {get; set;}
		public int id_esquema {get; set;}
		[StringLength(10)] public string clave_intermediarios_financiero {get; set;}
		public int id_genero {get; set;}
		public int id_rango_edad {get; set;}
		public int id_rango_salarial {get; set;}
		public int id_valor_vivienda {get; set;}
		public Decimal monto {get; set;}
		public int acciones {get; set;}
	}
}
