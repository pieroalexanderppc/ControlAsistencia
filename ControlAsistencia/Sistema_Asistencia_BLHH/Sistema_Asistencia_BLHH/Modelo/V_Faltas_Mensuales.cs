namespace Sistema_Asistencia_BLHH.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Faltas_Mensuales
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEmpleado { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Apellido { get; set; }

        public int? Mes { get; set; }

        public int? Faltas { get; set; }
    }
}
