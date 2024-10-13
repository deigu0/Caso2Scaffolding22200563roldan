﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Caso2Scaffolding22200563roldan.Models;

public partial class ParcialDbContext : DbContext
{
    public ParcialDbContext()
    {
    }

    public ParcialDbContext(DbContextOptions<ParcialDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mechanic> Mechanics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2300722;Database=Parcial20240222200563DB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mechanic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mechanic__3214EC0709A70564");

            entity.ToTable("Mechanic");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
