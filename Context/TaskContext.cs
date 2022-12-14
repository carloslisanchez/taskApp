using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TaskApp.Models;
#nullable disable
namespace Context.TaskContext
{
        public class TaskContext : DbContext
    {
        public TaskContext (DbContextOptions<TaskContext> options)
        :base(options)
        {}
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<AppModel> App {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=task.db");
            //  optionsBuilder.UseSqlite("Name=ConnectionStrings:TaskDB");
        }
    }
}