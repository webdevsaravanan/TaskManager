using TaskManager.Application.DTOs;
using TaskManager.Domain.Entities;
namespace TaskManager.Application.Interfaces;
public interface ITaskService
{
    Task<IEnumerable<TaskItem>> GetAllAsync();
    Task CreateAsync(string title);
    Task<IEnumerable<TaskItem>> GetTasksAsync(SearchTaskDto query);
}
