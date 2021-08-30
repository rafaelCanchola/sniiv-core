using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class reporte_presidencia
	{
		[Key] public int id {get; set;}
		public DateTime fecha_aprobacion_comite_financiamiento {get; set;}
		public string numero_comite_financiamiento {get; set;}
		public int id_programa_presupuestal {get; set;}
		[StringLength(10)] public string partida_presupuestal {get; set;}
		[StringLength(10)] public string unidad_medida {get; set;}
		public int id_modalidad {get; set;}
		public int id_linea_apoyo {get; set;}
		public int id_vertiente {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		[StringLength(10)] public string clave_localidad {get; set;}
		public int edad {get; set;}
		public int id_rango_edad {get; set;}
		public int id_genero {get; set;}
		public int beneficiario_meta {get; set;}
		public int beneficiario_comprometidos {get; set;}
		public Decimal dato_presupuestal_importe_aprobado {get; set;}
		[StringLength(10)] public string colonia {get; set;}
		[StringLength(10)] public string condicion_indigena {get; set;}
		public int id_derechohabiente {get; set;}
		public int anio {get; set;}
		public Boolean status {get; set;}
		public int id_status {get; set;}
		public Decimal dato_prespuestal_importe_modificado {get; set;}
		public Decimal dato_prespuestal_importe_compromiso {get; set;}
		public Decimal dato_prespuestal_importe_programado {get; set;}
		public Decimal dato_prespuestal_importe_ejercido {get; set;}
		public Decimal forma_pago_directo {get; set;}
		public Decimal forma_pago_dispersion {get; set;}
	}
}
