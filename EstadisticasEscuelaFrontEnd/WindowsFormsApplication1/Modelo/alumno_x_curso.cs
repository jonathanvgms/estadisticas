//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstadisticasEscuelaFrontEnd.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class alumno_x_curso
    {
        public alumno_x_curso()
        {
            this.asistencia = new HashSet<asistencia>();
        }
    
        public int Id { get; set; }
        public int AnioLectivo { get; set; }
        public bool Habilitado { get; set; }
        public int IdCurso { get; set; }
        public int IdAlumno { get; set; }
    
        public virtual alumno alumno { get; set; }
        public virtual curso curso { get; set; }
        public virtual ICollection<asistencia> asistencia { get; set; }
    }
}
