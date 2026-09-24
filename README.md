## How to Create a New Project

After installing the template, open PowerShell in the folder containing ArchitectureTemplate and run the following:

```powershell
dotnet new install .\ArchitectureTemplate
dotnet new architecture-template -n MyNewProject -o .\MyNewProject
dotnet build .\MyNewProject\MyNewProject.sln
dotnet run --project .\MyNewProject\MyNewProject.API\MyNewProject.API.csproj --launch-profile http
```

MyNewProject is an example. Specify your own name in Latin characters without spaces, such as LibraryApi. The command will replace the names of folders, projects, namespaces, and references in the solution. You only need to install the template once; keep the ArchitectureTemplate folder in place after installation. For subsequent projects, simply repeat the `dotnet new` command with a different name and a new folder.