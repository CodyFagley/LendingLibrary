# Cody && Lisa's Lending Library
This project was inspired by Handel IT and serves a few purposes:

* First, it fulfills the requirement for the interview process with Handel IT
* Second, it keeps track of loaned goods to friends and family

#  Functionality
It uses C# as a frontend and a Microsoft 2008 SQL Server for the backend.

When an item is loaned to family or a friend, the following is entered into a
 table:

* Primary Key
* Item Name
* Name of Loanee
* Date Loaned
* Date Returned (if returned)
* Description of the Item
* Is Deleted?

All Deletes are performed as "soft" deletes, meaning they are not removed from
 the database, entirely; instead, their isDeleted field is marked as true.

#  Installation Guide
Clone the project to a desired location on your hard drive.

Inside LLDatabase.cs on Lines 23-25, you will see the following:

    String server = "Server=CODY-PC\\LENDLIBRARY";
    String ssis = "Integrated security=SSPI";
    String dbname = "Items";

Change the server, security and database name as needed.

Then compile the project and run the Program.

To make migrating easier, All Database and Table Creation is done
 programatically.  This isn't how I would normally go about this project,
 but this project is to be shown as an example of my C# and SQL abilities
 and must be flexible in nature.

#  Notes on the Project
Admittedly, this is the first time I have used Visual Studio in a few years,
 and I have never used C#, SQL or .Net prior to this.

I will be slowly adding files to the .gitignore list as soon as I know which
 files are not required by others to build the project.