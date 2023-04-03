using AutoMapper;
using Clinical.Application.Interfaces.Interfaces;
using Clinical.Application.UseCases.Commons.Bases;
using MediatR;
using Entity = Clinical.Domain.Entities;

namespace Clinical.Application.UseCases.UseCases.Analysis.Commands.CreateCommand
{
    public class CreateAnalysisHandler : IRequestHandler<CreateAnalysisCommand, BaseResponse<bool>>
    {
        private readonly IAnalysisRepository _analysisRepository;
        private readonly IMapper _mapper;

        public CreateAnalysisHandler(IAnalysisRepository analysisRepository, IMapper mapper)
        {
            _analysisRepository = analysisRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<bool>> Handle(CreateAnalysisCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var analysis = _mapper.Map<Entity.Analysis>(request);
                response.Data = await _analysisRepository.RegisterAnalysis(analysis);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully query";
                }
            }
            catch (Exception ex)
            {

                response.Message = ex.Message;
            }

            return response;
        }
    }
}
