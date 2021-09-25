using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class MultiSelectDemo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("chackbox!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser
                                               //Launch Url(Open Google
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            IWebElement select_box = driver.FindElement(By.Name("States"));

            SelectElement select = new SelectElement(select_box);

            Boolean status_multiple = select.IsMultiple;

            Console.WriteLine(status_multiple);

            select.SelectByIndex(4);

            select.SelectByValue("California");

            select.SelectByText("New Jersey");

            //select.DeselectAll();

            select.DeselectByIndex(0);

            //Close the Browser

            //driver.Close();


        }


    }
}
