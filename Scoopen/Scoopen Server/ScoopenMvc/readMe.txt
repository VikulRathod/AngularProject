There are 6 different project in ScoopenMvc Solution.

1 - ScoopenMvc
This is a startup project which contains all UI related logic and files
This project web.config file will contain all configurations like connection string,
app settings etc...

2 - ScoopenMvcBLL
This is middle layer between UI and DAL layer

3 - ScoopenMvcDAL
This is data access layer where direct database connection or service/api calls

4 - ScoopenMvcModels
This project will contains all model classes which can be commonly used by all layers

5 - ScoopenMvcLogs
This project will contain logic to handle all Mvc Application errors 
It will contain all logic to store information/ warning/ errors from Mvc project to 
database directly 

6 - ScoopenMvc.Tests
This project contains all unit testing code for all projects