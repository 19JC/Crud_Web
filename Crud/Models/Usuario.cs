//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crud.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public int Id_Sexualidad { get; set; }
    
        public virtual Sexualidad Sexualidad { get; set; }
    }
}
