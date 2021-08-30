using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class shf
	{
		[Key]public int id {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(50)] public string cuv {get; set;}
		[StringLength(10)] public string id_microcredito {get; set;}
		public int id_producto_presentar_ef {get; set;}
		public int id_tipo_institucion {get; set;}
		public Decimal valor_vivienda {get; set;}
		public int id_tipo_vivienda {get; set;}
		public Decimal monto_microcredito_if {get; set;}
		public Decimal ingresos_acreditado {get; set;}
		public int id_genero {get; set;}
		public int edad {get; set;}
		public Decimal ingresos_coadreditado {get; set;}
		public int genero_coacreditado {get; set;}
		public int edad_coacreditado {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_tipo_ingreso {get; set;}
		public Decimal subsidio {get; set;}
		public Decimal monto_mensual {get; set;}
		public int plazo_credito {get; set;}
		public int acciones {get; set;}
		public Decimal monto {get; set;}
	}
}
