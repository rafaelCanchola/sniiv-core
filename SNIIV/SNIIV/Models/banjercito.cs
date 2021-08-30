using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class banjercito
	{
		[Key] public int id {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_linea_credito {get; set;}
		public string producto {get; set;}
		public int acciones {get; set;}
		public Decimal monto {get; set;}
		[StringLength(10)] public string genero {get; set;}
		public int edad {get; set;}
		public Decimal ingreso_VSMMDF {get; set;}
		public Decimal valor_vivienda_vsmmdf {get; set;}
		public string tipo_vivienda {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
	}
}
