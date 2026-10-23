# .NET 10 Upgrade

## Summary

- Retargeted `Hackney.Shared.Asset` and `Hackney.Shared.Asset.Tests` from `net8.0` to `net10.0`.
- Updated the test Docker image from the .NET 8 SDK to the .NET 10 SDK.
- Replaced the inherited template README with documentation of the shared asset library, its package setup, test workflow, persistence mappings, and the fact that this repository does not host HTTP endpoints.
- Preserved all package references and versions.

## Validation

- Before migration: `make test` built the .NET 8 projects and passed all 60 tests.
- After migration: `make test` built the .NET 10 projects and passed all 60 tests.
- The Docker build restored dependencies and built the test project and its library project successfully.
- The .NET 10 restore/build reports NU1510 for the existing explicit `System.Text.Json` package reference. It is retained because removing or changing package references is outside the required migration.
- `make clean`, invoked by the test target, reports that `docker rmi` received no image when there are no dangling images. The Makefile ignores this cleanup error; test execution itself succeeds.
- The Docker Compose file and test Dockerfile contained no SonarCloud configuration, so no temporary scanner workaround was applied.

## Package changes

None. All package references and versions are unchanged.

## Build tooling note

The Makefile already uses `docker compose` (Compose v2) for every Compose command, so no Makefile edit was required. This spelling was used for both baseline and post-upgrade test runs, and is required because the legacy `docker-compose` CLI is unavailable in this environment.
