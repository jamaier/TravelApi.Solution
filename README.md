# Travel API

#### By Jacob Maier, Molly Donegan, Eliot Gronstal

#### _An API that allows users to GET and POST reviews about various travel destinations around the world. Made using C# at Epicodus Coding School._

## Technologies Used

* _C#/.NET_
* _SQL Workbench_
* _MVC_
* _Entity Framework_
* _Identity_
* _JwtBearer_
* _Swagger_

## Description

An API that allows users to GET and POST reviews about various travel destinations around the world. Made using C# at Epicodus Coding School.

There are custom endpoints for some of these user stories.

* A user can GET and POST reviews about travel destinations.

* A user can GET reviews by country or city.

* A user can see the most popular travel destinations by number of reviews or by overall rating.

* A user can PUT and DELETE reviews, but only if their userName is attributed.

* A user can look up random destinations just for fun.

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
    "DefaultConnection": "Server=localhost;Port=3306;database=ProjectName;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
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

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:5000/api/users/authmanagement/register`
* Add the following query to the request as raw data in the Body tab:
```
{
    "name": "Test User",
    "email": "Test@Test.com",
    "password": "epicodus"
}
```
* The token will be generated in the response. Copy and paste it as the Token paramenter in the Authorization tab after selecting "Bearer Token" from the dropdown menu.

###  Swagger Documentation 
To view the Swagger documentation for the TravelApi, launch the project using `dotnet run` using Terminal or Powershell, then input the following URL into your browser: `http://localhost:5000/swagger`

###  Swagger Authorization 
In order to utilize Swagger and interact with the API, you will first need to authenticate yourself through Postman. 
* Once you have completed authorization and have obtained your Bearer Token, navigate back to `http://localhost:5000/swagger` then click on the `authorize` button in the top right corner.
* From there, you must type in `Bearer` followed by your `Token`.
* After you have inputted the necessary `Bearer Token`, click Authorize.
* Once successfully authorized, you will be able to utilize the Swagger docs to interact with the API.

### Desintations

Get information about different global destinations.

#### HTTP Request Structure
```
GET http://localhost:5000/api/Destinations/
GET http://localhost:5000/api/Destinations/{id}
POST http://localhost:5000/api/Destinations/
PUT http://localhost:5000/api/Destinations/{id}
DELETE http://localhost:5000/api/Destinations/{id}
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
https://localhost:5000/api/Destinations/1
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