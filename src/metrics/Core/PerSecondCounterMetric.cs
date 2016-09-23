using System.Runtime.Serialization;
using System.Text;
using Raven.Imports.metrics.Stats;

namespace Raven.Imports.metrics.Core
{
    public class PerSecondCounterMetric : ICounterMetric
    {
        private readonly string _eventType;
        private readonly TimeUnit _rateUnit;
        private readonly EWMA _ewma = EWMA.OneSecondEWMA();

        public void Tick()
        {
            _ewma.Tick();
        }

        public void LogJson(StringBuilder sb)
        {
            sb.Append("{\"count\":").Append(CurrentValue)
              .Append(",\"rate unit\":").Append(RateUnit).Append("}");

        }
        [IgnoreDataMember]
        public IMetric Copy
        {
            get
            {
                var metric = new PerSecondCounterMetric(EventType, RateUnit);

                return metric;
            }
        }

        public void Mark(long n)
        {
            _ewma.Update(n);
        }

        public void Mark()
        {
            _ewma.Update(1);
        }

        public double CurrentValue
        {
            get { return _ewma.Rate(_rateUnit); }
        }

        public string EventType
        {
            get { return _eventType; }
        }

        public TimeUnit RateUnit
        {
            get { return _rateUnit; }
        }

        private PerSecondCounterMetric(string eventType, TimeUnit rateUnit)
        {
            _eventType = eventType;
            _rateUnit = rateUnit;
        }

        public static PerSecondCounterMetric New(string eventType)
        {
            var meter = new PerSecondCounterMetric(eventType, TimeUnit.Seconds);
            return meter;
        }
    }
}