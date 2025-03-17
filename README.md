# NtfyCator

A minimalistic .NET library for publishing messages to [ntfy.sh](https://ntfy.sh/) and self-hosted instances.

## Features

✅ Simple and lightweight
✅ Async-friendly API
✅ Easy integration

## Installation

TBD

## Getting Started

### Register NtfyCator in `Program.cs`

In an **ASP.NET Core** or **.NET Generic Host** application:

```csharp
using NtfyCator;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddNtfyCator();

var app = builder.Build();
```

And now you are good to go to publish to [ntfy.sh](https://ntfy.sh). If you need to target a self-hosted instance, you can simply configure the server URI:

```csharp
builder.Services.AddNtfyCator(options =>
{
    options.Uri = "https://my.ntfy.server";
});
````

### Inject & Use the Client

```csharp
public class NotificationService
{
    private readonly INotificator _notificator;
    
    public NotificationService(INotificator notificator)
    {
        _notificator = notificator;
    }
    
    public async Task SendNotification()
    {
        var message = new NtfyMessageBuilder("my-topic")
                      .WithTitle("Test Message")
                      .WithMarkdownBody("This is _just_ a **Test**!")
                      .WithPriority(NtfyPriority.High)
                      .WithTags("tag1", "tag2")
                      .Build();
        
        await notificator.NotifyAsync(message);
    }
}
```

`INotificator` also provides an alternative fluent interface that combines message building and sending:

```csharp
await notificator.NotifyTopic("my-topic")
                 .WithBody("Just another Test!")
                 .WithPriority(NtfyPriority.Low)
                 .SendAsync();
```

### Authorization

**NtfyCator** currently supports access token authorization. To enable it simply call before first usage:

```csharp
notificator.WithAccessToken("tk_xxxxxxxxxxxxxxxxx");
```

Every subsequent notification will use the access token as Bearer Token.

## Configuration Options

**NtfyCator** allows configuring these options:

| Option | Type     | Default Value     | Description |
| ------ | -------- | ----------------- | ----------- |
| `Uri`  | `String` | `https://ntfy.sh` | Server URI  |

## License

MIT License - see [LICENSE](./LICENSE) for more information.
