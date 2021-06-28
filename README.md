# FogLampz

![FogLampz](logo.png)

FogLampz is a .NET wrapper around around the FogBugz API.

## Features

* Simple, Easy to use wrapper around the [Fogbugz XML API](http://www.fogcreek.com/fogbugz/docs/70/topics/advanced/api.html)
* Strong Type support for most FogBugz entities
* Extensible! Supports all built-in properties as well as providing easy access to custom fields

### Example

```csharp
FogBugzClient.LogOn("https://myproject.fogbugz.com/api.asp", "email@mydomain.com", "password");

var projects = FogBugzClient.GetProjects();
var areas = FogBugzClient.GetAreas();

var cases = FogBugzClient.GetCases(new[] {1, 2, 3, 4, 5});
var case2 = FogBugzClient.GetCase(2);

FogBugzClient.CreateArea(new Area {Name = "Sample Area", IndexProject = 2});
```

## Contribute

If you think this could be better, please [open an issue](https://github.com/risadams/FogLampz/issues/new)!

Please note that all interactions in this organization fall under our [Code of Conduct](CODE_OF_CONDUCT.md).

## License

[MIT](LICENSE) © 1996+ Ris Adams
