namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class MiscHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Resolution, new Regex(@"([0-9]{3,4}[pi])", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Resolution, new Regex(@"(4k)", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Extended, new Regex(@"EXTENDED"), new(type: "boolean")),
        new(DefaultHandlerNames.Convert, new Regex(@"CONVERT"), new(type: "boolean")),
        new(DefaultHandlerNames.Hardcoded, new Regex(@"HC|HARDCODED"), new(type: "boolean")),
        new(DefaultHandlerNames.Proper, new Regex(@"(?:REAL.)?PROPER"), new(type: "boolean")),
        new(DefaultHandlerNames.Repack, new Regex(@"REPACK|RERIP"), new(type: "boolean")),
        new(DefaultHandlerNames.Retail, new Regex(@"\bRetail\b", RegexOptions.IgnoreCase), new(type: "boolean")),
        new(DefaultHandlerNames.Remastered, new Regex(@"\bRemaster(?:ed)?\b", RegexOptions.IgnoreCase), new(type: "boolean")),
        new(DefaultHandlerNames.Unrated, new Regex(@"\bunrated|uncensored\b", RegexOptions.IgnoreCase), new(type: "boolean")),
        new(DefaultHandlerNames.Region, new Regex(@"R[0-9]")),
        new(DefaultHandlerNames.Container, new Regex(@"\b(MKV|AVI|MP4)\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
    ];
}