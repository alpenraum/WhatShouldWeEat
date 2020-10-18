using Microsoft.EntityFrameworkCore;

namespace WhatShouldWeEat.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
            //this.Database.EnsureCreated();
        }

        public DbSet<Test> Tests { get; set; }
    }
}