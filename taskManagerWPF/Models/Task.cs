using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManagerWPF.Models
{
    class Task
    {

        private String title;

        private String description;

        private bool done;

        public Task(String title, String description) 
        {
            this.title = title;
            this.description = description;
            done = false;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }
    }
}
