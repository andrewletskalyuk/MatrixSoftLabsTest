using System.ComponentModel.DataAnnotations;

namespace MatrixSoft.Core.Models;

public class Employee
{
    public int Id { get; set; }
    
    [Required]
    public required string NameFirst { get; set; }

    [Required]
    public required string NameLast { get; set; }
    public string? Biography { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public DateTime DateOfEmployment { get; set; }
    
    public string? EmploymentStatus { get; set; }
    
    public string? Title { get; set; }
    
    public string? ImageUrl { get; set; }
    
    public int UserId { get; set; }
    
    public int DepartmentId { get; set; }
    
    public int? BossId { get; set; }
    
    public required string Email { get; set; }
    
    public required string Phone { get; set; }
    
    public int? ImageModelId { get; set; }
    
    public bool IsConsultant { get; set; }

    // Navigation properties
    //public Department Department { get; set; } //TODO: add other entity
    public ICollection<Vacancy>? Vacancies { get; set; }
}

