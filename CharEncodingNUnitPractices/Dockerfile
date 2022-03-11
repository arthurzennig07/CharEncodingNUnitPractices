FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CharEncodingNUnitPractices/CharEncodingNUnitPractices.csproj", "CharEncodingNUnitPractices/"]
RUN dotnet restore "CharEncodingNUnitPractices/CharEncodingNUnitPractices.csproj"
COPY . .
WORKDIR "/src/CharEncodingNUnitPractices"
RUN dotnet build "CharEncodingNUnitPractices.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CharEncodingNUnitPractices.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CharEncodingNUnitPractices.dll"]
