using System;
using System.Collections.Generic;
using BlazorShared;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Models;

public partial class BlazorCrudContext : DbContext
{
    public BlazorCrudContext()
    {
    }

    public BlazorCrudContext(DbContextOptions<BlazorCrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Videojuegos> Videojuegos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
    if (!optionsBuilder.IsConfigured) 
        
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsetting.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
        }
    
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Videojuegos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__videojue__3213E83FD985A190");

            entity.ToTable("videojuegos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Desarrollador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desarrollador");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaLanzamiento).HasColumnName("fecha_lanzamiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.ImagenPortada)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("imagen_portada");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Plataforma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("plataforma");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
