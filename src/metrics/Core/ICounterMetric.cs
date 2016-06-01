namespace metrics.Core
{
    public interface ICounterMetric : IMetric
    {
        void Tick();
    }
}

        