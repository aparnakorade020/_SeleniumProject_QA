using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class AlertDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser
                                             
            driver.Url = "https://www.seleniumeasy.com/test/javascript-alert-box-demo.html";   //Launch Url

            //Click on Button To get Alert
            driver.FindElement(By.CssSelector("button.btn")).Click();

            //Read the Alert
            IAlert alert = driver.SwitchTo().Alert();

            String alert_Text = alert.Text;

            Console.WriteLine(alert_Text);

            Thread.Sleep(8000);

            //Respond Alert

            alert.Accept();

            //driver.Close();


        }


    }
}

