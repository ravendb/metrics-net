using System;

namespace Raven.Imports.metrics.Stats
{
    internal class DateTimeSupplier : IDateTimeSupplier
    {
        public DateTime UtcNow { get { return DateTime.UtcNow; } }
    }
}