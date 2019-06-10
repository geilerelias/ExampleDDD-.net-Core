using System;
using System.Collections.Generic;
using System.Text;
using Domain.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.Base
{
    public class UnitOfWork: IUnitOfWork
    {
        private IDbContext _dbContext;
        
        public UnitOfWork(IDbContext context)
        {
            _dbContext = context;
        }
        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
        }
        private void Dispose(bool disposing)
        {
            if (disposing && _dbContext != null)
            {
                ((DbContext)_dbContext).Dispose();
                _dbContext = null;
            }
        }

    }
}
