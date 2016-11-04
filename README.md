# 15-Chirper

<img src="http://i.imgur.com/w3zISX1.png" alt="" />

In this project, I built social network where people can register for a free account and chirp their thoughts in 240 characters or less to the world!

## App Requirements
- Users need to be able to register for an account.
- Users need to be able to log in to their account.
- Users need to be able to post "Chirps".
- Users need to be able to see "Chirps" that other users have posted.
- Users need to be able to like each others "Chirps".
- Users need to be able to comment on any Chirp.

## Pages
- Register Page
	- Registration fields
	- Register button
- Login Page
	- Email field
	- Password field
	- Login button
- Main Chirp Page
	- Chirp entry field
	- Chirp list
	- Commenting functionality
	- Like functionality

## Tasks
1. Created an Entity Relationship Diagram before coding. This helped in building my application.
4. Opened Visual Studio, created a new Solution called `Chirper`, with an ASP Web API project called `Chirper.API`.
5. From the Package Manager Console, added the following dependencies using these commands:
   - Install-Package Microsoft.AspNet.Identity.Owin 
   - Install-Package Microsoft.AspNet.Identity.EntityFramework 
   - Install-Package Microsoft.Owin.Host.SystemWeb 
   - Install-Package Microsoft.AspNet.WebApi.Owin 
   - Install-Package Microsoft.Owin.Security.OAuth 
   - Install-Package Microsoft.Owin.Cors 
6. In my models folder, created the necessary classes representing the entities I designed in step 1.
7. Created a `DataContext` class in a folder called `Infrastructure` that inherits from `IdentityDbContext`.
8. Configured the entity relationships as shown in class.
9. Created my database using Migrations. `Enable-Migrations`, `Add-Migration InitialCreate` and `Update-Database` were the commands.
10. Create my Web API controllers, one per Model class. 
11. Created my Angular application as discussed in class.
