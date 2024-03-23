namespace PromKnight.ParseTorrentTitle;

public class TorrentMetadata
{
    public string? Title { get; set; }
    public string? Year { get; set; }
    public string? Resolution { get; set; }
    public string? Extended { get; set; }
    public string? Convert { get; set; }
    public string? Hardcoded { get; set; }
    public string? Proper { get; set; }
    public string? Repack { get; set; }
    public string? Retail { get; set; }
    public string? Remastered { get; set; }
    public string? Unrated { get; set; }
    public string? Region { get; set; }
    public string? Container { get; set; }
    public string? Source { get; set; }
    public string? Codec { get; set; }
    public string? Audio { get; set; }
    public string? Group { get; set; }

    public List<int>? Seasons { get; set; }

    public List<int>? Episodes { get; set; }
    public string? Language { get; set; }
    public TorrentType TorrentType { get; set; }
}