namespace PromKnight.ParseTorrentTitle.Tests;

public class EpisodeTests: TestBase
{
    [Theory]
    [InlineData("The Simpsons S28E21 720p HDTV x264-AVS", 21)]
    [InlineData("breaking.bad.s01e01.720p.bluray.x264-reward", 1)]
    [InlineData("Dragon Ball Super S01 E23 French 1080p HDTV H264-Kesni", 23)]
    [InlineData("Doctor.Who.2005.8x11.Dark.Water.720p.HDTV.x264-FoV", 11)]
    [InlineData("Anubis saison 01 episode 38 tvrip FR", 38)]
    [InlineData("Anubis saison 01 episode 10 to 30 tvrip FR", 10)]
    [InlineData(" Le Monde Incroyable de Gumball - Saison 5 Ep 14 - L'ext�rieur", 14)]
    [InlineData(" Le Monde Incroyable de Gumball - Saison 5 - L'ext�rieur", null)]
    public void DetectEpisode(string title, int? episode)
    {
        var result = Parser.Parse(title);
        Assert.Equal(episode, result.Episodes?.FirstOrDefault());
    }
}