using System;
using DireccionesApi.Models.VM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;

#nullable disable

namespace DireccionesApi.Models.DataBaseContext
{
    public partial class Direcciones_SPAContext : DbContext
    {
      
        public Direcciones_SPAContext()
        {
            
        }


        public Direcciones_SPAContext(DbContextOptions<Direcciones_SPAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Direccione> Direcciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-G17J7E9;Initial Catalog=Direcciones_SPA;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Direccione>(entity =>
            {
                entity.HasKey(e => e.DireccionesId)
                    .HasName("PK__Direccio__660C0A701C8A6AD2");

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
