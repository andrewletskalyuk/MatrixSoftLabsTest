using System.ComponentModel.DataAnnotations;

namespace MatrixSoft.Core.Models;

public class VacancyCategory
{
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    
    public ICollection<Vacancy>? Vacancies { get; set; }
}
