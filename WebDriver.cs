using System;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject_QA
{
    internal class WebDriver
    {
        public static implicit operator WebDriver(ChromeDriver v)
        {
            throw new NotImplementedException();
        }
    }
}