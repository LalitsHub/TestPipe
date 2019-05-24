using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AgVueAutomation.pages
{
    class mainMenuFlorida
    {
        public static IWebElement inbox = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListInbox']/a"));
        public static IWebElement newCase = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListNew']/a"));
        public static IWebElement queries = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListQueries']/a"));
        public static IWebElement reports = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListReports']/a"));
        public static IWebElement admin = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListAdmin']"));
        ///   public static IWebElement allCasesTab = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-wp-app-inbox-processes-container']/div/ul[1]/li"));
        ///   public static IWebElement _BaseProcessesTab = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-wp-app-inbox-processes-container']/div/div[1]"));
        ///   public static IWebElement baseAppraisalRequestTab = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-wp-app-inbox-processes-container']/div/ul[2]/li[1]"));
        ///   public static IWebElement baseCreditRequestTab = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-wp-app-inbox-processes-container']/div/ul[2]/li[2]"));
        public static int waitTime = 2000;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuOption1"></param>
        /// <param name="menuOption2"></param>
        /// <param name="menuOption3"></param>

        public static void selectMenuFlorida(String menuOption1, String menuOption2, String menuOption3)

        {
            try

            {
                if (menuOption1.ToUpper().Equals("INBOX"))
                {
                    inbox.Click();
                    System.Threading.Thread.Sleep(waitTime);
                }
                else if (menuOption1.ToUpper().Equals("NEW CASE"))
                {
                    newCase.Click();
                    System.Threading.Thread.Sleep(waitTime);
                    if (menuOption2.ToUpper().Equals("HEALTH CHECK"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='Health Check']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("FCF CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='FCF Credit Request']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    //else if (menuOption2.ToUpper().Equals("AGC AUTO TESTING"))
                    //{
                    //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='AGC Auto Testing']")).Click();
                    //    System.Threading.Thread.Sleep(waitTime);
                    //}
                    //else if (menuOption2.ToUpper().Equals("YAN CREATE USER PROFILE"))
                    //{
                    //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='YAN Create User Profile']")).Click();
                    //    System.Threading.Thread.Sleep(waitTime);
                    //}
                }
                else if (menuOption1.ToUpper().Equals("QUERIES"))
                {
                    queries.Click();
                    System.Threading.Thread.Sleep(waitTime);
                    if (menuOption2.ToUpper().Equals("APPLICATION"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Application']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption3.ToUpper().Equals("CR CLOSING NWF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()=' CR Closing NWF Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING SWG SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()=' CR Closing SWG Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("ARB APPRAISAL REQUEST SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='ARB Appraisal Request Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("BASE APPRAISAL REQUEST SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='BASE Appraisal Request Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING ACF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing ACF Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING ACH SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing ACH Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING AGC SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing AGC Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING AGS SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing AGS Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING ARB SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing ARB Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING BASE SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing BASE Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING CFE SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing CFE Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING CFL SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing CFL Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING CKY SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing CKY Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING FCF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing FCF Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING PUR SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing PUR Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING YAN SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing YAN Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST ACF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request ACF Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST ACH SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request ACH Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST AGC SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request AGC Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST AGS SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request AGS Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST CFE SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request CFE Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST CFL SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request CFL Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST CKY SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request CKY Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST SWG SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request SWG Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST YAN SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request YAN Search']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        if (menuOption2.ToUpper().Equals("OTHER ENTITIES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Other Entities']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                            if (menuOption3.ToUpper().Equals("NWF BE SEARCH"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='NWF BE Search']")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                        }
                    }
                    else if (menuOption1.ToUpper().Equals("REPORTS"))
                    {
                        reports.Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption2.ToUpper().Equals("BAM"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li/div/span[text()='BAM']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                            if (menuOption3.ToUpper().Equals("PROCESS"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li/div/span[text()='Process']")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                            else if (menuOption3.ToUpper().Equals("ACTIVITIES"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li/div/span[text()='Activities']")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                            else if (menuOption3.ToUpper().Equals("RESOURCE MONITOR"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li/div/span[text()='Resource Monitor']")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                        }
                        else if (menuOption3.ToUpper().Equals("ANALYTICS"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li/div/span[text()='Analytics']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                            if (menuOption3.ToUpper().Equals("PROCESS"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li/div/span[text()='Process']")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                            else if (menuOption3.ToUpper().Equals("ACTIVITIES"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li/div/span[text()='Activities']")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                        }
                        else if (menuOption3.ToUpper().Equals("SENSORS"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li/div/span[text()='Sensors']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                    }
                    else if (menuOption1.ToUpper().Equals("ADMIN"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//li[@id='menuListAdmin']")).Click();
                        System.Threading.Thread.Sleep(waitTime);

                        // Sroll to the view
                        IWebElement elem4 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='Cases']"));
                        IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                        js.ExecuteScript("arguments[0].scrollIntoView(true);", elem4);

                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Menu " + menuOption1, "Should select menu " + menuOption1, "EXCEPTION: " + e, "FAIL");
            }
        }
        
        public static void searchCaseId(string casIn)
        {
            try
            {
                if (casIn != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).SendKeys(casIn);
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).SendKeys(Keys.Enter);

                    lib.resultUtil.AddResult("Search for the Case ID", "Enter the case ID", "Entered <<" + casIn + ">> the Case ID", "PASS");
                }
                //Click on the Search Button
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='I_RadNumber']")).Click();
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static void selectAdminMenuFlorida(String menuOption1, String menuOption2, String menuOption3)
        {
            try
            {
                if (menuOption1.ToUpper().Equals("ADMIN"))
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//li[@id='menuListAdmin']")).Click();
                    //lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/a/span[2][text()='Admin']")).Click();
                    
                    if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='Entities']")).Displayed)
                    {
                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                    }
                    else
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/a/span[2][text()='Admin']")).Click();
                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                    }
                    

                    // Scroll to the view
                    //IWebElement elem4 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='Cases']"));
                    //IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                    //js.ExecuteScript("arguments[0].scrollIntoView(true);", elem4);

                    
                }

            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Admin tab and then Case tab", "Should Search for the Admin tab and then Case tab", "EXCEPTION: " + e, "FAIL");
            }
        }

    }
}
