namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class AudioHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Audio, new Regex(@"7\.1[. ]?Atmos\b", RegexOptions.IgnoreCase), new(value: "7.1 atmos")),
        new(DefaultHandlerNames.Audio, new Regex(@"\bEAC-?3(?:[. -]?[256]\.[01])?", RegexOptions.IgnoreCase), new(value: "eac3")),
        new(DefaultHandlerNames.Audio, new Regex(@"\bAC-?3(?:[.-]5\.1|x2\.?0?)?\b", RegexOptions.IgnoreCase), new(value: "ac3")),
        new(DefaultHandlerNames.Audio, new Regex(@"\b5\.1ch\b", RegexOptions.IgnoreCase), new(value: "ac3")),
        new(DefaultHandlerNames.Audio, new Regex(@"\bDD5[. ]?1\b", RegexOptions.IgnoreCase), new(value: "dd5.1")),
        new(DefaultHandlerNames.Audio, new Regex(@"\bQ?AAC(?:[. ]?2[. ]0|x2)?\b", RegexOptions.IgnoreCase), new(value: "aac")),
        new(DefaultHandlerNames.Audio, new Regex(@"\bFLAC(?:\+?2\.0)?(?:x[2-4])?\b", RegexOptions.IgnoreCase), new(value: "flac")),
        new(DefaultHandlerNames.Audio, new Regex(@"\b(mp3|Atmos|DTS(?:-HD)?|TrueHD)\b", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Audio, new Regex(@"\bmd\b", RegexOptions.IgnoreCase), new(value: "md")),
        new(DefaultHandlerNames.Audio, new Regex(@"\b5\.1(?:x[2-4]+)?\+2\.0(?:x[2-4])?\b", RegexOptions.IgnoreCase), new(value: "2.0")),
        new(DefaultHandlerNames.Audio, new Regex(@"\b2\.0(?:x[2-4]|\+5\.1(?:x[2-4])?)\b", RegexOptions.IgnoreCase), new(value: "2.0")),
    ];
}