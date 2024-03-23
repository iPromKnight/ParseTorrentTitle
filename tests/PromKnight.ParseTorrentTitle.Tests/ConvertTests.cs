namespace PromKnight.ParseTorrentTitle.Tests;

public class ConvertTests: TestBase
{
    [Theory]
    [InlineData("Better.Call.Saul.S03E04.CONVERT.720p.WEB.h264-TBS", "True")]
    [InlineData("Have I Got News For You S53E02 EXTENDED 720p HDTV x264-QPEL", null)]
    public void DetectConvert(string title, string convert)
    {
        var result = Parser.Parse(title);
        Assert.Equal(convert, result.Convert);
    }
}