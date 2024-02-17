# Murder Mystery Party Creator

The goal of this project is to create an application that can be used to generate prompts for a Murder Mystery game! This includes default party options, characters, and the option of adding your own characters; create the beginning of your mystery with just a few clicks!

## How it Works
Using [CRUD functionality](https://www.codecademy.com/article/what-is-crud) and [MVC design](https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/overview/asp-net-mvc-overview), we’ve created a database to go along with our program that adds **2 default party themes** as well as **10 default characters**, each complete with descriptions. The user will also have the option to choose whether their story is scripted or improvised, and whether the murderer knows they are the killer or not. 
Once the user has filled in all necessary data, they can either download their custom instructions for printing, or save their current info to edit later.

## Requirements
- **Visual Studio 2022**
- **ASP.NET & web development workload**
- **.NET Version 8.0**

## Create the Database
1. Make sure all necessary NuGet packages are installed:
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
      
_Once your NuGet packages have finished installing:_   
2. Open the **Package Manager** (Tools -> NuGet Package Manager -> Package Manager Console)   
3. Execute the command “Update-Database” (no spaces!)   
4. Check your **SQL Server Object Explorer** for the **CPW211_MurderMystery database** under localdb.    
5. Done!   

## Contributors
- [FeelinProggy](https://github.com/FeelinProggy)
- [DZ1987](https://github.com/DZ1987)
- [Wesli-S](https://github.com/Wesli-S)
