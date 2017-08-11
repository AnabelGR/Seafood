﻿# Son of Cod Seafood
#### An Epicodus Friday independent project in .NET/Visual Studio 2015 with xUnit testing, 08.11.17

#### **By Anabel Ramirez**

## Description

An app to manage Son of Cod Seafood marketing.

|Behavior| Input (User Action/Selection) |Description|
|---|:---:|:---:|
|Visitors can view the marketing page.|marketing page link|view marketing page|
|Visitors can subscribe to a newsletter.|newsletter link|view form to subscribe|
|Admin can log in.|admin link|view admin log in|
|Once logged in, admin can view mailing list.|click mailing list link|view mailing list|

## Setup/Installation Requirements

#### Requirements

If you do not have Visual Studio 2015, download [HERE](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15).

If you do not have SSMS, download [HERE](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

Cloning From GitHub: Download or clone project repository onto desktop from GitHub using this [link](https://github.com/AnabelGR/Seafood.git).

Open the project in Visual Studio.

#### Migrations Setup

1. In Visual Studio, open the 'Solution Explorer' window.
2. Right-click the project root folder and choose 'Open in File Explorer' from the context menu.
3. Enter "cmd" in the address bar and press Enter.
4. Enter the following command in the command window:
```terminal
dotnet ef database update
```
5. Open seafood_scripts.sql in SSMS and execute (this will add sample data).
6. Back in Visual Studio, click 'IIS Express' at the top of the window. Project will open in a new localhost window on your default browser.

## Support and contact details

If you have any issues or have questions, ideas, concerns, or contributions please contact the contributor through Github.

## Technologies Used

**Languages:** HTML, SCSS, C#, ASP.NET, MUI

**IDE:** Visual Studio 2015

**Database Management:** MySQL (SSMS)

### License
This software is licensed under the MIT license.

Copyright (c) 2017 **Anabel Ramirez**