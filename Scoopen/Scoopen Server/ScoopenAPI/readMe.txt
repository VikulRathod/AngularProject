There are 8 different project in ScoopenAPI Solution.

1 - ScoopenAPI
This is a startup project which contains all WEB API Methods related logic and files
This project web.config file will contain all configurations like connection string,
app settings etc...

2 - ScoopenAPI.BLL
This is middle layer between WEB API Methods and DAL layer

3 - ScoopenAPI.DAL
This is data access layer where direct database connection 

4 - ScoopenAPI.Models
This project will contains all model classes which can be commonly used by all layers

5 - ScoopenAPI.Logs
This project will contain logic to handle all API Application errors 
It will contain all logic to store information/ warning/ errors from Mvc project to 
database directly 

6 - ScoopenAPI.Tests
This project contains all unit testing code for all projects

7 - ScoopenAPI.ExternalServices
This project contains integration with all external third party services 
Any services which are not part of our application can be consumed from this project

8 - ScoopenAPI.Notifications
This project contains all logic and code which is used to send notifications 
Notifications can be email, sms or any other media which is required