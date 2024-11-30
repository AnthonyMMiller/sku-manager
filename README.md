# sku-manager

A C# Blazor Server application for managing SKUs (Stock Keeping Units) with a Microsoft SQL Server backend. This tool allows users to add, view, update, deactivate, and reactivate SKUs through a web interface.

## Table of Contents
* Features
* Prerequisites
* Getting Started
* Installation
* Database Setup
* Running the Application
* Usage
* Add a New SKU
* View Active SKUs
* Edit a SKU
* Deactivate a SKU
* View Deactivated SKUs
* Reactivate a SKU
* Project Structure
* Dependencies
* Contributing
* License
* Features
  
**Add New SKUs:** Input SKU details such as name, SKU number, price, CEUs, course ID, and package ID.<br>

**View Active SKUs:** Display a list of all active SKUs in a structured table.<br>

**Edit SKUs:** Modify existing SKU details.<br>

**Deactivate SKUs:** Remove SKUs from the active list without deleting them permanently.<br>

**View Deactivated SKUs:** Access a list of SKUs that have been deactivated.<br>

**Reactivate SKUs:** Restore deactivated SKUs back to the active list.<br>

## Prerequisites
Before you begin, ensure you have the following installed:
* Visual Studio 2019/2022 with the ASP.NET and web development workload.
* .NET 6 SDK or later.
* Microsoft SQL Server (LocalDB or a full SQL Server instance).
* Entity Framework Core (included with the NuGet packages).
  
## Getting Started
**Installation**
* Clone the Repository: git clone https://github.com/AnthonyMMIller/sku-manager.git
* Open the Solution
* Navigate to the cloned repository.
* Open SkuManagementTool.sln with Visual Studio.
* Restore NuGet Packages

Visual Studio should automatically restore the required NuGet packages upon opening the solution.
If not, right-click on the solution and select Restore NuGet Packages.

**Database Setup** <br>
* Configure the Connection String<br>
* Open appsettings.json.<br>
* Update the DefaultConnection string with your SQL Server instance details.<br>

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=SkuManagementDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}

Replace YOUR_SERVER_NAME with your actual server name.

**Apply Migrations**

Open the Package Manager Console in Visual Studio.<br>

Run the following commands:
* Add-Migration InitialCreate<br>
* Update-Database<br>
* This will create the database and apply the initial schema.<br>

## Running the Application
Press F5 or click Start Debugging in Visual Studio.
The application should launch in your default web browser.
Navigate to https://localhost:[port]/ (the port number is assigned by Visual Studio).

## Usage
**Add a New SKU**<br>
* Navigate to the Add SKU Page
* Click on Add SKU in the navigation menu.
* Fill Out the Form
  
*Example*:
Name: Enter the SKU name (e.g., "Example Course").<br>
SKU Number: Enter the SKU number (e.g., "EPT601503").<br>
Price: Enter the price (e.g., "699").<br>
CEUs: Enter the CEUs (e.g., "1.9").<br>
Course ID: Enter the course ID (e.g., "10706").<br>
Package ID: Enter the package ID (e.g., "1068").<br>
Submit the Form<br>
You will be redirected to the Active SKUs page.<br>
  
**View Active SKUs**<br>
Click on Active SKUs in the navigation menu.<br>
A table displays all active SKUs with details.<br>
  
**Edit a SKU**<br>
* Locate the SKU In the Active SKUs page, find the SKU you wish to edit.<br>
* Click the Edit button next to the SKU.<br>
* Modify the Details<br>
* Save Changes<br>
* Changes will be saved, and you'll return to the Active SKUs page.
  
**Deactivate a SKU**<br>
* Click the Deactivate button next to the SKU in the Active SKUs page.<br>
* The SKU will move to the Deactivated SKUs list.<br>
  
**View Deactivated SKUs**<br>
* Click on Deactivated SKUs in the navigation menu.<br>
* A table displays all deactivated SKUs.<br>
  
**Reactivate a SKU**<br>
* In the Deactivated SKUs page, click the Reactivate button next to the SKU.<br>
* The SKU will move back to the Active SKUs list.<br>

## Project Structure<br>
SkuManagementTool/<br>
├── Data/<br>
│   └── ApplicationDbContext.cs<br>
├── Models/<br>
│   └── Sku.cs<br>
├── Pages/<br>
│   ├── AddSku.razor<br>
│   ├── ActiveSkus.razor<br>
│   ├── DeactivatedSkus.razor<br>
│   ├── EditSku.razor<br>
│   └── _Host.cshtml<br>
├── Services/<br>
│   └── SkuService.cs<br>
├── Shared/<br>
│   ├── MainLayout.razor<br>
│   ├── NavMenu.razor<br>
│   └── _Layout.cshtml<br>
├── wwwroot/<br>
│   ├── css/<br>
│   │   └── site.css<br>
│   └── index.html<br>
├── App.razor<br>
├── Program.cs<br>
└── appsettings.json<br>

## Dependencies
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.AspNetCore.Components

## License
None
