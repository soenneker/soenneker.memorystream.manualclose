[![](https://img.shields.io/nuget/v/Soenneker.MemoryStream.ManualClose.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.MemoryStream.ManualClose/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.memorystream.manualclose/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.memorystream.manualclose/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.MemoryStream.ManualClose.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.MemoryStream.ManualClose/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.memorystream.manualclose/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.memorystream.manualclose/actions/workflows/codeql.yml)

# Soenneker.MemoryStream.ManualClose

A derivation of MemoryStream that blocks automatic closing Make sure to set AllowClose = true after you're done or this will not dispose!.

## Install

```bash
dotnet add package Soenneker.MemoryStream.ManualClose
```

## What you get

- `ManualCloseMemoryStream` — A derivation of MemoryStream that blocks automatic closing Make sure to set AllowClose = true after you're done or this will not dispose!.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ManualCloseMemoryStream.AllowClose` | Should be set to true once the stream is ready to be disposed. | Should be set to true once the stream is ready to be disposed. |
