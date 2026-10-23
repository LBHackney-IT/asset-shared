# Hackney.Shared.Asset

`Hackney.Shared.Asset` is a .NET 10 class library containing shared asset-domain types and boundary contracts for Hackney services. It is a library, not a hosted web API.

## Contents

- Asset domain models, including address, location, management, characteristics, and tenure.
- Request and response contract types, plus FluentValidation validators for asset address edits and property patches.
- Mapping extensions between the asset domain and persistence representations.
- DynamoDB-mapped persistence models for the `Assets` table, using converters from `Hackney.Core.DynamoDb`.
- Shared tenure types and persistence models supplied by the Hackney tenure package.

## API endpoints

This repository defines no HTTP server, routes, or API endpoints. Its request and response classes are contracts intended for use by consuming services.

## Data sources

The library itself does not connect to or query external data sources. Its `Infrastructure` models describe DynamoDB serialization for the `Assets` table; database access is the responsibility of consuming applications. The tenure model includes types from the shared Hackney tenure package.

## Requirements

- .NET 10 SDK for local restore, build, and test commands.
- Docker with the Docker Compose v2 plugin to run the repository's container-based test target.
- Access to the Hackney GitHub NuGet feed for restoring the private package dependencies.

## Restore and build

Set `LBHPACKAGESTOKEN` to a GitHub token with access to the Hackney NuGet feed, then run:

```sh
dotnet restore Hackney.Shared.Asset.sln
dotnet build Hackney.Shared.Asset.sln
```

## Run tests

Create the Compose environment file from the sample and populate `LBHPACKAGESTOKEN`:

```sh
cp .env.sample .env
```

Then build and run the test container from the repository root:

```sh
make test
```

The test project is `Hackney.Shared.Asset.Tests`. The Makefile cleans up exited test containers and dangling images after the test run.

## Package use

The library is published as a NuGet package by the repository's GitHub Actions workflow. See [the Hackney package usage guide](<https://github.com/LBHackney-IT/lbh-core/wiki/Using-the-package(s)-from-the-Hackney.Core-repository>) for consuming packages from the Hackney repository.
