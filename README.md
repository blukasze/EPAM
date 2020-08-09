The task was to:
Implement a sample test automation project:

·       Decide what features can be automated on www.ubs.com

·       Write 3-5 scenarios in feature files preferably using SpecFlow (other BDD tools such as Cucumber are also acceptable)

·       Implement above in steps preferably using C# (Java or other alternatives are also acceptable)

·       Make project configurable, so it is possible to run test suite for particular language/instance/user…

I've implemented only one Feature file for the incorrect user login. I believe more would just be more of the same. I've picked login, because it required most of the framework functionality. 

The tests are configurable through a appsettings.json file. The links are hardcoded, but I would refactor that if more tests would be in place that reuse the same link.
There is a simple implementation of Page Object pattern that could be tweaked about to make the pages more feature oriented and more Single Purpose Principle ready.
In order to deal with the menu items and the Privacy popup I needed implement WebElement and WebDriver extension methods that could be reused in other areas.
The whole framework is using the Dependency Injection pattern. Thanks to that it would be easy to add things like API tests, DB connections or whatever would be needed to fully test the product.
