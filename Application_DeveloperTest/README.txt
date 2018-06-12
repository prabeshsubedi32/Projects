
Project Title:

Weather Forecast DCU - Application Developer Test

This console application project provides the 5 days weather forecast of cities according to the zip code. But since the cities zip code is 
already provided from the data repository it prints the average temperature for 5 days for 10 cities. It also indicates if it is raining 
or not. It makes a API call to OpenWeatherMap API and consumes the data and print in the console. 

Getting Started:

You can start by downloading the application folder. In order to run this code, you need to install visual studio. After the installation process you can 
directly open the project by double click on WeatherForecast.sln file inside the project folder. Also, you need to make sure that all the necessary assemblies
are installed or not. You can go to NuGet Package manager to install the necessary assemblies. You need to install System.Net.Http and Newtonsoft.Json inorder
to compile the project properly. 

Information about the Project:

For this Project I have created 8 different .cs files. All necessary .cs files to run this console application are:

1) WeatherDataProperties.cs
2) LocationData.cs
3) TemperatureDataCalculation.cs
4) AverageTemperatureCalculationProperties.cs
5) CityDataRepository.cs
6) APIClient.cs
7) UtilCalculation.cs
8) Program.cs

WeatherDataProperties.cs: This .cs file is in Model folder in the application. When you make the API call the response obtained is in Json format. 
So, the classes and properties in this file maps the Json data into a List which later is used to get the weather data to calculate the 
average temperature.

LocationData.cs: This .cs file is in Model folder in the application. This file provides the properties to create the data that is provided to make
the API call. It specifies the city name, state, and zip code to make the call to get the weather data according to the zip code. 

TemperatureDataCalculation.cs: This .cs file is in Model folder in the application. This file provides the properties to get the max temperature, 
min temperature, date and if it going to raining or not. 

AverageTemperatureCalculationProperties.cs: This .cs file is in Model folder in the application. This file provides the properties to get the average
temperature after calculation, get the date and check if it is raining or not. 

CityDataRepository.cs: This .cs file is in DataRepository folder in the application. It contains data for cities that we will use to make the API call and 
get the weather data for those cities.

APIClient.cs: This .cs file is in Services folder in the application. It contains all the code needed to make the API call and get the response from the API.
You specify the API link here which you want to a call. 

UtilCalculation.cs: This .cs file gets the max temperature, min temperature from the TemperatureDataCalculation.cs file and calculate the average temperature.

Program.cs : This .cs file contains the main method. This calls all the necessary .cs file to make this application running.  

Testing: 

In order to test the program, you can just hit the run button in Visual Studio. Since all the data necessary to make the API call is already provided. So, you don't
have to provide any input to the console application. 


