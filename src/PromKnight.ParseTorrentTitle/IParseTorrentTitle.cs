namespace PromKnight.ParseTorrentTitle;

public interface IParseTorrentTitle
{
    /// <summary>
    /// Parses the title to extract data using the provided handlers
    /// </summary>
    /// <param name="title"></param>
    /// <returns></returns>
    TorrentMetadata Parse(string title);

    void AddHandler(Handler handler);
}