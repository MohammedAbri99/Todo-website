using System.ComponentModel.DataAnnotations;

namespace ToDoWebsite.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string title { get; set; }
        public DateTime DeadLine { get; set; }
        
        public bool urgent { get; set; }
        public bool important { get; set; }

    }
}
