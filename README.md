# Travel API

#### By Jacob Maier, Molly Donegan, Eliot Gronstal

#### _An API that allows users to GET and POST reviews about various travel destinations around the world. Made using C# at Epicodus Coding School._

## Technologies Used

* _C#/.NET_
* _SQL Workbench_
* _MVC_
* _Entity Framework_
* _Identity_
* _Swagger_

## Description

An API that allows users to GET and POST reviews about various travel destinations around the world. Made using C# at Epicodus Coding School.

There are custom endpoints for some of these user stories.

* A user can GET and POST reviews about travel destinations.

* A user can GET reviews by country or city.

* A user can see the most popular travel destinations by number of reviews or by overall rating.

* A user can PUT and DELETE reviews, but only if their userName is attributed.

* A user can look up random destinations just for fun.

* A user can access the API endpoint with a query parameter that specifies the page that should be returned.

## Setup/Installation Requirements
_Requires console application such as Git Bash, Terminal, or PowerShell_

1. Open Git Bash or PowerShell if on Windows and Terminal if on Mac
2. Run the command

    ``git clone https://github.com/Elgrons/TravelApi``

3. Run the command

    ``cd TravelApi``

* You should now have a folder `TravelApi` with the following structure.
    <pre>TravelApi
    ├── .gitignore 
    ├── ... 
    └── TravelApi
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md</pre>

4. Add a file named appsettings.json in the following location, inside TravelApi folder 

    <pre>TravelApi
    ├── .gitignore 
    ├── ... 
    └── TravelApi
        ├── Controllers
        ├── Models
        ├── ...
        └── <strong>appsettings.json</strong></pre>
      
5. Copy and paste below JSON text in appsettings.json.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travelapi;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

```

7. Replace [YOUR-USERNAME-HERE] with your MySQL user name.

8. Replace [YOUR-PASSWORD-HERE] with your MySQL password.

9. Run the command

    ```dotnet ef database update```


<strong>To Run</strong>

Navigate to the following directory in the console
    <pre>TravelApi
    └── <strong>TravelApi</strong></pre>

Run the following command in the console

  ``dotnet build``

Then run the following command in the console

  ``dotnet run``

This program was built using _`Microsoft .NET SDK 6.0`_, and may not be compatible with other versions. Cross-version performance is neither implied nor guaranteed, your actual mileage may vary.

## API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

###  Swagger Documentation 
To view the Swagger documentation for the TravelApi, launch the project using `dotnet run` using Terminal or Powershell, then input the following URL into your browser: `https://localhost:5001/swagger/index.html`

### Destinations

Get information about different global destinations.

#### HTTP Request Structure
```
GET https://localhost:5001/api/Destinations/
GET https://localhost:5001/api/Destinations/{id}
POST https://localhost:5001/api/Destinations/
PUT https://localhost:5001/api/Destinations/{id}
DELETE https://localhost:5001/api/Destinations/{id}
GET https://localhost:5001/api/Destinations/page/{page}
```
* To utilize the POST request and create a new instance of a destination, the following information is required.
```
{
    "destinationId": "int",
    "country": "string",
    "city": "string",
    "review": "string",
    "rating": "int",
    "userName": "string"
}
```

#### Example Query
```
https://localhost:5001/api/Destinations/1
```
#### Sample JSON Response
```
{
    "destinationId": 1,
    "country": "Switzerland",
    "city": "Zurich",
    "review": "Great",
    "rating": 5,
    "userName": MollyD
}
```

## Known Bugs

* _No known issues_

* _Reach out with any questions or concerns to [eliot.lauren@gmail.com](eliot.lauren@gmail.com), [mollyrdonegan@gmail.com](mollyrdonegan@gmail.com), [jacobamaier@gmail.com](jacobamaier@gmail.com)_

## License

[MIT](/LICENSE)

Copyright Jacob Maier, Molly Donegan, Eliot Gronstal