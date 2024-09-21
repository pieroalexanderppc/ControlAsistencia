namespace Sistema_Asistencia_BLHH.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Asistencia")]
    public partial class Asistencia
    {
        [Key]
        public int IdAsistencia { get; set; }

        public int IdEmpleado { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaAsistencia { get; set; }

        public TimeSpan? HoraEntrada { get; set; }

        public TimeSpan? HoraSalida { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
