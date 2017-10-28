# MVC-Salon

#### This is for code Project#3 for C Sharp Course

#### By **Alan Falcon**

## Description

This website is our third project for C# course. This site is for a hair salon where hair stylists have clients assigned them and interaction with this site allow for managing both the clients assigned to a stylist as well as information that may be stored for the client.

## Setup/Installation Requirements

* You may view this project at: https://falconswoosh.github.io/Wk3C--IP-MVC-Salon
* This project may be cloned from:  https://github.com/falconswoosh/Wk3C--IP-MVC-Salon.git
* Install .NET SDK, .NET Runtime, Git, MAMP, and Mono (refer to links in **Technologies Used** section below).
* Clone this project to your local system
* Once MAMP is installed, the port configured, you have clicked on "Start Servers", and the servers show they are running, issue the following command (Windows or MAC) to start mySQL in your terminal based on your configuration:
  * <span style="color: #f2cf4a; font-family: Babas; font-size: 1em;" line-height: 0>NOTE:</span> Your installation directories may be slightly different. If so, adjust the MAMP command for your installation accordingly.
    * Depending if you are on Windows or MAC, go to your CMD, Command line interface, Terminal, PowerShell, or Bash. Issue (or copy/paste) the following to start MAMP. Then at the `mysql>` prompt, issue the subsequent commands for the database aspects for this project:
<table style="background-color: #000;" style="color:#0000ff;" border=2 cellspacing=2 cellpadding=2>
  <tr>
    <td bgcolor="#3B9FF;"><font color=#ffff00;" font-family: Babas; font-size: 4em;">Windows</font></td>
    <td bgcolor="#3B9FF;"><font color=#ffff00;" font-family: Babas; font-size: 4em;">MAC</font></td>
  </tr>
  <tr>
    <td>C:\MAMP\bin\mysql\bin -uroot -proot</td>
    <td>/Applications/MAMP/Library/bin/mysql --host=localhost -uroot -proot</td>
  </tr>  
  <tr>
    <td colspan="2">`mysql>` CREATE DATABASE alan_falcon;<br/>`mysql>` USE alan_falcon;<br/>`mysql>` CREATE TABLE stylists (sId serial PRIMARY KEY, sLastName VARCHAR(255), sFirstName VARCHAR(255));<br/>`mysql>` CREATE TABLE clients (cId serial PRIMARY KEY,cLastName VARCHAR(255), cFirstName VARCHAR(255));</td>            
  </tr>
</table>

<p><font style="color: #f2cf4a; font-family: Babas; font-size: 1em;">NOTE:</font> <font style="margin-bottom:0;">Unless you have done otherwise, the cloned project compressed as a .Zip file from GitHub would be uncompressed into the folder "Wk3-C--IP-Salon". Issue the following commands in sequence within your Terminal: </font></p>
<table style="background-color: #000;" style="color:#0000ff;" border=2 cellspacing=2 cellpadding=2>
  <tr>
    <td colspan="2" style="text-align:center;" bgcolor="#bc01bf;"><font color="#fff" size="3.5">**Choose One Column**<br/></font><font color="#fff" size="2">(__certain__ commands are the same for both columns)</font></td>
  </tr>
  <tr>
    <td bgcolor="#3B9FF;" style="text-align:center;"><font color=#ffff00;" font-family: Babas; font-size: 4em;">`Interact with the UI Database` <br/> (default usage)</font></td>
    <td bgcolor="#3B9FF;" style="text-align:center;"><font color=#ffff00;" font-family: Babas; font-size: 4em;">`Interact with the Test Database` <br/> (if you are modifying or testing the backend) </font></td>
  </tr>
  <tr>  
    <td colspan="2" style="text-align:center;">cd Wk3-C--IP-Salon</td>
  </tr>
  <tr>  
    <td colspan="2" style="text-align:center;">cd HairSalon.Solution</td>   
  </tr>
  <tr>  
    <td style="text-align:center;">cd HairSalon</td>
    <td style="text-align:center;">cd HairSalon.Tests</td>    
  </tr>
  <tr>  
    <td colspan="2" style="text-align:center;">dotnet restore <br/>dotnet build<br/>dotnet run</td>      
  </tr>
  <tr>  
    <td>Open a browser and navigate to http://localhost:5000 to interact with this project as a user.</td>     
    <td>Interaction is within the Terminal view</td>  
  </tr>  
  <tr>  
    <td colspan="2" style="text-align:center;"><font style="color: #f2cf4a; font-family: Babas; font-size: 1em;">(**NOTE**: When done, `CTRL-C` to stop the server as well as `in MAMP` click on **Stop Servers**.)</font></td>   
  </tr>        
