using System;
using OpenQA.Selenium;

namespace SeleniumProject_QA
{
    internal class SelectElement
    {
        private IWebElement select_box;

        public SelectElement(IWebElement select_box)
        {
            this.select_box = select_box;
        }

        public bool IsMultiple { get; internal set; }

        internal void SelectByIndex(int v)
        {
            throw new NotImplementedException();
        }

        internal void SelectByValue(string v)
        {
            throw new NotImplementedException();
        }

        internal void SelectByText(string v)
        {
            throw new NotImplementedException();
        }

        internal void DeselectByIndex(int v)
        {
            throw new NotImplementedException();
        }
    }
}