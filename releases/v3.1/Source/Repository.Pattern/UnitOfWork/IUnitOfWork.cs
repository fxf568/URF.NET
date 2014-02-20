﻿using System;
using Repository.Pattern.Repositories;

namespace Repository.Pattern.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : Infrastructure.EntityBase;
    }
}