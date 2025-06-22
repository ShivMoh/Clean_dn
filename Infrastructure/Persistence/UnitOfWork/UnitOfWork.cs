using Application.Common.Interfaces.Persistence;
using Domain.Common.Models;
using Domain.Entities;
using Domain.Entities.Events;
using Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext dbContext) {
        _dbContext = dbContext;
    }   

    public void SaveChanges() {
        _dbContext.SaveChanges();
    }
}