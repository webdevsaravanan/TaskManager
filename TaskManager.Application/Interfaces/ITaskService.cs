using TaskManager.Domain.Entities;
namespace TaskManager.Application.Interfaces;
public interface ITaskService
{
    Task<IEnumerable<TaskItem>> GetAllAsync();
}
