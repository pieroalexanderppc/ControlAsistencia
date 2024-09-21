namespace Sistema_Asistencia_BLHH.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Clave { get; set; }

        [Required]
        [StringLength(15)]
        public string Nivel { get; set; }

        public int Estado { get; set; }
    }
}
