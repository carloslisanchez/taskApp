using System;

namespace TaskApp.Models
{
    public class TaskModel
    {
         public int ID {get;set;}
        public string NameTask {get;set;} = default!;
        public string App {get;set;} = default!;
        public string Description {get;set;} = default!;
        // public DateTime Create_at{get;set;}
    }
}