# GateFlowDashboardAPI

## Description
This repository is a .Net 6 Web API that exposes two endpoints. [Get] GetGateFlowSummary and [POST] GenerateRecordForSimulation. These endpoints interacts with database using Entity Framework.This particular projects uses InMemoryDataBase and hence there is no need to connect to any database for operations.

## DataGeneration
### SeedDataGeneration on bootup
As mentioned earlier, we are using InMemoryDatabase and hence needed some seed data. On application start there is a logic in place in [Program.cs](https://github.com/aksrxl/GateFlowDashboardAPI/blob/main/Api/Program.cs) that generates seedData. SeedData is available in [SeedGenerator.cs](https://github.com/aksrxl/GateFlowDashboardAPI/blob/main/Api/EFCore/SeedGenerator.cs) file
### Endpoint for simulating more Data
Apart from relying on SeedData generated on application startup. The application also exposes endpoint <u>/GenerateRecordForSimulation/gate/type/{dateTime}</u> for simulating more test data.

## High Level Application Features
* .Net 6 Web API
* Entity Framework with in memory database
* Logging (Console for now)
* [Global Exception Filters](https://github.com/aksrxl/GateFlowDashboardAPI/tree/main/Api/Utilities/ExceptionHandling)
* Error Handling
* [Unit Tests](https://github.com/aksrxl/GateFlowDashboardAPI/tree/main/Test/UnitTests)
* [Integration Tests](https://github.com/aksrxl/GateFlowDashboardAPI/tree/main/Test/IntegrationTests)
* [Extension Methods](https://github.com/aksrxl/GateFlowDashboardAPI/blob/main/Api/Utilities/Extensions/Extension.cs)
* [Seed data on bootup](https://github.com/aksrxl/GateFlowDashboardAPI/blob/main/Api/EFCore/SeedGenerator.cs)
* Additional Endpoint for simulating data

## Debugging Instructions
* Install [dotnet 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* Clone Repo
```
git clone https://github.com/aksrxl/GateFlowDashboardAPI.git
```
### Visual Studio
* Set GateFlowDashboardAPI as startup project.
* Run the application.
* Swagger is available at application home page , depending on ide, it can be tricky based on your launchsetting.json so reach out to url https://localhost:7101/index.html (replace port accordingly).
* Refer [Invoking endpoints](#invoking-endpoints) section below for more details.

### Commandline
* Open command prompt and change directory to <u>..GateFlowDashboardAPI\Api</u>
* runn the following command 
```
  dotnet run
```
* Open browser and hit the swagger page url https://localhost:7101/index.html (replace the port where your application is hosted, see  appearing  console logs to find that out in the console window.)
* Refer [Invoking endpoints](#invoking-endpoints) section below for more details.

### Invoking endpoints
* Invoke <u>/GetGateFlowSummary</u> endpoint to get response for seeded data. Insuttructions for invoking endpoints are also explained on swagger page.
    * FilterParam - expects a key value pair. 
        * key is mapped to the database columns , possible values are 'Gate', 'Type' and CreatedDate.
        * Values are comma seperated string , is basically equivalent to sql in clause for Gate and Type and between inclusive clause for CreatedDate
    * Sample filter param : <u>{"Gate":["Gate A","Gate B","Gate C"],"Type":["Leave","Enter"],"CreatedDate":["yyyy-mm-dd","yyyy-mm-dd"]}</u> - Generates record where Gate is Gate A or Gate B or Gate C and Type is Enter or Leave and CreateDate is between given dates.
* Invoke <u>/GenerateRecordForSimulation</u> for generating more data. The input data are self explainatory with some validation in place for input data.

## [Test](https://github.com/aksrxl/GateFlowDashboardAPI/tree/main/Test)
The project has both [Unit](https://github.com/aksrxl/GateFlowDashboardAPI/tree/main/Test/UnitTests) and [Integration tests](https://github.com/aksrxl/GateFlowDashboardAPI/tree/main/Test/IntegrationTests) in place, with basic methods tested in consideration of time.

### Running tests
* Open command prompt and change directory to solution folder <u>..GateFlowDashboardAPI</u>
* Run the following command
```
dotnet test
```



