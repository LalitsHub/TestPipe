using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AgVueAutomation.pages
{
    class mainMenu
    {
        public static IWebElement inbox = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListInbox']/a"));
        public static IWebElement newCase = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListNew']/a"));
        public static IWebElement queries = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListQueries']/a"));
        public static IWebElement reports = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListReports']/a"));
        public static IWebElement admin = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuListAdmin']/a"));
        ///     public static IWebElement _BaseProcessesTab = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-wp-app-inbox-processes-container']/div/div[1]"));
        ///   public static IWebElement baseAppraisalRequestTab = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-wp-app-inbox-processes-container']/div/ul[2]/li[1]"));
        ///    public static IWebElement baseCreditRequestTab = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-wp-app-inbox-processes-container']/div/ul[2]/li[2]"));
        public static int waitTime = 2000;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuOption1"></param>
        /// <param name="menuOption2"></param>
        /// <param name="menuOption3"></param>

        public static void selectMenu(String menuOption1, String menuOption2, String menuOption3)
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
                    if (menuOption2.ToUpper().Equals("BASE CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul[1]/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("BASE APPRAISAL REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul[2]/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                }
                else if (menuOption1.ToUpper().Equals("QUERIES"))
                {
                    queries.Click();
                    System.Threading.Thread.Sleep(waitTime);
                    if (menuOption2.ToUpper().Equals("APPLICATION"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption3.ToUpper().Equals("ARB APPRAISAL REQUEST SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[1]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("BASE APPRAISAL REQUEST SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[2]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING ACF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[3]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING ACH SEARCH FORM"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[4]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING CFL SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[5]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING FCF SEARCH FORM"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[6]/li")).Click();
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
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[1]")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption3.ToUpper().Equals("PROCESS"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[1]")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("ACTIVITIES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[2]")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("RESOURCE MONITOR"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[3]")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                    }
                    else if (menuOption3.ToUpper().Equals("ANALYTICS"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[2]")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption3.ToUpper().Equals("PROCESS"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[1]")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("ACTIVITIES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[2]")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                    }
                    else if (menuOption3.ToUpper().Equals("SENSORS"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[3]")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Menu " + menuOption1, "Should select menu " + menuOption1, "EXCEPTION: " + e, "FAIL");
            }
        }
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
                        lib.initializeTest.driver.FindElement(By.XPath("")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("FCF CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul[2]/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("FCF AUTO TESTING"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul[2]/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("FCF CREATE USER PROFILE"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul[2]/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("FCF APPRAISAL REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul[2]/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("FCF CREATE OUTSIDE APPRAISER"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul[2]/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                }
                else if (menuOption1.ToUpper().Equals("QUERIES"))
                {
                    queries.Click();
                    System.Threading.Thread.Sleep(waitTime);
                    if (menuOption2.ToUpper().Equals("APPLICATION"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[1]/li")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption3.ToUpper().Equals("CR CLOSING NWF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[1]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING SWG SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[2]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("ARB APPRAISAL REQUEST SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[3]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("BASE APPRAISAL REQUEST SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[4]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING ACF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[5]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING ACH SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[6]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING AGC SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[7]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING AGS SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[8]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING ARB SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[9]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING BASE SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[10]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING CFE SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[11]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING CFL SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[12]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING CKY SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[13]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING FCF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[14]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CR CLOSING PUR SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[15]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST ACF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[16]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST ACH SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[17]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST AGC SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[18]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST AGS SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[19]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST CFE SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[20]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST CFL SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[21]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST CKY SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[22]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }

                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST FCF SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[23]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST SWG SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[24]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                        }
                        if (menuOption2.ToUpper().Equals("OTHER ENTITIES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[2]/li")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                            if (menuOption3.ToUpper().Equals("NWF BE SEARCH"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul[1]/li")).Click();
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
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[1]")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                            if (menuOption3.ToUpper().Equals("PROCESS"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[1]")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                            else if (menuOption3.ToUpper().Equals("ACTIVITIES"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[2]")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                            else if (menuOption3.ToUpper().Equals("RESOURCE MONITOR"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[3]")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                        }
                        else if (menuOption3.ToUpper().Equals("ANALYTICS"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[2]")).Click();
                            System.Threading.Thread.Sleep(waitTime);
                            if (menuOption3.ToUpper().Equals("PROCESS"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[1]")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                            else if (menuOption3.ToUpper().Equals("ACTIVITIES"))
                            {
                                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[2]")).Click();
                                System.Threading.Thread.Sleep(waitTime);
                            }
                        }
                        else if (menuOption3.ToUpper().Equals("SENSORS"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='bz-wp-widget-reportsmenu-list']/li[3]")).Click();
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
        public static void selectAdminCases()
        {
            try
            {
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@id='menuListAdmin']/a")).Click();
                System.Threading.Thread.Sleep(3000);
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li[@class='category CaseAdmin']")).Click();
            }
            
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Menu" , "Should select menu", "EXCEPTION: " + e, "FAIL");
            }
        }

        public static void selectMenuYAN(String menuOption1, String menuOption2, String menuOption3)
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
                    else if (menuOption2.ToUpper().Equals("YAN CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='YAN Credit Request']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("YAN AUTO TESTING"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='YAN Auto Testing']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("YAN CREATE USER PROFILE"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='YAN Create User Profile']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
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
                        admin.Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Menu " + menuOption1, "Should select menu " + menuOption1, "EXCEPTION: " + e, "FAIL");
            }
        }

        public static void selectMenuAGC(String menuOption1, String menuOption2, String menuOption3)
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
                    else if (menuOption2.ToUpper().Equals("AGC CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='AGC Credit Request']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("AGC AUTO TESTING"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='AGC Auto Testing']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    
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
                        admin.Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Menu " + menuOption1, "Should select menu " + menuOption1, "EXCEPTION: " + e, "FAIL");
            }
        }

        public static void selectMenuACH(String menuOption1, String menuOption2, String menuOption3)
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
                    else if (menuOption2.ToUpper().Equals("ACH CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='ACH Credit Request']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    else if (menuOption2.ToUpper().Equals("ACH AUTO TESTING"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='ACH Auto Testing']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }

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
                        admin.Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
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

        public static void selectMenuCFE(String menuOption1, String menuOption2, String menuOption3)
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
                    else if (menuOption2.ToUpper().Equals("CFE CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='CFE Credit Request']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    //else if (menuOption2.ToUpper().Equals("CFE AUTO TESTING"))
                    //{
                    //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='CFE Auto Testing']")).Click();
                    //    System.Threading.Thread.Sleep(waitTime);
                    //}
                    //else if (menuOption2.ToUpper().Equals("CFE CREATE USER PROFILE"))
                    //{
                    //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='CFE Create User Profile']")).Click();
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
                        else if (menuOption3.ToUpper().Equals("CR CLOSING CFE SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='CR Closing CFE Search']")).Click();
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
                        else if (menuOption3.ToUpper().Equals("CREDIT REQUEST CFE SEARCH"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='queries']/ul/li/span[text()='Credit Request CFE Search']")).Click();
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
                        admin.Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Menu " + menuOption1, "Should select menu " + menuOption1, "EXCEPTION: " + e, "FAIL");
            }
        }

        public static void selectMenuCKY(String menuOption1, String menuOption2, String menuOption3)
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
                    else if (menuOption2.ToUpper().Equals("CKY CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='CKY Credit Request']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    //else if (menuOption2.ToUpper().Equals("CKY AUTO TESTING"))
                    //{
                    //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='CKY Auto Testing']")).Click();
                    //    System.Threading.Thread.Sleep(waitTime);
                    //}
                    //else if (menuOption2.ToUpper().Equals("CKY CREATE USER PROFILE"))
                    //{
                    //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='CKY Create User Profile']")).Click();
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
                        admin.Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Menu " + menuOption1, "Should select menu " + menuOption1, "EXCEPTION: " + e, "FAIL");
            }
        }

        public static void selectMenuNWF(String menuOption1, String menuOption2, String menuOption3)
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
                    else if (menuOption2.ToUpper().Equals("NWF CREDIT REQUEST"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='NWF Credit Request']")).Click();
                        System.Threading.Thread.Sleep(waitTime);
                    }
                    //else if (menuOption2.ToUpper().Equals("CKY AUTO TESTING"))
                    //{
                    //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='CKY Auto Testing']")).Click();
                    //    System.Threading.Thread.Sleep(waitTime);
                    //}
                    //else if (menuOption2.ToUpper().Equals("CKY CREATE USER PROFILE"))
                    //{
                    //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='categories']/ul/li/span[text()='CKY Create User Profile']")).Click();
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
                        admin.Click();
                        System.Threading.Thread.Sleep(waitTime);
                        if (menuOption2.ToUpper().Equals("CASES"))
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='category CaseAdmin']")).Click();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Menu " + menuOption1, "Should select menu " + menuOption1, "EXCEPTION: " + e, "FAIL");
            }
        }
    }

}
