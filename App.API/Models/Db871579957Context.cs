using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App.API.Models;

public partial class Db871579957Context : DbContext
{
    public Db871579957Context()
    {
    }

    public Db871579957Context(DbContextOptions<Db871579957Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Utenti> Utenti { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Utenti>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
