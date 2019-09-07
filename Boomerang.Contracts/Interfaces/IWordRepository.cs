using Boomerang.Dtos;
using Boomerang.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Contracts.Interfaces
{
    public interface IWordRepository : IRepository<Word>
    {
        IEnumerable<WordDto> GetWords();

        WordDto GetWord(int id);

        Word CreateWord(WordForCreationDto wordForCreationDto);
    }
}