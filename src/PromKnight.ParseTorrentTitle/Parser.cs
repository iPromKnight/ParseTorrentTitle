namespace PromKnight.ParseTorrentTitle;

/// <summary>
/// Parses torrent names to extract data
/// </summary>
public class Parser
{
    public static Parser Default => new(true);

    private readonly List<Handler> _handlers = [];

    public Parser(bool applyDefaultHandlers)
    {
        if (applyDefaultHandlers)
        {
            _handlers.AddRange(DefaultHandlers.Handlers);
        }
    }

    public Parser()
        : this(true) { }

    /// <summary>
    /// Parses the title to extract data using the provided handlers
    /// </summary>
    /// <param name="title"></param>
    /// <returns></returns>
    public TorrentMetadata Parse(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentNullException(nameof(title));
        }

        if (_handlers.Count == 0)
        {
            throw new("No handlers have been added to the parser");
        }
        
        var torrentType = DefaultHandlers.TvRegexes.Any(regex => regex.IsMatch(title)) ? TorrentType.Tv : TorrentType.Movie;

        var endOfTitle = title.Length;
        Dictionary<string, string> result = new();
        foreach (var handler in _handlers)
        {
            var handlerResult = handler.Execute(title, ref result);

            if (handlerResult is null)
            {
                continue;
            }
            
            if (handler.Options.RemoveRawFromTitle)
            {
                endOfTitle -= handlerResult.Value.RawMatch.Length;
                continue;
            }
            
            if (handlerResult.Value.Index < endOfTitle)
            {
                endOfTitle = handlerResult.Value.Index.Value;
            }
        }

        result.Add(DefaultHandlerNames.Title, CleanTitle(title[..endOfTitle]));
        
        return new ParserResult(result)
            .MapToMetadata(torrentType);
    }

    public void AddHandler(Handler handler) => _handlers.Add(handler);

    private static string CleanTitle(string title)
    {
        var cleanedTitle = title + "";

        if (!cleanedTitle.Contains(' ', StringComparison.OrdinalIgnoreCase) && cleanedTitle.Contains('.', StringComparison.OrdinalIgnoreCase))
        {
            cleanedTitle = cleanedTitle.Replace(".", " ", StringComparison.OrdinalIgnoreCase);
        }

        cleanedTitle = cleanedTitle.Replace('_', ' ');
        cleanedTitle = Regex.Replace(cleanedTitle, @"([(_]|- )$", string.Empty).Trim();

        return cleanedTitle.Trim();
    }
}