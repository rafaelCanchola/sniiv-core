using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_linea_credito_shf
	{
		[Key] public int id {get; set;}
		public int id_producto_presentar_ef_shf {get; set;}
		public int id_tipo_vivienda {get; set;}
		public int id_subprograma {get; set;}
		public int id_tipo_credito {get; set;}
	}
}
