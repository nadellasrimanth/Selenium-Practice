using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumPractice
{
    public class Test1
    {

        public static void Main(string[] args)
        {
            Test1 tt = new Test1();
            tt.OpenChrome();
        }

        IWebDriver driver;
        [SetUp]
        public void OpenChrome()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "http://www.google.co.in";
                driver.Url = "http://www.irctc.co.in";
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();
                LoginUser();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //driver.Close();

        }
        public void LoginUser()
        {
            try
            {
                driver.FindElement(By.XPath("//a[@class='search_btn loginText ng-star-inserted']")).Click();
                driver.FindElement(By.XPath("//*[@id='userId']")).SendKeys("railmutyal");
                driver.FindElement(By.XPath("//*[@id='pwd']")).SendKeys("Irctc@1234");
                //System.Threading.Thread.Sleep(9000);
                System.Console.ReadLine();
                string captcha = System.Console.ReadLine();
                driver.FindElement(By.XPath("//*[@id='nlpAnswer']")).SendKeys(captcha);
                driver.FindElement(By.XPath("//button[contains(text(),'SIGN IN')]")).Click();
            }
            catch (Exception fg)
            {
                Console.WriteLine(fg);
            }
        }
    }
}
