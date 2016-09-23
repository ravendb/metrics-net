using System;
using NUnit.Framework;
using Raven.Imports.metrics.Core;

namespace Raven.Imports.metrics.Tests.Core
{
    [TestFixture]
    public class SampleExtensionsTests
    {
        [Test]
        public void NewSample_ForEachSampleType_DoesNotThrow()
        {
            foreach(var sampleType in (HistogramMetric.SampleType[])Enum.GetValues(typeof(HistogramMetric.SampleType)))
                sampleType.NewSample();
        }
    }
}
