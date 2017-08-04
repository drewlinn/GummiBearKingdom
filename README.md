# Gummi Bear Kingdom

#### Gummi Bear Kingdom, A Web Application for a Candy Store called Gummi Bear Kingdom. 08/04/2017

#### By Andrew Dalton

## Description

	This Web Application is designed for the user to see information about a Candy Store called Gummi Bear Kingdom. They can View a list of their products, view information about an individual product, add a new products, update an existing product, or delete an existing product.

## Planning

1. Configuration/dependencies
  * This should include ALL dependencies.

  * Install the following packages:

    * Backend Packages
      * The following were implemented for use in our Development Environment
		Microsoft.NETCore.App
		Microsoft.AspNetCore.Diagnostics Version 1.0.0,
		Microsoft.AspNetCore.Server.IISIntegration Version 1.0.0,
		Microsoft.AspNetCore.Server.Kestrel Version 1.0.1,
		Microsoft.Extensions.Logging.Console Version 1.0.0,
		Microsoft.AspNetCore.Mvc Version 1.0.0,
		Microsoft.EntityFrameworkCore Version 1.0.0,
		Microsoft.EntityFrameworkCore.SqlServer Version 1.0.0,
		Microsoft.Extensions.Configuration.FileExtensions Version 1.0.0,
		Microsoft.Extensions.Configuration.Json Version 1.0.0

    * Frontend Packages
      * The following were implemented in our Production Environment
        * bootstrap - provides us with some rudimentary page styling tools.


  2. Specifications

  | Behavior | Input | Output |
  | :--------| :---- | :------|
  | User can view information about Gummi Bear Kingdom | application Start | "Welcome to our Kingdom..." |
  | User can View a list of all the Products available | click "View Products" | "Gummi Bears, Chocolate, Candy Bars |
  | User can View the information of an individual Product | click "Gummi Bears" | "Gummi Bears", "$3.99/lb.", "Brazil" |
  | User can Add a Product | click "Add Product", enter product info | "Gummi Bears", "$3.99/lb.", "Brazil" |
  | User can Update a Product | click "Update Product", enter new product info | "Gummi Bears", "$2.99/lb.", "Honduras" |
  | User can Delete a Product | click "Delete Product" | This product has been deleted. |

3. Integration
  * index.cshtml
  * List.cshtml
  * Details.cshtml
  * Add.cshtml
  * Edit.cshtml
  * Delete.cshtml
  
## Setup/Installation Requirements

* Open your console or powershell command line.
* In your command line, navigate to the desktop or your desired folder destination.
* Copy the project's github address (https://github.com/drewlinn/GummiBearKingdom.git)
* Write in your console the command "git clone" and paste the project address afterward and press enter.
* Use your console to navigate to the project directory.
* Open the project using Visual Studio.
* Press the button in the tool bar with the green PLAY SYMBOL that says "IIS EXPRESS" next to it.
* Your default web browser should be open and navigate to the necessary localhost automatically.
* The application should successfully be displayed with full functionality.


## Known Bugs

There are no known bugs at this time.

## Support and contact details

If you notice any bugs in my program or any other issues with my code, please email me at expandrew@gmail.com

## Technologies Used

HTML
CSS
C#
Visual Studio 2015

### License

This software is licensed under the MIT license.

Copyright (c) 2016 **_{Andrew Dalton, Epicodus}_**