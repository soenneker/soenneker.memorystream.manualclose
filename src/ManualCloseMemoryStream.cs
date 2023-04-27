namespace Soenneker.MemoryStream.ManualClose;

/// <summary>
/// A derivation of MemoryStream that blocks automatic closing <para/>
/// Make sure to set AllowClose = true after you're done or this will not dispose!
/// </summary>
public class ManualCloseMemoryStream : System.IO.MemoryStream
{
    public ManualCloseMemoryStream()
    {
        AllowClose = true;
    }

    /// <summary>
    /// Should be set to true once the stream is ready to be disposed.
    /// </summary>
    public bool AllowClose { get; set; }

    public override void Close()
    {
        if (AllowClose)
            base.Close();
    }
}