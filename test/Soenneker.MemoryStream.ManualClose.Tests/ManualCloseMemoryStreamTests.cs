using Soenneker.Tests.HostedUnit;

namespace Soenneker.MemoryStream.ManualClose.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class ManualCloseMemoryStreamTests : HostedUnitTest
{
    public ManualCloseMemoryStreamTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
