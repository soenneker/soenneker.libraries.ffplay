
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Libraries.FFplay.Tests;

[Collection("Collection")]
public class FFplayTests : FixturedUnitTest
{

    public FFplayTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
