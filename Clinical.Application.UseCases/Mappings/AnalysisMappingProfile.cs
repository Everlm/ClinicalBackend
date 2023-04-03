using AutoMapper;
using Clinical.Application.Dtos.Dtos.Analysis.Resonse;
using Clinical.Application.Dtos.Dtos.Analysis.Response;
using Clinical.Application.UseCases.UseCases.Analysis.Commands.CreateCommand;
using Clinical.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinical.Application.UseCases.Mappings
{
    public class AnalysisMappingProfile : Profile
    {
        public AnalysisMappingProfile()
        {
            CreateMap<Analysis, GetAllAnalysisResponseDto>()
                .ForMember(x => x.StateAnalysis, x => x.MapFrom(y => y.State == 1 ? "Active" : "Inactive"))
                .ReverseMap();

            CreateMap<Analysis, GetAnalysisByIdResponseDto>()
                .ReverseMap();

            CreateMap<CreateAnalysisCommand, Analysis>();
        }
    }
}
