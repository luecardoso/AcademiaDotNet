﻿using System;
using System.Collections.Generic;
using ASPNETMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVC;

public partial class AulaentityContext : DbContext
{
    public AulaentityContext()
    {
    }

    public AulaentityContext(DbContextOptions<AulaentityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost; initial Catalog=aulaentity;User ID=aulaentity;password=senha1234;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasIndex(e => e.Pessoaid, "IX_Emails_pessoaid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email1).HasColumnName("email");
            entity.Property(e => e.Pessoaid).HasColumnName("pessoaid");

            entity.HasOne(d => d.Pessoa).WithMany(p => p.Emails)
                .HasForeignKey(d => d.Pessoaid)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome).HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
