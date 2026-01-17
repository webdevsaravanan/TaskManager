using TaskManager.Domain.Entities;
namespace TaskManager.Application;
public class TaskService : ITaskService
{
    public async Task<IEnumerable<TaskItem>> GetAllAsync() =>
        await Task.FromResult(new[] { new TaskItem { Title = "Sample Task" } });
}
