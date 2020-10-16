using Microsoft.EntityFrameworkCore;


namespace WhatShouldWeEat.Data
{

    //This is only used for creating the db schema on startup while in dev Phase
    public class dev_CreatorContext : DbContext
    {

        public dev_CreatorContext(DbContextOptions<dev_CreatorContext> options)
            : base(options) { }

        public DbSet<Test> Tests { get; set; }
    }
    
}
