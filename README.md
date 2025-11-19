# BookStackApi

A C# library for the BookStack API that supports async getting of books, pages & chapters. Designed to be used with Dependency Injection.

## Installing
You can install from Nuget using the following command:

`Install-Package MarvinKlein1508.BookStackApi`

Or via the Visual Studio package manger.

## Basic Usage

First you'll need to register a service. To do this we provide two extension methods. Those can be found within the namespace

    using BookStackApi;

Once you have imported the namespace, you'll need to register the service with DI. You can either manually define the options

```csharp
builder.Services.AddBookstack(options => {
    options.BaseUrl = "https://yourdomain/api/";
    options.Token = "YOUR TOKEN";
    options.Secret = "YOUR SECRET";
})
```
Or use the `appsettings.json` file to provide the configuration. Your `appsettings.json` needs to this section:
```json
"BookStack": {
    "BaseUrl": "https://yourdomain/api/",
    "Token": "YOUR TOKEN",
    "Secret": "YOUR SECRET"
}
```

Please note to specify the base URL with an ending `/api/`. Otherwise the API does not work.

Now you can use the extensionmethod to register the service:
```csharp
builder.Services.AddBookstack(builder.Configuration));
```

Finally you can inject `BookStackService` wherever you'll need it.

## Get Data
You can get data from the API by using the `GetAsync<T>` function. The Service will determine the correct endpoint by the specified class.
```csharp
bookStackService.GetAsync<Book>(id_of_book);
bookStackService.GetAsync<Page>(id_of_page);
bookStackService.GetAsync<Chapter>(id_of_chapter);
```

There is also a function to get a list of those objects.
```csharp
bookStackService.GetListAsync<Book>();
bookStackService.GetListAsync<Page>();
bookStackService.GetListAsync<Chapter>();
```

## How do I create, update, delete, export with this API?
This features are currently not supported by this implemention. I've only implemented the features that I'll needed right now. I'll might add more features in the future once I'll need those. Otherwise feel free to [create a pull request](https://github.com/MarvinKlein1508/BookStackApi/pulls).