using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }
        public Priority Priority { get; set; }
        public string Category { get; set; }
    }

    public enum Priority {  Low = 0, Medium = 1, Hight = 2 }
}