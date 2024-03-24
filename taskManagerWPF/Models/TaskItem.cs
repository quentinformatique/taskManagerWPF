namespace taskManagerWPF.Models
{
    public class TaskItem
    {
        public string title { get; set; }


        public bool done { get; set; }
        public Guid id { get; internal set; }

        public TaskItem(String title) 
        {
            if (title == null || title == "") throw new ArgumentNullException("title cannot be null or empty");
            
            this.title = title;
            done = false;
            id = Guid.NewGuid();
        }

    }
}
