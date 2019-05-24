using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using OpenQA.Selenium.IE;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace AgVueAutomation.pages
{
    //AgChoice Credit Request
    class ACHCreditRequest
    {
        public static IWebElement breadCrumbs = lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-form-process-path box-description']/p"));
        public static IWebElement applicantTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Applicants']/label"));
        public static IWebElement loanActionsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label"));
        public static IWebElement calculatorsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Calculators']/label"));
        //public static IWebElement inquiryTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Inquiry']/label"));
        public static IWebElement documentsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Documents']/label"));
        public static IWebElement newRPType = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'New')]"));
        public static IWebElement existingType = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'Existing')]"));
        // public static IWebElement newLoanActionType = lib.initializeTest.driver.FindElement(By.XPath("//div[@data-render-id='b0fdf5c0-fa55-43c5-bc4b-e9b680de5fb1']/span//..//..//div[@class='ui-radio']/label[contains(text(),'New')]"));
        // public static IWebElement servicingLoanActionType = lib.initializeTest.driver.FindElement(By.XPath("//div[@data-render-id='b0fdf5c0-fa55-43c5-bc4b-e9b680de5fb1']/span//..//..//div[@class='ui-radio']/label[contains(text(),'Servicing')]"));

        public static string readBreadCrumbs()
        {
            string str = null;
            try
            {
                str = breadCrumbs.Text;
                System.Console.WriteLine("breadCrumbs Text = " + str);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Read breadcrumbs", "Should read message from breadcrumbs", "EXCEPTION: " + e, "FAIL");
            }
            return str;
        }

        public static Boolean verifyBreadCrumbs(string str)
        {
            Boolean ret = false;
            try
            {
                string str1 = null;
                str1 = readBreadCrumbs();
                if (str.Contains(str1))
                {
                    ret = true;
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify breadcrumbs", "Should verify breadcrumbs message", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        public static Boolean selectTab(string tabName)
        {
            Boolean ret = false;
            try
            {
                if (tabName.ToUpper().Equals("APPLICANTS"))
                {
                    applicantTab.Click();
                    ret = true;
                }
                else if (tabName.ToUpper().Equals("LOAN ACTIONS"))
                {
                    loanActionsTab.Click();
                    ret = true;
                }
                else if (tabName.ToUpper().Equals("CALCULATORS"))
                {
                    calculatorsTab.Click();
                    ret = true;
                }
                //else if (tabName.ToUpper().Equals("INQUIRY"))
                //{
                //    inquiryTab.Click();
                //    ret = true;
                //}
                else if (tabName.ToUpper().Equals("DOCUMENTS"))
                {
                    documentsTab.Click();
                    ret = true;
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Tab", "Should select the tab - " + tabName, "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name: addApplicantACH
        /// Description: Should enter the below fields to add a new Applicant
        /// </summary>
        /// <param name="customerType"></param>
        /// <param name="applicantRole"></param>
        /// <param name="applicantType"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="suffix"></param>
        /// <param name="dob"></param>
        /// <param name="maritalStatus"></param>
        /// <param name="employer"></param>
        /// <param name="taxIdNo"></param>
        /// <param name="taxExempt"></param>
        /// <param name="conflictOfInterest"></param>
        /// <param name="address1"></param>
        /// <param name="address2"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="zipCodeExt"></param>
        /// <param name="emailAddress"></param>
        /// <param name="homePhoneCode"></param>
        /// <param name="homePhone"></param>
        /// <param name="workPhoneCode"></param>
        /// <param name="workPhone"></param>
        /// <param name="workPhoneExt"></param>
        /// <param name="faxCode"></param>
        /// <param name="faxNumber"></param>
        /// <param name="MobilePhoneCode"></param>
        /// <param name="MobilePhone"></param>
        /// <returns></returns>
        
        public static Boolean addApplicantACH(string customerType, string applicantRole, string applicantType, string firstName, string middleName, string lastName, string suffix, string dob, string maritalStatus, string employer, string taxIdNo, string taxExempt, string conflictOfInterest, string address1, string address2, string city, string state, string zipCode, string zipCodeExt, string popcountyname, string popCountyCode, string emailAddress, string homePhoneCode, string homePhone, string workPhoneCode, string workPhone, string workPhoneExt, string faxCode, string faxNumber, string MobilePhoneCode, string MobilePhone)
        {
            Boolean ret = false;
            string str = "";
            try
            {
                selectTab("Applicants");
                newRPType.Click();
                System.Threading.Thread.Sleep(8000);
                //Click on the + Link to add applicant
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='PRC_ACR_CreditRequest_entBE_colApplicants']/div/div[2]/div[3]/table/tbody/tr/th[1]/div/div/ul/li[1]/div")).Click();
                if (lib.initializeTest.driver.FindElement(By.XPath("html/body/div[6]")).Displayed)
                {
                    lib.resultUtil.AddResult("Add applicants screen", "After clicking on << + >>link Add applicants screen should display", "Add applicants screen displayed", "PASS");
                    //Select Customer Type
                    if (customerType != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='37b72e42-7308-4acc-b740-a45e84b836fa']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='dd-37b72e42-7308-4acc-b740-a45e84b836fa']/ul/li[text()='" + customerType + "']")).Click();
                        lib.resultUtil.AddResult("Select Customer Type", "Should select <<'" + customerType + "'>> for Customer Type", "Selected <<'" + customerType + "'>> for Customer Type", "PASS");
                    }
                    //Select Applicant Role
                    if (applicantRole != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='3d807d0e-4325-468c-9cc8-e859fd465660']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='dd-3d807d0e-4325-468c-9cc8-e859fd465660']/ul/li[text()='" + applicantRole + "']")).Click();
                        lib.resultUtil.AddResult("Select Applicant Role", "Should select <<" + applicantRole + ">> for Applicant Role", "Selected <<" + applicantRole + ">> for Applicant Role", "PASS");
                    }
                    //Select Applicant Type
                    if (applicantType != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='a43db5b4-cb7d-44ab-950a-2bd51be450b5']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='dd-a43db5b4-cb7d-44ab-950a-2bd51be450b5']/ul/li[text()='" + applicantType + "']")).Click();
                        lib.resultUtil.AddResult("Select Applicant Type", "Should select <<" + applicantType + ">> for Applicant Type", "Selected <<" + applicantType + ">> for Applicant Type", "PASS");
                    }
                    //Enter First Name
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sFirstName']/div/div/div[1]/input")).SendKeys(firstName);
                    lib.resultUtil.AddResult("Enter First Name", "Should enter First name", "Entered <<" + firstName + ">> for First name", "PASS");
                    //Enter Middle Name
                    if (middleName != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sMiddleName']/div/div/div[1]/input")).SendKeys(middleName);
                        lib.resultUtil.AddResult("Enter Middle Name", "Should enter Middle name", "Entered <<" + middleName + ">> for Middle name", "PASS");
                    }
                    //Enter Last Name
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sLastName']/div/div/div[1]/input")).SendKeys(lastName);
                    lib.resultUtil.AddResult("Enter Last Name", "Should enter Last name", "Entered <<" + lastName + ">> for Last name", "PASS");

                    //Select Suffix
                    if (suffix != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='32772719-0ebf-44fa-9d3e-87ac201e31ac']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='dd-32772719-0ebf-44fa-9d3e-87ac201e31ac']/ul/li[text()='" + suffix + "']")).Click();
                        lib.resultUtil.AddResult("Select Suffix", "Should select <<" + suffix + ">> for Suffix", "Selected <<" + suffix + ">> for Suffix", "PASS");
                    }
                    //Select Date of Birth                    
                    if (dob != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dDateofBirth']/div/div/div/div/span/input")).SendKeys(dob);
                        lib.resultUtil.AddResult("Enter Date of birth", "Should enter Date of birth", "Entered <<" + dob + ">> for Date of birth", "PASS");
                    }
                    //Select Marital Status
                    if (maritalStatus != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='f6a21af6-a4ec-4a30-b996-14691f9c4075']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='dd-f6a21af6-a4ec-4a30-b996-14691f9c4075']/ul/li[text()='" + maritalStatus + "']")).Click();
                        lib.resultUtil.AddResult("Select Marital Status", "Should select <<" + maritalStatus + ">> for Marital Status", "Selected <<" + maritalStatus + ">> for Marital Status", "PASS");
                    }
                    //Enter Employer
                    if (employer != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sEmployer']/div/div/div[1]/input")).SendKeys(employer);
                        lib.resultUtil.AddResult("Enter Employer", "Should enter Employer", "Entered <<" + employer + ">> for Employer", "PASS");
                    }
                    //Enter Tax ID Number
                    if (taxIdNo != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sTaxIDNumber']/div/div/div[1]/input")).SendKeys(taxIdNo);
                        lib.resultUtil.AddResult("Enter Tax Id Number", "Should enter Tax Id Number", "Entered <<" + taxIdNo + ">> for Tax Id Number", "PASS");
                    }
                    //Check Tax Exempt
                    if (taxExempt.ToUpper().Equals("Yes"))
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bIsTaxExempt']/div/div/div[1]/div/label")).Click();
                        lib.resultUtil.AddResult("Select Tax Exempt", "Should select Tax exempt check box", "Selected <<Tax exempt>> check box", "PASS");
                    }
                    //Select Conflict of Interest
                    if (conflictOfInterest != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='8cbff5a0-f662-45a7-8b56-8f38d2abbef4']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='dd-8cbff5a0-f662-45a7-8b56-8f38d2abbef4']/ul/li[text()='" + conflictOfInterest + "']")).Click();
                        lib.resultUtil.AddResult("Select Conflict of Interest", "Should select <<" + conflictOfInterest + ">> for Conflict of Interest", "Selected <<" + conflictOfInterest + ">> for Conflict of Interest", "PASS");
                    }
                    //Enter Address1
                    if (address1 != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sAddress1']/div/div/div[1]/input")).SendKeys(address1);
                        lib.resultUtil.AddResult("Enter Address1", "Should enter Address1", "Entered <<" + address1 + ">> for Address1", "PASS");
                    }
                    //Enter Address2
                    if (address2 != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sAddress2']/div/div/div[1]/input")).SendKeys(address2);
                        lib.resultUtil.AddResult("Enter Address2", "Should enter Address2", "Entered <<" + address2 + ">> for Address2", "PASS");
                    }
                    //Enter City
                    if (city != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sCity']/div/div/div[1]/input")).SendKeys(city);
                        lib.resultUtil.AddResult("Enter City", "Should enter City", "Entered <<" + city + ">> for City", "PASS");
                    }
                    //Select State                   
                    if (state != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ab3e2734-6a33-42a1-bf63-6c20ef05db9f']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='dd-ab3e2734-6a33-42a1-bf63-6c20ef05db9f']/ul/li[text()='" + state + "']")).Click();
                        lib.resultUtil.AddResult("Select State", "Should select <<" + state + ">> for State", "Selected <<" + state + ">> for State", "PASS");
                    }
                    //Enter Zipcode
                    if (zipCode != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sZipCode']/div/div/div[1]/input")).SendKeys(zipCode);
                        lib.resultUtil.AddResult("Enter Zipcode", "Should enter Zipcode", "Entered <<" + zipCode + ">> for Zipcode", "PASS");
                    }
                    
                    //Enter ZipCode Extension
                    if (zipCodeExt != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sZipCodeExt']/div/div/div[1]/input")).SendKeys(zipCodeExt);
                        lib.resultUtil.AddResult("Enter Zipcode Extension", "Should enter Zipcode Extension", "Entered <<" + zipCodeExt + ">> for Zipcode Extension", "PASS");
                    }
                    System.Threading.Thread.Sleep(5000);
                    //Verify the County Name
                    string CountyName = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sCountyName']/div/div/div/label")).GetAttribute("value");
                    if (CountyName == popcountyname)
                    {
                        lib.resultUtil.AddResult("Verify the County Name", "The County Name should be displayed as <<" + popcountyname + ">> ", "The County Name is displayed as <<" + popcountyname + ">> ", "PASS");

                    }
                    //Verify the County Code
                    string CountyCode = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sCountyCode']/div/div/div/label")).GetAttribute("value");
                    if (CountyCode == popCountyCode)
                    {
                        lib.resultUtil.AddResult("Verify the County Code", "The County Code should be displayed as <<" + popCountyCode + ">> ", "The County Code is displayed as << " + popCountyCode + " >> ", "PASS");

                    }
                    //Enter Email Address
                    if (emailAddress != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sEmailAddress']/div/div/div[1]/input")).SendKeys(emailAddress);
                        lib.resultUtil.AddResult("Enter Email address", "Should enter Email address", "Entered <<" + emailAddress + ">> for Email address", "PASS");
                    }
                    //Enter Home Phone code
                    if (homePhoneCode != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sHomePhoneAreaCode']/div/div/div[1]/input")).SendKeys(homePhoneCode);
                        lib.resultUtil.AddResult("Enter Home phone area code", "Should enter Home phone area code", "Entered <<" + homePhoneCode + ">> for Home phone area code", "PASS");
                    }
                    //Enter Home Phone number
                    if (homePhone != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sHomePhone']/div/div/div[1]/input")).SendKeys(homePhone);
                        lib.resultUtil.AddResult("Enter Home phone", "Should enter Home phone", "Entered <<" + homePhone + ">> for Home phone", "PASS");
                    }
                    //Enter Work Phone code
                    if (workPhoneCode != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sWorkPhoneAreaCode']/div/div/div[1]/input")).SendKeys(workPhoneCode);
                        lib.resultUtil.AddResult("Enter Work phone area code", "Should enter Work phone area code", "Entered <<" + workPhoneCode + ">> for Work phone area code", "PASS");
                    }
                    //Enter Work Phone number
                    if (workPhone != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sWorkPhone']/div/div/div[1]/input")).SendKeys(workPhone);
                        lib.resultUtil.AddResult("Enter work phone", "Should enter work phone", "Entered <<" + workPhone + ">> for Work phone", "PASS");
                    }
                    //Enter Work phone extension
                    if (workPhoneExt != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sWorkPhoneExtension']/div/div/div[1]/input")).SendKeys(workPhoneExt);
                        lib.resultUtil.AddResult("Enter Work phone extension", "Should enter Work phone extension", "Entered <<" + workPhoneExt + ">> for Work phone extension", "PASS");
                    }
                    //Enter Fax code
                    if (faxCode != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sFaxNumberAreaCode']/div/div/div[1]/input")).SendKeys(faxCode);
                        lib.resultUtil.AddResult("Enter Fax number area code", "Should enter Fax number area code", "Entered <<" + faxCode + ">> for Fax number area code", "PASS");
                    }
                    //Enter Fax Phone number
                    if (faxNumber != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sFaxNumber']/div/div/div[1]/input")).SendKeys(faxNumber);
                        lib.resultUtil.AddResult("Enter Fax number", "Should enter Fax number", "Entered <<" + faxNumber + ">> for Fax number", "PASS");
                    }
                    //Enter Mobile code
                    if (MobilePhoneCode != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sMobilePhoneAreaCode']/div/div/div[1]/input")).SendKeys(MobilePhoneCode);
                        lib.resultUtil.AddResult("Enter Mobile phone area code", "Should enter Mobile phone area code", "Entered <<" + MobilePhoneCode + ">> for Mobile phone area code", "PASS");
                    }
                    //Enter Mobile Phone number
                    if (MobilePhone != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sMobilePhone']/div/div/div[1]/input")).SendKeys(MobilePhone);
                        lib.resultUtil.AddResult("Enter Mobile phone number", "Should enter Mobile phone number", "Entered <<" + MobilePhone + ">> for Mobile phone number", "PASS");
                    }
                    lib.initializeTest.driver.FindElement(By.XPath("html/body/div[6]/div[3]/div/button[1]")).Click();
                    System.Threading.Thread.Sleep(3000);
                    System.Console.WriteLine("Text= " + lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='PRC_ACR_CreditRequest_entBE_colApplicants']/div/div[2]/div[1]/table/tbody/tr/td[2]/div/div/div/label")).Text);
                    if (middleName != "")
                    {
                        str = firstName + " " + middleName + " " + lastName;
                    }
                    else
                    {
                        str = firstName + " " + lastName;
                    }
                    if (suffix != "")
                    {
                        str = str + " " + suffix;
                    }
                    System.Console.WriteLine("Str = " + str);
                    if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='PRC_ACR_CreditRequest_entBE_colApplicants']/div/div[2]/div[1]/table/tbody/tr/td[2]/div/div/div/label")).Text.Equals(str))
                    {
                        lib.resultUtil.AddResult("Add Applicant", "Applicant should add successfully", "Applicant <<" + str + ">> added successfully", "PASS");
                    }
                    else
                    {
                        lib.resultUtil.AddResult("Add Applicant", "Applicant should add successfully", "Applicant <<" + str + ">> NOT added successfully", "FAIL");
                    }
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add applicant", "Should add applicant", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : addResponsiblePartyACH
        /// Description : Should Enter the below fields to update responsible party and other field values
        /// </summary>
        /// <param name="rpName"></param>
        /// <param name="involvementInFarming"></param>
        /// <returns></returns>
        public static Boolean addResponsiblePartyACH(string rpName, string involvementInFarming)
        {
            Boolean ret = false;
            try
            {
                //Enter RP Name
                if (rpName != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='RP Name']/../../div/div/div/input")).SendKeys(rpName);
                    lib.resultUtil.AddResult("Enter RP name", "Should enter <<" + rpName + ">> for RP Name", "Entered <<" + rpName + ">> for RP Name", "PASS");
                }

                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='PRC_ACR_CreditRequest_entBE_colApplicants']/div/div[2]/div[3]/table/tbody/tr/th[1]/div/div/ul/li[1]/div"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                //Select Involvement In Farming
                if (involvementInFarming != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Involvement In Farming']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Involvement In Farming']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + involvementInFarming + "']")).Click();
                    lib.resultUtil.AddResult("Select Involvement In Farming", "Should select <<" + involvementInFarming + ">> for Involvement In Farming", "Selected <<" + involvementInFarming + ">> for Involvement In Farming", "PASS");
                }
                //Click on Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(3000);

                // Scroll to the top of the Page
                IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']/p"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Responsible Party", "Should add Responsible Party", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : addLoanActionsACH
        /// Description : Should Enter the below fields to Add a new Loan Action
        /// </summary>
        /// <param name="loanOfficer"></param>
        /// <param name="financialSpecialist"></param>
        /// <param name="branch"></param>
        /// <param name="underwritingType"></param>
        /// <param name="loanAmount"></param>
        /// <param name="loanPurpose"></param>
        /// <returns></returns>

        public static Boolean addLoanActionsACH(string loanOfficer, string financialSpecialist, string branch, string underwritingType, string loanActionCode, string term, string loanAmount, string loanPurpose)
        {
            Boolean ret = false;
            try
            {
                //Select the Loan Actions Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                //System.Threading.Thread.Sleep(2000);
                //Select loan Officer
                if (loanOfficer != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Officer']//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Officer']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanOfficer + "']")).Click();
                    lib.resultUtil.AddResult("Select Account Officer", "Should select <<" + loanOfficer + ">> ", "Selected <<" + loanOfficer + ">> ", "PASS");
                }

                //Select Financial Specialist
                if (financialSpecialist != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Financial Specialist']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Financial Specialist']/../../div/div[@class='ui-select-dropdown open']/ul/li[contains(text(),'" + financialSpecialist + "')]")).Click();
                    lib.resultUtil.AddResult("Select Loan Specialist", "Should select <<" + financialSpecialist + ">> ", "Selected <<" + financialSpecialist + ">> ", "PASS");
                }
                
                //Select Branch
                if (branch != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Branch']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Branch']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + branch + "']")).Click();
                    lib.resultUtil.AddResult("Select Branch", "Should select <<" + branch + ">> for Branch", "Selected <<" + branch + ">> for Branch", "PASS");
                }
                //Select Underwriting Type
                if (underwritingType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Underwriting Type']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Underwriting Type']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + underwritingType + "']")).Click();
                    lib.resultUtil.AddResult("Select Underwriting Type", "Should select <<" + underwritingType + ">> ", "Selected <<" + underwritingType + ">>", "PASS");
                }

                //Scroll to view
                IWebElement hlog = lib.initializeTest.driver.FindElement(By.XPath(".//a[contains(text(),'History Log')]"));
                IJavaScriptExecutor elem = (IJavaScriptExecutor)lib.initializeTest.driver;
                elem.ExecuteScript("arguments[0].scrollIntoView(true);", hlog);

                //Click on the + Link to add Loan Actions(Compliance Check)
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@title='Add Loan Actions (UComply)']/div")).Click();
                //System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title']")).Displayed)
                {
                    lib.resultUtil.AddResult("Add Loan Actions(UComply) screen", "After clicking on + link Add Loan Actions(UComply) screen should display", "Add Loan Actions(UComply) screen displayed", "PASS");

                    //Select the Loan Action Type ( New )
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Type']/../../span/../div/div/div[1]/span/span[1]/div/label[contains(text(),'New')]")).Click();
                    lib.resultUtil.AddResult("Add Loan Action Type as New", "Should be able to select new option", "Selected New option", "PASS");

                    System.Threading.Thread.Sleep(2000);
                    //Select Loan Action Code 
                    if (loanActionCode != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Code']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Code']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanActionCode + "']")).Click();
                        lib.resultUtil.AddResult("Select Loan Action Code", "Should select <<" + loanActionCode + ">> for Loan Action Code", "Selected <<" + loanActionCode + ">> for Loan Action Code", "PASS");
                    }

                    //Select Get Results button
                    lib.initializeTest.driver.FindElement(By.XPath(".//input[@title='Get Results']")).Click();
                    lib.resultUtil.AddResult("Select Get Results button", "Should be able to select Get Results button", "Selected Get Results button", "PASS");


                    System.Threading.Thread.Sleep(10000);
                    //Enter Term(Months)
                    if (term != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='iTermMonths']/div/div/div[1]/input")).SendKeys(term);
                        lib.resultUtil.AddResult("Enter Term in Months number", "Should enter Term in Months", "Entered <<" + term + ">> for Term", "PASS");
                    }
                    // Enter Loan Amount
                    if (loanAmount != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='cPrimaryLoanAmount']/div/div/div[1]/input")).SendKeys(loanAmount);
                        lib.resultUtil.AddResult("Enter Loan Amount", "Should enter Loan Amount", "Entered <<" + loanAmount + ">> for Loan Amount", "PASS");
                    }

                    System.Threading.Thread.Sleep(2000);
                    //Select Loan Purpose
                    if (loanPurpose != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Purpose']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Purpose']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanPurpose + "']")).Click();
                        lib.resultUtil.AddResult("Select Loan Purpose", "Should select <<" + loanPurpose + ">> for Loan Purpose", "Selected <<" + loanPurpose + ">> for Loan Purpose", "PASS");
                    }
                    //Click on the Save Button
                    lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='Save']")).Click();
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Loan Actions", "Should add Loan Actions", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : addinquiryDecisionACH
        /// Description : Should Enter the below fields to add inquiry decision
        /// </summary>
        /// <param name="inquiryDecision"></param>
        /// <param name="appCurrentDate"></param>
        /// <param name="inquiryComments"></param>
        /// <returns></returns>

        public static Boolean addinquiryDecisionACH(string inquiryDecision, string appCurrentDate, string inquiryComments)
        {
            Boolean ret = false;
            try
            {
                // Scroll to the top of the Page
                IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']/p"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);
                System.Threading.Thread.Sleep(2000);

                //Select Inquiry Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Inquiry']/label")).Click();
                lib.resultUtil.AddResult("Select Inquiry Tab", "Should select Inquiry Tab", "Selected <<Inquiry Tab>>", "PASS");
                System.Threading.Thread.Sleep(2000);

                //Select Inquiry Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entInquiryDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + inquiryDecision + "')]")).Click();
                lib.resultUtil.AddResult("Select option <<" + inquiryDecision + ">> for Inquiry Decision", "Should select option <<" + inquiryDecision + ">> for Inquiry Decision", "Successfully selected option <<" + inquiryDecision + ">> for Inquiry Decision", "PASS");

                //Enter Valid Application Date
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/div/span/input")).Clear();
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/div/span/input")).SendKeys(appCurrentDate);
                lib.resultUtil.AddResult("Enter Application Date", "Should enter Valid Application Date", "Entered <<" + appCurrentDate + ">> for Application Date", "PASS");

                // Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton2']")).Click();
                System.Threading.Thread.Sleep(15000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Inquiry Decision", "Should Add Inquiry Decison", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : addCollateralandApplicationACH
        /// Description : Should check the collateral and process the application
        /// </summary>
        /// <param name="appDecision"></param>
        /// <param name="appComments"></param>
        /// <returns></returns>
        public static Boolean addCollateralandApplicationACH(string appDecision, string appComments)
        {
            Boolean ret = false;

            try
            {
                // Scroll to the view
                IWebElement elem3 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-id='c9c5ab0d-7560-4f6e-ad1d-dcbff28371e3']/span/label[text()='RP Name']"));
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js3.ExecuteScript("arguments[0].scrollIntoView(true);", elem3);

                //Select Application Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Application']/label")).Click();
                lib.resultUtil.AddResult("Select Application Tab", "Should select Application Tab", "Selected Application Tab", "PASS");
                System.Threading.Thread.Sleep(2000);

                //Select Application Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entApplicationDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + appDecision + "')]")).Click();
                lib.resultUtil.AddResult("Select option <<" + appDecision + ">> for Application Decision", "Should select option <<" + appDecision + ">> for Application Decision", "Successfully selected option <<" + appDecision + ">> for Application Decision", "PASS");

                System.Threading.Thread.Sleep(3000);
                //Enter Application Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).SendKeys(appComments);
                lib.resultUtil.AddResult("Enter Application Comments", "Should enter Application Comments", "Entered <<" + appComments + ">> for Application Comments", "PASS");

                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton2']")).Click();
                System.Threading.Thread.Sleep(7000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Collateral and Application", "Should Add Collateral and Application", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : EditLoanActionACH
        /// Description : Click on "Edit New Loan Actions" icon to edit the loan action for which status is mentioned as "Edits Required"
        /// </summary>
        /// <param name="approvalAuthority"></param>
        /// <param name="futureClosingDate"></param>
        /// <param name="consumerLoantype"></param>
        /// <param name="feeType"></param>
        /// <param name="feeAmount"></param>
        /// <param name="policyAmount"></param>
        /// <param name="exceptionComment"></param>
        /// <param name="subsidary"></param>
        /// <param name="termType"></param>
        /// <param name="loanType"></param>
        /// <param name="fcaLoanType"></param>
        /// <param name="primSICCode"></param>
        /// <param name="secSICCode"></param>
        /// <param name="primSICDep"></param>
        /// <param name="secSICDep"></param>
        /// <param name="accSystem"></param>
        /// <param name="secLoan"></param>
        /// <param name="rateType"></param>
        /// <param name="stateRate"></param>
        /// <param name="lenderDecision"></param>
        /// <returns></returns>
        public static Boolean EditLoanActionACH(string approvalAuthority, string futureClosingDate, string consumerLoantype, string feeType, string feeAmount, string policyAmount, string exceptionComment, string subsidary, string termType, string loanType, string fcaLoanType, string govtGuarantee, string primSICCode, string secSICCode, string primSICDep, string secSICDep, string accSystem, string secLoan, string rateType, string stateRate, string lenderDecision)
        {
            Boolean ret = false;

            try
            {
                System.Threading.Thread.Sleep(3000);
                //Select Loan Action Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected Loan Action Tab", "PASS");

                //Select Approval Authority
                if (approvalAuthority != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']/../../div/div[@class='ui-select-dropdown open']/ul/li[contains(text(),'" + approvalAuthority + "')]")).Click();
                    lib.resultUtil.AddResult("Select Loan Specialist", "Should select <<" + approvalAuthority + ">> ", "Selected <<" + approvalAuthority + ">> ", "PASS");
                }

                // Scroll to the view
                IWebElement elem5 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-id='9af28d66-5fb1-4db3-8178-3fe78429a987']/span/label[text()='Loan Action edits are required.']"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", elem5);

                //Click on Edit Loan Action Button
                lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='New Loan Actions (UComply)']/../../div/div/table[@class='ui-bizagi-grid-table ']/tbody/tr/td[13]/div/div/span/div/button[@id='ui-icon-action-edit']/i")).Click();
                lib.resultUtil.AddResult("Click on Edit Loan Action Button", "Should click on Edit Loan Action Button", "Clicked on <<Edit Loan Action Button>>", "PASS");

                // Verify whether the Edit New Loan Actions box Opens
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title' and contains(text(),'Edit New Loan Actions')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify whether the Edit New Loan Actions box Opens", "Edit New Loan Actions box should open", "Edit New Loan Actions box is opened Successfully", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify whether the Edit New Loan Actions box Opens", "Edit New Loan Actions box should open", "Edit New Loan Actions box is NOT opened", "FAIL");
                }

                //Enter the valid Estimated closing Date
                if (futureClosingDate != "")
                {
                    //Enter the date
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/div/span/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/div/span/input")).SendKeys(futureClosingDate);
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionType']/div/div")).Click();
                    lib.resultUtil.AddResult("Enter Estimated Closing Date", "Should enter Valid Estimated Closing Date", "Entered <<" + futureClosingDate + ">> for Estimated Closing Date", "PASS");
                }
                
                // NAVIGATE TO FEES TAB
                // Click on the Fees tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Fees']/label")).Click();
                lib.resultUtil.AddResult("Click on Fees tab", "Should Click on Fees tab", "Clicked on <<Fees tab>>", "PASS");

                // Click on Add Loan Action Fees(+ button)
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@title='Add Loan Action Fees']")).Click();
                lib.resultUtil.AddResult("Click on Add Loan Action Fees button", "Should Click on Add Loan Action Fees button", "Clicked on <<Add Loan Action Fees>> button", "PASS");

                // Select Fee Type
                if (feeType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entFeeType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + feeType + "']")).Click();
                    lib.resultUtil.AddResult("Select Fee Type", "Should select Fee Type", "Selected <<" + feeType + ">>Fee Type", "PASS");
                }

                // Enter Fee Amount
                if (feeAmount != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='cAmount']/div/div/div/input")).SendKeys(feeAmount);
                    lib.resultUtil.AddResult("Enter Amount", "Should enter Amount", "Entered <<" + feeAmount + ">> for Amount", "PASS");
                }

                // Select Payment Method (Financed)
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entPaymentMethod']/div/div/div/span/span/div/label[contains(text(),'Financed')]")).Click();
                lib.resultUtil.AddResult("Select Payment Method", "Should select Payment Method", "Successfully selected <<Payment Method>>", "PASS");

                //Select Fee Exception Check Box
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bFeeException']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Fee Exception Check Box", "Should select Fee Exception Check Box", "Successfully selected <<Fee Exception>> Check Box", "PASS");
                
                // Enter Policy Amount
                if (policyAmount != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='cPolicyAmount']/div/div/div/input")).SendKeys(policyAmount);
                    lib.resultUtil.AddResult("Enter Policy Amount", "Should enter Policy Amount", "Entered <<" + policyAmount + ">> for Policy Amount", "PASS");
                }

                // Enter Exception Comments
                if (exceptionComment != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sExceptionComments']/div/div/div/input")).SendKeys(exceptionComment);
                    lib.resultUtil.AddResult("Enter Exception Comments", "Should enter Exception Comments", "Entered <<" + exceptionComment + ">> for Exception Comments", "PASS");
                }

                //Click on Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//*[text()='Add Loan Action Fees']//..//..//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                lib.resultUtil.AddResult("Click on Save Button", "Should click on Save Button", "Clicked on <<Save>> Button", "PASS");
                System.Threading.Thread.Sleep(5000);

                //Select the Coding Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Coding']/label")).Click();
                lib.resultUtil.AddResult("Click on Coding Tab", "Should click on Coding Tab", "Clicked on <<Coding Tab>>", "PASS");

                //Select the Subsidary radio Button
                if (subsidary != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entSubsidiary']/div/div/div[1]/span/span/div/label[contains(text(),'" + subsidary + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Subsidary Radio Button", "Should select Subsidary Radio Button", "Selected <<" + subsidary + ">> for Subsidary Radio Button", "PASS");
                }
                System.Threading.Thread.Sleep(2000);
                //Select Term Type
                if (termType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entTermType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + termType + "']")).Click();
                    lib.resultUtil.AddResult("Select Term Type", "Should select Term Type", "Selected <<" + termType + ">> for Term Type", "PASS");
                }
                //Select Loan Type
                if (loanType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + loanType + "']")).Click();
                    lib.resultUtil.AddResult("Select Loan Type", "Should select Loan Type", "Selected <<" + loanType + ">> for Loan Type", "PASS");
                }

                System.Threading.Thread.Sleep(2000);
                //Select FCA Loan Type
                if (fcaLoanType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entFCALoanType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + fcaLoanType + "']")).Click();
                    lib.resultUtil.AddResult("Select FCA Loan Type", "Should select FCA Loan Type", "Selected <<" + fcaLoanType + ">> for FCA Loan Type", "PASS");
                }

                //Select Government Guarantee
                if (govtGuarantee != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entGovernmentGuarantee']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + govtGuarantee + "']")).Click();
                    lib.resultUtil.AddResult("Select Government Guarantee", "Should select Government Guarantee", "Selected <<" + govtGuarantee + ">> for FCA Loan Type", "PASS");
                }

                //Select Primary SIC Code
                if (primSICCode != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanPrimarySICCode']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + primSICCode + "']")).Click();
                    lib.resultUtil.AddResult("Select Primary SIC Code", "Should select Primary SIC Code", "Selected <<" + primSICCode + ">> for Primary SIC Code", "PASS");
                }

                //Select the Primary SIC Dependency radio Button
                if (primSICDep != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entPrimarySICDependency']/div/div/div[1]/span/span/div/label[contains(text(),'" + primSICDep + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Primary SIC Dependency Radio Button", "Should select Primary SIC Dependency Radio Button", "Selected <<" + primSICDep + ">> for Primary SIC Dependency Radio Button", "PASS");
                }

                //Select Secondary SIC Code
                if (secSICCode != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanSecondarySICCode']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + secSICCode + "']")).Click();
                    lib.resultUtil.AddResult("Select Secondary SIC Code", "Should select Secondary SIC Code", "Selected <<" + secSICCode + ">> for Secondary SIC Code", "PASS");
                }

                //Select the Secondary SIC Dependency radio Button
                if (secSICDep != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entSecondarySICDependency']/div/div/div[1]/span/span/div/label[contains(text(),'" + secSICDep + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Secondary SIC Dependency Radio Button", "Should select Secondary SIC Dependency Radio Button", "Selected <<" + secSICDep + ">> for Secondary SIC Dependency Radio Button", "PASS");
                }

                //Select the Accounting System radio Button
                if (accSystem != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entACR_M_LoanActionDetails.entAccountingSystem']/div/div/div[1]/span/span/div/label[contains(text(),'" + accSystem + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Accounting System Radio Button", "Should select Accounting System Radio Button", "Selected <<" + accSystem + ">> for Accounting System Radio Button", "PASS");
                }

                //Select the Secured Loan radio Button as No
                if (secLoan != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bSecuredLoan']/div/div/div/div/div/label[contains(text(),'" + secLoan + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Secured Loan Radio Button", "Should select Secured Loan Radio Button", "Selected <<" + secLoan + ">> for Secured Loan Radio Button", "PASS");
                }

                // Scroll to the view
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Rate and Terms']/label"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                // Select the Rate and Terms tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Rate and Terms']/label")).Click();
                lib.resultUtil.AddResult("Select Rate and Terms tab", "Should select Rate and Terms tab", "Selected <<Rate and Terms>> tab", "PASS");

                //Select Rate Type
                if (rateType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entRateType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + rateType + "']")).Click();
                    lib.resultUtil.AddResult("Select Rate Type", "Should select Rate Type", "Selected <<Rate Type>>", "PASS");
                }
                //Enter the Estimated State Rate
                if (stateRate != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='fEstimatedStatedRate']/div/div/div/input")).SendKeys(stateRate);
                    lib.resultUtil.AddResult("Enter the Estimated State Rate", "Should enter the Estimated State Rate", "Entered <<" + stateRate + ">> Estimated State Rate", "PASS");
                }
                
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(3000);

                //Click on the Save Button
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                //System.Threading.Thread.Sleep(6000);

                // Scroll to the view
                IWebElement elem3 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-id='c9c5ab0d-7560-4f6e-ad1d-dcbff28371e3']/span/label[text()='RP Name']"));
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js3.ExecuteScript("arguments[0].scrollIntoView(true);", elem3);

                //Verify whether the Loan Package Tab is Displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Package']/label")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Package']/label")).Click();
                    lib.resultUtil.AddResult("Select Loan Package Tab", "Should select Loan Package Tab", "Selected <<Loan Package Tab>>", "PASS");
                    System.Threading.Thread.Sleep(2000);
                }

                //Select Lender Decision 
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entLenderDecision']/div/div/div[1]/span/span[1]/div/label[contains(text(),'" + lenderDecision + "')]")).Click();
                lib.resultUtil.AddResult("Select option for Lender Decision", "Should select option for Lender Decision", "Successfully selected option for Lender Decision", "PASS");

                //Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton2']")).Click();
                lib.resultUtil.AddResult("Select Submit button", "Should select Submit button", "Selected Submit button", "PASS");
                System.Threading.Thread.Sleep(10000);

            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Edit Loan Action", "Should Edit Loan Action", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }        
        
        //Search case ID in the search box
        public static void searchCaseId(string casIn)
        {
            try
            {
                if (casIn != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).Clear();
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
        
        
        public static string readProcessStatge()
        {
            string str = null;
            try
            {
                str = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entProcessStage']/div/div")).Text;
                System.Console.WriteLine("Process Stage Text = " + str);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Read Process Stage", "Should read Process Stage", "EXCEPTION: " + e, "FAIL");
            }
            return str;
        }

        public static Boolean verifyProcessStage(string str)
        {
            Boolean ret = false;
            try
            {
                string str1 = null;
                str1 = readProcessStatge();
                if (str.Contains(str1))
                {
                    ret = true;
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Process Stage", "Should verify Process Stage", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : assignAnalystACH
        /// Description : Assign credit analyst
        /// </summary>
        /// <param name="assignAnalyst"></param>
        /// <param name="creditAnalyst"></param>
        /// <returns></returns>

        // Assign the Credit Analyst
        public static Boolean assignAnalystACH(string assignAnalyst, string creditAnalyst)
        {
            Boolean ret = false;
            try
            {
                //Select Assign Analyst button
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAssignAnalystDecision']/div/div/div/span/span/div/label[contains(text(),'" + assignAnalyst + "')]")).Click();
                lib.resultUtil.AddResult("Select option <<" + assignAnalyst + ">> for Lender Decision", "Should select option <<" + assignAnalyst + ">> for AssignAnalyst Decision", "Successfully selected option <<" + assignAnalyst + ">> for AssignAnalyst Decision", "PASS");

                //Scroll to view
                IWebElement crdtanalyst = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.entUnderwritingType.iSLAWorkingDays']/span/label[contains(text(),'Expected Duration of Analysis')]"));
                IJavaScriptExecutor elem = (IJavaScriptExecutor)lib.initializeTest.driver;
                elem.ExecuteScript("arguments[0].scrollIntoView(true);", crdtanalyst);

                //Select Credit Analyst
                if (creditAnalyst != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Credit Analyst']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Credit Analyst']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + creditAnalyst + "']")).Click();
                    lib.resultUtil.AddResult("Select Credit Analyst", "Should select <<" + creditAnalyst + ">> for Credit Analyst", "Selected <<" + creditAnalyst + ">> for Credit Analyst", "PASS");
                }

                //Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Assign Analyst", "Should Verify Assign Analyst", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : acceptAnalysisACH
        /// Description : Accept credit request
        /// </summary>
        /// <param name="acceptanceDecision"></param>
        /// <returns></returns>
       
        //Select Accepted for acceptance decision and submit
        public static Boolean acceptAnalysisACH(string acceptanceDecision)
        {
            Boolean ret = false;
            try
            {
                // Select 'Accepted' for Acceptance Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAcceptanceDecision']/div/div/div/span/span/div/label[contains(text(),"+ acceptanceDecision +")]")).Click();
                lib.resultUtil.AddResult("Select << "+ acceptanceDecision +" >> option for Acceptance Decision", "Should select << " + acceptanceDecision + " >> option for Acceptance Decision", "Selected << " + acceptanceDecision + " >> option for Acceptance Decision", "PASS");
              
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Accept Analysis", "Should verify Accept Analysis", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : creditAnalysisACH
        /// Description : Should enter the values for assigned PD and assignedLGD and start date. Then recommend it for further process
        /// </summary>
        /// <param name="assignedPD"></param>
        /// <param name="assignedLGD"></param>
        /// <returns></returns>

        // Select recommended for analyst decision
        public static void creditAnalysisACH(string assignedPD, string assignedLGD)
        {
            try
            {
                // Select the Analysis Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Analysis']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Analysis']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Analysis']")).Click();
                lib.resultUtil.AddResult("Select the Analysis Tab", "Should Select the Analysis Tab", "Selected the Analysis Tab", "PASS");

                //Scroll Into View
                IWebElement calcPD = lib.initializeTest.driver.FindElement(By.XPath(".//*[text()='Calculate PD Value']"));
                IJavaScriptExecutor jsc1 = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc1.ExecuteScript("arguments[0].scrollIntoView(true);", calcPD);

                   
                //Select Assigned PD 
                if (assignedPD != "")
                {
                    //lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD']//..//..//following-sibling::div/div/div/div/div[2]")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + assignedPD + "']")).Click();
                    lib.resultUtil.AddResult("Select PD Model", "Should select <<'" + assignedPD + "'>> for Assigned PD", "Selected <b>'" + assignedPD + "'</b> for Assigned PD", "PASS");
                }
                                               
                // Select No for 'Use LGD Calculator (Changing this value will clear any existing LGD values you may have entered)'
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.bUseLGDCalculator']/div/div/div/div[3]/div[2]/label[contains(text(),'No')]")).Click();
                lib.resultUtil.AddResult("Select No option", "Should select No option", "Selected No option", "PASS");

                //Select Assigned LGD 
                if (assignedLGD != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned LGD']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned LGD']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + assignedLGD + "']")).Click();
                    lib.resultUtil.AddResult("Select LGD Model", "Should select <<'" + assignedLGD + "'>> for Assigned LGD", "Selected <b>'" + assignedLGD + "'</b> for Assigned LGD", "PASS");
                }

                //Scroll Into View
                IWebElement calc = lib.initializeTest.driver.FindElement(By.XPath(".//*[text()='Loan Narrative']"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", calc);

                // Final CDA / Loan Narrative has been Uploaded to DocHub
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.bCDAUploadedtoDocHub']/div/div/div[1]/label/input")).Click();
                lib.resultUtil.AddResult("Select the Final CDA / Loan Narrative has been Uploaded to DocHub Check box", "Should Select the Final CDA / Loan Narrative has been Uploaded to DocHub Check box", "Selected the Final CDA / Loan Narrative has been Uploaded to DocHub Check box", "PASS");

                // Select the Recommmended option in the Analyst Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAnalystDecision']/div/div/div/span/span/div/label[text()=' Recommended  ']")).Click();
                lib.resultUtil.AddResult("Select Recommmended option in the Analyst Decision", "Should select Recommmended option in the Analyst Decision", "Selected Recommmended option in the Analyst Decision", "PASS");

                //Click on the Save Button
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                //lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");

                System.Threading.Thread.Sleep(2000);

                // Scroll Into View
                IWebElement elem3 = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='RP Name']"));
                IJavaScriptExecutor jsc3 = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc3.ExecuteScript("arguments[0].scrollIntoView(true);", elem3);

                // Select Collateral Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Collateral']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Collateral']")).Click();
                lib.resultUtil.AddResult("Select the Collateral Tab", "Should Select the Collateral Tab", "Selected the Collateral Tab", "PASS");

                // Select Collateral Entry Complete Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCollateral.bCollateralReviewed']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Conditions Reviewed Checkbox", "Should Select the Conditions Reviewed Checkbox", "Selected the Conditions Reviewed Checkbox", "PASS");

                // Select Exceptions Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Exceptions']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Exceptions']")).Click();
                lib.resultUtil.AddResult("Select the Exceptions Tab", "Should Select the Exceptions Tab", "Selected the Exceptions Tab", "PASS");

                // Select Exceptions Entry Complete Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entExceptions.bExceptionsReviewed']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Exceptions Reviewed Checkbox", "Should Select the Exceptions Reviewed Checkbox", "Selected the Exceptions Reviewed Checkbox", "PASS");

                // Select Conditions Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Conditions']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Conditions']")).Click();
                lib.resultUtil.AddResult("Select the Conditions Tab", "Should Select the Conditions Tab", "Selected the Conditions Tab", "PASS");

                // Select Conditions Entry Complete Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entConditions.bConditionsReviewed']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Conditions Reviewed Checkbox", "Should Select the Conditions Reviewed Checkbox", "Selected the Conditions Reviewed Checkbox", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Enter Credit Analysis Details", "Should enter Credit Analysis Details", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : preDecisionReviewACH
        /// Description : Should select approval authority and send for decisioning
        /// </summary>
        /// <returns></returns>
        public static void preDecisionReviewACH()
        {
            try
            {
                // Select the Pre-Decision Review Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Pre-Decision Review']")).Click();
                lib.resultUtil.AddResult("Select the Pre-Decision Review Tab", "Should Select the Pre-Decision Review Tab", "Selected the Pre-Decision Review Tab", "PASS");

                // Scroll Into View
                IWebElement historyLog = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entWorkflow.bBypassAcceptanceTask']/span/label[contains(text(),'Bypass Acceptance Task')]"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", historyLog);

                System.Threading.Thread.Sleep(3000);

                // Select the 'Send For Decisioning' option for the Pre-Decision Review Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entPreDecisionRevDecision']/div/div/div/span/span/div/label[contains(text(),'Send for Decisioning')]")).Click();
                lib.resultUtil.AddResult("Select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Should select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Selected << Sending For Decisioning >> option for the Pre-Decision Review Decision", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton2']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Pre-Decision Review", "Should Select Pre-Decision Review", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : approverDecision
        /// Description : Should select approer decision
        /// </summary>
        /// <param name="approverDecision"></param>
        /// <param name="postDecisionReview"></param>
        /// <returns></returns>
        public static void approverDecision(string approverDecision, string postDecisionReview)
        {
            try
            {
                //Select Accept Credit Request button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                lib.resultUtil.AddResult("Click On Accept Credit Request Button", "Should click On Accept Credit Request Button", "Clicked On Accept Credit Request Button", "PASS");
                System.Threading.Thread.Sleep(3000);

                // Select the 'Approve' option for Approver Decision
                if (approverDecision != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-render-radio-item']/div/label[contains(text(),'" + approverDecision + "')]")).Click();
                    lib.resultUtil.AddResult("Select <<" + approverDecision + ">> option for Approver Decision", "Should select <<" + approverDecision + ">> option for Approver Decision", "Selected <<" + approverDecision + ">> option for Approver Decision", "PASS");
                }
                
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);

                // Scroll Into View
                IWebElement historyLog = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.dDecisionDate']/span/label[contains(text(),'Decision Date')]"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", historyLog);
                
                // Select 'Submit Credit Request for processing' option for Post Decision review
                if (postDecisionReview != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-render-radio ']/span/div/label[contains(text(),'" + postDecisionReview + "')]")).Click();
                    lib.resultUtil.AddResult("Select <<" + postDecisionReview + ">> option for Post Decision review", "Should select <<" + postDecisionReview + ">> option for Post Decision review", "Selected <<" + postDecisionReview + ">> option for Post Decision review", "PASS");
                }
                System.Threading.Thread.Sleep(2000);

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(6000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Approver Decision", "Should verify Approver Decision", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : clickLoanActionClosing
        /// Description : Select Accept Loan Actions Checkbox and click reassign button
        /// </summary>

        public static void clickLoanActionClosing()
        {
            try
            {
                //Select checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Accept Loan Actions')]")).Click();
                lib.resultUtil.AddResult("Select Accept Loan Actions checkbox", "Should select Accept Loan Actions checkbox", "Successfully selected Accept Loan Actions checkbox", "PASS");

                //Select Reassign button
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='btn-admin-case-reassign']/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Select Reassign button", "Should select Reassign button", "Successfully selected Reassign button", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
            }

        }

        //Fetch case id from right pane
        public static string fetchCaseID()
        {
            string msg = null;
            string msg1 = null;
            try
            {
                System.Threading.Thread.Sleep(4000);
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='project-collapse-rightpanel']/div")).Click();
                if (lib.initializeTest.driver.FindElement(By.XPath(".//h3[@class='ui-bizagi-wp-project-case-state-number']/span")).Displayed)
                {
                    IWebElement caseID = lib.initializeTest.driver.FindElement(By.XPath(".//h3[@class='ui-bizagi-wp-project-case-state-number']/span"));
                    msg = caseID.Text;
                    msg1 = msg.Remove(0, 5);
                    System.Console.WriteLine(msg1);
                }
                else
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='project-collapse-rightpanel']/div")).Click();
                    IWebElement caseID = lib.initializeTest.driver.FindElement(By.XPath(".//h3[@class='ui-bizagi-wp-project-case-state-number']/span"));
                    msg = caseID.Text;
                    msg1 = msg.Remove(0, 5);
                    System.Console.WriteLine(msg1);
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Fetch Case ID", "Should Fetch Case ID", "EXCEPTION: " + e, "FAIL");
            }
            return msg1;
        }

        //Search case id from Admin -> Cases tab
        public static Boolean searchCase(string cID)
        {
            Boolean ret = false;
            try
            {
                //Search case ID
                //if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@id='ui-id-2']")).Displayed)
                
                    lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='caseInput']")).SendKeys(cID);
                    lib.initializeTest.driver.FindElement(By.XPath(".//button[@id='btn-admin-case-search']")).Click();
                    lib.resultUtil.AddResult("Search Case ID", "Should Search Case ID ", "Successfully Searched Case ID", "PASS");
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Assign Analyst", "Should Verify Assign Analyst", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }


        /// <summary>
        /// Function Name : assnCrdtAnalystQ
        /// Description : Select Assign Credit Analyst Queue checkbox and reassign it
        /// </summary>

        //Select Assign Credit Analyst Queue Checkbox and click reassign button
        public static void assnCrdtAnalystQ()
        {
            try
            {
                //Select Assign Credit Analyst Queue checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Assign Credit Analyst')]")).Click();
                lib.resultUtil.AddResult("Select Assign Credit Analyst Queue checkbox", "Should select Assign Credit Analyst Queue checkbox", "Successfully selected Assign Credit Analyst Queue checkbox", "PASS");

                //Select Reassign button
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='btn-admin-case-reassign']/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Select Reassign button", "Should select Reassign button", "Successfully selected Reassign button", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Assign Credit Analyst Queue", "Should Select Assign Credit Analyst Queue", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : decisionLoanactns
        /// Description : Select Assign Credit Analyst Queue Checkbox and click reassign button
        /// </summary>

        public static void decisionLoanactns()
        {
            try
            {
                //Select Decision Loan Actions checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Decision Credit Request')]")).Click();
                lib.resultUtil.AddResult("Select Decision Loan Actions checkbox", "Should select Decision Loan Actions checkbox", "Successfully selected Decision Loan Actions checkbox", "PASS");

                //Select Reassign button
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='btn-admin-case-reassign']/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Select Reassign button", "Should select Reassign button", "Successfully selected Reassign button", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
            }

        }            

        /// <summary>
        /// Function Name : PrepareDocs
        /// Description : Select Documents prepared checkbox and then select mandatory fields
        /// </summary>
        /// <param name="cdProcLo"></param>
        /// <param name="cdRecServLo"></param>
        /// <param name="cdMLO"></param>
        /// <returns></returns>

        public static void PrepareDocs(string cdProcLo, string cdRecServLo, string cdMLO)
        {
            try
            {
                //Select "Work on it" in the window selector for Prepare and Send documents task
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ui-bizagi-wp-app-routing-activity-container']/table/tbody/tr/td[contains(text(),' Prepare and Send Documents ')]//following::td[2]/button/span[contains(text(),'Work on it')]")).Click();
                lib.resultUtil.AddResult("Click on Documents prepared Checkbox", "Should click on Documents prepared Checkbox", "Successfully clicked on Documents prepared Checkbox", "PASS");

                //Scroll to view
                IWebElement dec = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.entFinalLoanActionDecision']/span/label[contains(text(),'Final Loan Action Decision')]"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", dec);

                //Select CD Processing LO
                if (cdProcLo != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD Processing LO']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD Processing LO']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + cdProcLo + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Processing LO", "Should select <<" + cdProcLo + ">> for CD Processing LO", "Selected <<" + cdProcLo + ">> for CD Processing LO", "PASS");
                }
                System.Threading.Thread.Sleep(1000);
                
                //Select CD Rec/Serv.L/O
                if (cdRecServLo != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD Rec./Serv. L/O']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD Rec./Serv. L/O']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + cdRecServLo + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Rec/Serv.L/O", "Should select <<" + cdRecServLo + ">> for CD Rec/Serv.L/O", "Selected <<" + cdRecServLo + ">> for CD Rec/Serv.L/O", "PASS");
                }
                System.Threading.Thread.Sleep(1000);

                //Select CD MLO/S.A.F.E
                if (cdMLO != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD MLO/S.A.F.E.']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD MLO/S.A.F.E.']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + cdMLO + "']")).Click();
                    lib.resultUtil.AddResult("Select CD MLO/S.A.F.E", "Should select <<" + cdMLO + ">> for CD MLO/S.A.F.E", "Selected <<" + cdMLO + ">> for CD MLO/S.A.F.E", "PASS");
                }

                //Scroll to view
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                //Select checkbox Documents Sent to Borrower or Ready for Closing
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsSenttoBorrower']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on Documents Sent to Borrower or Ready for Closing Checkbox", "Should click on Documents Sent to Borrower or Ready for Closing Checkbox", "Successfully clicked on Documents Sent to Borrower or Ready for Closing Checkbox", "PASS");

                //Scroll to view
                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Total Loan Amount']"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);

                //Navigate to Pre-Close Checklist tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Pre-Close Checklist']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Pre-Close Checklist']")).Click();
                lib.resultUtil.AddResult("Click On Pre-Close checklist tab", "Should click On Pre-Close checklist tab", "Clicked On Pre-Close checklist tab", "PASS");

                //Select Complete for Pre-Close status
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.colPreCloseChecklistItems']/div/div/div/div/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[1]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                //lib.resultUtil.AddResult("Select << Complete >> option for Pre-Close status", "Should select << Complete >> option for Pre-Close status", "Selected << Complete >> option for Pre-Close status", "PASS");

                //Select Complete for Pre-Close status
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.colPreCloseChecklistItems']/div/div/div/div/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[2]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for Pre-Close status", "Should select << Complete >> option for Pre-Close status", "Selected << Complete >> option for Pre-Close status", "PASS");

                //Select Complete for Pre-Close status
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.colPreCloseChecklistItems']/div/div/div/div/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[3]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for Pre-Close status", "Should select << Complete >> option for Pre-Close status", "Selected << Complete >> option for Pre-Close status", "PASS");

                //Select Complete for Pre-Close status
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.colPreCloseChecklistItems']/div/div/div/div/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[4]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for Pre-Close status", "Should select << Complete >> option for Pre-Close status", "Selected << Complete >> option for Pre-Close status", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);

                //Select "Work on it" in the window selector for Receive documents task
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ui-bizagi-wp-app-routing-activity-container']/table/tbody/tr/td[contains(text(),' Receive Documents ')]//following::td[2]/button/span[contains(text(),'Work on it')]")).Click();
                lib.resultUtil.AddResult("Click on Work on it for Receive documents", "Should click on Work on it for Receive documents", "Successfully clicked on Work on it for Receive documents", "PASS");

                // Select the Closing Documents Received checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsReceived']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Closing Documents Received checkbox", "Should select the Closing Documents Received checkbox", "Successfully selected the Closing Documents Received checkbox", "PASS");
                
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : reassign
        /// Description : Reassign to the user
        /// </summary>
        /// <param name="fullname"></param>
        /// <returns></returns>

        public static void reassign(string fullname)
        {
            try
            {
                // Click on the reassign Button
                //lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                
                //Enter the fullname
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userFullName']")).SendKeys(fullname);
                lib.resultUtil.AddResult("Enter the fullname", "Should enter the fullname", "Successfully enter the fullname", "PASS");
                
                //click on the search button
                lib.initializeTest.driver.FindElement(By.XPath(".//button[@id='btn-users-table-search']/span[text()='Search']")).Click();
                System.Threading.Thread.Sleep(3000);
                
                // Click on Reassign
                lib.initializeTest.driver.FindElement(By.XPath(".//span[text()=' Reassign ']")).Click();
                lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                
                // Click on the Finish Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Finish']")).Click();
                lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                
                //Close the Case Window
                lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']")).Click();
                lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : fetchtaskAssnCrdtAnalystQ
        /// Description : Fetch Assign Credit Analyst Queue from right pane
        /// </summary>

        public static void fetchtaskAssnCrdtAnalystQ()
        {
            try
            {
                //Click on the right Arrow icon
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='project-collapse-rightpanel']/div")).Click();
                lib.resultUtil.AddResult("Click on the right Arrow icon", "Should Click on the right Arrow icon", "Clicked on the right Arrow icon", "PASS");

                // Scroll to the top of the Page
                IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='event']/a/span[text()='Decision Credit Request']"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);

                //Click on the Assign Credit Analyst Queue
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='event']/a/span[text()='Decision Credit Request']")).Click();
                lib.resultUtil.AddResult("Click on the Decision Credit Request task", "Should Click on the Decision Credit Request task", "Clicked on the Decision Credit Request task", "PASS");
                System.Threading.Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Fetch loan action closing", "Should Fetch loan action closing", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : fetchtaskAcceptLoanActions
        /// Description : Fetch AcceptLoanActions from right pane
        /// </summary>

        public static void fetchtaskAcceptLoanActions()
        {
            try
            {
                //Click on the right Arrow icon
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='project-collapse-rightpanel']/div")).Click();
                lib.resultUtil.AddResult("Click on the right Arrow icon", "Should Click on the right Arrow icon", "Clicked on the right Arrow icon", "PASS");

                // Scroll to view
                IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='event']/a/span[text()='Accept Loan Actions']"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);

                //Click on the Assign Credit Analyst Queue
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='event']/a/span[text()='Accept Loan Actions']")).Click();
                lib.resultUtil.AddResult("Click on the Accept Loan Actions task", "Should Click on the Accept Loan Actions task", "Clicked on the Accept Loan Actions task", "PASS");
                System.Threading.Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Fetch loan action closing", "Should Fetch loan action closing", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : acptCommercialLnActions
        /// Description : Verify Accept all Commercial loan actions Button selected
        /// </summary>

        public static void acptCommercialLnActions()
        {
            try
            {
                
                //Click on the Accept all Commercial loan actions Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                lib.resultUtil.AddResult("Click On Accept all Commercial loan actions Button", "Should click On Accept all Commercial loan actions Button", "Clicked On Accept all Commercial loan actions Button", "PASS");
                System.Threading.Thread.Sleep(7000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Accept all Commercial loan actions Button selected", "Should verify Accept all Commercial loan actions Button selected", "EXCEPTION: " + e, "FAIL");
            }
        }
        /// <summary>
        /// Function Name : bookandFunding
        /// Description : select booking complete checkbox
        /// </summary>

        public static void bookandFunding(string independentVerifier)
        {
            try
            {
                //Select "Work on it" in the window selector for Booking and Funding task
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ui-bizagi-wp-app-routing-activity-container']/table/tbody/tr/td[contains(text(),'Booking and Funding')]//following::td[2]/button/span[contains(text(),'Work on it')]")).Click();
                lib.resultUtil.AddResult("Click on work on it for Booking and Funding", "Should click on work on it for Booking and Funding", "Successfully clicked on work on it for Booking and Funding", "PASS");

                // Select the Loan booked and funded Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bLoanBooked']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the << Booking Complete >> Check box", "Should Select the << Booking Complete >> Check box", "Selected the Booking Complete Check box", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);

                //Select "Work on it" in the window selector for Next Day Verification task
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ui-bizagi-wp-app-routing-activity-container']/table/tbody/tr/td[contains(text(),'Next Day Verifications')]//following::td[2]/button/span[contains(text(),'Work on it')]")).Click();
                lib.resultUtil.AddResult("Click on work on it for Next Day Verification", "Should click on work on it for Next Day Verification", "Successfully clicked on work on it for Next Day Verification", "PASS");

                // Select the Next Day Verification Complete Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bVerified']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Next Day Verification Complete Check box", "Should Select the Next Day Verification Complete Check box", "Selected the Next Day Verification Complete Check box", "PASS");

                //Select Independent Verifier
                if (independentVerifier != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Independent Verifier']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Independent Verifier']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + independentVerifier + "']")).Click();
                    lib.resultUtil.AddResult("Select Involvement In Farming", "Should select <<" + independentVerifier + ">> for Involvement In Farming", "Selected <<" + independentVerifier + ">> for Involvement In Farming", "PASS");
                }

                //Click on the Verification Complete Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Verification Complete >> Button", "Should click On << Verification Complete >> Button", "Clicked On Verification Complete Button", "PASS");
                System.Threading.Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Booking/Funding", "Should verify Booking/Funding", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : postCloseChecklist
        /// Description : Select the 'Complete' option for Post-Close Task
        /// </summary>
        public static void postCloseChecklist()
        {
            try
            {
                //Select "Work on it" in the window selector for Post Close Tasks
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ui-bizagi-wp-app-routing-activity-container']/table/tbody/tr/td[contains(text(),'Post Close Tasks')]//following::td[2]/button/span[contains(text(),'Work on it')]")).Click();
                lib.resultUtil.AddResult("Click on work on it for Post Close Tasks", "Should click on work on it for Post Close Tasks", "Successfully clicked on work on it for Post Close Tasks", "PASS");

                // Select the Post-Close Checklist Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Post-Close Checklist']")).Click();
                lib.resultUtil.AddResult("Select the Post-Close Checklist Tab", "Should Select the Post-Close Checklist Tab", "Selected the Post-Close Checklist Tab", "PASS");
                
                // Select the 'Complete' option for Post-Close Task1
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[1]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Task1", "Should select << Complete >> option for the Applicant Post-Close Task1", "Selected << Complete >> option for Applicant Post-Close Task1", "PASS");

                // Select the 'Complete' option for Applicant Post-Close Task2
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[2]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Applicant Post-Close Task2", "Should select << Complete >> option for the Applicant Post-Close Task2", "Selected << Complete >> option for Applicant Post-Close Task2", "PASS");

                // Select the 'Complete' option for Post-Close Task1
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[3]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Task1", "Should select << Complete >> option for the Applicant Post-Close Task1", "Selected << Complete >> option for Applicant Post-Close Task1", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Post Close Checklist", "Should verify Post Close Checklist", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : finalCreditRequestActions
        /// Description : Final credit request actions
        /// </summary>
        public static void finalCreditRequestActions()
        {
            try
            {
                // Select the Upload Documents Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Upload Documents']")).Click();
                lib.resultUtil.AddResult("Select the Upload Documents Tab", "Should Select the Upload Documents Tab", "Selected the Upload Documents Tab", "PASS");

                //Select the All AgVUE Documents have been uploaded to DocHub Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entProcessing.bDocsUploadedtoDocHub']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the << All AgVUE Documents have been uploaded to DocHub>> Check box", "Should Select the << All AgVUE Documents have been uploaded to DocHub>> Check box", "Selected the All AgVUE Documents have been uploaded to DocHub Check box", "PASS");

                //Select the All documents have been uploaded to AgDocs Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entProcessing.bDocsUploadedtoAgDocs']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the << All documents have been uploaded to AgDocs >> Check box", "Should Select the << All documents have been uploaded to AgDocs >> Check box", "Selected the All documents have been uploaded to AgDocs Check box", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify final Credit Request Actions", "Should verify final Credit Request Actions", "EXCEPTION: " + e, "FAIL");
            }
        }
    }
}
    