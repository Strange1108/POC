namespace MyNUnitProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

//using SeleniumExtras;


public class UnitTest1
{
    ChromeDriver driver;

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup1");
        driver = new ChromeDriver("C:\\Users\\MahendraJ2\\OneDrive - CitiusTech\\Desktop\\Backup\\Training\\PracticeTest\\driverexe");
    }

    [Test]
    public void Test1()
    {
        //Addition of elements

        Console.WriteLine("Test1");

        driver.Url = ("http://demoselsite.azurewebsites.net/webform1.aspx");

        IWebElement ele = driver.FindElement(By.Id("cmbop"));
        SelectElement list = new SelectElement(ele);
        driver.FindElement(By.Id("txtno1")).SendKeys("5");
        driver.FindElement(By.Id("txtno2")).SendKeys("6");

        list.SelectByValue("Add");
        Thread.Sleep(1200);
        driver.FindElement(By.Id("btnsrcvcalc")).Click();

        IWebElement res = driver.FindElement(By.Id("lblres"));

        string s = res.Text;

        Console.WriteLine(s);

        if (s.Equals("11"))
        {

            Console.WriteLine("Pass");

        }

        else
        {


            Console.WriteLine("Fail");

        }
                                        //Reloading the page

        Thread.Sleep(1200);
        driver.Navigate().GoToUrl("http://demoselsite.azurewebsites.net/webform1.aspx");


                                       //Multiplication of elements

                                
        IWebElement ele1 = driver.FindElement(By.Id("cmbop"));
        SelectElement list1 = new SelectElement(ele1);
        driver.FindElement(By.Id("txtno1")).SendKeys("12");
        driver.FindElement(By.Id("txtno2")).SendKeys("5");

       list1.SelectByValue("Multiply");
        Thread.Sleep(1200);
        driver.FindElement(By.Id("btnsrcvcalc")).Click();

        IWebElement res1 = driver.FindElement(By.Id("lblres"));

        s = res1.Text;

        

        Console.WriteLine(s);

        if (s.Equals("60"))
        {
            Console.WriteLine("Pass");
        }

        else
        {
            Console.WriteLine("Fail");
        }


                                             //Reloading the page

        Thread.Sleep(1000);
        driver.Navigate().GoToUrl("http://demoselsite.azurewebsites.net/webform1.aspx");

                                            //Division of elements

                                
        IWebElement ele2 = driver.FindElement(By.Id("cmbop"));
        SelectElement list2 = new SelectElement(ele2);
        driver.FindElement(By.Id("txtno1")).SendKeys("13");
        driver.FindElement(By.Id("txtno2")).SendKeys("2");

        list2.SelectByValue("Divide");
        Thread.Sleep(1200);
        driver.FindElement(By.Id("btnsrcvcalc")).Click();

        IWebElement res2 = driver.FindElement(By.Id("lblres"));

        s = res2.Text;

        

        Console.WriteLine(s);

        if (s.Equals("6.5"))
        {

            Console.WriteLine("Pass");

        }

        else
        {

            Console.WriteLine("Fail");

        }
        driver.Close();

    }


}