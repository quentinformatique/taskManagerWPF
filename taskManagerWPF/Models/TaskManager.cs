using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taskManagerWPF.Models
{
    public class TaskManager
    {
        private List<Task> _tasks = new List<Task>();

        public Task AddTask(string title, string description)
        {

            var task = new Task(title, description)
            {
                Id = Guid.NewGuid()
            };

            _tasks.Add(task);

            return task;
        }

        public List<Task> GetTasks()
        {
            return _tasks;
        }
    }
}
