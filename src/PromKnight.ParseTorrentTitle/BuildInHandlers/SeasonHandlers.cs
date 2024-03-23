namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class SeasonHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Season, new Regex(@"(?i)\sSeason\s(\d+(-\d+)?)\sCOMPLETE", RegexOptions.IgnoreCase), new(type: "integer", removeRawFromTitle: true)),
        new(DefaultHandlerNames.Season, new Regex(@"(?:complete\W|seasons?\W|\W|^)((?:s\d{1,2}[., +/\\&-]+)+s\d{1,2}\b)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:complete\W|seasons?\W|\W|^)[([]?(s\d{2,}-\d{2,}\b)[)\]]?", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:complete\W|seasons?\W|\W|^)[([]?(s[1-9]-[2-9]\b)[)\]]?", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:(?:\bthe\W)?\bcomplete\W)?(?:seasons?|[Сс]езони?|temporadas?)[. ]?[-:]?[. ]?[([]?((?:\d{1,2}[., /\\&]+)+\d{1,2}\b)[)\]]?", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:(?:\bthe\W)?\bcomplete\W)?(?:seasons|[Сс]езони?|temporadas?)[. ]?[-:]?[. ]?[([]?((?:\d{1,2}[. -]+)+[1-9]\d?\b)[)\]]?", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:(?:\bthe\W)?\bcomplete\W)?season[. ]?[([]?((?:\d{1,2}[. -]+)+[1-9]\d?\b)[)\]]?(?!.*\.\w{2,4}$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:(?:\bthe\W)?\bcomplete\W)?\bseasons?\b[. -]?(\d{1,2}[. -]?(?:to|thru|and|\+|:)[. -]?\d{1,2})\b", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:(?:\bthe\W)?\bcomplete\W)?(?:saison|seizoen|season|series|temp(?:orada)?):?[. ]?(\d{1,2})", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(\d{1,2})(?:-?й)?[. _]?(?:[Сс]езон|sez(?:on)?)(?:\W?\D|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"[Сс]езон:?[. _]?№?(\d{1,2})(?!\d)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:\D|^)(\d{1,2})Â?[°ºªa]?[. ]*temporada", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"t(\d{1,3})(?:[ex]+|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:(?:\bthe\W)?\bcomplete)?(?:\W|^)s(\d{1,3})(?:[\Wex]|\d{2}\b|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:(?:\bthe\W)?\bcomplete)?(?:\W|^)(\d{1,2})[. ]?(?:st|nd|rd|th)[. ]*season", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:\D|^)(\d{1,2})[xх]\d{1,3}(?:\D|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"\bSn([1-9])(?:\D|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"[[(](\d{1,2})\.\d{1,3}[)\]]", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"-\s?(\d{1,2})\.\d{2,3}\s?-", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?:^|\/)(\d{1,2})-\d{2}\b(?!-\d)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"[^\w-](\d{1,2})-\d{2}(?=\.\w{2,4}$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"(?<!\bEp?(?:isode)? ?\d+\b.*)\b(\d{2})[ ._]\d{2}(?:.F)?\.\w{2,4}$", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Season, new Regex(@"\bEp(?:isode)?\W+(\d{1,2})\.\d{1,3}\b", RegexOptions.IgnoreCase), new(type: "integer")),
    ];
}