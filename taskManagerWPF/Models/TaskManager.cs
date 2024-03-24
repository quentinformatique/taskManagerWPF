using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taskManagerWPF.Models
{
    public class TaskManager
    {
        private List<TaskItem> _tasks = new List<TaskItem>();

        public TaskItem AddTask(string title, string description)
        {

            var task = new TaskItem(title, description);

            _tasks.Add(task);

            return task;
        }

        public List<TaskItem> GetTasks()
        {
            return _tasks;
        }
    }
}
