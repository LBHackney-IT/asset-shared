# Hackney.Shared.Asset
At Hackney, we have created NuGet Packages to prevent the duplication of common code when implementing our APIs.
This NuGet package will store the shared code related to the asset domain that can then be used in the relevant projects.

## Using the package
For full details on how to use the package(s) within this repository please read 
[this wiki page](https://github.com/LBHackney-IT/lbh-core/wiki/Using-the-package(s)-from-the-Hackney.Core-repository).

## Contributing

### Running Tests Locally
1. Create the `.env` file based on the `.env.sample` and then populate the values for the variable names listed there. To create the `.env` run:
    ``` sh
    cp .env.sample .env
    ```
2. Run the tests by running:
    ``` sh
    make test
    ```

### Automated Versioning
The pipeline automatically updates the package version number.

Any specific version number follows the form `Major.Minor.Patch[-Suffix]`, where the components have the following meanings:

* *Major*: Breaking changes
* *Minor*: New features, but backward compatible
* *Patch*: Backwards compatible bug fixes only
* *Suffix (optional)*: a hyphen followed by a string denoting a pre-release version

### Branching Strategy

In order for the pipeline to be able to run automated tests and create preview versions of packages, you must name your branch correctly.

**Name your branch following the convention of `feature/<some-feature>`.** This will allow the pipeline to work correctly. 
If all tests pass, a new version of your package will be publised on every commit. You can see published versions of packages [here](https://github.com/orgs/LBHackney-IT/packages?repo_name=asset-shared).

All preview versions of packages will have the suffix **`-feat-<branch-name>-<number>`**.

This branch name in the package version has a character limit of **12 characters**, so try to name your branch accordingly, otherwise it will be cut off.