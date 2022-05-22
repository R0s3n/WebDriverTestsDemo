
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Create new Chrome browser instance
var driver = new ChromeDriver();

//Navigate to Wikipedia

driver.Url = "https://wikipedia.org";

System.Console.WriteLine("CURRENT TITLE: " + driver.Title);

//Locate Search field by ID
var searchField = driver.FindElement(By.Id("searchInput"));

//Click on Element
searchField.Click();

//fill QA and press ENTER
searchField.SendKeys("Quality Assurance" + Keys.Enter);

System.Console.WriteLine("TITLE AFTER SEACRH: " + driver.Title);

//Close browser
 driver.Quit();


