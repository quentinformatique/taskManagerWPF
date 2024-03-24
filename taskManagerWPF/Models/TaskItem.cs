namespace taskManagerWPF.Models
{
    public class TaskItem
    {
        private int id;

        private String title;

        private String description;

        private bool done;

        public TaskItem(String title, String description) 
        {
            if (title == null || title == "") throw new ArgumentNullException("title cannot be null or empty");
            if (description == null) throw new ArgumentNullException("description cannoit be null");


            this.title = title;
            this.description = description;
            done = false;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }
        public Guid Id { get; internal set; }
    }
}