</table>


* If you choose, you may use your editor-of-choice to edit and modify this project.
  * For example, if your editor is [Atom](https://flight-manual.atom.io/getting-started/sections/installing-atom/), issue the following in your bash if wishing to edit the Index.cshtml file from within the ...Views/Home directory for this project:
    $ Atom Index.cshtml
---

## Specifications    
| Implemented [X] |Item |Focus | Behavior | Input | Output | Comments |
|:--:|:---:|---|---|---|---|---|
|[&nbsp;&nbsp;]|1|*`Stylist`*|Be able to add a stylist. |  Susan | Susan | Selected a first name for simplicity in creating first revision.
|[&nbsp;&nbsp;]|2| *`Client`*| **Not** be able to add a client if no stylists have been added to the system or if a stylist has not been selected. |Click `Client Name` to view all Stylists | **Active Stylists:** <br /> Susan<br />Mary<br />Henry | Chose simple list of first names to create first revision of app for look-and-feel.|
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
| C# .NET Core 1.1 SDK (Software Development Kit) |  [Link too long (hover here to view link detail or right-click to copy HTML)](https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-win-x64.1.1.4.exe/ "https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-win-x64.1.1.4.exe") | [Link too long (hover here to view link detail or right-click to copy HTML)](https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-osx-x64.1.1.4.pkg/ "https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-osx-x64.1.1.4.pkg") |
| .NET Runtime |[Link too long (hover here to view link detail or right-click to copy HTML)](https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-win-x64.1.1.4.exe/ "https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-win-x64.1.1.4.exe") | [Link too long (hover here to view link detail or right-click to copy HTML)](https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-osx-x64.1.1.4.pkg/ "https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-osx-x64.1.1.4.pkg") |
| Atom | http://flight-manual.atom.io/getting-started/sections/why-atom/ | https://github.com/atom/atom/releases/download/v1.21.1/atom-mac.zip |
| CSS <td colspan=2>[Link too long (hover here to view link detail or right-click to copy HTML)](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwjswubPlLnWAhVGVRQKHaRLBkgQFggmMAA&url=https%3A%2F%2Fgetbootstrap.com%2Fcss%2F&usg=AFQjCNFpcAPIPLCu0F7w2NDTOafHdV8Pkw/ "https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwjswubPlLnWAhVGVRQKHaRLBkgQFggmMAA&url=https%3A%2F%2Fgetbootstrap.com%2Fcss%2F&usg=AFQjCNFpcAPIPLCu0F7w2NDTOafHdV8Pkw")  </td>|
| CSS: Materialize <td colspan=2> http://materializecss.com/forms.html  </td>|
| Git | https://git-for-windows.github.io/ | [Paste the following into Bash]:<br />$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"<br />$ echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile<br />$ brew install git |
| GitHub:<td colspan=2> https://github.com/  </td>|
| HTML:<td colspan=2> http://htmlreference.io  </td>|
| Javascript:<td colspan=2> https://www.javascript.com/  </td>|
| Javascript Jquery<td colspan=2> [Link too long (hover here to view link detail or right-click to copy HTML)](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwiBj_WJlbnWAhWBLhQKHfHUAQEQFggmMAA&url=https%3A%2F%2Fjquery.com%2F&usg=AFQjCNFnz7C6MAXGLm7pVcOD_LrOjJUUiA/ "https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwiBj_WJlbnWAhWBLhQKHfHUAQEQFggmMAA&url=https%3A%2F%2Fjquery.com%2F&usg=AFQjCNFnz7C6MAXGLm7pVcOD_LrOjJUUiA") </td> |
| MAMP (contains Apache server, MySQL, phpMyAdmin, etc.)<td colspan=2> https://en.wikipedia.org/wiki/Markdown<br>• Select either Windows or MAC<br/>• Once installed, click on 'Preferences' &#124; click on "Set Web & MySQL ports to 80 & 3306". &#124; Click on "Start Servers"...when the servers are up, the "button" toggles to "Stop Servers"<br/>&nbsp;&nbsp;**WARNING:**&nbsp; Otherwise, for the port - you may choose to identify certain ports yourself based on your system configuration. If doing this however, every line in the code referring to port `3306` will need to be modified with the port you specify for mySQL.  </td>|
| Markdown<td colspan=2> https://www.mamp.info/en/downloads/  </td>|
| Mono |http://www.mono-project.com/download/#download-win | http://www.mono-project.com/download/#download-mac |


### License
* All rights reserved for technologies utilized.

Copyright (c) 2016 **_{MIT}_**
