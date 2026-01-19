using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TaskManager.Application.Common;
using TaskManager.Application.DTOs;
using TaskManager.Application.Interfaces;

namespace TaskManager.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TasksController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTaskDto taskData)
    {
        await _taskService.CreateAsync(taskData.Title);
        return Ok(ApiResponse<string>.Ok(taskData.Title, "Task created"));
    }
    // GET /api/tasks?status=OPEN
    [HttpGet]
    public async Task<IActionResult> GetTasks([FromQuery] SearchTaskDto query)
    {
        var tasks = await _taskService.GetTasksAsync(query);

        return Ok(ApiResponse<object>.Ok(tasks));
    }
}
