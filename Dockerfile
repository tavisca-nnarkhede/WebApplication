FROM mcr.microsoft.com/dotnet/core/aspnet
WORKDIR /app
COPY WebApplicationHi/bin/Release/netcoreapp2.2/publish/. /app
EXPOSE 80
CMD ["dotnet","WebApplicationHi.dll"]
