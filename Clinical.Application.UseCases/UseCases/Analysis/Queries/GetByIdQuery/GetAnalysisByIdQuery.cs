using Clinical.Application.Dtos.Dtos.Analysis.Response;
using Clinical.Application.UseCases.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCases.UseCases.Analysis.Queries.GetByIdQuery
{
    public class GetAnalysisByIdQuery : IRequest<BaseResponse<GetAnalysisByIdResponseDto>>
    {
        public int AnalysisId { get; set; }
    }
}
