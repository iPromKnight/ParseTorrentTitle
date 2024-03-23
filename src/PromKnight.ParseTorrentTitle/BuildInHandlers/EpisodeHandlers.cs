namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class EpisodeHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Episode, new Regex(@"(?:[\W\d]|^)e[ .]?[([]?(\d{1,3}(?:[ .-]*(?:[&+]|e){1,2}[ .]?\d{1,3})+)(?:\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:[\W\d]|^)ep[ .]?[([]?(\d{1,3}(?:[ .-]*(?:[&+]|ep){1,2}[ .]?\d{1,3})+)(?:\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:[\W\d]|^)\d+[xх][ .]?[([]?(\d{1,3}(?:[ .]?[xх][ .]?\d{1,3})+)(?:\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:[\W\d]|^)(?:episodes?|[Сс]ерии:?)[ .]?[([]?(\d{1,3}(?:[ .+]*[&+][ .]?\d{1,3})+)(?:\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"[([]?(?:\D|^)(\d{1,3}[ .]?ao[ .]?\d{1,3})[)\]]?(?:\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:[\W\d]|^)(?:e|eps?|episodes?|[Сс]ерии:?|\d+[xх])[ .]*[([]?(\d{1,3}(?:-\d{1,3})+)(?:\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:\W|^)[st]\d{1,2}[. ]?[xх-]?[. ]?(?:e|x|х|ep|-|\.)[. ]?(\d{1,3})(?:[abc]|v0?[1-4]|\D|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"\b[st]\d{2}(\d{2})\b", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:\W|^)(\d{1,3}(?:[ .]*~[ .]*\d{1,3})+)(?:\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"-\s(\d{1,3}[ .]*-[ .]*\d{1,3})(?!-\d)(?:\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"s\d{1,2}\s?\((\d{1,3}[ .]*-[ .]*\d{1,3})\)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:^|\/)\d{1,2}-(\d{2})\b(?!-\d)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?<!\d-)\b\d{1,2}-(\d{2})(?=\.\w{2,4}$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?<!(?:seasons?|[Сс]езони?)\W*)(?:[ .([-]|^)(\d{1,3}(?:[ .]?[,&+~][ .]?\d{1,3})+)(?:[ .)\]-]|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?<!(?:seasons?|[Сс]езони?)\W*)(?:[ .([-]|^)(\d{1,3}(?:-\d{1,3})+)(?:[ .)(\]]|-\D|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"\bEp(?:isode)?\W+\d{1,2}\.(\d{1,3})\b", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:\b[ée]p?(?:isode)?|[Ээ]пизод|[Сс]ер(?:ии|ия|\.)?|cap(?:itulo)?|epis[oó]dio)[. ]?[-:#№]?[. ]?(\d{1,4})(?:[abc]|v0?[1-4]|\W|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"\b(\d{1,3})(?:-?я)?[ ._-]*(?:ser(?:i?[iyj]a|\b)|[Сс]ер(?:ии|ия|\.)?)/i"), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?:\D|^)\d{1,2}[. ]?[xх][. ]?(\d{1,3})(?:[abc]|v0?[1-4]|\D|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"[[(]\d{1,2}\.(\d{1,3})[)\]]", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"\b[Ss]\d{1,2}[ .](\d{1,2})\b", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"-\s?\d{1,2}\.(\d{2,3})\s?-/", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?<=\D|^)(\d{1,3})[. ]?(?:of|из|iz)[. ]?\d{1,3}(?=\D|$)", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"\b\d{2}[ ._-](\d{2})(?:.F)?\.\w{2,4}$", RegexOptions.IgnoreCase), new(type: "integer")),
        new(DefaultHandlerNames.Episode, new Regex(@"(?<!^)\[(\d{2,3})](?!(?:\.\w{2,4})?$)", RegexOptions.IgnoreCase), new(type: "integer"))
    ];
}