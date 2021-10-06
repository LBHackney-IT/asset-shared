FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.Asset.sln ./
COPY ./Hackney.Shared.Asset/Hackney.Shared.Asset.csproj ./Hackney.Shared.Asset/
COPY ./Hackney.Shared.Asset.Tests/Hackney.Shared.Asset.Tests.csproj ./Hackney.Shared.Asset.Tests/
COPY /nuget.config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./Hackney.Shared.Asset/Hackney.Shared.Asset.csproj
RUN dotnet restore ./Hackney.Shared.Asset.Tests/Hackney.Shared.Asset.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.Asset.Tests/Hackney.Shared.Asset.Tests.csproj

CMD dotnet test