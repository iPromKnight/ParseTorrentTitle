namespace PromKnight.ParseTorrentTitle.Tests;

public class RemasteredTests: TestBase
{
    [Theory]
    [InlineData("The Fifth Element 1997 REMASTERED MULTi 1080p BluRay HDLight AC3 x264 Zone80", "True")]
    [InlineData("Predator 1987 REMASTER MULTi 1080p BluRay x264 FiDELiO", "True")]
    [InlineData("Have I Got News For You S53E02 EXTENDED 720p HDTV x264-QPEL", null)]
    public void DetectRemastered(string title, string remastered)
    {
        var result = Parser.Parse(title);
        Assert.Equal(remastered, result.Remastered);
    }
}