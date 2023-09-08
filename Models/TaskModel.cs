using System;
#nullable disable
namespace TaskApp.Models
{
    public class TaskModel
    {
        public int ID { get; set; }
        public int IdApp { get; set; }
        public string NameTask { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at {get;set;}
        
    }
}
