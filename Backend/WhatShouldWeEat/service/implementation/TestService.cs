using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WhatShouldWeEat.Data;
using WhatShouldWeEat.exceptions;

public class TestService : ITestService
{
    internal TestContext repository;

    public TestService(TestContext dbContext)
    {
        this.repository = dbContext;
    }

    public async Task<DbSet<Test>> getAllTests()
    {
        return repository.Tests;
    }

    public async Task<Test> findTestbyId(int id)
    {
        Test result = await repository.Tests.FindAsync(id);
        if (result == null)
        {
            throw new NotFoundException("No Test with id=" + id + " found!");
        }
        return result;
    }
}