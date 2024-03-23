namespace PromKnight.ParseTorrentTitle.Tests;

public class SeasonTests: TestBase
{
    [Theory]
    [InlineData("The Simpsons S28E21 720p HDTV x264-AVS", 28)]
    [InlineData("breaking.bad.s01e01.720p.bluray.x264-reward", 1)]
    [InlineData("Dragon Ball Super S01 E23 French 1080p HDTV H264-Kesni", 1)]
    [InlineData("Dragon Ball Super S1 E3 French 1080p HDTV H264-Kesni", 1)]
    [InlineData("Doctor.Who.2005.8x11.Dark.Water.720p.HDTV.x264-FoV", 8)]
    [InlineData("Orange Is The New Black Season 5 Episodes 1-10 INCOMPLETE (LEAKED)", 5)]
    [InlineData("The Flash Season 1-10 COMPLETE", 1)]
    [InlineData("The Flash Season 1 to 10 COMPLETE", 1)]
    [InlineData("Criminal Minds Season 3 Complete WEB x264 [i_c]", 3)]
    [InlineData("the office us s01-s09 1080p bluray remux dts-hd.ma.5.1 avc-mixed [rick]", 1)]
    public void DetectSeason(string title, int? season)
    {
        var result = Parser.Parse(title);
        Assert.Equal(season, result.Seasons?.FirstOrDefault());
    }
}