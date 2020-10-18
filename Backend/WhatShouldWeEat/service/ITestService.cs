using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WhatShouldWeEat.exceptions;

public interface ITestService
{
    public Task<DbSet<Test>> getAllTests();

    /// <exception cref="NotFoundException">Why it's thrown.</exception>
    public Task<Test> findTestbyId(int id);
}