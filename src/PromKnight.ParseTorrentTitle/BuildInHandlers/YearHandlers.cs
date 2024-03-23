namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class YearHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Year, new Regex(@"[([]?[ .]?((?:19\d|20[012])\d[ .]?-[ .]?(?:19\d|20[012])\d)[ .]?[)\]]?"), new(type: "integer")),
        new(DefaultHandlerNames.Year, new Regex(@"[([][ .]?((?:19\d|20[012])\d[ .]?-[ .]?\d{2})[ .]?[)\]]"), new(type: "integer")),
        new(DefaultHandlerNames.Year, new Regex(@"[([]?(?!^)(?<!\d|Cap[. ]?)((?:19\d|20[012])\d)(?!\d|kbps)[)\]]?", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Year, new Regex(@"^[([]?((?:19\d|20[012])\d)(?!\d|kbps)[)\]]?", RegexOptions.IgnoreCase), new(type: "integer")),
    ];
}