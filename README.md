# Soenneker.MemoryStream.ManualClose
[![](https://img.shields.io/nuget/v/Soenneker.MemoryStream.ManualClose.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.MemoryStream.ManualClose/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.memorystream.manualclose/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.memorystream.manualclose/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.MemoryStream.ManualClose.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.MemoryStream.ManualClose/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.memorystream.manualclose/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.memorystream.manualclose/actions/workflows/codeql.yml)

A `MemoryStream` whose `Close` and `Dispose` calls can be temporarily ignored when another API incorrectly assumes ownership of a caller-owned stream.

## Installation

```bash
dotnet add package Soenneker.MemoryStream.ManualClose
```

## Usage

`AllowClose` defaults to `true`, so the stream behaves like a normal `MemoryStream` unless closing is explicitly blocked.

```csharp
var stream = new ManualCloseMemoryStream
{
    AllowClose = false
};

try
{
    await WritePayload(stream);

    // This dependency calls Dispose on the supplied stream.
    await SendWithoutOwnership(stream);

    // The stream remains usable because closing was blocked.
    stream.Position = 0;
    await SaveCopy(stream);
}
finally
{
    stream.AllowClose = true;
    stream.Dispose();
}
```

Always restore `AllowClose` and dispose in a `finally` block. While closing is blocked, a `using` statement or an early `Dispose` call does not release the stream's buffer.

This type is useful only when an API closes a stream it does not own and offers no leave-open option. Prefer the dependency's native `leaveOpen` setting when one exists. Do not change `AllowClose` concurrently with disposal; the property does not provide synchronization.
