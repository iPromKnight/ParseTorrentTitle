namespace PromKnight.ParseTorrentTitle;

/// <summary>
/// Parses torrent names to extract data
/// </summary>
public class ParseTorrentTitle(ILogger<ParseTorrentTitle> logger) : IParseTorrentTitle
{
    private readonly List<Handler> _handlers = 
    [
        ..DefaultHandlers.Handlers,
    ];

    /// <summary>
    /// Parses the title to extract data using the provided handlers
    /// </summary>
    /// <param name="title"></param>
    /// <returns></returns>
    public TorrentMetadata Parse(string title)
    {
        try
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

                if (handler.Options.RemoveRawFromTitle && handlerResult.Value.RawMatch is not null)
                {
                    logger.LogDebug("Removing {RawMatch} from title", handlerResult.Value.RawMatch);
                    title = title.Replace(handlerResult.Value.RawMatch, " ");

                    if (handlerResult.Value.Index < endOfTitle)
                    {
                        logger.LogDebug("Updating end of title index to {Index}", handlerResult.Value.Index);
                        endOfTitle = title.Length;
                    }

                    continue;
                }

                if (handlerResult.Value.Index < endOfTitle)
                {
                    logger.LogDebug("Updating end of title index to {Index}", handlerResult.Value.Index);
                    endOfTitle = handlerResult.Value.Index.Value;
                }
            }

            logger.LogDebug("Title: {Title}, endOfTitle: {EndOfTitle}", title, endOfTitle);
            result.Add(DefaultHandlerNames.Title, CleanTitle(title[..endOfTitle]));

            return new ParserResult(result)
                .MapToMetadata(torrentType);
        }
        catch (Exception e)
        {
            logger.LogDebug(e, "Failed to parse title {Title}", title);
            
            return new ParserResult(new()
            {
                [DefaultHandlerNames.Title] = title,
            }).MapToMetadata(TorrentType.Unknown);
        }
    }

    public void AddHandler(Handler handler) => _handlers.Add(handler);

    private string CleanTitle(string title)
    {
        var cleanedTitle = title + "";

        if (!cleanedTitle.Contains(' ', StringComparison.OrdinalIgnoreCase) && cleanedTitle.Contains('.', StringComparison.OrdinalIgnoreCase))
        {
            cleanedTitle = cleanedTitle.Replace(".", " ", StringComparison.OrdinalIgnoreCase);
        }

        cleanedTitle = cleanedTitle.Replace('_', ' ');
        cleanedTitle = Regex.Replace(cleanedTitle, @"([(_]|- )$", string.Empty).Trim();
        
        logger.LogDebug("Cleaned title: {CleanedTitle}", cleanedTitle);

        return cleanedTitle.Trim();
    }
}