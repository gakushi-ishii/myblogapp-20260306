FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY MyBlogApp/MyBlogApp.csproj MyBlogApp/
RUN dotnet restore MyBlogApp/MyBlogApp.csproj
COPY MyBlogApp/ MyBlogApp/
RUN dotnet publish MyBlogApp/MyBlogApp.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "MyBlogApp.dll"]
