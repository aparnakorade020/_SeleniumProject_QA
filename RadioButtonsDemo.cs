using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class RadioButtonsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("radiobutton!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser

            driver.Url = "https://www.google.co.in/"; //launch url open google

            //Launch Url(Open Google

            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";


            ReadOnlyCollection<IWebElement> radio_buttons = driver.FindElements(By.Name("optradio"));
        Thread.Sleep(3000);            

            radio_buttons[1].Click();

        Thread.Sleep(3000);

            //Close the Browser

            driver.Close();

        }


}
}

