using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class habitat
	{
		public string id {get; set;}
		public DateTime fecha_operacion {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_linea_credito {get; set;}
		[StringLength(50)] public string cuv {get; set;}
		public int id_intermediario {get; set;}
		public int acciones {get; set;}
		public Decimal recurso_propio {get; set;}
		public Decimal recurso_federal {get; set;}
		public Decimal recurso_beneficiario {get; set;}
		public Decimal recurso_financiero {get; set;}
		[StringLength(10)] public string genero {get; set;}
		public int edad {get; set;}
		public Decimal ingreso_salarial {get; set;}
		public int valor_vivienda {get; set;}
		public int tipo_vivienda {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
	}
}
