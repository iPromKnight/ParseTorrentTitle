namespace PromKnight.ParseTorrentTitle.Tests;

public class MainTests: TestBase
{
    [Fact]
    public void SonsOfAnarchy()
    {
        var title = "sons.of.anarchy.s05e10.480p.BluRay.x264-GAnGSteR";

        var result = Parser.Parse(title);
        Assert.Equal("sons of anarchy", result.Title);
        Assert.Equal("480p", result.Resolution);
        Assert.Equal("5", result.Seasons.First().ToString());
        Assert.Equal("10", result.Episodes.First().ToString());
        Assert.Equal("bluray", result.Source);
        Assert.Equal("x264", result.Codec);
        Assert.Equal("GAnGSteR", result.Group);
    }
    
    [Fact]
    public void CriminalMinds()
    {
        var title = "Criminal Minds Season 3 Complete x264 [i_c]";

        var result = Parser.Parse(title);
        Assert.Equal("3", result.Seasons?.First().ToString());
        Assert.Equal("Criminal Minds", result.Title);
    }

    [Fact]
    public void ColorOfNight()
    {
        var title = "Color.Of.Night.Unrated.DC.VostFR.BRrip.x264";

        var result = Parser.Parse(title);
        Assert.Equal("Color Of Night", result.Title);
        Assert.Equal("True", result.Unrated);
        Assert.Equal("vostfr", result.Language);
        Assert.Equal("brrip", result.Source);
        Assert.Equal("x264", result.Codec);
    }

    [Fact]
    public void DaVinciCode()
    {
        var title = "Da Vinci Code DVDRip";

        var result = Parser.Parse(title);
        Assert.Equal("Da Vinci Code", result.Title);
        Assert.Equal("dvdrip", result.Source);
    }

    [Fact]
    public void SomeGirls()
    {
        var title = "Some.girls.1998.DVDRip";

        var result = Parser.Parse(title);
        Assert.Equal("Some girls", result.Title);
        Assert.Equal("dvdrip", result.Source);
        Assert.Equal("1998", result.Year);
    }

    [Fact]
    public void EcritDansLeCiel()
    {
        var title = "Ecrit.Dans.Le.Ciel.1954.MULTI.DVDRIP.x264.AC3-gismo65";

        var result = Parser.Parse(title);
        Assert.Equal("Ecrit Dans Le Ciel", result.Title);
        Assert.Equal("dvdrip", result.Source);
        Assert.Equal("1954", result.Year);
        Assert.Equal("multi", result.Language);
        Assert.Equal("x264", result.Codec);
        Assert.Equal("ac3", result.Audio);
        Assert.Equal("gismo65", result.Group);
    }

    [Fact]
    public void AfterTheFallOfNewYork()
    {
        var title = "2019 After The Fall Of New York 1983 REMASTERED BDRip x264-GHOULS";

        var result = Parser.Parse(title);
        Assert.Equal("2019 After The Fall Of New York", result.Title);
        Assert.Equal("bdrip", result.Source);
        Assert.Equal("True", result.Remastered);
        Assert.Equal("1983", result.Year);
        Assert.Equal("x264", result.Codec);
        Assert.Equal("GHOULS", result.Group);
    }

    [Fact]
    public void GhostInTheShell()
    {
        var title = "Ghost In The Shell 2017 720p HC HDRip X264 AC3-EVO";

        var result = Parser.Parse(title);
        Assert.Equal("Ghost In The Shell", result.Title);
        Assert.Equal("hdrip", result.Source);
        Assert.Equal("True", result.Hardcoded);
        Assert.Equal("2017", result.Year);
        Assert.Equal("720p", result.Resolution);
        Assert.Equal("x264", result.Codec);
        Assert.Equal("ac3", result.Audio);
        Assert.Equal("EVO", result.Group);
    }

    [Fact]
    public void RogueOne()
    {
        var title = "Rogue One 2016 1080p BluRay x264-SPARKS";

        var result = Parser.Parse(title);
        Assert.Equal("Rogue One", result.Title);
        Assert.Equal("bluray", result.Source);
        Assert.Equal("2016", result.Year);
        Assert.Equal("1080p", result.Resolution);
        Assert.Equal("x264", result.Codec);
        Assert.Equal("SPARKS", result.Group);
    }

    [Fact]
    public void Desperation()
    {
        var title = "Desperation 2006 Multi Pal DvdR9-TBW1973";

        var result = Parser.Parse(title);
        Assert.Equal("Desperation", result.Title);
        Assert.Equal("dvd", result.Source);
        Assert.Equal("2006", result.Year);
        Assert.Equal("multi", result.Language);
        Assert.Equal("R9", result.Region);
        Assert.Equal("TBW1973", result.Group);
    }

    [Fact]
    public void Maman()
    {
        var title = "Maman, j'ai rat� l'avion 1990 VFI 1080p BluRay DTS x265-HTG";

        var result = Parser.Parse(title);
        Assert.Equal("Maman, j'ai rat� l'avion", result.Title);
        Assert.Equal("bluray", result.Source);
        Assert.Equal("1990", result.Year);
        Assert.Equal("dts", result.Audio);
        Assert.Equal("1080p", result.Resolution);
        Assert.Equal("vfi", result.Language);
        Assert.Equal("x265", result.Codec);
        Assert.Equal("HTG", result.Group);
    }
}