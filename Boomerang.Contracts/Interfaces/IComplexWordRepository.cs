using Boomerang.Dtos;
using Boomerang.Dtos.Resources;
using Boomerang.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Contracts.Interfaces
{
    public interface IComplexWordRepository : IRepository<ComplexWord>
    {
        ComplexWord CreateWord(ComplexWordForCreationDto complexWordForCreationDto);

        IEnumerable<ComplexWordDto> GetComplexWords(ComplexWordResources resources);

        ComplexWord UpdateComplexWord(int id, ComplexWordForUpdateDto complexWordForUpdateDto);
    }
}