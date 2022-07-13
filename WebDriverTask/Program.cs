// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Hello, World!");
IWebDriver driver = new ChromeDriver();
// navigate to URL  
driver.Navigate().GoToUrl("https://www.google.com/search?q=images&source=lnms&tbm=isch&sa=X&ved=2ahUKEwj814SK3_X4AhWIn4QIHbPvAzAQ_AUoAXoECAIQAw&biw=1920&bih=912&dpr=1");
Thread.Sleep(2000);
// identify the Google search text box  
IWebElement ele = driver.FindElement(By.XPath("/html/body/div[2]/c-wiz/div[3]/div[1]/div/div/div/div[1]/div[1]/span/div[1]/div[1]/div[1]/a[1]/div[1]/img"));
if(ele != null)
{
    Console.WriteLine("Images Found!");
}