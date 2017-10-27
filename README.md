# MVC-Salon

#### This is for code Project#3 for C Sharp Course

#### By **Alan Falcon**

## Description

This website is our third project for C# course. This site emulates one for a hair salon.

## Setup/Installation Requirements

* You may view this project at: https://falconswoosh.github.io/Wk3C--IP-MVC-Salon
Wk2-C--IP-WordCounter
* This project may be cloned from:  https://github.com/falconswoosh/Wk3C--IP-MVC-Salon.git
* Install .NET SDK, .NET Runtime, and Mono (refer to links in 'Technologies Used' section below).
* Clone to your local system
* Open the project folder "Wk3-C--IP-Salon"
* Depending if you are on Windows or MAC, go to your CMD, Command line interface, Terminal, PowerShell, or Bash. Enter the following to both setup this project with the additional necessary packages, configuration needed, and run a virtual server on your local system:
  * (Locate and traverse into the main source folder): cd WordCounter
  * dotnet restore
  * dotnet build
  * dotnet run
* Open a browser and navigate to http://localhost:5000 to interact with this project as a user.
* If you choose, you may use your editor-of-choice to edit and modify this project.
    * For example, if your editor is [Atom](https://flight-manual.atom.io/getting-started/sections/installing-atom/), issue the following in your bash:
    $ Atom index.html

## Specifications    
| [X] |Item |Focus | Behavior | Input | Output | Reason for selecting sample Input/Output |
|--|---|---|---|---|---|---|
* [ ]|*`Stylist`*|Be able to add a stylist. |  Susan | Susan | Selected a first name for simplicity in creating first revision.
* [ ]| *`Client`*| Be able to add a client. | Margaret | Margaret| Selected a first name for  simplicity in creating first revision.|
|\[ ]| *`Stylist`*| Be able to see list of stylsts. |Click `here` to view all Stylists | **Active Stylists:** <br /> Susan<br />Mary<br />Henry | Chose simple list of first names to create first revision of app for look-and-feel.|
| *`Client`*| Be able to see list of clients. |Click `here` to view all Clients | **Clients:** <br /> Margaret<br />James<br />Lisa | Chose simple list of first names to create first revision of app for look-and-feel.|
| *`Stylist`*| Be able to enter details of a stylist. |Name: Susan<br />Work Days: M-F<br />Hours: 12pm-8pm | Name: Susan<br />Work Days: M-F<br />Hours: 12pm-8pm  | Chose minimal list to create first revision of app for look-and-feel.|
| *`Client`*| Be able to enter details of a client. |Name: Margaret<br />Last cut: date<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little bit of bangs | Name: Margaret<br />Last cut: date<br />Cut Style: Bob <br />Length: Short<br />Comments: Likes to have a little 3-inch bangs  | Chose minimal list to create first revision of app for look-and-feel.|

## Known Bugs

* If running in Windows 10 and within Git Bash, the "dotnet build" and "dotnet run" commands may sometimes fail indicating certain files are already running or unable to bind...
* Solution is to run CMD as admin and do a netstat -ano | findstr 5000 and to taskkill the PID associated with port 5000. You need to reissue the netstat command until port 5000 no longer displays in the results prior to reissuing dotnet commands in Bash.

## Support and contact details

Alan Falcon email: [falconswoosh@gmail.com](falconswoosh@gmail.com)

## Technologies Used

| Technology | Windows | MAC |
|---|---|---|
| .NET Core 1.1 SDK (Software Development Kit) |  https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-win-x64.1.1.4.exe | https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-osx-x64.1.1.4.pkg |
| .NET Runtime | https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-win-x64.1.1.4.exe | https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-osx-x64.1.1.4.pkg |
| Atom | http://flight-manual.atom.io/getting-started/sections/why-atom/ | https://github.com/atom/atom/releases/download/v1.21.1/atom-mac.zip |
| CSS <td colspan=2>https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwjswubPlLnWAhVGVRQKHaRLBkgQFggmMAA&url=https%3A%2F%2Fgetbootstrap.com%2Fcss%2F&usg=AFQjCNFpcAPIPLCu0F7w2NDTOafHdV8Pkw |
| CSS: Materialize <td colspan=2> http://materializecss.com/forms.html |
| Git | https://git-for-windows.github.io/ | [Paste the following into Bash]:<br />$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"<br />$ echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile<br />$ brew install git |
| GitHub:<td colspan=2> https://github.com/ |
| HTML:<td colspan=2> http://htmlreference.io |
| Javascript:<td colspan=2> https://www.javascript.com/ |
| Javascript Jquery<td colspan=2> https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwiBj_WJlbnWAhWBLhQKHfHUAQEQFggmMAA&url=https%3A%2F%2Fjquery.com%2F&usg=AFQjCNFnz7C6MAXGLm7pVcOD_LrOjJUUiA |
| Markdown<td colspan=2> https://en.wikipedia.org/wiki/Markdown |
| Mono |http://www.mono-project.com/download/#download-win | http://www.mono-project.com/download/#download-mac |


### License
* All rights reserved for technologies utilized.

Copyright (c) 2016 **_{MIT}_**
