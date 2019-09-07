using AutoMapper;
using Boomerang.Context;
using Boomerang.Contracts.Interfaces;
using Boomerang.Dtos;
using Boomerang.Models.Models;
using Boomerang.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Repositories
{
    public class WordRepository : Repository<Word>, IWordRepository
    {
        private readonly IMapper _mapper;
        private IQueryable<Word> _query;

        public WordRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;

            _query = Set.AsQueryable();
        }

        public Word CreateWord(WordForCreationDto dto)
        {
            if (_query.Any(x => x.Name.Equals(dto.Name)))
                throw new CreationException($"Name: {dto.Name} already exists.");

            var word = _mapper.Map<Word>(dto);

            Set.Add(word);

            return word;
        }

        public WordDto GetWord(int id)
        {
            var word = Find(id);

            if (word == null)
                throw new NotFoundException();

            return _mapper.Map<WordDto>(word);
        }

        public IEnumerable<WordDto> GetWords() => _mapper.Map<IEnumerable<WordDto>>(_query);
    }
}