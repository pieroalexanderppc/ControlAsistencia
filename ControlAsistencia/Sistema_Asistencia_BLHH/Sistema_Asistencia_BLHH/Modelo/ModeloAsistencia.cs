using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sistema_Asistencia_BLHH.Modelo
{
    public partial class ModeloAsistencia : DbContext
    {
        public ModeloAsistencia()
            : base("name=ModeloAsistencia")
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Empleado_Puesto> Empleado_Puesto { get; set; }
        public virtual DbSet<Falta> Falta { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Puesto> Puesto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<V_Faltas_Mensuales> V_Faltas_Mensuales { get; set; }
        public virtual DbSet<V_Tardanza_Mensual> V_Tardanza_Mensual { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>()
                .Property(e => e.NombreArea)
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.DNI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Genero)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Asistencia)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Empleado_Puesto)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Falta)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Puesto>()
                .Property(e => e.NombrePuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Puesto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Puesto>()
                .HasMany(e => e.Empleado_Puesto)
                .WithRequired(e => e.Puesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nivel)
                .IsUnicode(false);

            modelBuilder.Entity<V_Faltas_Mensuales>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<V_Faltas_Mensuales>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<V_Tardanza_Mensual>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<V_Tardanza_Mensual>()
                .Property(e => e.Apellido)
                .IsUnicode(false);
        }
    }
}
