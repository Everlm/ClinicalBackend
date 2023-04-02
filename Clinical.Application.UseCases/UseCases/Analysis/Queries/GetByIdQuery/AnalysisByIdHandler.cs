using AutoMapper;
using Clinical.Application.Dtos.Dtos.Analysis.Response;
using Clinical.Application.Interfaces.Interfaces;
using Clinical.Application.UseCases.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCases.UseCases.Analysis.Queries.GetByIdQuery
{
    public class AnalysisByIdHandler : IRequestHandler<GetAnalysisByIdQuery, BaseResponse<GetAnalysisByIdResponseDto>>
    {
        private readonly IAnalysisRepository _analysisRepository;
        private readonly IMapper _mapper;

        public AnalysisByIdHandler(IAnalysisRepository analysisRepository, IMapper mapper)
        {
            _analysisRepository = analysisRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<GetAnalysisByIdResponseDto>> Handle(GetAnalysisByIdQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<GetAnalysisByIdResponseDto>();

            try
            {
                var analysis = await _analysisRepository.GetAnalysisById(request.AnalysisId);

                if (analysis == null)
                {
                    response.IsSuccess = false;
                    response.Message = "No records";
                    return response;
                }

                response.IsSuccess = true;
                response.Data = _mapper.Map<GetAnalysisByIdResponseDto>(analysis);
                response.Message = "Successfully Query";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
    }
}
