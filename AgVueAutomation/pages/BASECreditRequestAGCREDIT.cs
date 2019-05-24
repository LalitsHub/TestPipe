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
    class BASECreditRequestAGCREDIT
    {
        public static IWebElement breadCrumbs = lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-form-process-path box-description']/p"));
        public static IWebElement applicantTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Applicants']/label"));
        public static IWebElement loanActionsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label"));
        public static IWebElement calculatorsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Calculators']/label"));
        public static IWebElement inquiryTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Inquiry']/label"));
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
                else if (tabName.ToUpper().Equals("INQUIRY"))
                {
                    inquiryTab.Click();
                    ret = true;
                }
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
        /// Function Name: addApplicant
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
        
        public static Boolean addApplicantAgCredit(string customerType, string applicantRole, string applicantType, string firstName, string middleName, string lastName, string suffix, string dob, string maritalStatus, string employer, string taxIdNo, string taxExempt, string conflictOfInterest, string address1, string address2, string city, string state, string zipCode, string zipCodeExt, string popcountyname, string popCountyCode, string emailAddress, string homePhoneCode, string homePhone, string workPhoneCode, string workPhone, string workPhoneExt, string faxCode, string faxNumber, string MobilePhoneCode, string MobilePhone)
        {
            Boolean ret = false;
            string str = "";
            try
            {
                selectTab("Applicants");
                newRPType.Click();
                System.Threading.Thread.Sleep(4000);
                //Click on the + Link to add aplicant
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
                        lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dDateofBirth']/div/div/div/span/input")).SendKeys(dob);
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
                    /*    //Verify for multiple county window
                        if(lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-id-19']/div/div[7]")).Displayed)
                        {
                            lib.resultUtil.AddResult("Multiple county window", "Multiple county window should display for zipcode which associated to multiple county", "Multiple county window should displayed", "PASS");
                            //second option
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='entCountyList']/div/div[2]/div[1]/table/tbody/tr[2]/td[2]/div/div/span/div/label")).Click();
                            lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Update']")).Click();
                        }*/
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
        /// Function Name : addLoanActions
        /// Description : Should Enter the below fields to Add A new Loan Action
        /// </summary>
        /// <param name="accountOfficer"></param>
        /// <param name="loanSpecialist"></param>
        /// <param name="branch"></param>
        /// <param name="loanActionCode"></param>
        /// <param name="term"></param>
        /// <param name="loanAmount"></param>
        /// <param name="loanPurpose"></param>
        /// <returns></returns>
        public static Boolean addLoanActionsAgCredit(string accountOfficer, string loanSpecialist, string loanProcessor, string loanAccountant, string branch, string underwritingType, string loanActionCode, string term, string loanAmount, string loanPurpose)
        {
            Boolean ret = false;
            try
            {
                //Select the Loan Actions Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                //System.Threading.Thread.Sleep(2000);
                //Select Account Officer
                if (accountOfficer != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Account Officer']//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Account Officer']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + accountOfficer + "']")).Click();
                    lib.resultUtil.AddResult("Select Account Officer", "Should select <<" + accountOfficer + ">> for Account Officer", "Selected <<" + accountOfficer + ">> for Account Officer", "PASS");
                }
                //Select Loan Specialist
                if (loanSpecialist != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Specialist']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Specialist']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanSpecialist + "']")).Click();
                    lib.resultUtil.AddResult("Select Loan Specialist", "Should select <<" + loanSpecialist + ">> for Loan Specialist", "Selected <<" + loanSpecialist + ">> for Loan Specialist", "PASS");
                }
                //Select Loan Processor
                if (loanProcessor != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Processor']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Processor']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanProcessor + "']")).Click();
                    lib.resultUtil.AddResult("Select Loan Processor", "Should select <<" + loanProcessor + ">> for Loan Processor", "Selected <<" + loanProcessor + ">> for Loan Specialist", "PASS");
                }
                //Select Loan Accountant
                if (loanAccountant != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Accountant']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Accountant']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanAccountant + "']")).Click();
                    lib.resultUtil.AddResult("Select Loan Accountant", "Should select <<" + loanAccountant + ">> for Loan Accountant", "Selected <<" + loanAccountant + ">> for Loan Accountant", "PASS");
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
                    lib.resultUtil.AddResult("Select Underwriting Type", "Should select <<" + underwritingType + ">> for Underwriting Type", "Selected <<" + underwritingType + ">> for Underwriting Type", "PASS");
                }
                //Click on the + Link to add Loan Actions(Compliance Check)
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@title='Add Loan Actions (Compliance Check)']/div")).Click();
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title']")).Displayed)
                {
                    lib.resultUtil.AddResult("Add Loan Actions(Compliance Check) screen", "After clicking on + link Add Loan Actions(Compliance Check) screen should display", "Add Loan Actions(Compliance Check) screen displayed", "PASS");

                    //Select the Loan Action Type ( New )
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Type']/../../span/../div/div/div[1]/span/span[1]/div/label[contains(text(),'New')]")).Click();

                    //Select Loan Action Code 
                    if (loanActionCode != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Code']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Code']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanActionCode + "']")).Click();
                        lib.resultUtil.AddResult("Select Loan Action Code", "Should select <<" + loanActionCode + ">> for Loan Action Code", "Selected <<" + loanActionCode + ">> for Loan Action Code", "PASS");
                    }
                    //Select Is borrower(s) a Natural Person or Land Trust (tax, land, or estate planning)? (Yes)
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionCompliance.bComplyQuestion1']/div/div/div[1]/div[1]/div[1]/label")).Click();
                    lib.resultUtil.AddResult("Select option for Question 1", "Should select option for Question 1", "Successfully selected option for Question 1", "PASS");

                    //Select Will loan proceeds be used primarily for personal, family or household use? (Yes)
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionCompliance.bComplyQuestion2']/div/div/div[1]/div[1]/div[1]/label")).Click();
                    lib.resultUtil.AddResult("Select option for Question 2", "Should select option for Question 2", "Successfully selected option for Question 2", "PASS");

                    //System.Threading.Thread.Sleep(3000);
                    //Select Will the proposed loan be closed-end and secured by real property? (No)
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bConsumer3DLoan']/div/div/div[1]/div/div[2]/label")).Click();
                    lib.resultUtil.AddResult("Select option for Question 3", "Should select option for Question 3", "Successfully selected option for Question 3", "PASS");

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
        /// 
        /// </summary>
        /// <param name="rpName"></param>
        /// <param name="involvementInFarming"></param>
        /// <param name="integratorProcessor"></param>
        /// <param name="comments"></param>
        /// <param name="headquarterState"></param>
        /// <param name="headquarterCounty"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="taxNumber"></param>
        /// <param name="taxIdType"></param>
        /// <returns></returns>
        public static Boolean addResponsibleParty(string rpName, string involvementInFarming, string integratorProcessor, string comments, string headquarterState, string headquarterCounty, string firstName, string lastName, string address, string city, string state, string zipCode, string taxNumber, string taxIdType)
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
                //Select Involvement In Farming
                if (involvementInFarming != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Involvement In Farming']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Involvement In Farming']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + involvementInFarming + "']")).Click();
                    lib.resultUtil.AddResult("Select Involvement In Farming", "Should select <<" + involvementInFarming + ">> for Involvement In Farming", "Selected <<" + involvementInFarming + ">> for Involvement In Farming", "PASS");
                }

                //Select Integrator or Processor checkbox
                //System.Threading.Thread.Sleep(10000);
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bIsIntegratororProcessor']/div/div/div/label/input")).Click();

                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-tab-5629ea69-5f67-4ede-b468-69ee7d5ea01c']/div[2]/div[3]/div[2]/div/div[1]/div/span/label[contains(text(),'Integrator or Processor')]/../../div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Integrator or Processor checkbox", "Should select Integrator or Processor checkbox", "Selected Integrator or Processor checkbox", "PASS");

                //Select Integrator processor
                //System.Threading.Thread.Sleep(4000);
                if (integratorProcessor != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Integrator Processor']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Integrator Processor']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + integratorProcessor + "']")).Click();
                    lib.resultUtil.AddResult("Select Integrator processor", "Should select <<" + integratorProcessor + ">> for Integrator processor", "Selected <<" + integratorProcessor + ">> for Integrator processor", "PASS");
                }

                //IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
                //IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                //js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                // THE BELOW STEPS ARE NOT INCLUDED IN THE CURRENT SCENARIO, HENCE COMMENTED //
                ////Select Young

                ////lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bYoungFarmer']/div/div/div[1]/div[1]/div/label[contains(text(),'" + young + "')]")).Click();
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-tab-5629ea69-5f67-4ede-b468-69ee7d5ea01c']/div[2]/div[4]/div/div/div/div/div[1]/div/div[1]/div/span/label[contains(text(), 'Young')]/../../div/div/div[1]/div[1]/div[1]/label")).Click();
                //lib.resultUtil.AddResult("Select option <<" + young + ">> for Young", "Should select option <<" + young + ">> Young", "Successfully selected option <<" + young + ">> for Young", "PASS");

                ////Select Small
                ////lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bSmallFarmer']/div/div/div[1]/div[1]/div/label[contains(text(),'" + small + "')]")).Click();
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-tab-5629ea69-5f67-4ede-b468-69ee7d5ea01c']/div[2]/div[4]/div/div/div/div/div[1]/div/div[2]/div/span/label[contains(text(),'Small')]/../../div/div/div[1]/div/div[1]/label")).Click();
                //lib.resultUtil.AddResult("Select option <<" + small + ">>  for Small", "Should select option <<" + small + ">> for Small", "Successfully selected option <<" + small + ">> for Small", "PASS");

                //System.Threading.Thread.Sleep(3000);
                ////Select Beginning
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bBeginningFarmer']/div/div/div[1]/div[1]/div/label[contains(text(),'" + beginning + "')]")).Click();
                //lib.resultUtil.AddResult("Select option <<" + beginning + ">> for Beginning", "Should select option <<" + beginning + ">> for Beginning", "Successfully selected option <<" + beginning + ">> for Beginning", "PASS");

                ////Enter Year Began Farming
                //if (yearBeganFarming != "")
                //{
                //    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Year Began Farming']/../../div/div/div/input")).SendKeys(yearBeganFarming);
                //    lib.resultUtil.AddResult("Enter Year Began Farming", "Should enter <<" + yearBeganFarming + ">> for Year Began Farming", "Entered <<" + yearBeganFarming + ">> for Year Began Farming", "PASS");
                //}

                //Select Wholly outside
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bWhollyOutside']/div/div/div/label/input")).Click();
                //lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bWhollyOutside']/../div/div/div/div[1]/div/label")).Click();
                lib.resultUtil.AddResult("Select Wholly Outside checkbox", "Should select Wholly Outside checkbox", "Selected Wholly Outside checkbox", "PASS");

                //Verify whether the Comment box for the Territorial concurrence/Wholly Outside comments is displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.sTerrConcurWholeOutCmnts']/div/div/div/textarea")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.sTerrConcurWholeOutCmnts']/div/div/div/textarea")).SendKeys(comments);
                    lib.resultUtil.AddResult("Comment box displays", "Comment Box should be displayed", "Comment box is displayed successfully", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Comment box displays", "Comment Box should be displayed", "Comment box is NOT displayed", "FAIL");
                }
                //UnSelect Wholly outside
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bWhollyOutside']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("UnSelect Wholly Outside checkbox", "Should unselect Wholly Outside checkbox", "unselected Wholly Outside checkbox", "PASS");

                //Verify whether the Comment box for the Territorial concurrence/Wholly Outside comments is NOT displayed
                if (!lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.sTerrConcurWholeOutCmnts']/div/div/div/textarea")).Displayed)
                {
                    lib.resultUtil.AddResult("Comment box disappears", "Comment Box should not be displayed", "Comment box is not displayed ", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Comment box disappears", "Comment Box should not be displayed", "Comment box doesnot disappears", "FAIL");
                }

                //Select Alternate Voting Stockholder
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bVotingStockholder']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Alternate Voting Stockholder checkbox", "Should select Alternate Voting Stockholder checkbox", "Selected Alternate Voting Stockholder checkbox", "PASS");

                //Select Different Framing HQ
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bDifferentFarmingHQ']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Different Framing HQ checkbox", "Should select Different Framing HQ checkbox", "Selected Different Framing HQ checkbox", "PASS");

                //Select Headquarter State
                if (headquarterState != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Headquarter State']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Headquarter State']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + headquarterState + "']")).Click();
                    lib.resultUtil.AddResult("Select Headquarter State", "Should select <<" + headquarterState + ">> for Headquarter State", "Selected <<" + headquarterState + ">> for Headquarter State", "PASS");
                }
                System.Threading.Thread.Sleep(2000);
                //Select Headquarter County
                if (headquarterCounty != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Headquarter County']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Headquarter County']/../../div/div[@class='ui-select-dropdown open']/ul/li[contains(text(),'" + headquarterCounty + "')]")).Click();
                    lib.resultUtil.AddResult("Select Headquarter County", "Should select <<" + headquarterCounty + ">> for Headquarter County", "Selected <<" + headquarterCounty + ">> for Headquarter County", "PASS");
                }
                //Enter Stockholder First Name
                if (firstName != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder First Name']/../../div/div/div/input")).SendKeys(firstName);
                    lib.resultUtil.AddResult("Enter Stockholder First Name", "Should enter <<" + firstName + ">> for Stockholder First Name", "Entered <<" + firstName + ">> for Stockholder First Name", "PASS");
                }
                //Enter Stockholder Last Name
                if (lastName != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Last Name']/../../div/div/div/input")).SendKeys(lastName);
                    lib.resultUtil.AddResult("Enter Stockholder Last Name", "Should enter <<" + lastName + ">> for last Name", "Entered <<" + lastName + ">> for Stockholder Last Name", "PASS");
                }
                //Enter Stockholder Address
                if (address != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Address 1']/../../div/div/div/input")).SendKeys(rpName);
                    lib.resultUtil.AddResult("Enter Stockholder Address", "Should enter <<" + address + ">> for Stockholder Address", "Entered <<" + address + ">> for Stockholder Address", "PASS");
                }
                //Enter Stockholder City
                if (city != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder City']/../../div/div/div/input")).SendKeys(city);
                    lib.resultUtil.AddResult("Enter Stockholder City", "Should enter <<" + city + ">> for Stockholder City", "Entered <<" + city + ">> for Stockholder City", "PASS");
                }
                //Select Stockholder State
                if (state != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder State']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder State']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + state + "']")).Click();
                    lib.resultUtil.AddResult("Select Stockholder State", "Should select <<" + state + ">> for Stockholder State", "Selected <<" + state + ">> for Stockholder State", "PASS");
                }
                //Enter Stockholder ZipCode
                if (zipCode != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder ZipCode']/../../div/div/div/input")).SendKeys(zipCode);
                    lib.resultUtil.AddResult("Enter Stockholder ZipCode", "Should enter <<" + zipCode + ">> for Stockholder ZipCode", "Entered <<" + zipCode + ">> for Stockholder ZipCode", "PASS");
                }
                //Enter Stockholder Tax Number
                if (taxNumber != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Tax Number']/../../div/div/div/input")).SendKeys(taxNumber);
                    lib.resultUtil.AddResult("Enter Stockholder Tax Number", "Should enter <<" + taxNumber + ">> for Stockholder Tax Number", "Entered <<" + taxNumber + ">> for Stockholder Tax Number", "PASS");
                }
                //Select Stockholder Tax ID type
                if (taxIdType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Tax ID Type']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Tax ID Type']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + taxIdType + "']")).Click();
                    lib.resultUtil.AddResult("Select Stockholder Tax ID type", "Should select <<" + taxIdType + ">> for Stockholder Tax ID type", "Selected <<" + taxIdType + ">> for Stockholder Tax ID type", "PASS");
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
        public static Boolean addResponsiblePartyYankee(string rpName, string involvementInFarming, string integratorProcessor, string comments, string headquarterState, string headquarterCounty, string firstName, string lastName, string address, string city, string state, string zipCode, string taxNumber, string taxIdType)
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
                //Select Involvement In Farming
                if (involvementInFarming != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Involvement In Farming']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Involvement In Farming']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + involvementInFarming + "']")).Click();
                    lib.resultUtil.AddResult("Select Involvement In Farming", "Should select <<" + involvementInFarming + ">> for Involvement In Farming", "Selected <<" + involvementInFarming + ">> for Involvement In Farming", "PASS");
                }

                //Select Integrator or Processor checkbox
                //System.Threading.Thread.Sleep(10000);
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bIsIntegratororProcessor']/div/div/div/label/input")).Click();

                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-tab-5629ea69-5f67-4ede-b468-69ee7d5ea01c']/div[2]/div[3]/div[2]/div/div[1]/div/span/label[contains(text(),'Integrator or Processor')]/../../div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Integrator or Processor checkbox", "Should select Integrator or Processor checkbox", "Selected Integrator or Processor checkbox", "PASS");

                //Select Integrator processor
                //System.Threading.Thread.Sleep(4000);
                if (integratorProcessor != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Integrator Processor']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Integrator Processor']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + integratorProcessor + "']")).Click();
                    lib.resultUtil.AddResult("Select Integrator processor", "Should select <<" + integratorProcessor + ">> for Integrator processor", "Selected <<" + integratorProcessor + ">> for Integrator processor", "PASS");
                }
                //Select Wholly outside
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bWhollyOutside']/div/div/div/label/input")).Click();
                //lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bWhollyOutside']/../div/div/div/div[1]/div/label")).Click();
                lib.resultUtil.AddResult("Select Wholly Outside checkbox", "Should select Wholly Outside checkbox", "Selected Wholly Outside checkbox", "PASS");

                //Verify whether the Comment box for the Territorial concurrence/Wholly Outside comments is displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.sTerrConcurWholeOutCmnts']/div/div/div/textarea")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.sTerrConcurWholeOutCmnts']/div/div/div/textarea")).SendKeys(comments);
                    lib.resultUtil.AddResult("Comment box displays", "Comment Box should be displayed", "Comment box is displayed successfully", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Comment box displays", "Comment Box should be displayed", "Comment box is NOT displayed", "FAIL");
                }
                
                //Select Alternate Voting Stockholder
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bVotingStockholder']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Alternate Voting Stockholder checkbox", "Should select Alternate Voting Stockholder checkbox", "Selected Alternate Voting Stockholder checkbox", "PASS");

                //Select Different Framing HQ
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bDifferentFarmingHQ']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Different Framing HQ checkbox", "Should select Different Framing HQ checkbox", "Selected Different Framing HQ checkbox", "PASS");

                //Select Headquarter State
                if (headquarterState != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Headquarter State']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Headquarter State']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + headquarterState + "']")).Click();
                    lib.resultUtil.AddResult("Select Headquarter State", "Should select <<" + headquarterState + ">> for Headquarter State", "Selected <<" + headquarterState + ">> for Headquarter State", "PASS");
                }
                System.Threading.Thread.Sleep(2000);
                //Select Headquarter County
                if (headquarterCounty != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Headquarter County']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Headquarter County']/../../div/div[@class='ui-select-dropdown open']/ul/li[contains(text(),'" + headquarterCounty + "')]")).Click();
                    lib.resultUtil.AddResult("Select Headquarter County", "Should select <<" + headquarterCounty + ">> for Headquarter County", "Selected <<" + headquarterCounty + ">> for Headquarter County", "PASS");
                }
                //Enter Stockholder First Name
                if (firstName != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder First Name']/../../div/div/div/input")).SendKeys(firstName);
                    lib.resultUtil.AddResult("Enter Stockholder First Name", "Should enter <<" + firstName + ">> for Stockholder First Name", "Entered <<" + firstName + ">> for Stockholder First Name", "PASS");
                }
                //Enter Stockholder Last Name
                if (lastName != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Last Name']/../../div/div/div/input")).SendKeys(lastName);
                    lib.resultUtil.AddResult("Enter Stockholder Last Name", "Should enter <<" + lastName + ">> for last Name", "Entered <<" + lastName + ">> for Stockholder Last Name", "PASS");
                }
                //Enter Stockholder Address
                if (address != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Address 1']/../../div/div/div/input")).SendKeys(rpName);
                    lib.resultUtil.AddResult("Enter Stockholder Address", "Should enter <<" + address + ">> for Stockholder Address", "Entered <<" + address + ">> for Stockholder Address", "PASS");
                }
                //Enter Stockholder City
                if (city != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder City']/../../div/div/div/input")).SendKeys(city);
                    lib.resultUtil.AddResult("Enter Stockholder City", "Should enter <<" + city + ">> for Stockholder City", "Entered <<" + city + ">> for Stockholder City", "PASS");
                }
                //Select Stockholder State
                if (state != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder State']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder State']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + state + "']")).Click();
                    lib.resultUtil.AddResult("Select Stockholder State", "Should select <<" + state + ">> for Stockholder State", "Selected <<" + state + ">> for Stockholder State", "PASS");
                }
                //Enter Stockholder ZipCode
                if (zipCode != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder ZipCode']/../../div/div/div/input")).SendKeys(zipCode);
                    lib.resultUtil.AddResult("Enter Stockholder ZipCode", "Should enter <<" + zipCode + ">> for Stockholder ZipCode", "Entered <<" + zipCode + ">> for Stockholder ZipCode", "PASS");
                }
                //Enter Stockholder Tax Number
                if (taxNumber != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Tax Number']/../../div/div/div/input")).SendKeys(taxNumber);
                    lib.resultUtil.AddResult("Enter Stockholder Tax Number", "Should enter <<" + taxNumber + ">> for Stockholder Tax Number", "Entered <<" + taxNumber + ">> for Stockholder Tax Number", "PASS");
                }
                //Select Stockholder Tax ID type
                if (taxIdType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Tax ID Type']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Stockholder Tax ID Type']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + taxIdType + "']")).Click();
                    lib.resultUtil.AddResult("Select Stockholder Tax ID type", "Should select <<" + taxIdType + ">> for Stockholder Tax ID type", "Selected <<" + taxIdType + ">> for Stockholder Tax ID type", "PASS");
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

        public static Boolean calculateEligibility(string agAssets, string totalAssets, string agIncome, string totalIncome)
        {
            Boolean ret = false;

            try
            {
                //Select Calculators Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Calculators']/label")).Click();
                lib.resultUtil.AddResult("Select Calulators Tab", "Should select Calulators Tab", "Selected <<Calulators Tab>>", "PASS");
                //System.Threading.Thread.Sleep(2000);

                //Select Calculate Eligibility Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.bCalculateEligibility']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Calculate Eligibility Check box", "Should select Calculate Eligibility Check box", "Selected <<Calculate Eligibility>> Check box", "PASS");
                //System.Threading.Thread.Sleep(2000);

                //Enter AG Assets
                if (agAssets != "")
                {
                    //lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cAgAssets']/div/div/div/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cAgAssets']/div/div/div/input")).SendKeys(agAssets);
                    lib.resultUtil.AddResult("Enter AG Assets", "Should enter <<" + agAssets + ">> for AG Assets", "Entered <<" + agAssets + ">> for AG Assets", "PASS");
                }
                //Enter Total Assets
                if (totalAssets != "")
                {
                    //lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cTotalAssets']/div/div/div/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cTotalAssets']/div/div/div/input")).SendKeys(totalAssets);
                    lib.resultUtil.AddResult("Enter Total Assets", "Should enter <<" + totalAssets + ">> for Total Assets", "Entered <<" + totalAssets + ">> for Total Assets", "PASS");
                }

                //Enter AG Income
                if (agIncome != "")
                {
                    //lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cAgIncome']/div/div/div/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cAgIncome']/div/div/div/input")).SendKeys(agIncome);
                    lib.resultUtil.AddResult("Enter AG Income", "Should enter <<" + agIncome + ">> for AG Income", "Entered <<" + agIncome + ">> for AG Income", "PASS");
                }
                //Enter Total Income
                if (totalIncome != "")
                {
                    //lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cTotalIncome']/div/div/div/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cTotalIncome']/div/div/div/input")).SendKeys(totalIncome);
                    lib.resultUtil.AddResult("Enter Total Income", "Should enter <<" + totalIncome + ">> for Total Income", "Entered <<" + totalIncome + ">> for Total Income", "PASS");
                }
                System.Threading.Thread.Sleep(3000);
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(7000);
                //Enter Total Assets
                if (totalAssets != "")
                {
                    //lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cTotalAssets']/div/div/div/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cTotalAssets']/div/div/div/input")).SendKeys(totalAssets);
                    lib.resultUtil.AddResult("Enter Total Assets", "Should enter <<" + totalAssets + ">> for Total Assets", "Entered <<" + totalAssets + ">> for Total Assets", "PASS");
                }
                //Enter Total Income
                if (totalIncome != "")
                {
                    //lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cTotalIncome']/div/div/div/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.cTotalIncome']/div/div/div/input")).SendKeys(totalIncome);
                    lib.resultUtil.AddResult("Enter Total Income", "Should enter <<" + totalIncome + ">> for Total Income", "Entered <<" + totalIncome + ">> for Total Income", "PASS");
                }
                IWebElement calelem = lib.initializeTest.driver.FindElement(By.XPath(".//input[@title='Calculate']"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", calelem);
                System.Threading.Thread.Sleep(2000);

                // Click on the Calculate button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@title='Calculate']")).Click();
                System.Threading.Thread.Sleep(2000);
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@title='Calculate']")).Click();
                lib.resultUtil.AddResult("Click on the Calculate button", "Should Click on the Calculate button", "Clicked on the <<Calculate button>>", "PASS");
                System.Threading.Thread.Sleep(2000);

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Calculate Eligibility", "Should Calculate Eligibility", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        public static double fetchPercentage()
        {
            double percentVal = 0;
            try
            {
                //double percentVal;
                string ovrallper;
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.fOverallAgPercentage']/div/div/div/label"));
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                ovrallper = elem.Text;
                Console.WriteLine("The string Value is" + ovrallper);
                percentVal = double.Parse(ovrallper);
                Console.WriteLine("The integer Value is" + percentVal);
                //result = ((double)percentVal);
                //Console.WriteLine("The Double Value is" + result);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Fetch Percentage", "Should Fetch Percentage value", "EXCEPTION: " + e, "FAIL");

            }
            return percentVal;
        }

        public static Boolean comparePercentageCriteria(string fullTime, string partTime, string essentially)
        {
            Boolean ret = false;

            try
            {
                double percentvalue = 0;
                percentvalue = fetchPercentage();
                string involvement = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entCalculatedInvolveInFarm']/div/div/div[1]")).Text;

                if ((percentvalue <= 100.00) && (percentvalue >= 50.00) && (involvement.Equals(fullTime)))
                {
                    lib.resultUtil.AddResult("Verify Eligibility Classification", "Should be Full-Time Farmer", "Displays correct Eligibility Classification", "PASS");

                }
                else if ((percentvalue <= 50.00) && (percentvalue >= 10.00) && (involvement.Equals(partTime)))
                {

                    lib.resultUtil.AddResult("Verify Eligibility Classification", "Should be Part-Time Farmer", "Displays correct Eligibility Classification", "PASS");
                }
                else if ((percentvalue <= 10.00) && (involvement.Equals(essentially)))
                {
                    lib.resultUtil.AddResult("Verify Eligibility Classification", "Should be Essentially Other than Farming", "Displays correct Eligibility Classification", "PASS");

                }
                else
                {
                    lib.resultUtil.AddResult("Verify Eligibility Classification", "Should display correct Eligibility Classification", "Displays Incorrect Eligibility Classification", "FAIL");

                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Fetch Percentage", "Should Fetch Percentage value", "EXCEPTION: " + e, "FAIL");

            }
            return ret;
        }
        public static Boolean addinquiryDecision(string inquiryDecision, string appPastDate, string appCurrentDate, string inquiryComments)
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

                // THIS SCENARIO HAS A DEFECT RAISED AND IS NOT YET FIXED //
                //Enter Invalid Application Date                 
                if (appPastDate != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/span/input")).SendKeys(appPastDate);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).Click();

                    lib.resultUtil.AddResult("Enter Application Date", "Should enter Invalid Application Date", "Entered Past 30 +years date <<" + appPastDate + ">> for Application Date", "PASS");

                    if (lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-notifications-header ui-widget-header ui-state-active']")).Displayed)
                    {
                        lib.resultUtil.AddResult("User able to select application date which was past 30+ years", "User must not be able to select application date which was past 30+ years", "User IS NOT able to select application date which was past 30+ years", "PASS");

                    }
                    else
                    {
                        lib.resultUtil.AddResult("User able to select application date which was past 30+ years", "User must not be able to select application date which was past 30+ years", "User IS able to select application date which was past 30+ years", "FAIL");
                    }
                }

                //Enter Valid Application Date
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/span/input")).Clear();
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/span/input")).SendKeys(appCurrentDate);
                lib.resultUtil.AddResult("Enter Application Date", "Should enter Valid Application Date", "Entered <<" + appCurrentDate + ">> for Application Date", "PASS");

                //Enter Inquiry Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).SendKeys(inquiryComments);
                lib.resultUtil.AddResult("Enter Inquiry Comments", "Should enter Inquiry Comments", "Entered <<" + inquiryComments + ">> for inquiryComments", "PASS");

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                //System.Threading.Thread.Sleep(7000);

                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                //System.Threading.Thread.Sleep(5000);

            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Inquiry Decision", "Should Add Inquiry Decison", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean addinquiryDecisionYankee(string inquiryDecision, string appCurrentDate, string inquiryComments)
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
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/span/input")).Clear();
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/span/input")).SendKeys(appCurrentDate);
                lib.resultUtil.AddResult("Enter Application Date", "Should enter Valid Application Date", "Entered <<" + appCurrentDate + ">> for Application Date", "PASS");

                //Enter Inquiry Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).SendKeys(inquiryComments);
                lib.resultUtil.AddResult("Enter Inquiry Comments", "Should enter Inquiry Comments", "Entered <<" + inquiryComments + ">> for inquiryComments", "PASS");

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(3000);

                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton2']")).Click();
                System.Threading.Thread.Sleep(4000);

            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Inquiry Decision", "Should Add Inquiry Decison", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean addCollateralandApplication(string appDecision, string appComments)
        {
            Boolean ret = false;

            try
            {

                //Verify whether the Collateral Tab is Displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Collateral']/label")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Collateral']/label")).Click();
                    lib.resultUtil.AddResult("Select Collateral Tab", "Should select Collateral Tab", "Selected <<Collateral Tab>>", "PASS");
                   System.Threading.Thread.Sleep(2000);
                }

                //Check on Collateral tab is Complete Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCollateral.bCollateralReviewed']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Collateral tab is Complete checkbox", "Should select Collateral tab is Complete checkbox", "Selected Collateral tab is Complete checkbox", "PASS");

                //Select Application Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Application']/label")).Click();
                lib.resultUtil.AddResult("Select Application Tab", "Should select Application Tab", "Selected Application Tab", "PASS");
                System.Threading.Thread.Sleep(2000);

                //Select Application Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entApplicationDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + appDecision + "')]")).Click();
                lib.resultUtil.AddResult("Select option <<" + appDecision + ">> for Application Decision", "Should select option <<" + appDecision + ">> for Application Decision", "Successfully selected option <<" + appDecision + ">> for Application Decision", "PASS");

                //Enter Application Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).SendKeys(appComments);
                lib.resultUtil.AddResult("Enter Application Comments", "Should enter Application Comments", "Entered <<" + appComments + ">> for Application Comments", "PASS");

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(5000);
                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                System.Threading.Thread.Sleep(7000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Collateral and Application", "Should Add Collateral and Application", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean addCollateralandApplicationYankee(string appDecision, string appComments)
        {
            Boolean ret = false;

            try
            {

                //Verify whether the Collateral Tab is Displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Collateral']/label")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Collateral']/label")).Click();
                    lib.resultUtil.AddResult("Select Collateral Tab", "Should select Collateral Tab", "Selected <<Collateral Tab>>", "PASS");
                    System.Threading.Thread.Sleep(2000);
                }

                //Check on Collateral Reviewed Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCollateral.bCollateralReviewed']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Collateral Reviewed checkbox", "Should select Collateral Reviewed checkbox", "Selected Collateral Reviewed checkbox", "PASS");

                //Select Application Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Application']/label")).Click();
                lib.resultUtil.AddResult("Select Application Tab", "Should select Application Tab", "Selected Application Tab", "PASS");
                System.Threading.Thread.Sleep(2000);

                //Select Application Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entApplicationDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + appDecision + "')]")).Click();
                lib.resultUtil.AddResult("Select option <<" + appDecision + ">> for Application Decision", "Should select option <<" + appDecision + ">> for Application Decision", "Successfully selected option <<" + appDecision + ">> for Application Decision", "PASS");

                //Enter Application Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).SendKeys(appComments);
                lib.resultUtil.AddResult("Enter Application Comments", "Should enter Application Comments", "Entered <<" + appComments + ">> for Application Comments", "PASS");

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(5000);
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
        public static Boolean addLoanPackageDecision(string lenderDecision, string comments)
        {
            Boolean ret = false;

            try
            {
                //Verify whether the Loan Package Tab is Displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Package']/label")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Package']/label")).Click();
                    lib.resultUtil.AddResult("Select Loan Package Tab", "Should select Loan Package Tab", "Selected <<Loan Package Tab>>", "PASS");
                    System.Threading.Thread.Sleep(2000);
                }
                //Select Lender Decision Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entLenderDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + lenderDecision + "')]")).Click();
                lib.resultUtil.AddResult("Select option <<" + lenderDecision + ">> for Lender Decision", "Should select option <<" + lenderDecision + ">> for Lender Decision", "Successfully selected option <<" + lenderDecision + ">> for Lender Decision", "PASS");

                //Enter Comments For Analyst
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entWorkflow.sCommentsforAnalyst']/div/div/div/textarea")).SendKeys(comments);
                lib.resultUtil.AddResult("Enter Comments for Analyst", "Should enter Comments for Analyst", "Entered <<" + comments + ">> for Comments for Analyst", "PASS");

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(5000);
                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton2']")).Click();
                System.Threading.Thread.Sleep(7000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Loan Package Decision", "Should Add Loan Package Decision", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean EditLoanAction(string pastClosingDate, string futureClosingDate, string newMoney, string consumerLoantype, string primaryLoan, string primaryLoanAmount, string feeType, string feeAmount, string policyAmount, string exceptionComment, string subsidary, string termType, string loanType, string fcaLoanType, string primSICCode, string secSICCode, string primSICDep, string secSICDep, string accSystem, string secLoan, string rateType, string stateRate, string policyMargin, string rateExcepComm)
        {
            Boolean ret = false;

            try
            {
                //Select Loan Action Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected Loan Action Tab", "PASS");

                //Click on Edit Loan Action Button
                lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='New Loan Actions']/../../div/div/table[@class='ui-bizagi-grid-table ']/tbody/tr/td[8]/div/div/span/div/button[2]/i")).Click();
                lib.resultUtil.AddResult("Click on Edit Loan Action Button", "Should click on Edit Loan Action Button", "Clicked on <<Edit Loan Action Button>>", "PASS");

                // Verify whether the Edit New Loan Actions box Opens
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title' and contains(text(),'Edit New Loan Actions')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify whether the Edit New Loan Actions box Opens", "Edit New Loan Actions box sould open", "Edit New Loan Actions box is opened Successfully", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify whether the Edit New Loan Actions box Opens", "Edit New Loan Actions box sould open", "Edit New Loan Actions box is NOt opened", "FAIL");
                }

                //Select Loan Action Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action']")).Click();
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected <<Loan Action Tab>>", "PASS");

                // THIS SCENARIO HAS A DEFECT RAISED AND IS NOT YET FIXED //
                //Enter Invalid (More than 30 years + the current date )Estimated Closing Date                 
                if (pastClosingDate != "")
                {
                    //Enter the date
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/span/input")).SendKeys(pastClosingDate);
                    //Switch control to the next field to check whether the Error message is displayed
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionType']/div/div")).Click();
                    lib.resultUtil.AddResult("Enter Estimated Closing Date", "Should enter Invalid Estimated Closing Date", "Entered Past more than 30 +years date for Estimated Closing Date", "PASS");

                    if (lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-notifications-header ui-widget-header ui-state-active']")).Displayed)
                    {
                        lib.resultUtil.AddResult("User able to select Estimated Closing date which was past more than 30+ years", "User must not be able to select Estimated Closing date which was past more than 30+ years", "User IS NOT able to select Estimated Closing date which was past more than 30+ years", "PASS");
                    }
                    else
                    {
                        lib.resultUtil.AddResult("User able to select Estimated Closing date which was past more than 30+ years", "User must not be able to select Estimated Closing date which was past more than 30+ years", "User IS able to select Estimated Closing date which was past more than 30+ years", "FAIL");
                    }
                }

                //Enter the valid Estimated closing Date
                if (futureClosingDate != "")
                {
                    //Enter the date
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/span/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/span/input")).SendKeys(futureClosingDate);
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionType']/div/div")).Click();
                    lib.resultUtil.AddResult("Enter Estimated Closing Date", "Should enter Valid Estimated Closing Date", "Entered <<" + futureClosingDate + ">> for Estimated Closing Date", "PASS");
                }
                //Enter New Money
                if (newMoney != "")
                {
                    //Enter New Money
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='cNewMoney']/div/div/div/input")).SendKeys(newMoney);
                    lib.resultUtil.AddResult("Enter value for New Money", "Should enter value for New Money", "Entered <<" + newMoney + ">> for New Money", "PASS");
                }
                //Select CD Consumer Loan type
                if (consumerLoantype != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanRequestType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + consumerLoantype + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Consumer Loan type", "Should select Consumer Loan type", "Selected <<" + consumerLoantype + ">> for Consumer Loan type", "PASS");
                }
                // Check on the Start w/ Gross Loan Amount
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bStartWithGrossLoanAmount']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on the Start w/ Gross Loan Amount", "Should click on the Start w/ Gross Loan Amount", "Successfully clicked on the <<Start w/ Gross Loan Amount>>", "PASS");

                // Check on Additional Loan Purposes
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bAdditionalLoanPurposes']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on Additional Loan Purposes", "Should click on Additional Loan Purposes", "Successfully clicked on <<Additional Loan Purposes>>", "PASS");

                //Select Primary Loan Purpose
                if (primaryLoan != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanPurpose3']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + primaryLoan + "']")).Click();
                    lib.resultUtil.AddResult("Select Primary Loan Purpose", "Should select Primary Loan Purpose", "Selected <<" + primaryLoan + ">> for Primary Loan Purpose", "PASS");
                }
                //Enter Primary Loan Amount
                if (primaryLoanAmount != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanPurpose3']/div/div/div/div/div/input")).SendKeys(primaryLoanAmount);
                    lib.resultUtil.AddResult("Enter Primary Loan Amount", "Should enter Primary Loan Amount", "Entered <<" + primaryLoanAmount + ">> for Primary Loan Amount", "PASS");
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
                //System.Threading.Thread.Sleep(2000);
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
                //Select FCA Loan Type
                if (fcaLoanType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entFCALoanType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + fcaLoanType + "']")).Click();
                    lib.resultUtil.AddResult("Select FCA Loan Type", "Should select FCA Loan Type", "Selected <<" + fcaLoanType + ">> for FCA Loan Type", "PASS");
                }
                //Select Primary SIC Code
                if (primSICCode != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanPrimarySICCode']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + primSICCode + "']")).Click();
                    lib.resultUtil.AddResult("Select Primary SIC Code", "Should select Primary SIC Code", "Selected <<" + primSICCode + ">> for Primary SIC Code", "PASS");
                }
                //Select Secondary SIC Code
                if (secSICCode != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanSecondarySICCode']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + secSICCode + "']")).Click();
                    lib.resultUtil.AddResult("Select Secondary SIC Code", "Should select Secondary SIC Code", "Selected <<" + secSICCode + ">> for Secondary SIC Code", "PASS");
                }
                //Select the Primary SIC Dependency radio Button
                if (primSICDep != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entPrimarySICDependency']/div/div/div[1]/span/span/div/label[contains(text(),'" + primSICDep + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Primary SIC Dependency Radio Button", "Should select Primary SIC Dependency Radio Button", "Selected <<" + primSICDep + ">> for Primary SIC Dependency Radio Button", "PASS");
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
                //Select the Secured Loan radio Button
                if (secLoan != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bSecuredLoan']/div/div/div/div/div/label[contains(text(),'" + secLoan + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Secured Loan Radio Button", "Should select Secured Loan Radio Button", "Selected <<" + secLoan + ">> for Secured Loan Radio Button", "PASS");
                }

                // Sroll to the view
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
                //Select Rate Exception Check Box
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bRateException']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Rate Exception Check Box", "Should select Rate Exception Check Box", "Successfully selected <<Rate Exception>> Check Box", "PASS");
                //Enter the Policy Margin
                if (policyMargin != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='fPolicyMargin']/div/div/div/input")).SendKeys(policyMargin);
                    lib.resultUtil.AddResult("Enter the Policy Margin", "Should enter the Policy Margin", "Entered <<" + policyMargin + ">> Policy Margin", "PASS");
                }
                //Enter the Rate Exception Comments
                if (rateExcepComm != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sRateExceptionComments']/div/div/div/input")).SendKeys(rateExcepComm);
                    lib.resultUtil.AddResult("Enter the Rate Exception Comments", "Should enter the Rate Exception Comments", "Entered <<" + rateExcepComm + ">> Rate Exception Comments", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(3000);

                // Click on the submit Button
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();

            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Edit Loan Action", "Should Edit Loan Action", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean EditLoanActionYankee(string docSpl, string futureClosingDate, string newMoney, string consumerLoantype, string primaryLoan, string primaryLoanAmount, string feeType, string feeAmount, string policyAmount, string exceptionComment, string feeType2, string feeAmount2, string subsidary, string termType, string loanType, string fcaLoanType, string primSICCode, string secSICCode, string primSICDep, string secSICDep, string accSystem, string secLoan, string rateType, string stateRate, string policyMargin, string rateExcepComm)
        {
            Boolean ret = false;

            try
            {
                //Select Loan Action Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label")).Click();
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected Loan Action Tab", "PASS");

                //Select Document Specialist 
                if (docSpl != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Document Specialist']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Document Specialist']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + docSpl + "']")).Click();
                    lib.resultUtil.AddResult("Select Document Specialist", "Should select <<" + docSpl + ">> for Document Specialist", "Selected <<" + docSpl + ">> for Document Specialist", "PASS");
                }

                //Click on Edit Loan Action Button
                lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='New Loan Actions']/../../div/div/table[@class='ui-bizagi-grid-table ']/tbody/tr/td[9]/div/div/span/div/button[2]/i")).Click();
                lib.resultUtil.AddResult("Click on Edit Loan Action Button", "Should click on Edit Loan Action Button", "Clicked on <<Edit Loan Action Button>>", "PASS");

                // Verify whether the Edit New Loan Actions box Opens
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title' and contains(text(),'Edit New Loan Actions')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify whether the Edit New Loan Actions box Opens", "Edit New Loan Actions box sould open", "Edit New Loan Actions box is opened Successfully", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify whether the Edit New Loan Actions box Opens", "Edit New Loan Actions box sould open", "Edit New Loan Actions box is NOt opened", "FAIL");
                }

                //Select Loan Action Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action']")).Click();
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected <<Loan Action Tab>>", "PASS");

                //Enter the valid Estimated closing Date
                if (futureClosingDate != "")
                {
                    //Enter the date
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/span/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/span/input")).SendKeys(futureClosingDate);
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionType']/div/div")).Click();
                    lib.resultUtil.AddResult("Enter Estimated Closing Date", "Should enter Valid Estimated Closing Date", "Entered <<" + futureClosingDate + ">> for Estimated Closing Date", "PASS");
                }
                //Enter New Money
                if (newMoney != "")
                {
                    //Enter New Money
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='cNewMoney']/div/div/div/input")).SendKeys(newMoney);
                    lib.resultUtil.AddResult("Enter value for New Money", "Should enter value for New Money", "Entered <<" + newMoney + ">> for New Money", "PASS");
                }
                //Select CD Consumer Loan type
                if (consumerLoantype != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanRequestType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + consumerLoantype + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Consumer Loan type", "Should select Consumer Loan type", "Selected <<" + consumerLoantype + ">> for Consumer Loan type", "PASS");
                }
               
                // Check on Additional Loan Purposes
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bAdditionalLoanPurposes']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on Additional Loan Purposes", "Should click on Additional Loan Purposes", "Successfully clicked on <<Additional Loan Purposes>>", "PASS");

                //Select Primary Loan Purpose
                if (primaryLoan != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanPurpose3']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + primaryLoan + "']")).Click();
                    lib.resultUtil.AddResult("Select Primary Loan Purpose", "Should select Primary Loan Purpose", "Selected <<" + primaryLoan + ">> for Primary Loan Purpose", "PASS");
                }
                //Enter Primary Loan Amount
                if (primaryLoanAmount != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanPurpose3']/div/div/div/div/div/input")).SendKeys(primaryLoanAmount);
                    lib.resultUtil.AddResult("Enter Primary Loan Amount", "Should enter Primary Loan Amount", "Entered <<" + primaryLoanAmount + ">> for Primary Loan Amount", "PASS");
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
                // Click on Add Loan Action Fees(+ button)
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@title='Add Loan Action Fees']")).Click();
                lib.resultUtil.AddResult("Click on Add Loan Action Fees button", "Should Click on Add Loan Action Fees button", "Clicked on <<Add Loan Action Fees>> button", "PASS");
                // Select Fee Type
                if (feeType2 != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entFeeType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + feeType + "']")).Click();
                    lib.resultUtil.AddResult("Select Fee Type", "Should select Fee Type", "Selected <<" + feeType + ">>Fee Type", "PASS");
                }
                // Enter Fee Amount
                if (feeAmount2 != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='cAmount']/div/div/div/input")).SendKeys(feeAmount);
                    lib.resultUtil.AddResult("Enter Amount", "Should enter Amount", "Entered <<" + feeAmount + ">> for Amount", "PASS");
                }
                // Select Payment Method (Cash)
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entPaymentMethod']/div/div/div/span/span/div/label[contains(text(),'Cash')]")).Click();
                lib.resultUtil.AddResult("Select Payment Method", "Should select Payment Method", "Successfully selected <<Payment Method>>", "PASS");
                
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
                //Select FCA Loan Type
                if (fcaLoanType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entFCALoanType']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + fcaLoanType + "']")).Click();
                    lib.resultUtil.AddResult("Select FCA Loan Type", "Should select FCA Loan Type", "Selected <<" + fcaLoanType + ">> for FCA Loan Type", "PASS");
                }
                //Select Primary SIC Code
                if (primSICCode != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanPrimarySICCode']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + primSICCode + "']")).Click();
                    lib.resultUtil.AddResult("Select Primary SIC Code", "Should select Primary SIC Code", "Selected <<" + primSICCode + ">> for Primary SIC Code", "PASS");
                }
                //Select Secondary SIC Code
                if (secSICCode != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanSecondarySICCode']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + secSICCode + "']")).Click();
                    lib.resultUtil.AddResult("Select Secondary SIC Code", "Should select Secondary SIC Code", "Selected <<" + secSICCode + ">> for Secondary SIC Code", "PASS");
                }
                //Select the Primary SIC Dependency radio Button
                if (primSICDep != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entPrimarySICDependency']/div/div/div[1]/span/span/div/label[contains(text(),'" + primSICDep + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Primary SIC Dependency Radio Button", "Should select Primary SIC Dependency Radio Button", "Selected <<" + primSICDep + ">> for Primary SIC Dependency Radio Button", "PASS");
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
                //Select the Secured Loan radio Button
                if (secLoan != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bSecuredLoan']/div/div/div/div/div/label[contains(text(),'" + secLoan + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Secured Loan Radio Button", "Should select Secured Loan Radio Button", "Selected <<" + secLoan + ">> for Secured Loan Radio Button", "PASS");
                }

                // Sroll to the view
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
                //Select Rate Exception Check Box
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bRateException']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Rate Exception Check Box", "Should select Rate Exception Check Box", "Successfully selected <<Rate Exception>> Check Box", "PASS");
                //Enter the Policy Margin
                if (policyMargin != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='fPolicyMargin']/div/div/div/input")).SendKeys(policyMargin);
                    lib.resultUtil.AddResult("Enter the Policy Margin", "Should enter the Policy Margin", "Entered <<" + policyMargin + ">> Policy Margin", "PASS");
                }
                //Enter the Rate Exception Comments
                if (rateExcepComm != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sRateExceptionComments']/div/div/div/input")).SendKeys(rateExcepComm);
                    lib.resultUtil.AddResult("Enter the Rate Exception Comments", "Should enter the Rate Exception Comments", "Entered <<" + rateExcepComm + ">> Rate Exception Comments", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(3000);

                // Click on the submit Button
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();

            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Edit Loan Action", "Should Edit Loan Action", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        public static Boolean addLoanActiondetails(string underwritingType, string approvalAuthority)
        {
            Boolean ret = false;
            try
            {
                //Select Loan Action Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected <<Loan Action Tab>>", "PASS");
                //Select Underwriting type
                if (underwritingType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Underwriting Type']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Underwriting Type']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + underwritingType + "']")).Click();
                    lib.resultUtil.AddResult("Select Underwriting type", "Should select <<" + underwritingType + ">> for Underwriting type", "Selected <<" + underwritingType + ">> for Underwriting type", "PASS");
                }
                // Sroll to the view
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);
                //Select Approval Authority
                if (approvalAuthority != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + approvalAuthority + "']")).Click();
                    lib.resultUtil.AddResult("Select Approval Authority", "Should select <<" + approvalAuthority + ">> for Approval Authority", "Selected <<" + approvalAuthority + ">> for Approval Authority", "PASS");
                }
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sCRDescription']/div/div/div/input")).Click();
                System.Threading.Thread.Sleep(3000);
                ////Click on the Save Button
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                 System.Threading.Thread.Sleep(5000);
                // Sroll to the view
                IWebElement elememet = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']"));
                IJavaScriptExecutor jscrip = (IJavaScriptExecutor)lib.initializeTest.driver;
                jscrip.ExecuteScript("arguments[0].scrollIntoView(true);", elememet);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Loan Action details in Build Loan Package", "Should Add Loan Action details in Build Loan Package", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean addLoanActiondetailsYan(string underwritingType, string creditAnalyst, string approvalAuthority)
        {
            Boolean ret = false;
            try
            {
                //Select Loan Action Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected <<Loan Action Tab>>", "PASS");
                //Select Underwriting type
                if (underwritingType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Underwriting Type']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Underwriting Type']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + underwritingType + "']")).Click();
                    lib.resultUtil.AddResult("Select Underwriting type", "Should select <<" + underwritingType + ">> for Underwriting type", "Selected <<" + underwritingType + ">> for Underwriting type", "PASS");
                }
                // Sroll to the view
                //IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label"));
                //IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                //js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                //Select Credit Analyst
                if (creditAnalyst != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Credit Analyst']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Credit Analyst']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + creditAnalyst + "']")).Click();
                    lib.resultUtil.AddResult("Select Credit Analyst", "Should select <<" + approvalAuthority + ">> for Credit Analyst", "Selected <<" + creditAnalyst + ">> for Credit Analyst", "PASS");
                    
                }
                //Select Approval Authority
                if (approvalAuthority != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + approvalAuthority + "']")).Click();
                    lib.resultUtil.AddResult("Select Approval Authority", "Should select <<" + approvalAuthority + ">> for Approval Authority", "Selected <<" + approvalAuthority + ">> for Approval Authority", "PASS");
                }
               
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sCRDescription']/div/div/div/input")).Click();
                //System.Threading.Thread.Sleep(3000);
                //Click on the Save Button
                 lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                // System.Threading.Thread.Sleep(5000);
                // Sroll to the view
                //IWebElement elememet = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']"));
                //IJavaScriptExecutor jscrip = (IJavaScriptExecutor)lib.initializeTest.driver;
                //jscrip.ExecuteScript("arguments[0].scrollIntoView(true);", elememet);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Loan Action details in Build Loan Package", "Should Add Loan Action details in Build Loan Package", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        public static void addLiabilityCalculations(string borrEntName, string LGD, string PD, string interestRate, string margin, string grossExp, string netExp)
        {
            try
            {
                
                //Select Total Liability Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Total Liability']/label")).Click();
                lib.resultUtil.AddResult("Select Total Liability Tab", "Should select Total Liability Tab", "Selected <<Total Liability Tab>>", "PASS");

                //// Sroll to the view
                //IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.cTotalNetExposure']/div/div/div/label"));
                //IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                //js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                //string totalACA1 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.cTotalNetExposure']/div/div/div/label")).Text;
                //string totalGross1 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.cTotalGrossExposure']/div/div/div/label")).Text;

                //Click Add Liability Calculation
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@title='Add Liability Calculation']")).Click();
                lib.resultUtil.AddResult("Click Add Liability Calculation", "Should click Add Liability Calculation", "Clicked on <<Add Liability Calculation>>", "PASS");
                // Verify whether the Add Liability Calculation Dialog box appers
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title' and text()='Add Liability Calculation']")).Displayed)
                {
                    lib.resultUtil.AddResult("Add Liability Calculation Dialog box should apper", "Should Verify whether the Add Liability Calculation Dialog box appers", "Add Liability Calculation Dialog box appers", "PASS");
                }
                //Enter Borrowing Entity Name
                if (borrEntName != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sBorrowerName']/div/div/div/input")).SendKeys(borrEntName);
                    lib.resultUtil.AddResult("Enter the Borrowing Entity Name", "Should enter the Borrowing Entity Name", "Entered <<" + borrEntName + ">> Borrowing Entity Name", "PASS");
                }
                //Enter LGD
                if (LGD != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sLiabilityLGD']/div/div/div/input")).SendKeys(LGD);
                    lib.resultUtil.AddResult("Enter the LGD", "Should enter LGD", "Entered <<" + LGD + ">> LGD", "PASS");
                }
                //Enter PD
                if (PD != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sLiabilityPD']/div/div/div/input")).SendKeys(PD);
                    lib.resultUtil.AddResult("Enter the PD", "Should enter the PD", "Entered <<" + PD + ">> PD", "PASS");
                }
                //Enter Interest Rate(%)
                if (interestRate != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='fInterestRate']/div/div/div/input")).SendKeys(interestRate);
                    lib.resultUtil.AddResult("Enter the Interest Rate(%)", "Should enter the Interest Rate(%)", "Entered <<" + interestRate + ">> Interest Rate(%)", "PASS");
                }
                //Enter Margin(%)
                if (margin != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='fMargin']/div/div/div/input")).SendKeys(margin);
                    lib.resultUtil.AddResult("Enter the Margin(%)", "Should enter the Margin(%)", "Entered <<" + margin + ">> Margin(%)", "PASS");
                }
                //Enter Gross Exposure
                if (grossExp != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='cGrossExposure']/div/div/div/input")).SendKeys(grossExp);
                    lib.resultUtil.AddResult("Enter the Gross Exposure", "Should enter the Gross Exposure", "Entered <<" + grossExp + ">> Gross Exposure", "PASS");
                }
                //Enter Net Exposure
                if (netExp != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='cNetExposure']/div/div/div/input")).SendKeys(netExp);
                    lib.resultUtil.AddResult("Enter the Net Exposure", "Should enter theNet Exposure", "Entered <<" + netExp + ">> Net Exposure", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(3000);

                //// Sroll to the view
                //IWebElement elem3 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.cTotalNetExposure']/div/div/div/label"));
                //IJavaScriptExecutor js3 = (IJavaScriptExecutor)lib.initializeTest.driver;
                //js3.ExecuteScript("arguments[0].scrollIntoView(true);", elem3);

                //string totalACA2 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.cTotalNetExposure']/div/div/div/label")).Text;
                //string totalGross2 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.cTotalGrossExposure']/div/div/div/label")).Text;

                //if ((!totalACA1.Equals(totalACA2)) && (!totalGross1.Equals(totalGross2)))
                //{
                //    lib.resultUtil.AddResult("Total ACA and Total Gross is calculated", "Total ACA and Total Gross should be calculated", "Total ACA and Total Gross is successfully calculated", "PASS");
                //}
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(5000);
                // Sroll to the view
                IWebElement elememt = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']"));
                IJavaScriptExecutor jscrip = (IJavaScriptExecutor)lib.initializeTest.driver;
                jscrip.ExecuteScript("arguments[0].scrollIntoView(true);", elememt);
                System.Threading.Thread.Sleep(3000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Liability Calculations in Build Loan Package", "Should Add Liability Calculations in Build Loan Package", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static Boolean addNarrativeDetails(string borrElig, string borrChar, string capital, string capacity, string collateral, string bCondtns, string genComm)
        {
            Boolean ret = false;
            try
            {
                //Select Narrative Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Narrative']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Narrative']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Narrative']/label")).Click();
                lib.resultUtil.AddResult("Select Narrative Tab", "Should select Narrative Tab", "Selected Narrative Tab", "PASS");
                //Enter Borrower Eligibility
                if (borrElig != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entNarrative.sBorrowerEligibility']/div/div/div/textarea")).SendKeys(borrElig);
                    lib.resultUtil.AddResult("Enter the Borrower Eligibility", "Should enter the Borrower Eligibility", "Entered the Borrower Eligibility", "PASS");
                }
                //Enter Character
                if (borrChar != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entNarrative.sCharacter']/div/div/div/textarea")).SendKeys(borrChar);
                    lib.resultUtil.AddResult("Enter the Character", "Should enter the Character", "Entered the Character", "PASS");
                }
                //Enter Capital
                if (capital != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entNarrative.sCapital']/div/div/div/textarea")).SendKeys(capital);
                    lib.resultUtil.AddResult("Enter the Capital", "Should enter the Capital", "Entered the Capital", "PASS");
                }
                //Enter Capacity
                if (capacity != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entNarrative.sCapacity']/div/div/div/textarea")).SendKeys(capacity);
                    lib.resultUtil.AddResult("Enter the Capacity", "Should enter the Capacity", "Entered the Capacity", "PASS");
                }
                //Enter Collateral
                if (collateral != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entNarrative.sCollateral']/div/div/div/textarea")).SendKeys(collateral);
                    lib.resultUtil.AddResult("Enter the Collateral", "Should enter the Collateral", "Entered the Collateral", "PASS");
                }

                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sGenCreditRequestComments']/div/div/div/textarea")).Click();

                //Enter Conditions
                if (bCondtns != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entNarrative.sConditions']/div/div/div/textarea")).SendKeys(bCondtns);
                    lib.resultUtil.AddResult("Enter the Conditions", "Should enter the Conditions", "Entered the Conditions", "PASS");

                }
                //Enter General Credit Request Comments
                if (genComm != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sGenCreditRequestComments']/div/div/div/textarea")).SendKeys(genComm);
                    lib.resultUtil.AddResult("Enter the General Credit Request Comments", "Should enter the General Credit Request Comments", "Entered the General Credit Request Comments", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(5000);

                // Sroll to the view
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entBE.sBEName']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(false);", elem);
                System.Threading.Thread.Sleep(10000);

                //Select Documents Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();

                lib.resultUtil.AddResult("Select Documents Tab", "Should select Documents Tab", "Selected Documents Tab", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Click on Copy Generated Documents on DocHub
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest']/div/div/div/input")).Click();
                lib.resultUtil.AddResult("Click on Copy Generated Documents on DocHub", "Should click on Copy Generated Documents on DocHub", "Clicked on Copy Generated Documents on DocHub", "PASS");
                //Click on the Genearate Documents for Loan Narrative
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entCreditAnalysis.fileLoanNarrative']/div/div/div/div/div/button")).Click();
                lib.resultUtil.AddResult("Click on Genearate Documents for Loan Narrative", "Should click on Genearate Documents for Loan Narrative", "Clicked on Genearate Documents for Loan Narrative", "PASS");
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'docx')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Generate Documents for Approval Document
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entDecision.fileApprovalDocGenerator']/div/div/div/div/div/button")).Click();
                lib.resultUtil.AddResult("Click on Genearate Documents for Approval Document", "Should click on Genearate Documents for Approval Document", "Clicked on Genearate Documents for Approval Document", "PASS");
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'pdf')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(5000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Narrative details in Build Loan Package", "Should Add Narrative details in Build Loan Package", "EXCEPTION: " + e, "FAIL");
            }
            return ret;

        }
        public static void verifyDocuments()
        { 
            try
            {
                //Select Documents Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();

                lib.resultUtil.AddResult("Select Documents Tab", "Should select Documents Tab", "Selected Documents Tab", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Click on Copy Generated Documents on DocHub
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest']/div/div/div/input")).Click();
                lib.resultUtil.AddResult("Click on Copy Generated Documents on DocHub", "Should click on Copy Generated Documents on DocHub", "Clicked on Copy Generated Documents on DocHub", "PASS");
                System.Threading.Thread.Sleep(5000);
                //Click on Assign Conditions link
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='colLoanActions']/div/div[2]/div[1]/table/tbody/tr/td[5]/div/div/span/a")).Click();
                //Verify whether the Assign Conditions Dialog box appears
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-dialog-title' and text()='Assign Conditions']")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify Assign Conditions dialog box appears", "Should verify whether the Assign Conditions Dialog box appears", "Assign Conditions Dialog box appears", "PASS");
                }
                System.Threading.Thread.Sleep(5000);
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath("html/body/div[8]/div[3]/div/button[1]")).Click();
                System.Threading.Thread.Sleep(5000);
                //Click on the Genarate Documents for Loan Narrative
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entCreditAnalysis.fileLoanNarrative']/div/div/div/div/div/button")).Click();
                lib.resultUtil.AddResult("Click on Genearate Documents for Loan Narrative", "Should click on Genearate Documents for Loan Narrative", "Clicked on Genearate Documents for Loan Narrative", "PASS");
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'docx')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Generate Documents for Approval Document
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entDecision.fileApprovalDocGenerator']/div/div/div/div/div/button")).Click();
                lib.resultUtil.AddResult("Click on Genearate Documents for Approval Document", "Should click on Genearate Documents for Approval Document", "Clicked on Genearate Documents for Approval Document", "PASS");
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'pdf')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Genarate Documents for Commitment Letter
                lib.initializeTest.driver.FindElement(By.XPath(".//td[@class='ui-bizagi-grid-align-center']/div/div/span/div/div/button")).Click();
                lib.resultUtil.AddResult("Click on Genearate Documents for Commitment Letter", "Should click on Genearate Documents for  Commitment Letter", "Clicked on Genearate Documents for Commitment Letter", "PASS");
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='Commitment Letter.docx']")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(5000);
                //Click on Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(3000);
                //Click on Submit For Analysis
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                System.Threading.Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Documents in Build Loan Package", "Should verify Documents in Build Loan Package", "EXCEPTION: " + e, "FAIL");

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
        public static Boolean liteAnalysisCalculatorCommercial(string currAssets, string nonCurrentAsset, string currentLiabilities, string nonCurrentLiabilities, string grossInc, string opExp, string depAmort, string intExp, string taxes, string livExp, string otherIncome)
        {
            Boolean ret = false;

            try
            {
                //Scroll Into View
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Calculators']/label"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                //UnSelect Calculate Eligibility Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.bCalculateEligibility']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("UnSelect Calculate Eligibility Check box", "Should unselect Calculate Eligibility Check box", "Unselected Calculate Eligibility Check box", "PASS");
                System.Threading.Thread.Sleep(2000);

                //Select the Lite Analysis Calculator Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.UseLightAnalysisCalculator']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Lite Analysis Calculator Check box", "Should select Lite Analysis Calculator Check box", "Selected Lite Analysis Calculator Check box", "PASS");

                //Scroll Into View
                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCurrentAssets']/div/div/div/input"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);

                //Enter Current Assets
                if (currAssets != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCurrentAssets']/div/div/div[1]/input")).SendKeys(currAssets);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCurrentAssets']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCurrentAssets']/div/div/div[1]/input")).SendKeys(currAssets);
                    lib.resultUtil.AddResult("Enter Current Asset", "Should enter Current Asset", "Entered <<" + currAssets + ">> for Current Asset", "PASS");
                }
                //Non Current Asset Textbox
                if (nonCurrentAsset != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cNonCurrentAssets']/div/div/div[1]/input")).SendKeys(nonCurrentAsset);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cNonCurrentAssets']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cNonCurrentAssets']/div/div/div[1]/input")).SendKeys(nonCurrentAsset);
                    lib.resultUtil.AddResult("Enter Non Current Asset", "Should enter Non Current Asset", "Entered <<" + nonCurrentAsset + ">> for Non Current Asset", "PASS");
                }
                //Current Liabilities Textbox
                if (currentLiabilities != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCurrentLiabilities']/div/div/div[1]/input")).SendKeys(currentLiabilities);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCurrentLiabilities']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCurrentLiabilities']/div/div/div[1]/input")).SendKeys(currentLiabilities);
                    lib.resultUtil.AddResult("Enter Current Liabilities", "Should enter Current Liabilities", "Entered <<" + currentLiabilities + ">> for Current Liabilities", "PASS");
                }

                //Non Current Liabilities Textbox
                if (nonCurrentLiabilities != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cNonCurrentLiabilities']/div/div/div[1]/input")).SendKeys(nonCurrentLiabilities);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cNonCurrentLiabilities']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cNonCurrentLiabilities']/div/div/div[1]/input")).SendKeys(nonCurrentLiabilities);
                    lib.resultUtil.AddResult("Enter Non Current Liabilities", "Should enter Non Current Liabilities", "Entered <<" + nonCurrentLiabilities + ">> for Non Current Liabilities", "PASS");
                }
                //Owners Equity net worth
                string ownersEquityNetWorth = "";
                ownersEquityNetWorth = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOwnersEquityNetWorth']/div/div/div[1]/label")).Text;
                lib.resultUtil.AddResult("Fetch Owners Equity Net Worth", "Should read Owners Equity Net worth", "Owners Equity Net Worth is <<" + ownersEquityNetWorth + ">> ", "PASS");
                if (ownersEquityNetWorth != null)
                {
                    lib.resultUtil.AddResult("Owners Equity Net Worth is calculated", "Owners Equity Net Worth should be calculated", "Owners Equity Net Worth is calculated ", "PASS");
                }
                //Enter Gross Income
                if (grossInc != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cGrossIncome']/div/div/div[1]/input")).SendKeys(grossInc);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cGrossIncome']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cGrossIncome']/div/div/div[1]/input")).SendKeys(grossInc);
                    lib.resultUtil.AddResult("Enter Gross Income", "Should enter value for Gross Income", "Entered <<" + grossInc + ">> value for Gross Income", "PASS");
                }
                //Enter Operating Expenses
                if (opExp != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOperatingExpenses']/div/div/div[1]/input")).SendKeys(opExp);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOperatingExpenses']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOperatingExpenses']/div/div/div[1]/input")).SendKeys(opExp);
                    lib.resultUtil.AddResult("Enter Operating Expenses", "Should enter value for Operating Expenses", "Entered value for Operating Expenses", "PASS");
                }
                //Enter Deprication/Amortization
                if (depAmort != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cDeprecation']/div/div/div[1]/input")).SendKeys(depAmort);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cDeprecation']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cDeprecation']/div/div/div[1]/input")).SendKeys(depAmort);
                    lib.resultUtil.AddResult("Enter Deprication/Amortization", "Should enter value for Deprication/Amortization", "Entered value for Deprication/Amortization", "PASS");
                }
                //Enter Interest Expense
                if (intExp != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cInterestExpense']/div/div/div[1]/input")).SendKeys(intExp);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cInterestExpense']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cInterestExpense']/div/div/div[1]/input")).SendKeys(intExp);
                    lib.resultUtil.AddResult("Enter Interest Expense", "Should enter value for Interest Expense", "Entered value for Interest Expense", "PASS");
                }
                //Enter Taxes
                if (taxes != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cTaxes']/div/div/div[1]/input")).SendKeys(taxes);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cTaxes']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cTaxes']/div/div/div[1]/input")).SendKeys(taxes);
                    lib.resultUtil.AddResult("Enter Taxes", "Should enter value for Taxes", "Entered value for Taxes", "PASS");
                }
                //Enter Living Expense
                if (livExp != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cLivingExpenses']/div/div/div[1]/input")).SendKeys(livExp);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cLivingExpenses']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cLivingExpenses']/div/div/div[1]/input")).SendKeys(livExp);
                    lib.resultUtil.AddResult("Enter Living Expense", "Should enter value for Living Expense", "Entered value for Living Expense", "PASS");
                }
                //Enter Other Income
                if (otherIncome != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOtherIncome']/div/div/div[1]/input")).SendKeys(otherIncome);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOtherIncome']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOtherIncome']/div/div/div[1]/input")).SendKeys(otherIncome);
                    lib.resultUtil.AddResult("Enter Other Income", "Should enter value for Other Income", "Entered value for Other Income", "PASS");
                }
                //Click on the Recalculate Button
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-tab-609beb60-534e-48dd-bb77-6b023a88e1d9']/div[2]/div/div[2]/div/div[7]/div/div/div/div/div/div/div[1]/input")).Click();
                System.Threading.Thread.Sleep(3000);
                //Current Ratio
                string currRatio = "";
                currRatio = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.dCurrentRatio']/div/div/div[1]/label")).Text;
                lib.resultUtil.AddResult("Fetch Current Ratio", "Should read Current Ratio", "Current Ratio is <<" + currRatio + ">> ", "PASS");
                //Equity Percentage
                string equityPercent = "";
                equityPercent = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.dEquity']/div/div/div[1]/label")).Text;
                lib.resultUtil.AddResult("Fetch Equity Percentage", "Should read Equity Percentage", "Equity Percentage is <<" + equityPercent + ">> ", "PASS");
                if ((currRatio != null) && (equityPercent != null))
                {
                    lib.resultUtil.AddResult("Current Ratio and Equity Percentage is calculated", "Current Ratio and Equity Percentage should be calculated", "Current Ratio and Equity Percentage is calculated ", "PASS");
                }
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Calculate Commercial", "Should Calculate Commercial", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean liteAnalysisCalculatorWageEarner(string yearlySal, string otherIncome, string cashEqui, string mortgage, string realEst, string insurance, string othrOblig)
        {
            Boolean ret = false;

            try
            {
                //Scroll Into View
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Calculators']/label"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                // Select the Wage Earner tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Wage Earner']")).Click();

                //Enter Value Under Income And Assets
                //Enter Yearly Salary/ Wages
                if (yearlySal != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cYearlySalary']/div/div/div[1]/input")).SendKeys(yearlySal);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cYearlySalary']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cYearlySalary']/div/div/div[1]/input")).SendKeys(yearlySal);
                    lib.resultUtil.AddResult("Enter Current Assets", "Should enter value for Current Assets", "Entered value for Current Assets", "PASS");
                }
                //Enter Other Income
                if (otherIncome != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cIAAOtherIncome']/div/div/div[1]/input")).SendKeys(otherIncome);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cIAAOtherIncome']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cIAAOtherIncome']/div/div/div[1]/input")).SendKeys(otherIncome);
                    lib.resultUtil.AddResult("Enter Non Current Assets", "Should enter value for Non Current Assets", "Entered value for Non Current Assets", "PASS");
                }

                //Enter Cash and Equivalent Assets
                if (cashEqui != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCashAndEquivalent']/div/div/div[1]/input")).SendKeys(cashEqui);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCashAndEquivalent']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cCashAndEquivalent']/div/div/div[1]/input")).SendKeys(cashEqui);
                    lib.resultUtil.AddResult("Enter Current Liabilities", "Should enter value for Current Liabilities", "Entered value for Current Liabilities", "PASS");
                }
                // Enter value under Monthly Debt
                //Enter Mortgage Payment /Rent (Monthly)
                if (mortgage != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cMortgagePayment']/div/div/div[1]/input")).SendKeys(mortgage);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cMortgagePayment']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cMortgagePayment']/div/div/div[1]/input")).SendKeys(mortgage);
                    lib.resultUtil.AddResult("Enter Non Current Liabilities", "Should enter value for Non Current Liabilities", "Entered value for Non Current Liabilities", "PASS");
                }

                //Enter Real Estate Taxes (Monthly)
                if (realEst != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cRealEstateTaxes']/div/div/div[1]/input")).SendKeys(realEst);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cRealEstateTaxes']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cRealEstateTaxes']/div/div/div[1]/input")).SendKeys(realEst);
                    lib.resultUtil.AddResult("Enter Gross Income", "Should enter value for Gross Income", "Entered value for Gross Income", "PASS");
                }
                //Enter Insurance (Monthly)
                if (insurance != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cInsurance']/div/div/div[1]/input")).SendKeys(insurance);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cInsurance']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cInsurance']/div/div/div[1]/input")).SendKeys(insurance);
                    lib.resultUtil.AddResult("Enter Operating Expenses", "Should enter value for Operating Expenses", "Entered value for Operating Expenses", "PASS");
                }

                //Enter Other Obligations (Monthly)
                if (othrOblig != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOtherObligations']/div/div/div[1]/input")).SendKeys(othrOblig);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOtherObligations']/div/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.cOtherObligations']/div/div/div[1]/input")).SendKeys(othrOblig);
                    lib.resultUtil.AddResult("Enter Deprication/Amortization", "Should enter value for Deprication/Amortization", "Entered value for Deprication/Amortization", "PASS");
                }
                //Back End Ratio
                string backEnd = "";
                backEnd = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.dBackEndRatio']/div/div/div[1]/label")).Text;
                lib.resultUtil.AddResult("Fetch Current Ratio", "Should read Current Ratio", "Current Ratio is <<" + backEnd + ">> ", "PASS");
                //Cash Reserves
                string cashReserves = "";
                cashReserves = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entLightAnalysisCalculator.dCashReserves']/div/div/div[1]/label")).Text;
                lib.resultUtil.AddResult("Fetch Equity Percentage", "Should read Equity Percentage", "Equity Percentage is <<" + cashReserves + ">> ", "PASS");
                if ((backEnd != null) && (cashReserves != null))
                {
                    lib.resultUtil.AddResult("Back End Ratio and Cash Reserves is calculated", "Back End Ratio and Cash Reserves should be calculated", "Back End Ratio and Cash Reserves is calculated ", "PASS");
                }
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Calculate Wage Earner", "Should Calculate Wage Earner", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
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
        public static void sendNoticeOfIncomplete(string appdate, string missingInfo)
        {
            try
            {
                //Click on the right Arrow icon
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-wp-project-panel-collapseicon ui-bizagi-wp-project-panel-rowicon-right']")).Click();
                lib.resultUtil.AddResult("Click on the right Arror icon", "Should Click on the right Arror icon", "Clicked on the right Arror icon", "PASS");

                //Scroll Into View
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='Add plan']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);
                //Click on the Send Notice Of Incomplete option
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@class='event']/a/span[text()='Send Notice of Incomplete']")).Click();
                lib.resultUtil.AddResult("Click on the Send Notice Of Incomplete option", "Should Click on the Send Notice Of Incomplete option", "Clicked on the Send Notice Of Incomplete option", "PASS");

                //Enter the Incomplete Application Needed By Date
                if (appdate != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCompliance.dIncompleteAppNeededByDate']/div/div/div//span/input")).SendKeys(appdate);
                    lib.resultUtil.AddResult("Enter the Incomplete Application Needed By Date", "Should enter the Incomplete Application Needed By Date", "Entered the Incomplete Application Needed By Date", "PASS");
                }
                //Enter Missing Info
                if (missingInfo != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='PRC_ACR_CreditRequest_entCompliance_colIncompleteAppInfo']/div/div[2]/div[1]/table/tbody/tr/td[2]/div/div/span/textarea")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='PRC_ACR_CreditRequest_entCompliance_colIncompleteAppInfo']/div/div[2]/div[1]/table/tbody/tr/td[2]/div/div/span/textarea")).SendKeys(missingInfo);
                    lib.resultUtil.AddResult("Enter the Missing Information", "Should enter the Missing Information", "Entered the Missing Information", "PASS");
                }
                // Select the Incomplete Application Notice Sent Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCompliance.bIncompleteAppNotice']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Incomplete Application Notice Sent Check box", "Should Select the Incomplete Application Notice Sent Check box", "Selected the Incomplete Application Notice Sent Check box", "PASS");
                // Click on Generate Document
                lib.initializeTest.driver.FindElement(By.XPath(".//button[text()='Generate Document']")).Click();
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'Incomplete Application Notice.docx')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(2000);
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static Boolean assignAnalyst(string creditAnalyst)
        {
            Boolean ret = false;
            try
            {
                // Select 'Assign Analyst' for Assign Analyst Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAssignAnalystDecision']/div/div/div/span/span/div/label[contains(text(),'Assign Analyst')]")).Click();
                lib.resultUtil.AddResult("Select << Assign Analyst >> option for Assign Analyst Decision", "Should select << Assign Analyst >> option for Assign Analyst Decision", "Selected << Assign Analyst >> option for Assign Analyst Decision", "PASS");

                //Select Credit Analyst
                if (creditAnalyst != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Credit Analyst']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Credit Analyst']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + creditAnalyst + "']")).Click();
                    lib.resultUtil.AddResult("Select Credit Analyst", "Should select <<" + creditAnalyst + ">> for Credit Analyst", "Selected <<" + creditAnalyst + ">> for Credit Analyst", "PASS");
                }
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Assign Analyst", "Should Verify Assign Analyst", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean acceptAnalysis(string acceptanceComments)
        {
            Boolean ret = false;
            try
            {
                // Select 'Accepted' for Acceptance Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAcceptanceDecision']/div/div/div/span/span/div/label[contains(text(),'Accepted')]")).Click();
                lib.resultUtil.AddResult("Select << Accepted >> option for Acceptance Decision", "Should select << Accepted >> option for Acceptance Decision", "Selected << Accepted >> option for Acceptance Decision", "PASS");
              
                //Enter the Acceptance Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.sAcceptanceComments']/div/div/div/textarea")).SendKeys(acceptanceComments);
                lib.resultUtil.AddResult("Enter Acceptance Comments", "Should enter Acceptance Comments", "Entered Acceptance Comments", "PASS");

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

        public static void creditAnalysis(string pdModel, string currRatio, string equityCMV, string debtCoverage, string agScore, string assignedPD, string asignedPDGovt, string lgdLoanAmt, string asignedLGDwitoutGurnte, string asignedLGDwithGurnte)
        {
            try
            {
                // Select the Credit Analysis Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Credit Analysis']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Credit Analysis']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Credit Analysis']")).Click();
                lib.resultUtil.AddResult("Select the Credit Analysis Tab", "Should Select the Credit Analysis Tab", "Selected the Credit Analysis Tab", "PASS");

                // Select the Calculate PD Value Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entPDCalculator.bUsePDCalculator']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Calculate PD Value Check box", "Should Select the Calculate PD Value Check box", "Selected the Calculate PD Value Check box", "PASS");
                //Select PD Model
                if (pdModel != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='PD Model']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='PD Model']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + pdModel + "']")).Click();
                    lib.resultUtil.AddResult("Select PD Model", "Should select <<'" + pdModel + "'>> for PD Model", "Selected <b>'" + pdModel + "'</b> for PD Model", "PASS");
                }
                System.Threading.Thread.Sleep(3000);
                //Enter the Current Ratio
                if (currRatio != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entPDCalculator.fCurrentRatio']/div/div/div/input")).SendKeys(currRatio);
                    lib.resultUtil.AddResult("Enter the Current Ratio", "Should enter the Current Ratio", "Entered the Current Ratio", "PASS");
                }
                //Enter the Equity CMV
                if (equityCMV != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entPDCalculator.fEquityAsset']/div/div/div/input")).SendKeys(equityCMV);
                    lib.resultUtil.AddResult("Enter the Equity CMV", "Should enter the Equity CMV", "Entered the Equity CMV", "PASS");
                }
                //Enter the Debt Coverage ratio
                if (debtCoverage != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entPDCalculator.fDebtCoverage']/div/div/div/input")).SendKeys(debtCoverage);
                    lib.resultUtil.AddResult("Enter the Debt Coverage ratio", "Should enter the Debt Coverage ratio", "Entered the Debt Coverage ratio", "PASS");
                }
                //Enter Agscore
                if (agScore != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entPDCalculator.fAgScore']/div/div/div/input")).SendKeys(agScore);
                    lib.resultUtil.AddResult("Enter the Agscore", "Should enter the Agscore", "Entered the Agscore", "PASS");
                }
                //Scroll Into View
                IWebElement calcPD = lib.initializeTest.driver.FindElement(By.XPath(".//*[text()='Calculate PD Value']"));
                IJavaScriptExecutor jsc1 = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc1.ExecuteScript("arguments[0].scrollIntoView(true);", calcPD);
                //Click on the Calculate PD
                // lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Calculate PD']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ui-bizagi-tab-9390761b-5ef1-488e-97ec-bc326e9e0bac']/div[2]/div[1]/div/div/div[2]/div/div/div/div[1]/div/div/div/div[4]/div[1]/div/div[2]/div/div/div/div[1]/input")).Click();
                lib.resultUtil.AddResult("Click on Calculate PD button", "Should Click on Calculate PD button", "Clicked on Calculate PD button", "PASS");
                System.Threading.Thread.Sleep(4000);
                //Verify whether PD Value is calculated
                IWebElement pdval = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entPDCalculator.fCalculatedPDValue']/div/div/div/label"));
                string pdvl = pdval.Text;
                if (pdvl != null)
                {
                    lib.resultUtil.AddResult("Verify whether PD Value is calculated", "PD Value should be calculated", "PD Value is calculated", "PASS");
                }
                //Select Assigned PD 
                if (assignedPD != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + assignedPD + "']")).Click();
                    lib.resultUtil.AddResult("Select PD Model", "Should select <<'" + assignedPD + "'>> for Assigned PD", "Selected <b>'" + assignedPD + "'</b> for Assigned PD", "PASS");
                }
                //Select Assigned PD with Govt Gte
                if (asignedPDGovt != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD with Govt Gte']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD with Govt Gte']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + asignedPDGovt + "']")).Click();
                    lib.resultUtil.AddResult("Select Assigned PD with Govt Gte", "Should select <<'" + asignedPDGovt + "'>> for Assigned PD with Govt Gte", "Selected <b>'" + asignedPDGovt + "'</b> for Assigned PD with Govt Gte", "PASS");
                }
                // Select the Use LGD Calculator Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.bUseLGDCalculator']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Use LGD Calculator Check box", "Should Select the Use LGD Calculator Check box", "Selected the Use LGD Calculator Check box", "PASS");
                //Scroll Into View
                IWebElement addBut = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Use LGD Calculator']"));
                IJavaScriptExecutor jsc2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc2.ExecuteScript("arguments[0].scrollIntoView(true);", addBut);
                System.Threading.Thread.Sleep(3000);
                // Click on the Add LGD Calculations (+ Button)
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='PRC_ACR_CreditRequest_entCreditAnalysis_colLGDCalculations']/div/div[2]/div[3]/table/tbody/tr/th[1]/div/div/ul/li[1]/div")).Click();
                lib.resultUtil.AddResult("Click on Add LGD Calculations button", "Should Click on Add LGD Calculations button", "Clicked on Add LGD Calculations button", "PASS");
                //Enter LGD Loan Amount
                if (lgdLoanAmt != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='cLGDLoanAmount']/div/div/div/input")).SendKeys(lgdLoanAmt);
                    lib.resultUtil.AddResult("Enter the LGD Loan Amount", "Should enter the LGD Loan Amount", "Entered the LGD Loan Amount", "PASS");
                }

                //Scroll Into View
                IWebElement calc = lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title']/../../div[2]/div/div[3]/div/div/div/div[2]/div[1]/div/div[2]/div/div/div/div/input"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", calc);
                //Click on the Calculate Button
                lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title']/../../div[2]/div/div[3]/div/div/div/div[2]/div[1]/div/div[2]/div/div/div/div/input")).Click();
                lib.resultUtil.AddResult("Click on Calculate Button", "Should Click on Calculate Button", "Clicked on Calculate Button", "PASS");
                //Select Assigned LGD without Guarantee
                if (asignedLGDwitoutGurnte != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned LGD without Guarantee']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned LGD without Guarantee']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + asignedLGDwitoutGurnte + "']")).Click();
                    lib.resultUtil.AddResult("Select Assigned LGD without Guarantee", "Should select <<'" + asignedLGDwitoutGurnte + "'>> for Assigned LGD without Guarantee", "Selected <b>'" + asignedLGDwitoutGurnte + "'</b> for Assigned LGD without Guarantee", "PASS");
                }
                //Select Assigned LGD with Guarantee
                if (asignedLGDwithGurnte != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned LGD with Guarantee']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned LGD with Guarantee']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + asignedLGDwithGurnte + "']")).Click();
                    lib.resultUtil.AddResult("Select Assigned LGD with Guarantee", "Should select <<'" + asignedLGDwithGurnte + "'>> for Assigned LGD with Guarantee", "Selected <b>'" + asignedLGDwithGurnte + "'</b> for Assigned LGD with Guarantee", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Click On Save Button", "PASS");
                System.Threading.Thread.Sleep(5000);
                // Click on Generate Documents Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.fileLoanNarrative']/div/div/div[1]/div/div/button")).Click();
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'ACH Credit Request CDA.docx')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                // Select the Recommmended option in the Analyst Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAnalystDecision']/div/div/div/span/span/div/label[text()=' Recommended  ']")).Click();
                lib.resultUtil.AddResult("Select Recommmended option in the Analyst Decision", "Should select Recommmended option in the Analyst Decision", "Selected Recommmended option in the Analyst Decision", "PASS");
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");
                System.Threading.Thread.Sleep(2000);
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
        public static void preDecisionReview(string approveAuth)
        {
            try
            {
                // Select the Pre-Decision Review Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Pre-Decision Review']")).Click();
                lib.resultUtil.AddResult("Select the Pre-Decision Review Tab", "Should Select the Pre-Decision Review Tab", "Selected the Pre-Decision Review Tab", "PASS");

                //Select Approval Authority
                if (approveAuth != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + approveAuth + "']")).Click();
                    lib.resultUtil.AddResult("Select Approval Authority", "Should select <<" + approveAuth + ">> for Approval Authority", "Selected <<" + approveAuth + ">> for Approval Authority", "PASS");
                }
                System.Threading.Thread.Sleep(3000);
                // Select the 'Sending For Decisioning' option for the Pre-Decision Review Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entPreDecisionRevDecision']/div/div/div/span/span/div/label[contains(text(),'Send for Decisioning')]")).Click();
                lib.resultUtil.AddResult("Select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Should select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Selected << Sending For Decisioning >> option for the Pre-Decision Review Decision", "PASS");
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");
                System.Threading.Thread.Sleep(2000);
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Pre-Decision Review", "Should Select Pre-Decision Review", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static void approverDecisionDeny(string approverDecision, string comments, string postDecisionReview, string reapprovecomments)
        {
            try
            {
                // Select the 'Deny' option for Approver Decision
                if (approverDecision != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-render-radio ']/span/div/label[contains(text(),'" + approverDecision + "')]")).Click();
                    lib.resultUtil.AddResult("Select <<" + approverDecision + ">> option for Approver Decision", "Should select <<" + approverDecision + ">> option for Approver Decision", "Selected <<" + approverDecision + ">> option for Approver Decision", "PASS");
                }
                //Enter the Comments/Conditions
                if (comments != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//tbody[@class='ui-bizagi-grid-body']/tr/td[7]/div/div/span/textarea")).SendKeys(comments);
                    lib.resultUtil.AddResult("Enter Comments/Conditions", "Should enter Comments/Conditions", "Entered Comments/Conditions", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");
                System.Threading.Thread.Sleep(2000);
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Verify whether the Final Loan Action Deciosn is displayed as "Denied"
                if (lib.initializeTest.driver.FindElement(By.XPath(".//tbody[@class='ui-bizagi-grid-body']/tr/td[6]/div/div/div[text()='Denied']")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify whether the Final Loan Action Deciosn is displayed as << Denied >>", "Should verify whether the Final Loan Action Deciosn is displayed as << Denied >>", "The Final Loan Action Deciosn is displayed as << Denied >>", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify whether the Final Loan Action Deciosn is displayed as << Denied >>", "Should verify whether the Final Loan Action Deciosn is displayed as << Denied >>", "The Final Loan Action Deciosn is displayed as << Denied >>", "FAIL");
                }
                // Select the 'Return For Reapproval' option for Post Decision Review
                if (postDecisionReview != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entPostApprovalDecision']/div/div/div/span/span/div/label[contains(text(),'" + postDecisionReview + "')]")).Click();
                    lib.resultUtil.AddResult("Select <<" + postDecisionReview + ">> option for Post Decision Review", "Should select <<" + postDecisionReview + ">> option for Post Decision Review", "Selected <<" + postDecisionReview + ">> option for Post Decision Review", "PASS");
                }
                //Enter the Reapproval Comments
                if (reapprovecomments != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.sReapprovalComments']/div/div/div/textarea")).SendKeys(reapprovecomments);
                    lib.resultUtil.AddResult("Enter Reapproval Comments", "Should enter Reapproval Comments", "Entered Reapproval Comments", "PASS");
                }
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(7000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Deny Approver Decision", "Should verify Deny Approver Decision", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static void approverDecisionWithConditions(string approverDecision, string comments, string postDecisionReview)
        {
            try
            {
                // Select the 'Sending For Decisioning' option for the Pre-Decision Review Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entPreDecisionRevDecision']/div/div/div/span/span/div/label[contains(text(),'Send for Decisioning')]")).Click();
                lib.resultUtil.AddResult("Select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Should select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Selected << Sending For Decisioning >> option for the Pre-Decision Review Decision", "PASS");
                System.Threading.Thread.Sleep(2000);
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);

                // Select the 'Approve With Conditions' option for Approver Decision
                if (approverDecision != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-render-radio ']/span/div/label[contains(text(),'" + approverDecision + "')]")).Click();
                    lib.resultUtil.AddResult("Select <<" + approverDecision + ">> option for Approver Decision", "Should select <<" + approverDecision + ">> option for Approver Decision", "Selected <<" + approverDecision + ">> option for Approver Decision", "PASS");
                }
                //Enter the Comments/Conditions
                if (comments != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//tbody[@class='ui-bizagi-grid-body']/tr/td[7]/div/div/span/textarea")).SendKeys(comments);
                    lib.resultUtil.AddResult("Enter Comments/Conditions", "Should enter Comments/Conditions", "Entered Comments/Conditions", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");
                System.Threading.Thread.Sleep(2000);
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Verify whether the Final Loan Action Deciosn is displayed as "Approved with Conditions"
                if (lib.initializeTest.driver.FindElement(By.XPath(".//tbody[@class='ui-bizagi-grid-body']/tr/td[6]/div/div/div[text()='Approved with Conditions']")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify whether the Final Loan Action Deciosn is displayed as << Approved with Conditions >>", "Should verify whether the Final Loan Action Deciosn is displayed as << Approved with Conditions >>", "The Final Loan Action Deciosn is displayed as << Approved with Conditions >>", "PASS");
                }
                else
                {
                    lib.resultUtil.AddResult("Verify whether the Final Loan Action Deciosn is displayed as << Approved with Conditions >>", "Should verify whether the Final Loan Action Deciosn is displayed as << Approved with Conditions >>", "The Final Loan Action Deciosn is displayed as << Approved with Conditions >>", "FAIL");
                }
                //Select Approval Conditions have been addressed check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.bApprovalConditionsAdded']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Approval Conditions have been addressed check box", "Should select Approval Conditions have been addressed check box", "Selected Approval Conditions have been addressed check box", "PASS");

                //Select Documents Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();

                lib.resultUtil.AddResult("Select Documents Tab", "Should select Documents Tab", "Selected Documents Tab", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Click on Copy Generated Documents on DocHub
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest']/div/div/div/input")).Click();
                lib.resultUtil.AddResult("Click on Copy Generated Documents on DocHub", "Should click on Copy Generated Documents on DocHub", "Clicked on Copy Generated Documents on DocHub", "PASS");
                //Click on the Generate Documents for Approval Document
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entDecision.fileApprovalDocGenerator']/div/div/div/div/div/button")).Click();
                lib.resultUtil.AddResult("Click on Genearate Documents for Approval Document", "Should click on Genearate Documents for Approval Document", "Clicked on Genearate Documents for Approval Document", "PASS");
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'pdf')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(5000);
                //Select Decision Review Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Decision Review']")).Click();
                // Scroll Into View
                IWebElement historyLog = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", historyLog);
                // Select 'Submit Credit Request for processing' option for Post Decision review
                if (postDecisionReview != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-render-radio ']/span/div/label[contains(text(),'" + postDecisionReview + "')]")).Click();
                    lib.resultUtil.AddResult("Select <<" + postDecisionReview + ">> option for Post Decision review", "Should select <<" + postDecisionReview + ">> option for Post Decision review", "Selected <<" + postDecisionReview + ">> option for Post Decision review", "PASS");
                }

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Approver Decision with Condition", "Should verify Approver Decision with Condition", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static void cdSubmit(string cdProcLo, string cdRecServLo, string cdMLO)
        {
            try
            {
                //// Select the Credit Delivery Tab
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Credit Delivery']")).Click();
                //lib.resultUtil.AddResult("Select the Credit Delivery Tab", "Should Select the Credit Delivery Tab", "Selected the Credit Delivery Tab", "PASS");

                //Select CD Processing LO
                if (cdProcLo != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD Processing LO']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD Processing LO']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + cdProcLo + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Processing LO", "Should select <<" + cdProcLo + ">> for CD Processing LO", "Selected <<" + cdProcLo + ">> for CD Processing LO", "PASS");
                }
                System.Threading.Thread.Sleep(3000);
                //Select CD Rec/Serv.L/O
                if (cdRecServLo != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD Rec./Serv. L/O']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD Rec./Serv. L/O']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + cdRecServLo + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Rec/Serv.L/O", "Should select <<" + cdRecServLo + ">> for CD Rec/Serv.L/O", "Selected <<" + cdRecServLo + ">> for CD Rec/Serv.L/O", "PASS");
                }
                System.Threading.Thread.Sleep(3000);

                //Select CD MLO/S.A.F.E
                if (cdMLO != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD MLO/S.A.F.E.']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='CD MLO/S.A.F.E.']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + cdMLO + "']")).Click();
                    lib.resultUtil.AddResult("Select CD MLO/S.A.F.E", "Should select <<" + cdMLO + ">> for CD MLO/S.A.F.E", "Selected <<" + cdMLO + ">> for CD MLO/S.A.F.E", "PASS");
                }
                System.Threading.Thread.Sleep(3000);
                // Scroll Into View
                IWebElement elem1 = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Primary Loan Amount']"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", elem1);

                ////Verify whether CD Loan ID is Empty
                //string loanID = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.ACR_M_CDLoan.sCDLoanID']/div/div/div[contains(@class,'ui-bizagi-render-control')]")).Text;
                //if (loanID == "")
                //{
                //    lib.resultUtil.AddResult("Verify whether CD Loan ID is Empty", "CD Loan ID should be Empty", "CD Loan ID IS Empty", "PASS");
                //}
                //else
                //{
                //    lib.resultUtil.AddResult("Verify whether CD Loan ID is Empty", "CD Loan ID should be Empty", "CD Loan ID IS NOT Empty", "FAIL");
                //}
                // Scroll Into View
                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Documents Sent to Borrower']"));
                IJavaScriptExecutor jsc2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);

                //UNABLE TO CLICK ON THIS AS IT THROWS AN ERROR WHILE DOING
                //// Click on Submit Loan To CD Button
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@title='Submit Loan to CD']")).Click();
                //lib.resultUtil.AddResult("Click on Submit Loan To CD Button", "Should click on Submit Loan To CD Button", "Clicked on Submit Loan To CD Button", "PASS");

                // Select the Documents Sent to Borrower Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsSenttoBorrower']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the Documents Sent to Borrower Check box", "Should Select the Documents Sent to Borrower Check box", "Selected the Documents Sent to Borrower Check box", "PASS");

                // Scroll Into View
                IWebElement elem3 = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='RP Name']"));
                IJavaScriptExecutor jsc3 = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc3.ExecuteScript("arguments[0].scrollIntoView(true);", elem3);
                // Select the Pre-Close Checklist Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Pre-Close Checklist']")).Click();
                lib.resultUtil.AddResult("Select the Pre-Close Checklist Tab", "Should Select the Pre-Close Checklist Tab", "Selected the Pre-Close Checklist Tab", "PASS");
                // Select the 'Complete' option for Applicant Pre-Close Task1
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[1]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Applicant Pre-Close Task1", "Should select << Complete >> option for the Applicant Pre-Close Task1", "Selected << Complete >> option for Applicant Pre-Close Task1", "PASS");
                // Select the 'Complete' option for Applicant Pre-Close Task2
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[2]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Applicant Pre-Close Task2", "Should select << Complete >> option for the Applicant Pre-Close Task2", "Selected << Complete >> option for Applicant Pre-Close Task2", "PASS");
                // Select the 'Complete' option for Gurantee Pre-Close Task
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[3]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Gurantee Pre-Close Task", "Should select << Complete >> option for the Gurantee Pre-Close Task", "Selected << Complete >> option for Gurantee Pre-Close Task", "PASS");
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Credit Delivery Submit", "Should verify Credit Delivery Submit", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static void addConditions(string condCat, string conditionDesc, string condType, string respRole)
        {
            try
            {
                //Select Conditions Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Conditions']/label")).Click();
                lib.resultUtil.AddResult("Select Conditions Tab", "Should select Conditions Tab", "Selected Conditions Tab", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Click on Add Condition Category(+ button)
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Add Conditions']/div")).Click();
                lib.resultUtil.AddResult("Click on Add Condition Category", "Should click on Add Condition Category", "Clicked on Add Condition Category", "PASS");
                //Verify whether the Add Conditions Dialog box appears
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-dialog-title' and text()='Add Conditions']")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify Add Conditions dialog box appears", "Should verify whether the Add Conditions Dialog box appears", "Add Conditions Dialog box appears", "PASS");
                }
                //Select Condition Category
                if (condCat != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entConditionCategory']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + condCat + "']")).Click();
                    lib.resultUtil.AddResult("Select Condition Category", "Should select Condition Category", "Selected Condition Category", "PASS");
                }
                //Click on the Commitment letter Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bCommitmentLetter']/div/div/div/label/input")).Click();
                //Enter Condition
                if (conditionDesc != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sCondition']/div/div/div/textarea")).SendKeys(conditionDesc);
                    lib.resultUtil.AddResult("Enter the Conditions", "Should enter the Conditions", "Entered the Conditions", "PASS");
                }
                //Select the Condition Type
                if (condType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entConditionType']/div/div/div[1]/span/span/div/label[contains(text(),'" + condType + "')]")).Click();
                    lib.resultUtil.AddResult("Select option for Condition Type Radio Button", "Should select option for Condition Type Radio Button", "Selected option for Condition Type Radio Button", "PASS");
                }
                //Select Responsible Role
                if (respRole != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entResponsibleRole']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + respRole + "']")).Click();
                    lib.resultUtil.AddResult("Select Condition Category", "Should select Condition Category", "Selected Condition Category", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(5000);
                //Click on Assign Conditions link
                lib.initializeTest.driver.FindElement(By.XPath("//a[text()='Assign Conditions']")).Click();
                //Verify whether the Assign Conditions Dialog box appears
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-dialog-title' and text()='Assign Conditions']")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify Assign Conditions dialog box appears", "Should verify whether the Assign Conditions Dialog box appears", "Assign Conditions Dialog box appears", "PASS");
                }
                // Click on the Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[text()='Life and Crop Insurance']//..//..//preceding-sibling::div//..//..//preceding-sibling::div//..//..//preceding-sibling::td/div/div/span/label/input")).Click();
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(5000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Documents in Build Loan Package", "Should verify Documents in Build Loan Package", "EXCEPTION: " + e, "FAIL");

            }

        }
        public static void verifyDocumentsForAnalyzeCreditRequest()
        {
            try
            {
                //Select Documents Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Documents']")).Click();
                lib.resultUtil.AddResult("Select Documents Tab", "Should select Documents Tab", "Selected Documents Tab", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Click on Copy Generated Documents on DocHub
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest']/div/div/div/input")).Click();
                lib.resultUtil.AddResult("Click on Copy Generated Documents on DocHub", "Should click on Copy Generated Documents on DocHub", "Clicked on Copy Generated Documents on DocHub", "PASS");
                System.Threading.Thread.Sleep(5000);
                //Click on the Genarate Documents for Loan Narrative
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entCreditAnalysis.fileLoanNarrative']/div/div/div/div/div/button")).Click();
                lib.resultUtil.AddResult("Click on Genearate Documents for Loan Narrative", "Should click on Genearate Documents for Loan Narrative", "Clicked on Genearate Documents for Loan Narrative", "PASS");
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'docx')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Generate Documents for Approval Document
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entDecision.fileApprovalDocGenerator']/div/div/div/div/div/button")).Click();
                lib.resultUtil.AddResult("Click on Genearate Documents for Approval Document", "Should click on Genearate Documents for Approval Document", "Clicked on Genearate Documents for Approval Document", "PASS");
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'pdf')]")).Displayed)
                {
                    lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(5000);
                //Click on Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Documents in Analyze Credit request", "Should verify Documents in Analyze Credit request", "EXCEPTION: " + e, "FAIL");

            }

        }

        public static void addExceptions(string excepCat, string expComm)
        {
            try
            {
                //Select Exceptions Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Exceptions']/label")).Click();
                lib.resultUtil.AddResult("Select Exceptions Tab", "Should select Exceptions Tab", "Selected Exceptions Tab", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Click on Add Policy Exceptions(+ button)
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Add Policy Exceptions']/div")).Click();
                lib.resultUtil.AddResult("Click on Add Policy Exceptions", "Should click on Add Policy Exceptions", "Clicked on Add Policy Exceptions", "PASS");
                //Verify whether the Add Policy Exceptions Dialog box appears
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-dialog-title' and text()='Add Policy Exceptions']")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify Add Policy Exceptions dialog box appears", "Should verify whether the Add Policy Exceptions Dialog box appears", "Add Policy Exceptions Dialog box appears", "PASS");
                }
                //Select Exception Category
                if (excepCat != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entExceptionCategory']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + excepCat + "']")).Click();
                    lib.resultUtil.AddResult("Select Exception Category", "Should select Exception Category", "Selected Exception Category", "PASS");
                }
                //Enter Exception Comments
                if (expComm != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='sExceptionItem']/div/div/div/textarea")).SendKeys(expComm);
                    lib.resultUtil.AddResult("Enter the Exception Comments", "Should enter <<" + expComm + ">> for Exception Comments", "Entered <<" + expComm + ">> for Exception Comments", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(5000);
                //Verify whether the Rate Exceptions are displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='Rate Exceptions (Populated from the Individual Loan Actions)']/../../div[@class='bz-rn-grid-wrapper ']/div/table/tbody/tr[@data-bizagi-component='cells']")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify whether Rate Exceptions are displayed", "Should verify whether the Rate Exceptions are displayed", "Rate Exceptions are displayed", "PASS");
                }
                //Verify whether the Fee Exceptions are displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='Fee Exceptions (Populated from the Individual Loan Actions)']/../../div[@class='bz-rn-grid-wrapper ']/div/table/tbody/tr[@data-bizagi-component='cells']")).Displayed)
                {
                    lib.resultUtil.AddResult("Verify whether Fee Exceptions are displayed", "Should verify whether the Fee Exceptions are displayed", "Fee Exceptions are displayed", "PASS");
                }

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Documents in Build Loan Package", "Should verify Documents in Build Loan Package", "EXCEPTION: " + e, "FAIL");

            }

        }

        public static void receiveCompletedDocuments()
        {
            try
            {
                //// Select the Closing Tab
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Closing']")).Click();
                //lib.resultUtil.AddResult("Select the Closing Tab", "Should Select the Closing Tab", "Selected the Closing Tab", "PASS");
                // Select the Documents Received Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsReceived']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the << Documents Received >> Check box", "Should Select the << Documents Received >> Check box", "Selected the Documents Received Check box", "PASS");
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Receive Completed Documents", "Should verify Receive Completed Documents", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static void bookingAndFunding()
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                //// Select the Booking/Funding Tab
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Booking / Funding']")).Click();
                //lib.resultUtil.AddResult("Select the Booking/Funding Tab", "Should Select the Booking/Funding Tab", "Selected the Booking/Funding Tab", "PASS");
                // Select the Loan booked and Funded Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bLoanBooked']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select the << Loan booked and Funded >> Check box", "Should Select the << Loan booked and Funded >> Check box", "Selected the Loan booked and Funded Check box", "PASS");
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Booking/Funding", "Should verify Booking/Funding", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static void postCloseChecklist()
        {
            try
            {
                //// Select the Post-Close Checklist Tab
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Post-Close Checklist']")).Click();
                //lib.resultUtil.AddResult("Select the Post-Close Checklist Tab", "Should Select the Post-Close Checklist Tab", "Selected the Post-Close Checklist Tab", "PASS");
                // Select the 'Complete' option for Post-Close Task1
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[1]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Task1", "Should select << Complete >> option for the Applicant Post-Close Task1", "Selected << Complete >> option for Applicant Post-Close Task1", "PASS");
                // Select the 'Complete' option for Applicant Post-Close Task2
                lib.initializeTest.driver.FindElement(By.XPath("//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[2]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Applicant Post-Close Task2", "Should select << Complete >> option for the Applicant Post-Close Task2", "Selected << Complete >> option for Applicant Post-Close Task2", "PASS");
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
        public static void finalCreditRequestActions()
        {
            try
            {
                //// Select the Post-Close Checklist Tab
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Post-Close Checklist']")).Click();
                //lib.resultUtil.AddResult("Select the Post-Close Checklist Tab", "Should Select the Post-Close Checklist Tab", "Selected the Post-Close Checklist Tab", "PASS");
                // Select the Condition Met Check box
                lib.initializeTest.driver.FindElement(By.XPath(".//table[@class='ui-bizagi-grid-table ']/tbody/tr/td[5]/div/div/span/label/input")).Click();
                lib.resultUtil.AddResult("Select the << Condition Met >> Check box", "Should Select the << Condition Met >> Check box", "Selected the Condition Met Check box", "PASS");
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
                // verify whether the request is submitted successfully
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[contains(text(),'RETURN TO YOUR INBOX TO VIEW YOUR CURRENTLY ASSIGNED TASKS.')]")).Displayed)
                {
                    lib.resultUtil.AddResult("The request should be submitted successfully", "Should verify whether the request is submitted successfully", "The request is submitted successfully", "PASS");

                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify final Credit Request Actions", "Should verify final Credit Request Actions", "EXCEPTION: " + e, "FAIL");
            }
        }
    }
}
    