﻿namespace PromKnight.ParseTorrentTitle;

public class DefaultHandlers
{
    /// <summary>
    /// Default handlers
    /// </summary>
    internal static IReadOnlyList<Handler> Handlers =>
    [
        ..YearHandlers.Handlers,
        ..AudioHandlers.Handlers,
        ..SourceHandlers.Handlers,
        ..SeasonHandlers.Handlers,
        ..EpisodeHandlers.Handlers,
        ..GroupHandlers.Handlers,
        ..CodecHandlers.Handlers,
        ..LanguageHandlers.Handlers,
        ..MiscHandlers.Handlers,
    ];

    internal static List<Regex> TvRegexes { get; set; } =
    [
        new(@"[se]\d\d", RegexOptions.IgnoreCase),
        new(@"\b(tv|complete)\b", RegexOptions.IgnoreCase),
        new(@"\b(saisons?|stages?|seasons?).?\d", RegexOptions.IgnoreCase),
        new(@"[a-z]\s?\-\s?\d{2,4}\b", RegexOptions.IgnoreCase),
        new(@"\d{2,4}\s?\-\s?\d{2,4}\b", RegexOptions.IgnoreCase),
    ];
}