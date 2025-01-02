FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["submodules/bamfs/bam.files.tests/bam.files.tests.csproj", "submodules/bamfs/bam.files.tests/"]
RUN dotnet restore "submodules/bamfs/bam.files.tests/bam.files.tests.csproj"
COPY . .
WORKDIR "/src/submodules/bamfs/bam.files.tests"
RUN dotnet build "bam.files.tests.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "bam.files.tests.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bam.files.tests.dll"]
