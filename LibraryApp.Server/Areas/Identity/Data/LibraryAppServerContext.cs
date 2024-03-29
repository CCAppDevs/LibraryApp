﻿using LibraryApp.Server.Areas.Identity.Data;
using LibraryApp.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Server.Data;

public class LibraryAppServerContext : IdentityDbContext<AppUser>
{

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    public LibraryAppServerContext(DbContextOptions<LibraryAppServerContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
