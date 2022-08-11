using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TaskApp.Models;

namespace Context.TaskContext
{
        public class TaskContext : DbContext
    {
        public TaskContext (DbContextOptions<TaskContext> options)
        :base(options)
        {}
        public DbSet<TaskModel> Tasks { get; set; }

        public string DbPath {get;}

        // public TaskContext(){
        //     var folder = Environment.SpecialFolder.LocalApplicationData;
        //     var path = Environment.GetFolderPath(folder);
        //     Console.WriteLine($"===={path}");
        //     DbPath = System.IO.Path.Join(path, "task.db");
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=task.db");
            //  optionsBuilder.UseSqlite("Name=ConnectionStrings:TaskDB");
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Tarea>().ToTable("Tasks");
        // }
    }
}