namespace PromKnight.ParseTorrentTitle.Tests;

public class RetailTests: TestBase
{
    [Theory]
    [InlineData("MONSTER HIGH: ELECTRIFIED (2017) Retail PAL DVD9 [EAGLE]", "True")]
    [InlineData("Have I Got News For You S53E02 EXTENDED 720p HDTV x264-QPEL", null)]
    public void DetectResolution(string title, string retail)
    {
        var result = Parser.Parse(title);
        Assert.Equal(retail, result.Retail);
    }
}