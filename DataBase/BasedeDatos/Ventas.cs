//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase.BasedeDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        public short ID_Venta { get; set; }
        public byte Cant_Ventas { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Tot_Tarjeta { get; set; }
        public decimal Tot_Venta { get; set; }
    }
}