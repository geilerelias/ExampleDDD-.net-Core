using System;
using System.Collections.Generic;
using System.Text;
using Domain.Abstracts;
using Domain.Entities;
using Infraestructure.Data.Base;

namespace Infraestructure.Data.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(IDbContext context)
              : base(context)
        {

        }

    }
}
