using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Configuration;
using Notifier.Abstractions.Entities;

namespace Notifier.Database;

public class ToDoListDatabase: DbContext
{
    public DbSet<Notification> Notifications => Set<Notification>();
    public DbSet<List> Lists => Set<List>();
    public ToDoListDatabase()
        : base()
    {
        Database.EnsureCreated();
        //Database.EnsureDeleted();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .SetBasePath(Directory.GetCurrentDirectory())
            .Build();
        optionsBuilder.UseSqlite(config.GetConnectionString("DefaultConnection"));
    }
    
}
