using System.Collections.ObjectModel;
using System.Windows.Input;
using taskManagerWPF.Models;

namespace taskManagerWPF.ViewModels
{
    internal class TaskManagerViewModel
    {
        public ObservableCollection<TaskItem> TaskItems { get; set; }
        public ICommand AddTaskCommand { get; set; }

        public TaskManagerViewModel()
        {
            TaskItems = new ObservableCollection<TaskItem>();
            AddTaskCommand = new RelayCommand(AddTask);
        }

        private void AddTask(object parameter)
        {
            TaskItems.Add(new TaskItem("title"));
        }
    }
}