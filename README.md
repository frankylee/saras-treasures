# S.A.R.A.'s Treasures
ASP.NET full website redesign for [local non-profit](https://sarastreasures.org) in Eugene, OR.

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

---
###### CS296N Web Development 2: ASP.NET W21
