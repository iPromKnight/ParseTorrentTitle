namespace PromKnight.ParseTorrentTitle;

public class DefaultHandlers
{
    /// <summary>
    /// Default handlers
    /// </summary>
    internal static IReadOnlyList<Handler> Handlers =>
    [
        ..MiscHandlers.Handlers,
        ..YearHandlers.Handlers,
        ..AudioHandlers.Handlers,
        ..SourceHandlers.Handlers,
        ..SeasonHandlers.Handlers,
        ..EpisodeHandlers.Handlers,
        ..GroupHandlers.Handlers,
        ..CodecHandlers.Handlers,
        ..LanguageHandlers.Handlers,
    ];

    internal static List<Regex> TvRegexes { get; set; } =
    [
        new(@"[se]\d\d", RegexOptions.IgnoreCase),
        new(@"\b(tv|complete)\b", RegexOptions.IgnoreCase),
        new(@"\b(saison|stage).?\d", RegexOptions.IgnoreCase),
        new(@"[a-z]\s?\-\s?\d{2,4}\b", RegexOptions.IgnoreCase),
        new(@"\d{2,4}\s?\-\s?\d{2,4}\b", RegexOptions.IgnoreCase),
    ];
}