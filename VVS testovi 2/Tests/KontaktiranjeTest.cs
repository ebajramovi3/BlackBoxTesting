// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class KontaktiranjeTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
        driver.Manage().Window.Maximize();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void kontaktiranje()
    {
        driver.Navigate().GoToUrl("https://buybook.ba/");

        Assert.That(driver.Title, Is.EqualTo("Buybook Shop"));
        //ClickElementWithWait(By.LinkText("Kontaktirajte nas"));
        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        Thread.Sleep(3000);
        driver.FindElement(By.LinkText("Kontaktirajte nas")).Click();
        Assert.That(driver.Title, Is.EqualTo("Kontaktirajte nas"));
        Assert.That(driver.Title, Is.EqualTo("Kontaktirajte nas"));
        driver.FindElement(By.Id("type")).Click();
        driver.FindElement(By.Id("type")).SendKeys("test");
        driver.FindElement(By.Id("inputEmail4")).SendKeys("test@test.com");
        driver.FindElement(By.Name("phone")).SendKeys("0000000");
        Thread.Sleep(3000);
        driver.FindElement(By.Id("inputAddress")).SendKeys("Test");
        driver.FindElement(By.Id("floatingTextarea2")).SendKeys("Test");
        {
            var element = driver.FindElement(By.Id("type"));
            Boolean isEditable = element.Enabled && element.GetAttribute("readonly") == null;
            Assert.True(isEditable);
        }
        driver.FindElement(By.CssSelector(".section:nth-child(2)")).Click();
        driver.Close();
    }
}
