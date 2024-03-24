using System.Collections.ObjectModel;
using System.Windows.Input;
using taskManagerWPF.Models;
using taskManagerWPF.Views;

namespace taskManagerWPF.ViewModels
{
    internal class TaskManagerViewModel
    {
        public ObservableCollection<TaskItem> TaskItems { get; set; }
        public ICommand AddTaskCommand { get; set; }
        public ICommand DeleteTaskCommand { get; set; }
        public ICommand EditTaskCommand { get; set; }


        public TaskManagerViewModel()
        {
            TaskItems = new ObservableCollection<TaskItem>();
            AddTaskCommand = new RelayCommand(AddTask);
            DeleteTaskCommand = new RelayCommand(DeleteTask);
            EditTaskCommand = new RelayCommand(EditTask);
        }


        private void AddTask(object parameter)
        {
            var dialog = new InputDialog("Add Task", "Enter task title:");
            if (dialog.ShowDialog() == true)
            {
                var title = dialog.Answer;
                if (!string.IsNullOrWhiteSpace(title))
                {
                    TaskItems.Add(new TaskItem(title));
                }
            }
        }

        private void DeleteTask(object parameter)
        {
            var task = parameter as TaskItem;
            if (task != null)
            {
                TaskItems.Remove(task);
            }
        }

        private void EditTask(object parameter)
        {
            var task = parameter as TaskItem;
            if (task != null)
            {
                var dialog = new InputDialog("Edit Task", "Enter new task title:", task.Title);
                if (dialog.ShowDialog() == true)
                {
                    var newTitle = dialog.Answer;
                    if (!string.IsNullOrWhiteSpace(newTitle))
                    {
                        task.Title = newTitle;
                    }
                }
            }
        }


    }
}
