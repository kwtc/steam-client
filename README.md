# dotnet-actions-template
Template for .NET projects with Github actions

## Features and setup
- Github actions
    - [.NET build and test](#dotnet)
    - [Pull request labeler](#pr-lebeler)
    - [Require pull request label](#pr-require-label)
    - [Release drafter](#release-drafter)
    - [Publish](#publish)
- [Token](#token)
- [NuGet](#nuget)

### <a name="dotnet"></a>.NET build and test
This action does multiple things to ensure that a pull request is good when a pull request targeting the main branch is opened and again when pushed.

1. Checkout the code from repository.
2. Update the nuget.config file kwtc entry with a username and password (token) to be able to have dependencies on private Github nuget packages (See [NuGet](#nuget) section for further instructions).
3. Restore dependencies for solution.
4. Build the solution with the Release configuration.
5. Test the solution with the Release configuration.

<p style="color:red">Required configuration in ci.yml: Define solution file path and name.</p>

### <a name="pr-labeler"></a>Pull request labeler
Adds a label to a pull request based on the branch name e.g. feature/super-awesome-new-thingy will add a feature tag. The following tag are configured:
- feature/* - A new feature.
- fix/* - A bug fix.
- chore/* - General maintanence.

These labels are then used by the [Release drafter](#release-drafter) action.

### <a name="require-pr-label"></a>Require pull request label
This action ensures that a pull request has one of the following labels applied:
- major
- minor 
- patch 

One of these labels has to be manually created and applied and are then used by the [Release drafter](#release-drafter) action.

### <a name="release-drafter"></a>Release drafter
Creates a release draft with all merged pull requests grouped by their feature(Features), fix(Bug fixes) or chore(Maintenance) labels see [Pull request labeler](#pr-lebeler). Release version is automatically determined by the major, minor or patch label following this template `<major>.<minor>.<patch>`.

### <a name="publish"></a>Publish
The publish action builds, tests and packs the ...

### <a name="token"></a>Token
Both [.NET build and test](#dotnet) and [Publish](#publish) actions make use of the GITHUB_TOKEN which is automatically generated when running an action. 

TODO: permissions for the two actions etc.

### <a name="nuget"></a>NuGet
nuget.config is configured with two package sources:
- https://api.nuget.org/v3/index.json
- https://nuget.pkg.github.com/kwtc/index.json

To access private packages from kwtc in Github actions make sure that the ewquired packages themselves are made available to the executing repository under the individual package settings e.g. [Kwtc.BackgroundJob.Hangfire](https://github.com/users/kwtc/packages/nuget/Kwtc.BackgroundJob.Hangfire/settings) settings.
