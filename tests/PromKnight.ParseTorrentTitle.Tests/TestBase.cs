namespace PromKnight.ParseTorrentTitle.Tests;

public abstract class TestBase
{
    protected ParseTorrentTitle Parser { get; } = new(NullLogger<ParseTorrentTitle>.Instance);
}