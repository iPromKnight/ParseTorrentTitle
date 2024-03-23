namespace PromKnight.ParseTorrentTitle.Tests;

public class TitleTests: TestBase
{
    [Theory]
    [InlineData("La famille b�lier", "La famille b�lier")]
    [InlineData("La.famille.b�lier", "La famille b�lier")]
    [InlineData("Mr. Nobody", "Mr. Nobody")]
    [InlineData("doctor_who_2005.8x12.death_in_heaven.720p_hdtv_x264-fov", "doctor who")]
    public void DetectTitle(string title, string expectedTitle)
    {
        var result = Parser.Parse(title);
        Assert.Equal(expectedTitle, result.Title);
    }
}