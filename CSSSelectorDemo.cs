using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class CSSSelectorDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSSselector dEmo!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser

            driver.Url = "https://www.google.co.in/"; //launch url open google

            // BY CSS Selector Xpath

            //driver.FindElement(By.CssSelector("input.gLFyf")).SendKeys("Selenium");
            //By Attribute
            //driver.FindElement(By.CssSelector("input[role='combobox']")).SendKeys("Selenium");
            //Starts with
            //driver.FindElement(By.CssSelector("input[role^='combo']")).SendKeys("Selenium");
            //Contains
            //driver.FindElement(By.CssSelector("input[role*='mbo']")).SendKeys("Selenium");
            //Ends-With

            driver.FindElement(By.CssSelector("input[role$='box']")).SendKeys("Selenium");


            //Close the Browser

            Thread.Sleep(8000);
            driver.Close();


        }
    }
}