using ProjectModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModule.Services
{
    public interface ITaskServices
    {
        Task<List<ProjectTask>> GetAllTasks();
    }
    public class TaskServices : ITaskServices
    {
        public async Task<List<ProjectTask>> GetAllTasks()
        {
            List<ProjectTask> tasks = new List<ProjectTask>
            {
                new ProjectTask { Id = "1", Name = "Task 1", Description = "Description of Task 1" },
                new ProjectTask { Id = "2", Name = "Task 2", Description = "Description of Task 2" },
                new ProjectTask { Id = "3", Name = "Task 3", Description = "Description of Task 3" }
            };
            return tasks;
        }
    }
}
