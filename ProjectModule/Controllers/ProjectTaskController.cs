using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectModule.Services;
namespace ProjectModule.Controllers
{
    public class ProjectTaskController : ControllerBase
    {
        ITaskServices _taskServices;
        public ProjectTaskController(ITaskServices taskServices)
        {
            _taskServices = taskServices;
        }
        
        
        [HttpGet("/get-list")]
        public async Task<IActionResult> GetAllProjectsTasks()
        {
            var prjectTasks = await _taskServices.GetAllTasks();
            return Ok(prjectTasks);
        }
    }
}
