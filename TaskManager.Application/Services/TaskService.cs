using TaskManager.Application.DTOs;
using TaskManager.Application.Interfaces;
using TaskManager.Domain;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.Services;

public class TaskService : ITaskService
{
    private readonly IUnitOfWork _unitOfWork;

    public TaskService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<TaskItem>> GetAllAsync()
    {
        return await _unitOfWork.Tasks.GetAllAsync();
    }

    public async Task CreateAsync(string title)
    {
        var task = new TaskItem
        {
            Title = title,
            Status = "OPEN"
        };

        await _unitOfWork.Tasks.AddAsync(task);
        await _unitOfWork.SaveChangesAsync();
    }
    public async Task<IEnumerable<TaskItem>> GetTasksAsync(SearchTaskDto query)
    {
        // Business decision belongs here
        if (string.IsNullOrWhiteSpace(query.Status))
        {
            return await _unitOfWork.Tasks.GetAllAsync();
        }

        return await _unitOfWork.Tasks.GetByStatusAsync(query.Status);
    }
}
