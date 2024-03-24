using System.ComponentModel;

namespace taskManagerWPF.Models
{
    public class TaskItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public bool Done { get; set; }
        public Guid Id { get; internal set; }

        public TaskItem(string title)
        {
            if (title == null || title == "") throw new ArgumentNullException("title cannot be null or empty");

            Title = title;
            Done = false;
            Id = Guid.NewGuid();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
