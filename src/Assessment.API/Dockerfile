#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Assessment.API/Assessment.API.csproj", "src/Assessment.API/"]
COPY ["src/Assessment.Application/Assessment.Application.csproj", "src/Assessment.Application/"]
COPY ["src/Assessment.Infrastructure/Assessment.Infrastructure.csproj", "src/Assessment.Infrastructure/"]
COPY ["src/Assessment.Core/Assessment.Core.csproj", "src/Assessment.Core/"]
RUN dotnet restore "src/Assessment.API/Assessment.API.csproj"
COPY . .
WORKDIR "/src/src/Assessment.API"
RUN dotnet build "Assessment.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Assessment.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assessment.API.dll"]