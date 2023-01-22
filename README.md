# capstone_backend
General Assembly capstone project in C#, .NET

tutorials i used
from Microsoft to build ASP.NET MongoDB API
https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-7.0&tabs=visual-studio-code

VS Code Docker Tutorial
https://code.visualstudio.com/docs/containers/quickstart-aspnet-core

Docker to Heroku Tutorial
https://medium.com/bina-nusantara-it-division/how-to-deploy-your-asp-net-core-web-api-on-heroku-using-docker-a21409881d76#:~:text=Currently%2C%20Heroku%20supports%20languages%20Ruby,in%20order%20to%20deploy%20our%20.
made precite bookstore api w/ docker thru vscode docker tutorial... but crashed on heroku
failed ... something missing in dockerfile

tried this buildpack
https://github.com/jincod/dotnetcore-buildpack
doesn't work w/ cors??
giving up on deploying to heroku for the moment... may try deploying to azure later on

## Tech Used
- ASP.NET Core
- MongoDB

## Installation Instructions
- clone capstone_backend repo onto your local machine -cd into ArtStoreApi
    - dotnet build
    - dotnet run
    - If you'd like to view it on your local machine, navigate to http://localhost:5245/api/art

- clone capstone_frontend repo onto your local machine
    - cd into art-store
    - $ npm i
    - If you'd like to view it on your local machine, navigate to http://localhost:3000/art