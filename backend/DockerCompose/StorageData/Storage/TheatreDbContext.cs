using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StorageData;

public partial class TheatreDbContext : DbContext
{
    public TheatreDbContext(IConfiguration config)
    {
        _config = config;
    }

    public virtual DbSet<Act> Act { get; set; }

    public virtual DbSet<Admin> Admin { get; set; }

    public virtual DbSet<Auditoriumsector> Auditoriumsector { get; set; }

    public virtual DbSet<BoughtTickets> BoughtTickets { get; set; }

    public virtual DbSet<Employee> Employee { get; set; }

    public virtual DbSet<Genre> Genre { get; set; }

    public virtual DbSet<Location> Location { get; set; }

    public virtual DbSet<LocationState> LocationState { get; set; }

    public virtual DbSet<Position> Position { get; set; }

    public virtual DbSet<Repertoire> Repertoire { get; set; }

    public virtual DbSet<Role> Role { get; set; }

    public virtual DbSet<SoldTicketsMonth> SoldTicketsMonth { get; set; }

    public virtual DbSet<Spectacle> Spectacle { get; set; }

    public virtual DbSet<SpectaclesBoxofficeYear> SpectaclesBoxofficeYear { get; set; }

    public virtual DbSet<State> State { get; set; }

    public virtual DbSet<SumHoursWatching> SumHoursWatching { get; set; }

    public virtual DbSet<Ticket> Ticket { get; set; }

    public virtual DbSet<Viewer> Viewer { get; set; }

    public virtual DbSet<ViewerGenreVisits> ViewerGenreVisits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL(_config.GetConnectionString("DbConnection")!);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Act>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("act");

            entity.HasIndex(e => e.Date, "Date_UNIQUE").IsUnique();

            entity.HasIndex(e => e.RepertoireId, "FKAct473309");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("timestamp");
            entity.Property(e => e.RepertoireId).HasColumnName("RepertoireID");

            entity.HasOne(d => d.Repertoire).WithMany(p => p.Act)
                .HasForeignKey(d => d.RepertoireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKAct473309");
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("admin");

            entity.HasIndex(e => e.Name, "Name_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(45);
            entity.Property(e => e.Password).HasMaxLength(500);
        });

        modelBuilder.Entity<Auditoriumsector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("auditoriumsector");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BoughtTickets>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("bought_tickets");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.PositionId, "FKEmployee102996");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(11);
            entity.Property(e => e.PositionId).HasColumnName("PositionID");

            entity.HasOne(d => d.Position).WithMany(p => p.Employee)
                .HasForeignKey(d => d.PositionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKEmployee102996");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("genre");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("location");

            entity.HasIndex(e => e.ActId, "ActIdFK_idx");

            entity.HasIndex(e => e.SectorId, "SectorIdFK_idx");

            entity.HasIndex(e => e.LocationStateId, "StateIdFK_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActId).HasColumnName("ActID");
            entity.Property(e => e.LocationStateId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("LocationStateID");
            entity.Property(e => e.Price)
                .HasPrecision(10)
                .HasDefaultValueSql("'3000.00'");
            entity.Property(e => e.SectorId).HasColumnName("SectorID");

            entity.HasOne(d => d.Act).WithMany(p => p.Location)
                .HasForeignKey(d => d.ActId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ActIdFK");

            entity.HasOne(d => d.LocationState).WithMany(p => p.Location)
                .HasForeignKey(d => d.LocationStateId)
                .HasConstraintName("StateIdFK");

            entity.HasOne(d => d.Sector).WithMany(p => p.Location)
                .HasForeignKey(d => d.SectorId)
                .HasConstraintName("SectorIdFK");
        });

        modelBuilder.Entity<LocationState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("location_state");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(45);
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("position");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<Repertoire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("repertoire");

            entity.HasIndex(e => e.SpectacleId, "FKRepertoire391374");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.SpectacleId).HasColumnName("SpectacleID");

            entity.HasOne(d => d.Spectacle).WithMany(p => p.Repertoire)
                .HasForeignKey(d => d.SpectacleId)
                .HasConstraintName("FKRepertoire391374");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EmployeeId, e.SpectacleId }).HasName("PRIMARY");

            entity.ToTable("role");

            entity.HasIndex(e => e.SpectacleId, "FKRole597480");

            entity.HasIndex(e => e.EmployeeId, "FKRole800896");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.SpectacleId).HasColumnName("SpectacleID");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Employee).WithMany(p => p.Role)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKRole800896");

            entity.HasOne(d => d.Spectacle).WithMany(p => p.Role)
                .HasForeignKey(d => d.SpectacleId)
                .HasConstraintName("FKRole597480");
        });

        modelBuilder.Entity<SoldTicketsMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sold_tickets_month");

            entity.Property(e => e.Year).HasColumnType("year");
        });

        modelBuilder.Entity<Spectacle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spectacle");

            entity.HasIndex(e => e.GenreId, "FKSpectacle929668");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GenreId).HasColumnName("GenreID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Plot).HasMaxLength(10000);

            entity.HasOne(d => d.Genre).WithMany(p => p.Spectacle)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKSpectacle929668");
        });

        modelBuilder.Entity<SpectaclesBoxofficeYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("spectacles_boxoffice_year");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TotalBoxOffice).HasPrecision(32);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("state");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<SumHoursWatching>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sum_hours_watching");

            entity.Property(e => e.ViewerId).HasColumnName("ViewerID");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ticket");

            entity.HasIndex(e => e.ViewerId, "FKTicket117495");

            entity.HasIndex(e => e.StateId, "FKTicket375826");

            entity.HasIndex(e => e.LocationId, "LocationIDFK_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.ViewerId).HasColumnName("ViewerID");

            entity.HasOne(d => d.Location).WithMany(p => p.Ticket)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("LocationIDFK");

            entity.HasOne(d => d.State).WithMany(p => p.Ticket)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKTicket375826");

            entity.HasOne(d => d.Viewer).WithMany(p => p.Ticket)
                .HasForeignKey(d => d.ViewerId)
                .HasConstraintName("FKTicket117495");
        });

        modelBuilder.Entity<Viewer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("viewer");

            entity.HasIndex(e => e.Mail, "Mail").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(11);
        });

        modelBuilder.Entity<ViewerGenreVisits>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewer_genre_visits");

            entity.Property(e => e.GenreName)
                .HasMaxLength(50)
                .HasColumnName("genreName");
            entity.Property(e => e.ViewerId).HasColumnName("viewerID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    private readonly IConfiguration _config;
}
