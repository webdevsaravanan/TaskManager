using TaskManager.Domain.Entities;
namespace TaskManager.Application;
public interface ITaskService
{
    Task<IEnumerable<TaskItem>> GetAllAsync();
}
