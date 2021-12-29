using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GuiaEpisodiosSimpson.Models
{
    public partial class simpsonContext : DbContext
    {
        public simpsonContext()
        {
        }

        public simpsonContext(DbContextOptions<simpsonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Episodio> Episodios { get; set; }
        public virtual DbSet<Temporadum> Temporada { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=simpson", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.18-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8");

            modelBuilder.Entity<Episodio>(entity =>
            {
                entity.ToTable("episodio");

                entity.HasIndex(e => e.IdTemporada, "FK_IdTemporada_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdTemporada).HasColumnType("int(11)");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdTemporadaNavigation)
                    .WithMany(p => p.Episodios)
                    .HasForeignKey(d => d.IdTemporada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdTemporada");
            });

            modelBuilder.Entity<Temporadum>(entity =>
            {
                entity.ToTable("temporada");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FechaEstreno)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Temporada)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
