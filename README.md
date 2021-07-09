### _This project is not in a complete or portfolio ready state, and should not be considered representiational of professional work._

# United States Parks Lookup API

### Epicodus Independent Code Review - Building an API

### By Faisal Rana

## Technologies Used

* Git
* C#
* .NET 5.0
* ASP.NET Core
* Entity Framework Core
* RESTful Routing, CRUD
* MySQL & MySQL Workbench
* Swagger
* Postman

## Description

This is a C# API Framework application built to allow users to make API calls to find parks and good spots to visit in the country of Pakistan. The application can be searched and returns information regarding the site including provice and location. 


## Setup/Installation Requirements

* _Requires Visual Studio Code Installation_
* _Requires Terminal Installation_
* _Open the terminal on your local machine_
* _Navigate to the directory inside of which you wish to house this project_
* _Clone this project with the following command  `$ git clone <https://github.com/FaisalRana/ParksLookupAPI.Solution>`_
* _Next you will need to download and install .NET Core through this link if you don't already have it: https://dotnet.microsoft.com/download_
* _After downloading and installing .NET Core, return to your terminal and navigate to the root directory by entering `$ cd Parks.Solution`_
* _Open this project in Visual Studio Code with the command `$ code .`_
* _Still in the terminal, navigate to the desired subdirectory of the repository with the command `$ cd Parks`_
* _Retrieve and install packages listed in the .csproj files with the command `$ dotnet restore`_
* _Create internal content for build with the command `$ dotnet build`_
* _In Visual Studio Code, navigate to the `Parks` directory and create an **appsettings.json** file and input the following script (**note the name of the database can be whatever you would like (e.g. faisal_rana_test)**)_
![Image of appsettings.json example](./Parks/wwwroot/img/appsettings.json_test.png)
* _If you do not have MySQL Workbench, it can be downloaded here: https://dev.mysql.com/downloads/file/?id=484391_
* _Create Initial SQL migration with the following command `$ dotnet ef migrations add Initial`_
* _Update the database in MySQL Workbench with the following command `$ dotnet ef database update` (**note this will title the database whatever you listed in your appsettings.json file (e.g. faisal_rana_test)**) _
* _Back in the terminal, navigate to `$ cd Parks` and run the application with the command `$ dotnet run`


## Documentation

#### CRUD Structure
```
GET /api/parks
GET /api/parks/{id}
POST /api/parks
PUT /api/parks/{id}
DELETE /api/parks/{id}
```
This project also has an additional endpoint to launch swagger UI which can be used to identify and execute all working endpoints.  
```

#### Example Query
```
GET /api/parks/?location=GB
```

#### Swagger

This project utilizes full swagger documentation that can be found here: https://app.swaggerhub.com/apis-docs/faisalrana/ParksApi/0.1

![Image of swagger documentation](./Parks/wwwroot/img/swagger_screenshot.png)


## Known Bugs

No known bugs at this time

## Improvement Opportunities

* Eventually have all National and State parks included in the database
* Create an MVC application that interacts with the API

## Link

This project is not hosted on GitHub Pages

## License

Copyright (c) 2021 Faisal Rana

This software is licensed under the MIT license

## Contact Information

inquisitive@gmail.com