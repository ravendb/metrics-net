namespace Raven.Imports.metrics.Core
{
    public interface ICounterMetric : IMetric
    {
        void Tick();
    }
}

        