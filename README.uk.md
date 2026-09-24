## Як створити новий проєкт

Після встановлення шаблону відкрийте PowerShell у папці, що містить ArchitectureTemplate, і виконайте:

```powershell
dotnet new install .\ArchitectureTemplate
dotnet new architecture-template -n MyNewProject -o .\MyNewProject
dotnet build .\MyNewProject\MyNewProject.sln
dotnet run --project .\MyNewProject\MyNewProject.API\MyNewProject.API.csproj --launch-profile http
```

MyNewProject — приклад. Вкажіть власну назву латиницею без пробілів, наприклад LibraryApi. Команда замінить назви папок, проєктів, просторів імен та посилань у solution. Шаблон достатньо встановити один раз; папку ArchitectureTemplate після встановлення зберігайте на місці. У наступних проєктах повторюйте лише команду dotnet new з іншою назвою та новою папкою.