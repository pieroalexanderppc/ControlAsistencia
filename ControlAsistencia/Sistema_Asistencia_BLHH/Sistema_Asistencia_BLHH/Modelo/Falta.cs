namespace Sistema_Asistencia_BLHH.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Falta")]
    public partial class Falta
    {
        [Key]
        public int IdFalta { get; set; }

        public int IdEmpleado { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaFalta { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
