namespace TaskManager.Domain.Entities;
public class TaskItem : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Status { get; set; } = "OPEN";
    public string? Description { get; set; }

}
