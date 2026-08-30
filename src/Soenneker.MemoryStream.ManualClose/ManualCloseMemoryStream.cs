namespace Soenneker.MemoryStream.ManualClose;

/// <summary>
/// A memory stream whose close operation can be temporarily suppressed.
/// </summary>
public class ManualCloseMemoryStream : System.IO.MemoryStream
{
    public ManualCloseMemoryStream()
    {
        AllowClose = true;
    }

    /// <summary>
    /// Gets or sets whether calls to <see cref="Close"/> may close the stream. The default is <see langword="true"/>.
    /// </summary>
    public bool AllowClose { get; set; }

    /// <summary>
    /// Executes the close operation.
    /// </summary>
    public override void Close()
    {
        if (AllowClose)
            base.Close();
    }
}
