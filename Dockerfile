FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /Cahtbot

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /Cahtbot
COPY --from=build-env /Cahtbot/out .
EXPOSE 3030

ENTRYPOINT ["dotnet", "Cahtbot.dll"]