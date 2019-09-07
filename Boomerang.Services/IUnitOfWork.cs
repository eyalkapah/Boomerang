using AutoMapper;
using Boomerang.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; set; }
        ISiteRepository Sites { get; set; }
        IWordRepository Words { get; set; }
        IMapper Mapper { get; }

        bool Save();
    }
}