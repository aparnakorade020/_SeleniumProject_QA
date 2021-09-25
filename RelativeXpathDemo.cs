using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class RelativeXpathDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AbsoluteXpathDemo!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser

            driver.Url = "https://www.google.co.in/"; //launch url open google

            driver.FindElement(By.XPath("//div[@jsname='gLfyf']//input")).SendKeys("selenium");


            driver.Close();  //close the browser
        }
    }
}

