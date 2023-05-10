using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace DemoQA_JQuery
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new EdgeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Manage().Window.Maximize();

            driver.Url = "https://demoqa.com/";

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(3000);

            js.ExecuteScript("$('#app > div > div > div.home-body > div > div:nth-child(1) > div').click()");
            js.ExecuteScript("$('#item-0').click()");



            //For Text Box Section
            js.ExecuteScript("$('#userName').val('Mujahid')");
            js.ExecuteScript("$('#userEmail').val('mujahidakberali@gmail.com')");
            js.ExecuteScript("$('#currentAddress').val('Karachi, Pakistan')");
            js.ExecuteScript("$('#permanentAddress').val('Karachi, Pakistan')");
            js.ExecuteScript("$('#submit').click()");

            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,100)");
            Thread.Sleep(1000);

            //For Check Box
            js.ExecuteScript("$('#item-1').click()");

            Thread.Sleep(3000);
            js.ExecuteScript("$('#tree-node > div > button.rct-option.rct-option-expand-all').click()");

            Thread.Sleep(2000);

            js.ExecuteScript("$('#tree-node > div > button.rct-option.rct-option-expand-all').click()");
            js.ExecuteScript("$('#tree-node > ol > li > ol > li:nth-child(1) > span > label').click()");
            js.ExecuteScript("$('#tree-node > ol > li > ol > li:nth-child(2) > span > label').click()");
            js.ExecuteScript("$('#tree-node > ol > li > ol > li:nth-child(3) > span > label').click()");

            Thread.Sleep(1000);

            js.ExecuteScript("$('#tree-node > div > button.rct-option.rct-option-collapse-all').click()");
            Thread.Sleep(3000);

            //For Radio Button
            js.ExecuteScript("$('#item-2').click()");
            Thread.Sleep(3000);

            js.ExecuteScript("$('#yesRadio').click()");
            Thread.Sleep(3000);

            //For Webtables
            js.ExecuteScript("$('#item-3').click()");
            Thread.Sleep(3000);
            js.ExecuteScript("$('#addNewRecordButton').click()");
            js.ExecuteScript("$('#firstName').val('Mujahid')");
            js.ExecuteScript("$('#lastName').val('Akber Ali')");
            js.ExecuteScript("$('#userEmail').val('mujahidakberali@gmail.com')");
            js.ExecuteScript("$('#age').val('23')");
            js.ExecuteScript("$('#salary').val('23,000')");
            js.ExecuteScript("$('#department').val('QA Intern')");
            js.ExecuteScript("$('#submit').click()");
            Thread.Sleep(3000);
            js.ExecuteScript("$('body > div.fade.modal.show > div > div > div.modal-header > button').click()");

            //For Opening form and filling practice form
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            js.ExecuteScript("$('#firstName').val('Mujahid')");
            js.ExecuteScript("$('#lastName').val('Akber Ali')");
            js.ExecuteScript("$('#userEmail').val('mujahidakberali@gmail.com')");
            js.ExecuteScript("$('#gender-radio-1').click();");
            js.ExecuteScript("$('#userNumber').val('87976876876')");

            js.ExecuteScript("$('#dateOfBirthInput').val('03 July 1998')");


            driver.FindElement(By.Id("subjectsInput")).SendKeys("math");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(OpenQA.Selenium.Keys.Enter);
            driver.FindElement(By.Id("subjectsInput")).SendKeys(OpenQA.Selenium.Keys.Tab);
            //checkbox

            js.ExecuteScript("$('#hobbies-checkbox-1').click();");

            // Select the subjects
            driver.FindElement(By.Id("uploadPicture")).SendKeys(@"D:\repos\DemoQA_JQuery\DemoQA_JQuery\File to Upload\TestFile.png");


            // Select the hobbies
            js.ExecuteScript("$('#hobbies-checkbox-1').prop('checked', true);");
            //js.ExecuteScript("$('#hobbies-checkbox-3').prop('checked', true);");

            // Enter the current address
            js.ExecuteScript("$('#currentAddress').val('123 Main St');");

            // Select the state

            driver.FindElement(By.Id("react-select-3-input")).SendKeys("NCR");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(OpenQA.Selenium.Keys.Enter);

            // Select the city
            driver.FindElement(By.Id("react-select-4-input")).SendKeys("Delhi");
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(OpenQA.Selenium.Keys.Enter);

            // Click the submit button
            js.ExecuteScript("$('#submit').click();");
        }
    }
}
