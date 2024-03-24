namespace taskManagerWPF.Models
{
    public class TaskItem
    {
        public string title { get; set; }

        public string description { get; set; }

        public bool done { get; set; }
        public Guid id { get; internal set; }

        public TaskItem(String title, String description) 
        {
            if (title == null || title == "") throw new ArgumentNullException("title cannot be null or empty");
            if (description == null) throw new ArgumentNullException("description cannoit be null");


            this.title = title;
            this.description = description;
            done = false;
            id = Guid.NewGuid();
        }

    }
}
