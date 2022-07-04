using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace avv.Pages;

public class Index_Tests : avvWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
