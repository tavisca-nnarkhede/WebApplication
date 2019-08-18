FROM mcr.microsoft.com/dotnet/core/aspnet
WORKDIR /app
COPY WebApplication/bin/Release/netcoreapp1.1/publish/. /app
EXPOSE 80
CMD ["dotnet","WebApplication.dll"]
