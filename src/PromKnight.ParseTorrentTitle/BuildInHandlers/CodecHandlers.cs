namespace PromKnight.ParseTorrentTitle.BuildInHandlers;

internal static class CodecHandlers
{
    internal static readonly List<Handler> Handlers =
    [
        new(DefaultHandlerNames.Codec, new Regex(@"dvix|mpeg2|divx|xvid|[xh][-. ]?26[45]|avc|hevc", RegexOptions.IgnoreCase), new(type: "lowercase")),
        new(DefaultHandlerNames.Codec, (results, handler) =>
        {
            if (results.ContainsKey(DefaultHandlerNames.Codec))
            {
                results[DefaultHandlerNames.Codec] = Regex.Replace(results[DefaultHandlerNames.Codec], @"[ .-]", string.Empty);
            }

            return (null, null);
        }, new(skipIfAlreadyFound: false)),
    ];
}