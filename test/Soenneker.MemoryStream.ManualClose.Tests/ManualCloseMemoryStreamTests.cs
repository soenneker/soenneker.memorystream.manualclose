using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.MemoryStream.ManualClose.Tests;

[Collection("Collection")]
public class ManualCloseMemoryStreamTests : FixturedUnitTest
{
    public ManualCloseMemoryStreamTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
