using AutoMapper;
using Boomerang.Context;
using Boomerang.Contracts.Interfaces;
using Boomerang.Dtos;
using Boomerang.Dtos.Resources;
using Boomerang.Models.Models;
using Boomerang.Services.Exceptions;
using Boomerang.Services.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Repositories
{
    public class ComplexWordRepository : Repository<ComplexWord>, IComplexWordRepository
    {
        private readonly Dictionary<string, Action> _constants = new Dictionary<string, Action>();
        private readonly IMapper _mapper;
        private IQueryable<ComplexWord> _query;

        public ComplexWordRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
            _query = Set.AsQueryable();

            _constants.Add("words", () => _query = _query.QueryWords());
        }

        public ComplexWord CreateWord(ComplexWordForCreationDto dto)
        {
            if (_query.Any(x => x.Name.Equals(dto.Name)))
                throw new CreationException($"Name: {dto.Name} already exists.");

            var complexWord = _mapper.Map<ComplexWord>(dto);

            var entry = Set.Add(complexWord);

            return complexWord;
        }

        public IEnumerable<ComplexWordDto> GetComplexWords(ComplexWordResources resources)
        {
            if (resources.Includes != null)
            {
                foreach (var item in resources.Includes?.Split(','))
                {
                    _constants.TryGetValue(item.ToLower(), out Action action);

                    action?.Invoke();
                }
            }

            var dto = _mapper.Map<IEnumerable<ComplexWordDto>>(_query);

            if (resources.Id != null)
            {
                var complexWord = dto.FirstOrDefault(x => x.Id == resources.Id);

                if (complexWord == null)
                    throw new NotFoundException();

                return new List<ComplexWordDto> { complexWord };
            }

            return dto;
        }

        public ComplexWord UpdateComplexWord(int id, ComplexWordForUpdateDto dto)
        {
            if (_query.Any(x => x.Name.Equals(dto.Name) && !x.Id.Equals(id)))
                throw new DuplicateNameException(dto.Name);

            var complexWord = Find(id);

            if (complexWord == null)
                throw new NotFoundException();

            return _mapper.Map(dto, complexWord);
        }
    }
}