# Assignment2- HarbirBookStore
Srarting time- 2105
Date- 2023-10-30
Author-Harbir Kaur Powar
ID- 0825064
Created a ASP.NET MVC application and use .Net5 SDK
used individual user account authorization and then added README.md file README.txt file
Then created the github repo
Firstly, in the launchsettings.json, commented out the //"sslPort": and then removed the (options => options.SignIn.RequireConfirmedAccount = true) from the startup.cs file
Now, from the Bootswatch.com downloaded the bootstrap.css and then in the wwwroot file, removed the exist bootstrap.css which found in-lib>bootstrap>dist>css
Open the wwwroot and replaced the exist site.css file with main css folder

Changed the file name from bootstrap.min.css to bootstrap.css from the Views>Shared>_Layout.cshtml
In the nav class, Changed the navbar-light to navbar-dark and bg-white to bg-primary
In line 23- removed the text-dark and added the "text-white-50 bg-primary" properties to the footer class
Removed the "text-dark" in the _loginPartial.cshtml and run the project
Run Successfully...!

Added the additional stylesheet and script from the CSS_JS.txt file in the _Layout.cshtml
In Views>Shared>_Layout.cshtml, added a dropdown to the NavBar
Before saving and reviewing the UI, changed the 'Dropdown' to 'Content Management' and now run it
Its Working...!

Now, added the three projects(.NET Core class library) from name- HarbirBooks.DataAccess, HarbirBooks.Models, HarbirBooks.Utility
Then copied the data folder and pasted to the .DataAccess project and after that , deleted the original one
Installed Microsoft.EntityFramework, Core.Relational and Core.SqlServer packages
Then, deleted the migrations folder and now installed the NuGet package-Identity.EntityFramework Core
Edited the namespace and deleted the default Class1.cs file in all projects
Build the project and run it
Run Successfully...!

Now moved the Models in to HarbirBooks.Models and deleted the original one 
Edited the Error.cshtnl in the Views>Shared and then selected the .DataAccess and .Models by project-add-project reference
Renamed Models folder to ViewModels and changed the ErrorViewModels.cs namespace with .Models.ViewModels
Build the project and fixed the errors  and run it
No Error...Working fine...!

Created a static details class called SD.cs in the Utility project and then edited the properties of the class
Added project reference to the main project and selected the Models and Utility in the DataAccess project
Added a "Customers" area to Areas and then changed the routes in the ScaffoldingReadMe.txt
Moved the HomeController.cs to the Controller folder and deleted the Data as well as models
Modified the HomeController.cs and moved Views>Home and edited the HomeController namespace
Run the application
Run Successfully...!

Now, Views are located in Areas and then copied the _ViewImport and _ViewStart to Customer Area
Modified the _ViewStart.cshtml in order to reflected the new path
Run the application 
It Working...!

Added a new Admin area in Areaa and also added the view files
Deleted the Data, Models and Controllers folders
In last, updated the GitHub repo



