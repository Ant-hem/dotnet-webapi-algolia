# 🔎 Getting started with Algolia, Swagger and .NET WebAPI

## Hi everyone 👋

In this repository you will find the source of an application I used in a talk to present how Algolia can work with a .NET WebAPI and Swagger.

The purpose was to show how it's easy to use Algolia with a .NET WebAPI.
I didn't add all the method of the API since it was a demo. I may add them in the future. If you want to contribute to the project, feel free to submit a PR.

## 🚀 How to start the project?

- Set the following environment variables:

```sh
ALGOLIA_API_KEY = your_api_key
```

```sh
ALGOLIA_APPLICATION_ID = your_admin_key
```

- Then type:

```sh
dotnet run --project  src/Algolia.WebAPI.csproj
```

 - Then go to `https://localhost:5001/swagger/index.html`

If you need a dataset you can use the [Actor](https://github.com/algolia/algoliasearch-console-dotnet/blob/master/src/AlgoliaConsole/Datas/Actors.json) dataset.

# Getting help

- 🆘 **I don't have an Algolia Index**! Go the [.NET client repository](https://github.com/algolia/algoliasearch-client-csharp) to index your data!
- 🐞 **Found a bug?** Feel free to open an issue
- 💡 **Improvement idea? Adding methods?** Feel free to open a PR