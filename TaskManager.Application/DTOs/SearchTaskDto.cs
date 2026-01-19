using System.ComponentModel.DataAnnotations;

namespace TaskManager.Application.DTOs;

public class SearchTaskDto
{
    [MaxLength(100)]
    public string? Status { get; set; }
}
