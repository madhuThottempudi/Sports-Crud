#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SportsApplication/SportsApplication.csproj", "SportsApplication/"]
RUN dotnet restore "SportsApplication/SportsApplication.csproj"
COPY . .
WORKDIR "/src/SportsApplication"
RUN dotnet build "SportsApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SportsApplication.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SportsApplication.dll"]