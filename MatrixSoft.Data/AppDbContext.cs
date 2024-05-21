using MatrixSoft.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MatrixSoft.Data;

public class AppDbContext : IdentityDbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
	{
	}

    public DbSet<Employee> Employees { get; set; }

    public DbSet<VacancyCategory> VacancyCategories { get; set; }

    public DbSet<Vacancy> Vacancies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Employee to Vacancies - One to Many
        modelBuilder.Entity<Employee>()
            .HasMany(e => e.Vacancies)
            .WithOne(v => v.Employee)
            .HasForeignKey(v => v.EmployeeId);

        // Vacancy to VacancyCategory - Many to One
        modelBuilder.Entity<Vacancy>()
            .HasOne(v => v.VacancyCategory)
            .WithMany(vc => vc.Vacancies)
            .HasForeignKey(v => v.VacancyCategoryId);
    }
}
