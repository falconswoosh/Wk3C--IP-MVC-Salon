# MVC-Salon

#### This is for code Project#3 for C Sharp Course

#### By **Alan Falcon**

## Description

This website is our third project for C# course. This site emulates one for a hair salon.

## Setup/Installation Requirements

* You may view this project at: https://falconswoosh.github.io/Wk3C--IP-MVC-Salon
* This project may be cloned from:  https://github.com/falconswoosh/Wk3C--IP-MVC-Salon.git
* Install .NET SDK, .NET Runtime, Git, MAMP, and Mono (refer to links in 'Technologies Used' section below).
* Clone to your local system
* Open the project folder "Wk3-C--IP-Salon"
* Depending if you are on Windows or MAC, go to your CMD, Command line interface, Terminal, PowerShell, or Bash. Enter the following to both setup this project with the additional necessary packages, configuration needed, and run a virtual server on your local system:
  * (Locate and traverse into the main source folder): cd Salon.Solution.
  * To interact with the UI Model enter the following into Bash:
    * cd Salon
    * dotnet restore
    * dotnet build
    * dotnet run
    * (When done, CTRL-C to stop the server as well as open MAMP and click on "Stop Servers".)  
  * To interact with the Test Model enter the following into Bash:
    * cd Salon.Tests
    * dotnet restore
    * dotnet build
    * dotnet run
    * (When done, CTRL-C to stop the server as well as open MAMP and click on "Stop Servers".)      
