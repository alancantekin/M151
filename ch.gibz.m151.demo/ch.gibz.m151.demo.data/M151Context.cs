using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m151.demo.data
{
    public class M151Context : DbContext
    {
        public M151Context(DbContextOptions<M151Context> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
