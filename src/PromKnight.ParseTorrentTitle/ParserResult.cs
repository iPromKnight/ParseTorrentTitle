namespace PromKnight.ParseTorrentTitle;

public class ParserResult(Dictionary<string, string> results) : IReadOnlyDictionary<string, string>
{
    private readonly ReadOnlyDictionary<string, string> _results = new(results);

    public string? GetTitle() => this[DefaultHandlerNames.Title];

    public string? this[string handlerName]
    {
#pragma warning disable CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
        get
#pragma warning restore CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
        {
            handlerName = handlerName.ToLower().Trim();
            return _results.GetValueOrDefault(handlerName);
        }
    }

    public int Count => _results.Count;

    public IEnumerable<string> Keys => _results.Keys;

    public IEnumerable<string> Values => _results.Values;

    public bool ContainsKey(string key) => _results.ContainsKey(key);

    public bool TryGetValue(string key, [MaybeNullWhen(false)] out string value) => _results.TryGetValue(key, out value);

    IEnumerator IEnumerable.GetEnumerator() => _results.GetEnumerator();

    public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => _results.GetEnumerator();
    
    public TorrentMetadata MapToMetadata(TorrentType type)
    {
        var metadata = new TorrentMetadata
        {
            Title = this.GetValueOrDefault(DefaultHandlerNames.Title),
            Year = this.GetValueOrDefault(DefaultHandlerNames.Year),
            Resolution = this.GetValueOrDefault(DefaultHandlerNames.Resolution),
            Extended = this.GetValueOrDefault(DefaultHandlerNames.Extended),
            Convert = this.GetValueOrDefault(DefaultHandlerNames.Convert),
            Hardcoded = this.GetValueOrDefault(DefaultHandlerNames.Hardcoded),
            Proper = this.GetValueOrDefault(DefaultHandlerNames.Proper),
            Repack = this.GetValueOrDefault(DefaultHandlerNames.Repack),
            Retail = this.GetValueOrDefault(DefaultHandlerNames.Retail),
            Remastered = this.GetValueOrDefault(DefaultHandlerNames.Remastered),
            Unrated = this.GetValueOrDefault(DefaultHandlerNames.Unrated),
            Region = this.GetValueOrDefault(DefaultHandlerNames.Region),
            Container = this.GetValueOrDefault(DefaultHandlerNames.Container),
            Source = this.GetValueOrDefault(DefaultHandlerNames.Source),
            Codec = this.GetValueOrDefault(DefaultHandlerNames.Codec),
            Audio = this.GetValueOrDefault(DefaultHandlerNames.Audio),
            Group = this.GetValueOrDefault(DefaultHandlerNames.Group),
            Seasons = this.GetValueOrDefault(DefaultHandlerNames.Season)?.Split(',').Select(int.Parse).ToList(),
            Episodes = this.GetValueOrDefault(DefaultHandlerNames.Episode)?.Split(',').Select(int.Parse).ToList(),
            Language = this.GetValueOrDefault(DefaultHandlerNames.Language),
            TorrentType = type,
        };

        return metadata;
    }
}