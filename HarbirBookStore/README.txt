﻿# Assignment2- HarbirBookStore
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
Its Working...!

Added a new Admin area in Areaa and also added the view files
Deleted the Data, Models and Controllers folders
In last, updated the GitHub repo

--------------- PART 2 ---------------------
Starting time: 1455
Date: 2023-11-06

For the next part, firstly i built the application in order to confirm there is no error
Made changes in the appsetting.json(modify the database name) and then added the migration
i selected the wrong the migration and now changed to the correct default project and run it- its working...
paste the migration file's name here- 20231106201049_AddDefaultIdentityMigration.cs
Review the file of the SQL and then updated the database after completing the migration
checked the error and run it
IT IS WORKING...!

Added the Category.cs file to the Models project and modify the Category.cs file  
Then added the migration and made the changes in the dbcontext file
Deleted the AddCategoryToDb to fix the error and after that updated the database
Added a new folder from name- Repository and then added the IRepository folder inside it
Added a new item called IRepository.cs and modified it
Made another item and then modified the code in the Repository folder
Created the individual repo for category and all potential models to be added in the CategoryRepository.cs and ICategoryRepository.cs
modified the CategoryRepository.cs and ICategoryRepository.cs
made some changes in the categoryRepository.cs
Added a new interface in the IRepository folder from ISP_Call.cs and then installed the NuGet package for dapper
Added a new class called SP_Call.cs inside Repository folder made some changes in the code and then modify the ISP_Call interface code
Added a new interface called IUnitOfWork inside the IRepository folder and modify the code
Then added the UnitOfWork.cs in the Repository folder
Modify the code in it and there were several errors
Fixing the error and run it
ITs WORKING...!

Now added the additional line in startup.cs which will be accessible with DI by any controller
Added a new MVC controller from name- CategoryController.cs
Added the code in the CategoryControlller.cs and then created a new folder from name Category
Then created a Index.cshtml inside the Category folder
Modified the Index.cshtml and then made some changes in the code inside the Layout.cshtml
save the changes and run it
IT IS WORKING..!

Modify the Index.cshtml and then deleted it and added the javaScript inside the category.js
After that add the @section call inside the Index.cshtml
save it and run it
its showing error which i mentioned below:
DataTables warning: table id=tblData - Ajax error. For more information about this error, please see http://datatables.net/tn/7

edited the code inside the CategoryController.cs and then created a new category using the Upsert action
modify the code in it and then created the partial view for EDIT | BLACK
then created the _CreateAndBackToListButton.cshtml and added the asp-action in it
then agian created another partial view named-_EditAndBackToListButton and added the code in it
modify the Upsert.cshtml with additional codes and then added the asp-action to the Index.cshtml
run it
having an error in Repository.cs
trying to fix it....
finally fixed it..

created an Upsert post action in CategoryController.cs and added the void Save() method to the IUnitOfWork
made some changes in the _UnitOfWork.Save() method and removed the_db.SaveChanges() method in the CategoryRepository.cs
checked the errors and found some of them
fixed all the errors and then added the API call for HTTPDelete in CategoryController.cs
added the delete functionality in Category.js along with onclick event to delete function
added the Delete(url) function and after that checked the errors, found one error in the Repository.cs
trying to fix it...
finally fixed it and then saved all the changes and test the applictaion
Updated the GitHub Repo
closing time: 2346

--------------- PART 3 ---------------------
Starting time: 1545
Date: 2023-11-20

2018
for the next part, first created the CoverTypeRepository.cs and ICoverTypeRepository.cs inside the Repository folder
then made some changes in it and edited the UnitOfWork and IUnitOfWork
created a CoverType.cs inside the Models folder and modified  it
2050
made CoverTypeController.cs inside the controllers and also created the Upsert.cshtml, then modified both of them
found some errors in CoverTypeRepository.cs and tried to fix it
FIXED IT....!
2106
made changes in layout.cshtml and fixed the error which was showing in the Upsert.cshtml
file was not working, create button was not working, trying to fix this issue
finally fixed it....
now created the Product.cs and modified the code inside it and then edited the ApplicationDbContext
1519
add the migration and updated the database 
added Timestamp here --- 20231126201916_AddProductToDb.cs
1540
added the IProductRepository interface and ProductRepository class
then modify UnitOfWork and IUnitOfWork
save and run it
IT IS WORKING...!

1545
created the ProductController.cs and added the code in it
added ProductVM class and then installed Microsoft.AspNetCore.Mvc.ViewFeatures package
1609
created Index.cshtml and modified it
modified the Product.js and added a new link to product in layout.cshtml
1630
in product, created an Upsert.cshtml and modified the code 
found some errors, working on it
product - NOT WORKING...

1640
made some changes in the Upsert.cshtml inside the product

1251
trying to solve the error and added the upsert.cshtml in the product folder









