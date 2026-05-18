using DemoLibrary;

namespace DemoLibrary.Tests;

public class StringToolsTests
{
    [Fact]
    public void Reverse_WorksCorrectly()
    {
        var result = StringTools.Reverse("abc");
        Assert.Equal("cba", result);
    }
}