using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class AbsoluteXpathDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AbsoluteXpathDemo!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser

            driver.Url = "https://www.google.co.in/"; //launch url open google

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys("selenium");

          
             driver.Close();  //close the browser
        }
    }
}


///html/body/ntp-app//div/ntp-realbox//div/input
