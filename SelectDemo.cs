using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    class SelectDemo
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("hello!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\user\\Downloads\\chromedriver_win32"); //launch chrome

            driver.Manage().Window.Maximize(); //max the browser


            //Launch Url(Open Google
            driver.Url = "https://formstone.it/components/dropdown/demo/";

            IWebElement select_box = driver.FindElement(By.Id("demo_basic"));

        SelectElement select = new SelectElement(select_box);

        //select.SelectByIndex(1);

        //select.SelectByValue("2");

        select.SelectByText("Two");

            //Close the Browser
            driver.Close();

        }


}
}
   
