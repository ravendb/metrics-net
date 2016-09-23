using Raven.Imports.metrics.Util;

namespace Raven.Imports.metrics.Reporting
{
    public class JsonReportFormatter : IReportFormatter
    {
        private readonly Metrics _metrics;

        public JsonReportFormatter(Metrics metrics)
        {
            _metrics = metrics;
        }

        public string GetSample()
        {
            return Serializer.Serialize(_metrics.AllSorted);
        }
    }
}