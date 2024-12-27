using Soenneker.Libraries.FFplay.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Libraries.FFplay.Tests;

[Collection("Collection")]
public class FFplayTests : FixturedUnitTest
{
    private readonly IFFplay _library;

    public FFplayTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _library = Resolve<IFFplay>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
