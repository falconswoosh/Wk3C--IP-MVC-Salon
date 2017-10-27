# MVC-Salon

#### This is for code Project#3 for C Sharp Course

#### By **Alan Falcon**

## Description

This website is our third project for C# course. This site emulates one for a hair salon.

## Setup/Installation Requirements

* You may view this project at: https://falconswoosh.github.io/Wk3-C--IP-Salon
Wk2-C--IP-WordCounter
* This project may be cloned from:  https://github.com/falconswoosh/Wk3-C--IP-Salon.git
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
| Behavior | Input | Output | Comments |
|---|---|---|---|
| Be able to input a (search) word. |  `Search WORD`: car | N/A | "car" as an input was chosen since it's short and its three letters may be contained in other words not an exact match to "car".
| Additionally, have another input for a sentence to be searched and allow both the search Word and Sentence to be submitted via a submit button. |`SENTENCE to be Searched`: As a  caring car owner, I maintain my car as well as respect other folks' property. At parking lots, I ensure I open my car door carefully so as  not to hit the other car with my car door.<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(button clicked) | N/A| The sample sentence input was used  due to two other words being used that  are not a full word match.|
| Lastly, having clicked on the submit button the site responds via a separate page the results of having searched for a word in a sentence provided the site. The response will be how many times the word appears in the sentence. *`ONLY`* full word matches are counted. |`Search WORD`: car<br />`SENTENCE to be Searched`: As a caring car owner, I maintain mycar as well as respect other folks' property. At parking lots, I ensure I open my car door carefully so as  not to hit the other car with my car door. | `car` occurs 5 times<br />`Search WORD`: car<br />`SENTENCE Searched`: As a caring caring **car** owner, I maintain my**car** as well as respect other folks' property. At parking lots, I ensure I open my **car** door carefully so as  not to hit the other **car** with my **car** door. | N/A |


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
