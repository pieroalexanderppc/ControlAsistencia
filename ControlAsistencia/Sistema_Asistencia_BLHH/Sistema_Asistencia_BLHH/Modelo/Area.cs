namespace Sistema_Asistencia_BLHH.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Area")]
    public partial class Area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Area()
        {
            Empleado = new HashSet<Empleado>();
        }

        [Key]
        public int IdArea { get; set; }

        public int? IdHorario { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreArea { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public virtual Horario Horario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
