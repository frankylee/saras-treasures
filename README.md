# S.A.R.A.'s Treasures
ASP.NET full website redesign for [local non-profit](https://sarastreasures.org) in Eugene, OR.

View this project [live on Azure](https://sarastreasures.azurewebsites.net)


## Lab 1: Validation of User Input
For all three types of web sites, add validation using data annotations to your models. Use validation that makes sense for the properties you choose to validate.

Create a new branch named Lab1 based on your main branch.
- Add validation to at least three properties from any of your models.
- Use at least three different validation attributes.
- At least one property should have more than one validation attribute.

To make the validation useful, in addition to adding validation annotations to model properties you will also need to:
- Add a new migration and update your database.
- Add at least a validation summary tag helper to the views where data entry is done.
- Add code to check ModelState in the controller methods that the data entry forms post to.

## Lab 2: Identity
Create a new branch named Lab02 based on your lab 1 branch.

Add Identity to your web app—use the same database as the one used by your application (don't create a separate DbContext class).

Your user model will need to inherit from the IdentityUser class. Make the following changes to your user model.
  - Remove the the DbSet you were using for your user model.
  - Remove the ID.
  - Add one or more properties. You can choose the properties, just don't duplicate the ones already in IdentityUser. 

Add a migration and update your database. Confirm that the identity tables have been added to your database correctly.

## Lab 3: Authentication
Add Authentication code to your lab web site for each of these features:
  - Registration
  - Login
  - Logout
  - Use the currently logged in user in any place where a user previously needed to enter their name.

## Lab 4: Authorization
You will add all the same Authorization features to your web site that your instructor added to the example web site:
  - Two roles of your choice.
    - One for all registered users.
    - Another for administrators.
  - Restrict some part of the web site to only be accessed by registered users.
  - Add a page for user and role management.
  - Restrict access to the management page to administrators.
  - Add a page for user and role management. The operations on this page will be:
    - Delete user
    - Add to Admin
    - Remove from Admin
    - Delete role
  - Restrict access to the management page to administrators.
    - You will need to seed the database with a user who is in the Admin role in order to be able to access the management page for the first time.

## Lab 5: Complex Domain Models
Add one or two additional classes to your web site's domain model. Make a UML class diagram of your domain model--include cardinality. Put the UML diagram in a docs folder in your solution.
  - Add comments to stories. A story can have multiple comments.
  - Implement your domain model in code. Add the corresponding controller method and view so that the new feature can be used by site users.
  
## Lab 6: Web Security Testing and Countermeasures
Use OWASP ZAP to scan your code for security vulnerabilities.
- Do a manual passive scan. Before doing the scan, log in as a registered user, but not as an admin. Navigate to every page of your web site and enter data in all the forms.
- Run an automated passive scan.
- Without closing the app, or after loading a stored passive testing session, run an active test of your web app.
- Fix at least three of the security vulnerabilities identified in the alerts. Preferably, solve the highest priority issues. Only solve issues that can be fixed in your app’s code, not issues that require changes to the web server.
- Add a markdown document containing:
    - A list of the high, medium and low priority issues that came up in the initial passive and active scans of your app.
    - The issues you chose to mitigate and the classes and methods that you changed to implement the mitigation.
    - A list of the issues that come up in passive and active scans after making the code changes.
---
###### CS296N Web Development 2: ASP.NET W21
