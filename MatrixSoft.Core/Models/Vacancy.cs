namespace MatrixSoft.Core.Models;

public class Vacancy
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public string? Comment { get; set; }

    public int VacancyCategoryId { get; set; }

    public bool Approved { get; set; }

    public DateTime DateApproved { get; set; }

    public int UserApprovedId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public string? VacancyStatus { get; set; }


    
    public VacancyCategory? VacancyCategory { get; set; }

    public Employee? Employee { get; set; }
}
