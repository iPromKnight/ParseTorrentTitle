namespace PromKnight.ParseTorrentTitle;

/// <summary>
/// Options for a handler
/// </summary>
public class HandlerOptions(string? type = null, string? value = null, bool? skipIfAlreadyFound = null, bool? removeRawFromTitle = null)
{
    public static HandlerOptions Default => new("string", null, true, false);

    /// <summary>
    /// Type of the value - Defaults to string
    /// Used for transformation from the result
    /// </summary>
    public string Type { get; } = (type ?? Default.Type).Trim().ToLower();

    /// <summary>
    /// Override value used in transformation
    /// If a value is present, it will always be returned by the transformer
    /// </summary>
    public string? Value { get; } = value?.Trim().ToLower();

    /// <summary>
    /// Indicates whether or not a handler should process if a value for a handler of the same name already exists
    /// </summary>
    public bool SkipIfAlreadyFound { get; } = skipIfAlreadyFound ?? Default.SkipIfAlreadyFound;
    
    public bool RemoveRawFromTitle { get; } = removeRawFromTitle ?? Default.RemoveRawFromTitle;
}