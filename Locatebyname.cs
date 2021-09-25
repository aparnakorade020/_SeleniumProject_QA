using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class Locatebyname
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser

            driver.Url = "https://www.google.co.in/"; //launch url open google


            // IWebElement search_box = driver.FindElement(By.Name("q"));  //enter the selenium in search box
            //search_box.SendKeys("Selenium");

            driver.FindElement(By.Name("q")).SendKeys("selenium");


            // driver.Close();  //close the browser
        }
    }
}
