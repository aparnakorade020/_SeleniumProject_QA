using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class TitleDemo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("title demo!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser
                                               
            //Launch Url(Open Google
            driver.Url = "https://www.google.co.in/";
            String title = driver.Title;

            Console.WriteLine(title);

            // BY LinkText

            driver.FindElement(By.LinkText("Gmail")).Click();

            title = driver.Title;

            Console.WriteLine(title);

            //Close the Browser

            driver.Close();

        }
    }
}
