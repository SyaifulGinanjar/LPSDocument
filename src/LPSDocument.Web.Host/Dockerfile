FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/LPSDocument.Web.Host/LPSDocument.Web.Host.csproj", "src/LPSDocument.Web.Host/"]
COPY ["src/LPSDocument.Web.Core/LPSDocument.Web.Core.csproj", "src/LPSDocument.Web.Core/"]
COPY ["src/LPSDocument.Application/LPSDocument.Application.csproj", "src/LPSDocument.Application/"]
COPY ["src/LPSDocument.Core/LPSDocument.Core.csproj", "src/LPSDocument.Core/"]
COPY ["src/LPSDocument.EntityFrameworkCore/LPSDocument.EntityFrameworkCore.csproj", "src/LPSDocument.EntityFrameworkCore/"]
WORKDIR "/src/src/LPSDocument.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/LPSDocument.Web.Host", "src/LPSDocument.Web.Host"]
COPY ["src/LPSDocument.Web.Core", "src/LPSDocument.Web.Core"]
COPY ["src/LPSDocument.Application", "src/LPSDocument.Application"]
COPY ["src/LPSDocument.Core", "src/LPSDocument.Core"]
COPY ["src/LPSDocument.EntityFrameworkCore", "src/LPSDocument.EntityFrameworkCore"]
WORKDIR "/src/src/LPSDocument.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "LPSDocument.Web.Host.dll"]
