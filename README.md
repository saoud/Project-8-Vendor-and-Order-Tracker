### Epicodus Independent Code Review - Basic Web Applications

### By Saoud Rana
## Description
MVC application to track vendors that order baked goods from a bakery.

## Specifications
|                                                          Behavior                                                         | Input                             | Output                                                                                                       | Met? (Y/N) |
|--------------------------------------------------------------------------------------------------------------------------|-----------------------------------|--------------------------------------------------------------------------------------------------------------|------------|
| Program should create an Order object with properties for title, description, price, and date                             | croissants, weekly, 35, 5/10/2021 | Order newOrder = new Order() {OrderTitle = "croissants", Description = "weekly", Price=35, Date="5/10/2021"} | Y          |
| Program should create a Vendor object with properties for name, description, and a list of order belonging to the vendor  | Suzie's Cafe, small cafe          | Vendor newVendor = new Vendor() {VendorName = "Suzie's Cafe", Description = "small cafe"}                    | Y          |
| Program should add an order object to a Vendor object                                                                     | add newOrder to newVendor         | Suzie's Cafe {OrderTitle = "croissants"}                                                                     | Y          |

## Known Bugs
* No known bugs.   

## Setup/Installation Requirements

#### View locally

*[.NET Core](https://dotnet.microsoft.com/download/dotnet/5.0) is needed to run this application*

To clone this repository from your command line you will need [Git](https://git-scm.com/) installed. 

First navigate in the command line to where you want to clone this repository. 

Then from your command line run:

`$ git clone https://github.com/saoud/Project-8-Vendor-and-Order-Tracker.git`

Once the repository has been cloned, navigate to the to the application directory and run `$ dotnet build`.

#### Run locally
* To run the program run `$ dotnet run` 

### Edit
* To view and edit the code, open the application in your preferred code editor, such as Visual Studio Code.

## Technologies Used
```
* Visual Studio Code
* C#
* .NET Core 5.0.100
* MSTest
* MVC
* RESTful Routing
* Git
```

## License
* [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/saoud/csharp-TDD-template/blob/main/LICENSE)
* Copyright 2021 Saoud Rana
## Contact
[Saoud Rana](mailto:githubissues@saoud.dev)
