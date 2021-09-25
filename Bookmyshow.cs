using NPOI.HSSF.UserModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;

namespace SeleniumProject_QA
{

    class Bookmyshow
    {
        public static List<String> ReadDataFromExcel(String path)
        {
            HSSFWorkbook wb = new HSSFWorkbook(File.Open(path, FileMode.Open));
            HSSFSheet sh = (HSSFSheet)wb.GetSheetAt(0);
            HSSFRow row = (HSSFRow)sh.GetRow(0);
            HSSFCell cell = null;
            List<String> cell_values = new List<string>();
            int i, j;
            for (i = 1; i <= sh.LastRowNum; i++)
            {
                int cell_count = sh.GetRow(0).LastCellNum;
                for (j = 0; j < cell_count; j++)
                {
                    cell = (HSSFCell)sh.GetRow(i).GetCell(j);
                    String cell_value = cell.StringCellValue;
                    cell_values.Add(cell_value);
                }

            }
            return cell_values;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        //Launch Chrome
        BookMyshow: IWebDriver driver = new ChromeDriver();
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://in.bookmyshow.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            String path = @"C:\Users\Aaranya\Bela _SeleniumC#batch\Selenium_QABatch_IDE\Selenium_WebDriver_Assignments\SeleniumProject_QA_04_Updated\cities.xls";
            //WorkBook->Sheet->Row->Cell
            //.xls -> HSSF
            List<String> cell_values = ReadDataFromExcel(path);
            foreach (String cell_value in cell_values)
            {
                Console.WriteLine(cell_value);
            }
            //Thread.Sleep(3000);
            IWebElement notification_box = driver.FindElement(By.Id("wzrk-confirm"));
            if (notification_box.Displayed)
            {
                notification_box.Click();
            }
            driver.FindElement(By.CssSelector("input.sc-bqjOQT")).SendKeys("Nashik");
            Thread.Sleep(3000);
            Actions action = new Actions(driver);

            Thread.Sleep(3000);
            IWebElement search_box = driver.FindElement(By.CssSelector("input.sc-bqjOQT"));
            action.MoveToElement(search_box).Click().Perform();
            driver.FindElement(By.TagName("Body")).SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector("li.sc-cpHetk")).Click();
            driver.FindElement(By.Id("4")).Click();
            driver.FindElement(By.CssSelector("input.sc-bqjOQT")).SendKeys("Shersh");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("li.sc-cpHetk")).Click();
            String about_Movie = driver.FindElement(By.CssSelector("div.styles__DescriptionContainer-sc-o4g232-3")).Text;
            Console.WriteLine(about_Movie);
            driver.Quit();
        }
    }
}