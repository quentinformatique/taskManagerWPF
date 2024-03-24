using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManagerWPF.Models
{
    public class Task
    {
        private int id;

        private String title;

        private String description;

        private bool done;

        public Task(String title, String description) 
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
