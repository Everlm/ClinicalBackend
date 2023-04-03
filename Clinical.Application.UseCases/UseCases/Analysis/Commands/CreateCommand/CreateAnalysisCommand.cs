using Clinical.Application.UseCases.Commons.Bases;
using MediatR;

namespace Clinical.Application.UseCases.UseCases.Analysis.Commands.CreateCommand
{
    public class CreateAnalysisCommand : IRequest<BaseResponse<bool>>
    {
        public string? Name { get; set; }
    }
}
