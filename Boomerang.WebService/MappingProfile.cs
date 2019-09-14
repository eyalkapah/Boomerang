using AutoMapper;
using Boomerang.Dtos;
using Boomerang.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.WebService
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Section, SectionDto>();
            CreateMap<Package, PackageDto>();
            CreateMap<WordBase, WordBaseDto>();
            CreateMap<Word, WordDto>().ReverseMap();
            //CreateMap<WordDto, Word>();
            CreateMap<ComplexWord, ComplexWordDto>();
            CreateMap<Enrollment, EnrollmentDto>();
            CreateMap<Site, SiteDto>();
            CreateMap<IrcInfo, IrcInfoDto>();
            CreateMap<PackageEnrollment, PackageEnrollmentDto>();
            CreateMap<ComplexWordMap, ComplexWordMapDto>().ReverseMap();
            CreateMap<WordBaseForCreationDto, WordBase>();
            CreateMap<WordForCreationDto, Word>();
            CreateMap<WordForUpdateDto, Word>();
            CreateMap<ComplexWordForCreationDto, ComplexWord>();
            //CreateMap<Course, Details.Model>();
            //CreateMap<Create.Command, Course>(MemberList.Source).ForSourceMember(c => c.Number, opt => opt.Ignore());
            //CreateMap<Course, Edit.Command>().ReverseMap();
            //CreateMap<Course, Delete.Command>();
        }
    }
}