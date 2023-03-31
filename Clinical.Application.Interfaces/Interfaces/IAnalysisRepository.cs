using Clinical.Domain.Entities;

namespace Clinical.Application.Interfaces.Interfaces
{
    public interface IAnalysisRepository
    {
        Task<IEnumerable<Analysis>> ListAnalysis();
    }
}
