using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class infonavit
	{
		public int id {get; set;}
		[StringLength(50)] public string cuv {get; set;}
		[StringLength(10)] public string clave_entidad_captura {get; set;}
		[StringLength(10)] public string clave_entidad_ejercicio {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_esquema {get; set;}
		public int id_intermediario_financiero {get; set;}
		public int edad {get; set;}
		[StringLength(10)] public string estado_civil {get; set;}
		[StringLength(10)] public string tipo_credito {get; set;}
		public int id_genero {get; set;}
		public int id_segundo_credito {get; set;}
		public int id_linea {get; set;}
		public Decimal precio_venta {get; set;}
		public Decimal salario_integrado {get; set;}
		public Boolean vivienda_nueva {get; set;}
		public int id_linea_credito {get; set;}
		public Decimal inversion_infonavit {get; set;}
		public Decimal inversion_entidad_financiera {get; set;}
		public Decimal derrama_infonavit {get; set;}
		public DateTime fecha_pago {get; set;}
		public Boolean sustentabilidad {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
	}
}
