# <h1 align = "center"> Flix Master
  
#### _C# ASP.NET Core MVC and EF Core practice for Epicodus, 08.05.2020_

#### By _**Brittany Lindgren, Christine Augustine & Teresa Rosinski**_


## Description

_Welcome to our Indie Movie Theater app. Administrators can update movie listings and showtimes and customers can search showtimes to see what movies are playing._ 

## Setup/Installation Requirements

  1. Follow this [link to the project repository](PUT LINK HERE) on GitHub.  
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose **open with...** and open using a text editor such as VS Code or Atom, etc.
  8. Once you are inside of your text editor, open the terminal. If you are in VS Code for example, this can be done by clicking on `Terminal` at the top of the editor and then selecting `New Terminal`. **You can navigate to different directories in the project by typing `cd DirectoryName` to go down into specific directories or `cd ..` to go back up one directory. 
  9. Navigate to the DIRECTORYNAME directory by typing `cd FlixMaster` in your terminal and hitting `enter`. Then type the command `dotnet restore`,`dotnet build`, then `dotnet run` into your terminal and hit enter. You should see files appear inside of your bin folder. The bin folder should appear greyed out. 
  10. Click on the link provided after you see `now listening on: ... ` appear in your terminal.


#### Additional Setup/Installation Notes:

* You will need to configure the MySQL Workbench database in order to run this project. See directions directly below.   
* Do not alter the bin/ or obj/ directories or any of the files in them.

#### Configure the MySQL Workbench Database:
* Install MySQL and MySQL Workbench first. During installation of MySQL you will be asked to create a password. This is important! Take note of your password. Once you have installed MySQL and MySQL Workbenck, start MySQL by entering `mysql -uroot -p+_yourpassword_` in the terminal. Example: password is `tomato`, enter `mysql -uroot ptomato`. If this doesn't work in your terminal, try using your computer's command line interface application. If you are successful, you will see a message in the terminal, ending with the line `mysql>`. Once you have succesfully completed these steps, follow the instructions below.

A) Create the Database in MySQL Workbench
1. Open MySQL Workbench and double click on the grey box under the line `MySQL Connections` (this box should say `mamp` and have some text and numbers ending in `:3306`). This will launch the MySQL Workbench. You may be prompted to enter the same password that you used in the previous step (ex: `tomato`). 
2. You should see an icon in the upper left that looks like a little piece of paper with the letters `SQL` and a + sign. Hover over the icon and confirm that this is the 'create a new SQL tab for executing queries' icon. Once confirmed, double click the icon.
3. Enter the following (excluding the ``` at the beginning and end of the code) text into the window for the SQL File tab.

#### To Import the Database (As Taken From LearnHowToProgram.com)

### In the Navigator > Administration window, select Data Import/Restore.
### In Import Options select Import from Self-Contained File.
### Navigate to the file we just created.
### Under Default Schema to be Imported To, select the New button.
### Enter the name of your database with _test appended to the end.
### In this case to_do_list_test.
### Click Ok.
### Click Start Import.
### Reopen the Navigator > Schemas tab. Right click and select Refresh All. Your new test database will appear.

# SQL Schema Query #

``` 
CREATE DATABASE IF NOT EXISTS flix_master; USE flix_master;

DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) 

DROP TABLE IF EXISTS `movies`;
CREATE TABLE `movies` (
  `MovieId` int NOT NULL AUTO_INCREMENT,
  `Title` longtext,
  `Description` longtext,
  `Genre` longtext,
  `Rating` longtext,
  PRIMARY KEY (`MovieId`)
)

DROP TABLE IF EXISTS `movieshowing`;
CREATE TABLE `movieshowing` (
  `MovieShowingId` int NOT NULL AUTO_INCREMENT,
  `MovieId` int NOT NULL,
  `ShowingId` int NOT NULL,
  PRIMARY KEY (`MovieShowingId`),
  KEY `IX_MovieShowing_MovieId` (`MovieId`),
  KEY `IX_MovieShowing_ShowingId` (`ShowingId`),
  CONSTRAINT `FK_MovieShowing_Movies_MovieId` FOREIGN KEY (`MovieId`) REFERENCES `movies` (`MovieId`) ON DELETE CASCADE,
  CONSTRAINT `FK_MovieShowing_Showings_ShowingId` FOREIGN KEY (`ShowingId`) REFERENCES `showings` (`ShowingId`) ON DELETE CASCADE
) 

DROP TABLE IF EXISTS `showings`;
CREATE TABLE `showings` (
  `ShowingId` int NOT NULL AUTO_INCREMENT,
  `ShowingDate` datetime(6) NOT NULL,
  `ShowingTime` datetime(6) NOT NULL,
  PRIMARY KEY (`ShowingId`)
) 

 ```

4. Click 'execute' (this may appear as a lightening bolt icon).

**OR**

B) Populate the Database from the VS Code terminal using Migrations
1. Enter the following into the VS Code terminal `dotnet ef migrations add Initial` and hit Enter
2. Now enter `dotnet ef dtabase update` and hit Enter


## Known Bugs

| Bug : Message |  Situation  | Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ | ------- |
|  |  |  |  |


## Support and contact details

_Please feel free to contact the authors through GitHub (LINDGRENBA, CHRISTINEREINA, TERESAROSINSKI) with any feedback, questions or concerns._


## Technologies Used

* C#
* .NET-Core 2.2
* ASP.NET Core MVC
* Entity Framework Core
* Visual Studio Code
* Git Version Control
* GitHub
* Bootswatch


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_{Brittany Lindgren, Christine Augustine & Teresa Rosinski}_**
