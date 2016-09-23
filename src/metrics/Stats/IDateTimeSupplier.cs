using System;

namespace Raven.Imports.metrics.Stats
{
    public interface IDateTimeSupplier
    {
        DateTime UtcNow { get; }
    }
}