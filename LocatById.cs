using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class LocatById
    {
        static void Main(string[] args)
        {
            Console.WriteLine("locate by id");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser

            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?hl=en&flowName=GlifWebSignIn&flowEntry=SignUp"; //launch url open google


           // driver.FindElement(By.Id("firstname")).SendKeys("aparna");
            //or
            driver.FindElement(By.CssSelector("#firstName")).SendKeys("aparna");

            Thread.Sleep(3000);




            driver.Close();  //close the browser
        }
    }
}
