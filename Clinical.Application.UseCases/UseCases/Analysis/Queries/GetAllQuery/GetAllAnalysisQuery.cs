using Clinical.Application.Dtos.Dtos.Analysis.Resonse;
using Clinical.Application.UseCases.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCases.UseCases.Analysis.Queries.GetAllQuery
{
    public class GetAllAnalysisQuery :IRequest<BaseResponse<IEnumerable<GetAllAnalysisResponseDto>>>
    {
    }
}
