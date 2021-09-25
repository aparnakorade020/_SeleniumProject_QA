using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class TagNameDemo
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("AbsoluteXpathDemo!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser

            driver.Url = "https://www.google.co.in/"; //launch url open google

            //By TagName
            //driver.FindElement(By.TagName("input")).SendKeys("Selenium");

            // Store in The List And Then Print the Size


            ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));

        //ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));

        Console.WriteLine(links.Count);
            foreach(IWebElement link in links)
            {
                Console.WriteLine(link.Text);
            }
    //Close the Browser
    Thread.Sleep(3000);
            driver.Close();


        }
    }
}
