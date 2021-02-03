# Fortnite.Net

[![Nuget](https://img.shields.io/nuget/v/Fortnite.Net.Thoo?logo=nuget)](https://www.nuget.org/packages/Fortnite.Net.Thoo)
[![Nuget DLs](https://img.shields.io/nuget/dt/Fortnite.Net.Thoo?logo=nuget)](https://www.nuget.org/packages/Fortnite.Net.Thoo)
[![GitHub License](https://img.shields.io/github/license/thoo0224/Fortnite.Net)](https://github.com/Fortnite-API/csharp-wrapper/blob/master/LICENSE)

```csharp
        private static async Task Main()
        {
            var api = new FortniteApiBuilder()
                .SetDevice("x", "x", "x")
                .Build();
            api.Login += model =>
            {
                Console.WriteLine($"Successfully logged in on {model.DisplayName}.");
            };
            await api.LoginWithDeviceAsync();
            // Self-Explanatory :)
        }
```