using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class infonavit_00635_fte_his
	{
		public int anio {get; set;}
		[StringLength(10)] public string mes {get; set;}
		public Decimal CT_CREDITO_AUTORIZADO_VSM {get; set;}
		[StringLength(10)] public string CT_EDAD {get; set;}
		[StringLength(50)] public string CV_CUV {get; set;}
		[StringLength(10)] public string CV_ENTIDAD_CAPTURA {get; set;}
		[StringLength(10)] public string CV_ENTIDAD_FEDERATIVA_EJERCICIO {get; set;}
		[StringLength(10)] public string CV_ENTIDAD_VIVIENDA {get; set;}
		[StringLength(10)] public string CV_MUNICIPIO_VIVIENDA {get; set;}
		[StringLength(10)] public string CV_ESTADO_CIVIL {get; set;}
		[StringLength(10)] public string CV_TIPO_CREDITO {get; set;}
		[StringLength(10)] public string CV_TIPO_MONEDA {get; set;}
		public DateTime FH_ENVIO_PAGO {get; set;}
		[StringLength(10)] public string NU_BIMESTRES_COTIZACION {get; set;}
		[StringLength(10)] public string ID_GENERO {get; set;}
		[StringLength(10)] public string ID_SEGUNDO_CREDITO {get; set;}
		[StringLength(10)] public string ID_TIPO_LINEA_CREDITO {get; set;}
		public Decimal IM_CAPACIDAD_COMPRA_VSM {get; set;}
		public Decimal IM_COFINANCIAMIENTO_PESOS {get; set;}
		public Decimal IM_PRECIO_VENTA {get; set;}
		public Decimal IM_SALARIO_INTEGRADO {get; set;}
		public Decimal IM_SALDO_SUBCUENTA {get; set;}
		public Decimal IN_VIVIENDA_NUEVA {get; set;}
		public Decimal PC_TASA_INTERES {get; set;}
		public Boolean IN_SUSTENTABILIDAD {get; set;}
		public string programa {get; set;}
		public string programa_TXT {get; set;}
		public string sub_programa {get; set;}
		public string sub_programa_TXT {get; set;}
		public string entidad_financiera {get; set;}
		public string producto {get; set;}
		public string sub_producto {get; set;}
		public Decimal Inversion_Infonavit {get; set;}
		public Decimal estimacion_inversion_entidad_financiera {get; set;}
		public Decimal Derrama_Infonavit {get; set;}
		public Decimal Inversion_Total {get; set;}
		[StringLength(10)] public string PERIODO_REP {get; set;}
		[Key]public int ID {get; set;}
	}
}
