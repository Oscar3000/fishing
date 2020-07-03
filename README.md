commands:
 for creating/adding migrations:
- dotnet ef migrations add InitialCreate
 for removing migrations:
 - dotnet ef migrations remove
 for updating/creating database and tables
 - dotnet ef database update
 for starting using mssql cmd
 - sqlcmd -S localhost -U SA -P 
for checking list of dbs through sqlcmd
- SELECT Name from sys.Databases

for scaffolding a controller
- dotnet aspnet-codegenerator controller -name BoatController -async -api -m Boat -dc ApplicationDbContext -outDir Controllers



packages to install
- dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- dotnet add package Microsoft.EntityFrameworkCore.Design


global tool
- dotnet tool install --global dotnet-ef 
- echo 'export PATH="$PATH:$HOME/.dotnet/tools"' >> ~/.bash_profile
- echo 'export PATH="$PATH:$HOME/.dotnet/tools"' >> ~/.bashrc
- source ~/.bashrc