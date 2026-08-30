[![](https://img.shields.io/nuget/v/soenneker.libraries.ffplay.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.ffplay/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libraries.ffplay/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libraries.ffplay/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libraries.ffplay.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libraries.ffplay/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libraries.ffplay/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.libraries.ffplay/actions/workflows/codeql.yml)

# Soenneker.Libraries.FFplay

The FFplay Windows executable packaged as a .NET content asset.

## Install

```bash
dotnet add package Soenneker.Libraries.FFplay
```

The package copies the executable beneath the application output directory:

```text
Resources/ffplay.exe
```

```csharp
string ffplay = Path.Combine(AppContext.BaseDirectory, "Resources", "ffplay.exe");
```

This package supplies the Windows executable but does not start or manage the media player. FFplay opens a native window and requires a usable desktop/audio session; it is generally unsuitable for headless server workloads.
