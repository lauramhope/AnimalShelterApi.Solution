# Animal Shelter API

#### _API that lists all available cats and dogs at the local animal shelter_

### By **Laura Hope**

## _Description_

_This application showcases creating an API and implementing CRUD functionality within the project. The API allows users to GET, POST, PUT, and DELETE animals from the animal shelter. Application will return responses for each API call to custom endpoints and can be viewed in localhost:5001 within the browser or an API platform such as Postman._

## _Technologies Used_

* _C#_
* _.NET_
* _ASP.NET Core_
* _MVC_
* _Entity Framework Core_
* _Pomelo Entity Framework Core_
* _EF Core Migrations_
* _Swashbuckle_
* _Swagger_
* _MySQL_

## _Setup/Installation Instructions_

1. Clone "AnimalShelterApi.Solution" from the repository to your desktop.
2. Open your terminal (e.g. Terminal or GitBash) and navigate to this project's directory called "AnimalShelterApi".
3. Set up the project:
  * Create two files in the AnimalShelterApi.Solution/AnimalShelterApi directory: 
  **'.gitignore'**
  **'appsettings.json'**
  * Add the following code to the appsettings.json file:
  ```
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=[USER_ID];pwd=[USER-PW];"
    }
  }
  ```
  * _Remove the square brackets and replace **USER-ID** and **USER-PW** with your own ID and password_
4. Set up the database:
  * Make sure EF Core Migrations is installed on your computer by running ```dotnet tool install --global dotnet-ef --version 6.0.0```
  * In the production folder of the project (AnimalShelterApi.Solution/AnimalShelterApi) run:
  ```
  dotnet ef database update
  ```
  * You should see the new schema in your _Navigator > Schemas_ tab of your MySql Workbench on refresh called ```animal_shelter_api```
5. Add the EF Core packages by typing the following into the command line:
```
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
$ dotnet tool install --global dotnet-ef --version 6.0.0
$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```

## Using This API
* Endpoints for this API are as follows:
```
GET https://localhost:5001/api/animals/
GET https://localhost:5001/api/animals/{id}
POST https://localhost:5001/api/animals/
PUT https://localhost:5001/api/animals/{id}
DELETE https://localhost:5001/api/animals/{id}

```
* In your terminal run ```dotnet watch run``` in the project directory.
* In your browser open https://localhost:5001/swagger/index.html
* Use the GUI to navigate the API

* Query Parameters for a GET Request on **Animals**: 

| Parameter  | Type   | Required     | Description                                      | Sample Url  |
|----------- |-----   | ---------    | -------------                                    | ----------  |
| Animals | List | not required | Returns a list of all animals in database | https://localhost:5001/api/animals |
| Name       | String | not required | Returns animals with a matching name value     | https://localhost:5001/api/animals?name={ANIMALNAME} |
| Species   | String | not required | Returns animals with a matching species value | https://localhost:5001/api/animals?species={SPECIES} |
| Breed    | String | not required | Returns animals with a matching breed value  | https://localhost:5001/api/animals?breed={BREED} |
| Age | Int    | not required | Returns animals with a matching age value | https://localhost:5001/api/animals?age={NUMBER} |

## Known Bugs

No known bugs as of 6/9/23

## [MIT](https://opensource.org/license/mit/) License 

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright © 2023 Laura Hope