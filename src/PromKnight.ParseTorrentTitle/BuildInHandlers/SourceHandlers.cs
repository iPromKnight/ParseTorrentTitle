namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class SourceHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Source, new Regex(@"\b(?:HD-?)?CAM\b"), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\b(?:HD-?)?T(?:ELE)?S(?:YNC)?\b", RegexOptions.IgnoreCase), new(value: "telesync")),
        new(DefaultHandlerNames.Source, new Regex(@"\bHD-?Rip\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bBRRip\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bBDRip\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bDVDRip\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bDVD(?:R[0-9])?\b", RegexOptions.IgnoreCase), new(value: "dvd")),
        new(DefaultHandlerNames.Source, new Regex(@"\bDVDscr\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\b(?:HD-?)?TVRip\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bTC\b"), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bPPVRip\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bR5\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bVHSSCR\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bBluray\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bWEB-?DL\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\bWEB-?Rip\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\b(?:DL|WEB|BD|BR)MUX\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"\b(DivX|XviD)\b"), new(type: "lowercase")),
        new(DefaultHandlerNames.Source, new Regex(@"HDTV", RegexOptions.IgnoreCase), new(type: "lowercase")),
    ];
}