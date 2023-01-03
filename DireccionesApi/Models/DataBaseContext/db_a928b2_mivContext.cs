using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DireccionesApi.Models
{
    public partial class db_a928b2_mivContext : DbContext
    {
        public db_a928b2_mivContext()
        {
        }

        public db_a928b2_mivContext(DbContextOptions<db_a928b2_mivContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Direccione> Direcciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //TODO ocultar
                optionsBuilder.UseSqlServer("Data Source=SQL8004.site4now.net;Initial Catalog=db_a928b2_miv;User Id=db_a928b2_miv_admin;Password=slinki20");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Direccione>(entity =>
            {
                entity.HasKey(e => e.DireccionesId)
                    .HasName("PK__Direccio__660C0A70ECB0E903");

                entity.Property(e => e.DireccionesId).HasColumnName("Direcciones_Id");

                entity.Property(e => e.AliasDireccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Alias_Direccion");

                entity.Property(e => e.CalleNumero)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Calle_Numero");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Codigo_Postal");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Creacion");

                entity.Property(e => e.FechaEdicion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Edicion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Eliminacion");

                entity.Property(e => e.NombrePersona)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Nombre_Persona");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Referencia).HasMaxLength(150);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
