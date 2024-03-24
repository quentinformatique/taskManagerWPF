﻿using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using taskManagerWPF.Models;

namespace taskManagerWPF.ViewModels
{
    internal class TaskManagerViewModel
    {
        public ObservableCollection<TaskItem> TaskItems { get; set; }
        public ICommand AddTaskCommand { get; set; }
        public ICommand DeleteTaskCommand { get; set; }


        public TaskManagerViewModel()
        {
            TaskItems = new ObservableCollection<TaskItem>();
            AddTaskCommand = new RelayCommand(AddTask);
            DeleteTaskCommand = new RelayCommand(DeleteTask);
        }


        private void AddTask(object parameter)
        {
            TaskItems.Add(new TaskItem("title"));
        }

        private void DeleteTask(object parameter)
        {
            var task = parameter as TaskItem;
            if (task != null)
            {
                TaskItems.Remove(task);
            }
        }

    }
}