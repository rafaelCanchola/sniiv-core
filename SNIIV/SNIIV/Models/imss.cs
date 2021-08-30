using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class imss
	{
		public int id {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		public int id_delegacion {get; set;}
		public int id_subdelegacion {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		[StringLength(10)] public string clave_sector_economico {get; set;}
		[StringLength(10)] public string clave_registro_patronal {get; set;}
		public int id_genero {get; set;}
		[StringLength(10)] public string clave_rango_edad {get; set;}
		[StringLength(10)] public string clave_rango_vsm {get; set;}
		[StringLength(10)] public string clave_rango_uma {get; set;}
		public int asegurados {get; set;}
		public int numero_trabajadores {get; set;}
		public int empleo_asegurado {get; set;}
		public int empleo_eventual_urbano {get; set;}
		public int empleo_eventual_campo {get; set;}
		public int empleo_permanente_urbano {get; set;}
		public int empleo_permanente_campo {get; set;}
		public int empleo_asegurado_salario_asociado {get; set;}
		public int empleo_eventual_urbano_salario_asociado {get; set;}
		public int empleo_eventual_campo_salario_asociado {get; set;}
		public int empleo_permanente_urbano_salario_asociado {get; set;}
		public int empleo_permanente_campo_salario_asociado {get; set;}
		public Decimal masa_salarial_asociada_empleo_asegurado {get; set;}
		public Decimal masa_salarial_asociada_empleo_eventual_urbano {get; set;}
		public Decimal masa_salarial_asociada_empleo_eventual_campo {get; set;}
		public Decimal masa_salarial_asociada_empleo_permanente_urbano {get; set;}
		public Decimal masa_salarial_asociada_empleo_permanente_campo {get; set;}
	}
}
