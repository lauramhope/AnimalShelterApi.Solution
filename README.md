# Animal Shelter API

#### _API that lists all available cats and dogs at a local animal shelter_

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
6. Make sure you are still in the production folder (AnimalShelterApi.Solution/AnimalShelterApi) and run ```dotnet watch run``` - this will run the API and open up Swagger UI in your browser.

## _Testing This API_

1. Navigate to **Swagger UI** to test API calls using [this link](https://localhost:5001/swagger/index.html)
 * To make a GET request, click on the "GET/api/animals" route and click "try it out"
 * You can leave the default values in the query parameters or fill each of the fields out
 * Click the "execute" button to see results - status code 200 is success
 * Optionally, you can try out the different endpoints under the section **Using This API** within the README.

2. Another way to test API calls is by using **Postman**
  * Make sure the application is running via ```dotnet watch run```
  * Enter the URL into the search bar: https://localhost:5001/api/animals
  * To make a GET request on all animals, select GET in the dropdown box to the left of the search bar and select "send" - all entries will pop up in the body listed below
  * To make a GET request on a specific animal, enter the id, name, species, breed, or age in the URL link:
      * Id = https://localhost:5001/api/Animals/[ENTER ID HERE]
      * Name = https://localhost:5001/api/Animals?name=[ENTER NAME HERE]
      * Species = https://localhost:5001/api/Animals?species=[ENTER SPECIES HERE]
      * Breed = https://localhost:5001/api/Animals?breed=[ENTER BREED HERE]
      * Age = https://localhost:5001/api/Animals?age=[ENTER AGE HERE]
  * To make a POST request for a new animal, enter the URL https://localhost:5001/api/Animals and select POST from the dropdown box to the left
      * Click on "body" under the search bar and enter a name, species, breed, and age for the new entry (ID will automatically be generated)
      * Select "send" and see your new animal pop up in the body section at the bottom of the page with a new unique animal ID
  * To make a PUT request to update existing information on an animal entry, enter the URL https://localhost:5001/api/Animals/[ENTER ID HERE] with the ID of the animal
      * Select GET from the dropdown and click "send"
      * Select "body" in the section directly below the search bar, then select "raw" and change the text to "JSON" 
      * Change the name, species, breed, and/or age of the animal within the body section
      * Select PUT in the dropdown box to the left of the search bar, and then click "send"
      * Re-select GET and click "send" again, you will now see your changes
  * To make a DELETE request to delete an existing animal entry, enter the URL https://localhost:5001/api/Animals/[ENTER ID HERE] with the ID of the animal you are wanting to delete
    * Select DELETE from the dropdown box to the left of the search bar and click "send"
    * Entry should now be deleted

## _Running this API with the Client_
* Follow the instructions in the README.md of [AnimalShelterClient.Solution](https://github.com/lauramhope/AnimalShelterClient.Solution) to set up and run the Animal Shelter Client.

## _Using This API_
* Endpoints for this API are as follows:
```
GET https://localhost:5001/api/animals/
GET https://localhost:5001/api/animals/{id}
POST https://localhost:5001/api/animals/
PUT https://localhost:5001/api/animals/{id}
DELETE https://localhost:5001/api/animals/{id}

```

* Query Parameters for a GET Request on **Animals**: 

| Parameter  | Type   | Required     | Description                                      | Sample Url  |
|----------- |-----   | ---------    | -------------                                    | ----------  |
| Animals | List | not required | Returns a list of all animals in database | https://localhost:5001/api/animals |
| Name       | String | not required | Returns animals with a matching name value     | https://localhost:5001/api/animals?name={ANIMALNAME} |
| Species   | String | not required | Returns animals with a matching species value | https://localhost:5001/api/animals?species={SPECIES} |
| Breed    | String | not required | Returns animals with a matching breed value  | https://localhost:5001/api/animals?breed={BREED} |
| Age | Int    | not required | Returns animals with a matching age value | https://localhost:5001/api/animals?age={NUMBER} |
| Page Number + Page Size | int, int | not required | Returns animals with selected page number & page size | https://localhost:5001/api/animals?pageNumber={PAGENUMBER}&pageSize={PAGESIZE} |

## _Further Exploration_

* Pagination: the process of separating content into discrete pages
* _This application has pagination implemented into the AnimalsController.cs file. The user can enter the number of objects seen per page as well as what page number to navigate to when calling on the API. The API responds via entering those integers (page size, page number) into the localhost:5001 URL to take user to the pagination endpoint._

## _Known Bugs_

* No known bugs as of 6/15/23

## _Copyright/License_

## [MIT](https://opensource.org/license/mit/) 

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright © 2023 Laura Hope

_Please reach out to me for any questions, comments, or concerns: lauramhope.dpt@gmail.com_