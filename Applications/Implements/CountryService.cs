using System;
using System.Collections.Generic;
using System.Text;
using Applications.Abstracts;
using Applications.Base;
using Domain.Abstracts;
using Domain.Entities;

namespace Applications.Implements
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly ICountryRepository _countryRepository;

        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = countryRepository;
        }

    }
}
