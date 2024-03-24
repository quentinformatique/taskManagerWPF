using System.Collections.ObjectModel;
using System.Windows.Input;
using taskManagerWPF.Models;

namespace taskManagerWPF.ViewModels
{
    internal class TaskManagerViewModel
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }
        public ICommand AddTaskCommand { get; set; }
        public ICommand DeleteTaskCommand { get; set; }

        public TaskManagerViewModel()
        {
            Tasks = new ObservableCollection<TaskItem>();
            AddTaskCommand = new RelayCommand(AddTask);
            DeleteTaskCommand = new RelayCommand(DeleteTask);
        }

        private void AddTask(object parameter)
        {
            Tasks.Add(new TaskItem("Nouvelle tâche", "description"));
        }

        private void DeleteTask(object parameter)
        {
            // Supprimer la tâche sélectionnée de la liste des tâches
        }
    }
}