//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web.TI_Web.modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROFESOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROFESOR()
        {
            this.CURSOes = new HashSet<CURSO>();
        }
    
        public int ID_PROFESOR { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
        public Nullable<int> ID_USUARIO_CREA { get; set; }
        public Nullable<int> ID_USUARIO_MOD { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string CORREO { get; set; }
        public Nullable<int> CELULAR { get; set; }
        public string DIRECCION { get; set; }
        public string PROFESION { get; set; }
        public string ABSTRACT { get; set; }
        public Nullable<int> DNI { get; set; }
        public Nullable<int> ESTADO { get; set; }
        public string FECHA_CREA { get; set; }
        public string FECHA_MOD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CURSO> CURSOes { get; set; }
    }
}