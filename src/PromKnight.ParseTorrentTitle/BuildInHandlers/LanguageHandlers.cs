namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class LanguageHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Language, new Regex(@"\bRUS\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Language, new Regex(@"\bNL\b"), new(type: "lowercase")),
        new(DefaultHandlerNames.Language, new Regex(@"\bFLEMISH\b"), new(type: "lowercase")),
        new(DefaultHandlerNames.Language, new Regex(@"\bGERMAN\b"), new(type: "lowercase")),
        new(DefaultHandlerNames.Language, new Regex(@"\bDUBBED\b"), new(type: "lowercase")),
        new(DefaultHandlerNames.Language, new Regex(@"\b(ITA(?:LIAN)?|iTALiAN)\b"), new(value: "ita")),
        new(DefaultHandlerNames.Language, new Regex(@"\bFR(?:ENCH)?\b"), new(type: "lowercase")),
        new(DefaultHandlerNames.Language, new Regex(@"\bTruefrench|VF(?:[FI])\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Language, new Regex(@"\bVOST(?:(?:F(?:R)?)|A)?|SUBFRENCH\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Language, new Regex(@"\bMULTi(?:Lang|-VF2)?\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
    ];
}