* Open a browser and navigate to http://localhost:5000 to interact with this project as a user.
* If you choose, you may use your editor-of-choice to edit and modify this project.
    * For example, if your editor is [Atom](https://flight-manual.atom.io/getting-started/sections/installing-atom/), issue the following in your bash:
    $ Atom index.html

## Specifications    
| Implemented [X] |Item |Focus | Behavior | Input | Output | Comments |
|:--:|:---:|---|---|---|---|---|
|[&nbsp;&nbsp;]|1|*`Stylist`*|Be able to add a stylist. |  Susan | Susan | Selected a first name for simplicity in creating first revision.
|[&nbsp;&nbsp;]|2| *`Client`*| **Not** be able to add a client if no stylsts have been added to the system or if a stylist has not been selected. |Click `Client Name` to view all Stylists | **Active Stylists:** <br /> Susan<br />Mary<br />Henry | Chose simple list of first names to create first revision of app for look-and-feel.|
|[&nbsp;&nbsp;]|3| *`Client`*| Be able to add a client to a specific stylist. | **Select Stylist:**<br />Susan<br />Jason<br /><br/>`If Susan AND 'Add a Client' were clicked:`<br/>Stylist: Susan<br/>• View Stylist Details<br/>• View Stylist's Clients<br/>• `Add a Client`| ** NEW Client ** <br/>Stylist: Susan<br/>`Client Name: `<br/>.<br/>.<br/>.| Selected a first name for  simplicity in creating first revision.|
|[&nbsp;&nbsp;]|4| *`Stylist`*| Be able to see list of stylists. |Click `here` to view all Stylists | **Active Stylists:** <br /> Susan<br />Mary<br />Henry | Chose simple list of first names to create first revision of app for look-and-feel.|
|[&nbsp;&nbsp;]|5| *`Client`*| Be able to see list of clients. |Click `here` to view all Clients | **Clients:** <br /> Margaret<br />James<br />Lisa | Chose simple list of first names to create first revision of app for look-and-feel.|
|[&nbsp;&nbsp;]|6| *`Stylist`*| Be able to see list of clients that are associated with a stylist. |Click `here` to view all Stylists <br/> <br/>**Select Stylist:**<br />Susan<br />Jason<br /><br/>Stylist: Susan<br/>• View Stylist Details<br/>• `View Stylist's Clients`<br/>• Add a Client | **Clients:** <br /> Margaret<br />James<br />Lisa |If 'Susan' and 'View Stylist's Clients' were clicked.|
|[&nbsp;&nbsp;]|7| *`Stylist`*| Be able to enter details of a stylist. |Name: Susan<br />Work Days: Mon-Fri<br />Hours: 12pm-8pm | Name: Susan<br />Work Days: Mon-Fri<br />Hours: 12pm-8pm  | Chose minimal list to create first revision of app for look-and-feel.|
|[&nbsp;&nbsp;]|8| *`Client`*| Be able to enter details of a client. |Name: Margaret<br />Last cut: 2017-10-19<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little bit of bangs | Name: Margaret<br />Last cut: 2017-10-19<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little 3-inch bangs  | Chose minimal list to create first revision of app for look-and-feel. Date format is YYYY-MM-DD.|
|[&nbsp;&nbsp;]|9| *`Client`*| Be able to update details of a client. |*`FROM`*<br />Name: Margaret<br />Last cut: 2017-10-19<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little bit of bangs <br /><br/>*`To`*<br />Name: Margaret<br />Last cut: `2017-12-15`<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little bit of bangs| Name: Margaret<br />Last cut: `2017-12-15`<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little bit of bangs  | If modifying Last Cut date.|
|[&nbsp;&nbsp;]|10| *`Stylist`*| Be able to update details of a stylist. |*`FROM`*<br />Name: Susan<br />Work Days: `Mon-Fri`<br />Hours: 12pm-8pm <br /><br/>*`To`*<br />Name: Susan<br />Work Days: `Mon-Thu`<br />Hours: 12pm-8pm |Name: Susan<br />Work Days: `Mon-Thu`<br />Hours: 12pm-8pm | If Work Days is modified.|
|[&nbsp;&nbsp;]|11| *`Client`*| Be able to delete a client. |Name: Margaret<br />Last cut: 2017-10-19<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little bit of bangs<br/><br/>`<Delete This Client>`| (client record deleted from database) | When "Delete This Client" is clicked. |
|[&nbsp;&nbsp;]|12| *`Client`*| Be able to select a client and within the client view, have a field identifying which stylist they are associated with. |**Click on a client to View** Margaret<br/>Matthew| Name: Margaret<br />`Stylist: Susan`<br />Last cut: 2017-10-19<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little bit of bangs|If "Margaret" was clicked|

## Known Bugs

* If running in Windows 10 and within Git Bash, the "dotnet build" and "dotnet run" commands may sometimes fail indicating certain files are already running or unable to bind...
* Solution is to run CMD as admin and do a netstat -ano | findstr 5000 and to taskkill the PID associated with port 5000. You need to reissue the netstat command until port 5000 no longer displays in the results prior to reissuing dotnet commands in Bash.

## Support and contact details

Alan Falcon email: [falconswoosh@gmail.com](falconswoosh@gmail.com)

## Technologies Used

| Technology | Windows | MAC |
|---|---|---|
| C# .NET Core 1.1 SDK (Software Development Kit) |  https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-win-x64.1.1.4.exe | https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-osx-x64.1.1.4.pkg |
| .NET Runtime | https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-win-x64.1.1.4.exe | https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-osx-x64.1.1.4.pkg |
| Atom | http://flight-manual.atom.io/getting-started/sections/why-atom/ | https://github.com/atom/atom/releases/download/v1.21.1/atom-mac.zip |
| CSS <td colspan=2>https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwjswubPlLnWAhVGVRQKHaRLBkgQFggmMAA&url=https%3A%2F%2Fgetbootstrap.com%2Fcss%2F&usg=AFQjCNFpcAPIPLCu0F7w2NDTOafHdV8Pkw |
| CSS: Materialize <td colspan=2> http://materializecss.com/forms.html |
| Git | https://git-for-windows.github.io/ | [Paste the following into Bash]:<br />$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"<br />$ echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile<br />$ brew install git |
| GitHub:<td colspan=2> https://github.com/ |
| HTML:<td colspan=2> http://htmlreference.io |
| Javascript:<td colspan=2> https://www.javascript.com/ |
| Javascript Jquery<td colspan=2> https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwiBj_WJlbnWAhWBLhQKHfHUAQEQFggmMAA&url=https%3A%2F%2Fjquery.com%2F&usg=AFQjCNFnz7C6MAXGLm7pVcOD_LrOjJUUiA |
| MAMP (contains among other things Apache server, MySQL, and phpMyAdmin)<td colspan=2> https://en.wikipedia.org/wiki/Markdown<br>• Select either Windows or MAC<br/>• Once installed, click on 'Preferences' &#124; click on "Set Web & MySQL ports to 80 & 3306".<br/>&nbsp;&nbsp;**WARNING:**&nbsp; Otherwise you may choose to identify certain ports yourself based on your system configuration. If doing this however, every line in the code referring to port `3306` will need to be modified with the port for mySQL. |
| Markdown<td colspan=2> https://www.mamp.info/en/downloads/|
| Mono |http://www.mono-project.com/download/#download-win | http://www.mono-project.com/download/#download-mac |


### License
* All rights reserved for technologies utilized.

Copyright (c) 2016 **_{MIT}_**
