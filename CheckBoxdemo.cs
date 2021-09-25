using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumProject_QA_04
{
    class CheckBoxdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?hl=en&flowName=GlifWebSignIn&flowEntry=SignUp";
            IWebElement check_box = driver.FindElement(By.XPath("//input[@id='i3']"));
            Thread.Sleep(3000);
            check_box.Click();

            Thread.Sleep(3000);

            //Close the Browser
            driver.Close();

        }


    }
}