FROM mcr.microsoft.com/dotnet/core/samples:aspnetapp AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["AlloeHRMSystem.UI/AlloeHRMSystem.UI.csproj", "AlloeHRMSystem.UI/"]
COPY ["AlloeHRMSystem.Persistence/AlloeHRMSystem.Persistence.csproj", "AlloeHRMSystem.Persistence/"]
COPY ["AlloeHRMSystem.Domain/AlloeHRMSystem.Domain.csproj", "AlloeHRMSystem.Domain/"]
COPY ["AlloeHRMSystem.ApplicationServices/AlloeHRMSystem.ApplicationServices.csproj", "AlloeHRMSystem.ApplicationServices/"]
RUN dotnet restore "AlloeHRMSystem.UI/AlloeHRMSystem.UI.csproj"
COPY . .
WORKDIR "/src/AlloeHRMSystem.UI"
RUN dotnet build "AlloeHRMSystem.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AlloeHRMSystem.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AlloeHRMSystem.UI.dll"]