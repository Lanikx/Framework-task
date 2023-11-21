﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerTests.PageObjects
{
    internal class CatalogPage : BasePage
    {
        public CatalogPage(IWebDriver driver) : base(driver, "https://www.onliner.by/")
        {

        }
    
    }
}