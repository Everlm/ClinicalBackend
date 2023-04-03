using Clinical.Domain.Entities;

namespace Clinical.Application.Interfaces.Interfaces
{
    public interface IAnalysisRepository
    {
        Task<IEnumerable<Analysis>> ListAnalysis();
        Task<Analysis> GetAnalysisById(int Analysisid);
        Task<bool> RegisterAnalysis(Analysis analysis);

    }
}
