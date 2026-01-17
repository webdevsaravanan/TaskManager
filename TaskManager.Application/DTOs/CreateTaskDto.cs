using System.ComponentModel.DataAnnotations;

namespace TaskManager.Application.DTOs;

public class CreateTaskDto
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;
}
