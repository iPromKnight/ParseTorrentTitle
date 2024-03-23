namespace PromKnight.ParseTorrentTitle.Tests;

public class RegionTests: TestBase
{
    [Theory]
    [InlineData("Welcome to New York 2014 R5 XviD AC3-SUPERFAST", "R5")]
    [InlineData("Have I Got News For You S53E02 EXTENDED 720p HDTV x264-QPEL", null)]
    public void DetectRegion(string title, string region)
    {
        var result = Parser.Parse(title);
        Assert.Equal(region, result.Region);
    }
}