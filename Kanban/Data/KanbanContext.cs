﻿using Kanban.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Data
{
    public class KanbanContext : DbContext
    {
        public KanbanContext(DbContextOptions<KanbanContext> options)
           : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<ProjectInfo> Project { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProjectInfo>()
                .HasIndex(x => x.Name)
                .IsUnique();
        }

    }
}
