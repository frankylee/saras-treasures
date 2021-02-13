# Lab 6 – Web Security Testing and Countermeasures

1. A list of the high, medium and low priority issues that came up in the initial passive and active scans of your app (located in ZapReport.md).
2. The issues you chose to mitigate and the classes and methods that you changed to implement the mitigation.
3. A list of the issues that come up in passive and active scans after making the code changes (located in ZapReport2.md).


### App Crash on Null Quiz Input
- Fix: Added data annotations on QuizVM for string input to be required and have minimum and maximum values

### Cross Site Scripting (Reflected)
- Risk: High
- Confidence: Low
- Fix: Did not see evidence of script having been injected into login pages and decided to move on. 

### X-Frame-Options Header Not Set 
- Risk: Medium
- Confidence: Medium
- Fix: Update to Startup.cs Configure method in app.Use()

### X-Content-Type-Options Header Missing
- Risk: Low
- ConfidenceL Medium
- Fix: Update to Startup.cs Configure method in app.Use()

### Cookie Without Secure Flag
- Fix: Added using statement for Microsoft.AspNetCore.CookiePolicy to Startup.cs and added a cookie policy to Configure method in app.UseCookiePolicy()

### Loosely Scoped Cookie 
- Risk: Informational
- Confidence: Low
- Fix: Update to Startup.cs Configure method by setting CookieOptions for new CookieOptions to include Domain and Path settings (this only works on the live site, not on localhost and was tested by Tiff, as I was unable to bring myself to destroy my Azure site or get charged for creating a new "deployment test" site since I only have $8 in Azure credits remaining).

---
##### Teammates: Tiffany G. and frankylee.