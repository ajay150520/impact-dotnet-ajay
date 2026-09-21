public class Playlist
{
    private readonly List<string> songs = new()
    {
        "Perfect",
        "Shape of You",
        "Believer"
    };

    private readonly Dictionary<string, string> metadata = new()
    {
        ["Name"] = "My Playlist",
        ["Genre"] = "Pop"
    };

    // Integer indexer with bounds checking.
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= songs.Count)
            {
                throw new IndexOutOfRangeException(
                    $"Song index must be between 0 and {songs.Count - 1}."
                );
            }

            return songs[index];
        }

        set
        {
            if (index < 0 || index >= songs.Count)
            {
                throw new IndexOutOfRangeException(
                    $"Song index must be between 0 and {songs.Count - 1}."
                );
            }

            songs[index] = value;
        }
    }

    // String indexer.
    public string this[string key]
    {
        get
        {
            if (!metadata.ContainsKey(key))
            {
                throw new KeyNotFoundException(
                    $"Metadata key '{key}' was not found."
                );
            }

            return metadata[key];
        }

        set
        {
            metadata[key] = value;
        }
    }

    public int Count => songs.Count;
}