using System.Text;

namespace Raven.Imports.metrics.Core
{
    public interface IMetric : ICopyable<IMetric>
    {
        void LogJson(StringBuilder sb);
    }
}

        