My UI Automation Test Suite work

Web UI Automation testing framework is developed by free version of Microsoft Visual Studio Community 2017 Version 15.9.19. It can be downloaded from my google drive as below link.

https://drive.google.com/file/d/1GzpCtZ_TqVFDRsExp8f7uOqeeqh2TGzd/view?usp=sharing

Installed NuGet:

Selenium.WebDriver 3.12.0

Selenium.Support 3.12.0

SpecFlow 3.1.82

NUnit3TestAdapter 3.12.0

NUnit 3.11.0

SpecFlow.NUnit 3.1.82

SpecFlow.Tools.MsBuild.Generation 3.1.82

Gherkin 6.0.0

FluentAssertions 4.19.4

Newtonsoft.Json 10.0.3

Getting Started: Download Microsoft Visual Studio Community 2017 and install necessary NuGets. Unzip the Lyratesting2Project1.7z and open Lyratesting2Project1.sln file by Microsoft Visual Studio Community 2017.

Technical issues: How to separate the test data and business logic to design web UI automation framework? How to design test cases and transfer test data to UI automation framework? How to design and code the web UI automation framework? Or setting up environment could be challenge?

Technical solutions: Using data table and scenario outlines in specflow to transfer test data to web UI automation framework. Using Page Object pattern to design the UI automation framework. In processing project, it is important to locate the web UI elements by using By ID, By Name, By XPath, and By LinkText or PartialLinkText methods. Sometime it need to search results which need to design a method to return the searching List or collections. Automating all test cases need to use Hook methods before Scenario and after Scenario so that each test case finished will close the current page browser and each test case start will open a new page browser automatically.
