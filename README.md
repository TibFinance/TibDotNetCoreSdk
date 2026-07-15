# TIB Finance .NET Core SDK

![.NET](https://img.shields.io/badge/.NET-8.0%2B-512BD4)

.NET Core SDK for the TIB Finance payment processing API.

## Installation

```bash
git clone https://github.com/TibFinance/TibDotNetCoreSdk.git
```

Add a project reference:

```bash
dotnet add reference path/to/Tib.Api.csproj
```

Alternatively, download the prebuilt NuGet package (`.nupkg`) from the latest [GitHub release](https://github.com/TibFinance/TibDotNetCoreSdk/releases) and install it with `dotnet add package Tib.Api --source <folder>`.

## Quick Start

```csharp
using System;
using Tib.Api;
using Tib.Api.Model.General;

TibInvoker.InitializePortal("https://sandboxportal.tib.finance");

var sessionArgs = new CreateSessionArgs {
    ClientId = Guid.Parse("00000000-0000-0000-0000-000000000000"), // replace with your client id
    Username = "your_username",
    Password = "your_password"
};
var response = TibInvoker.Portal.CreateSession(sessionArgs);
if (response.HasError)
{
    Console.WriteLine("Session failed: " + response.Messages);
}
else
{
    Console.WriteLine(response.SessionId);
}
```

## Documentation

For the complete API reference and guides, visit [doc.tib.finance](https://doc.tib.finance).

This SDK provides access to **62 API methods** for payment processing, merchant management, and financial operations.

## Other TIB Finance SDKs

| SDK | Repository |
|-----|------------|
| Python | [TibPythonSdk](https://github.com/TibFinance/TibPythonSdk) |
| Java | [TibJavaSdk](https://github.com/TibFinance/TibJavaSdk) |
| .NET Framework | [TibDotNetSdk](https://github.com/TibFinance/TibDotNetSdk) |
| PHP | [TibPhpSdk](https://github.com/TibFinance/TibPhpSdk) |
| JavaScript (Browser) | [TibJavascriptSdk](https://github.com/TibFinance/TibJavascriptSdk) |
| Node.js | [TibNodeJsSdk](https://github.com/TibFinance/TibNodeJsSdk) |

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

- Documentation: [doc.tib.finance](https://doc.tib.finance)
- Email: support@tib.finance
