using Microsoft.AspNetCore.Mvc;
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

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var tasks = await _taskService.GetAllAsync();
        return Ok(tasks);
    }
    [HttpPost]
    public IActionResult Create(CreateTaskDto taskData)
    {
        return Ok(new { success = true, taskData.Title });
    }
}
