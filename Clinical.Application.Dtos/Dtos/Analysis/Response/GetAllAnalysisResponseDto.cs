namespace Clinical.Application.Dtos.Dtos.Analysis.Resonse
{
    public class GetAllAnalysisResponseDto
    {
        public int AnalysisId { get; set; }
        public string? Name { get; set; }
        public int State { get; set; }
        public string? StateAnalysis { get; set; }
        public DateTime AuditCreateDate { get; set; }
    }
}
