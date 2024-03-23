namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class GroupHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Group, new Regex(@"- ?([^\-. ]+)$")),
    ];
}