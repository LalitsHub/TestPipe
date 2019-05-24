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
    //Yankee Credit Request
    class YANCreditRequestcs
    {
        public static IWebElement breadCrumbs = lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-form-process-path box-description']/p"));
        public static IWebElement applicantTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Applicants']/label"));
        public static IWebElement loanActionsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label"));
        public static IWebElement calculatorsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Calculators']/label"));
        public static IWebElement inquiryTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Inquiry']/label"));
        public static IWebElement documentsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Documents']/label"));
        //public static IWebElement newRPType = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'New')]"));
        //public static IWebElement existingType = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'Existing')]"));

        /// <summary>
        /// Function Name : selectTab
        /// Description : Should select the tab by giving the names of the Tab
        /// </summary>
        /// <param name="tabName"></param>
        /// <returns></returns>
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
        /// Function Name : addApplicantYankee
        /// Description : Should Enter all the below fields to Add an applicant to the Yankee Association
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
        /// <param name="popcountyname"></param>
        /// <param name="popCountyCode"></param>
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

        public static Boolean addApplicantYankee(string customerType, string applicantRole, string applicantType, string firstName, string middleName, string lastName, string suffix, string dob, string maritalStatus, string employer, string taxIdNo, string taxExempt, string conflictOfInterest, string address1, string address2, string city, string state, string zipCode, string zipCodeExt, string popcountyname, string popCountyCode, string emailAddress, string homePhoneCode, string homePhone, string workPhoneCode, string workPhone, string workPhoneExt, string faxCode, string faxNumber, string MobilePhoneCode, string MobilePhone)
        {
            Boolean ret = false;
            string str = "";
            try
            {
                selectTab("Applicants");
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'New')]")).Click();
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
        /// Function Name : addResponsiblePartyYankee
        /// Description : Add the below fields to add the responsible party
        /// </summary>
        /// <param name="rpName"></param>
        /// <param name="involvementInFarming"></param>        
        /// <returns></returns>
        public static Boolean addResponsiblePartyYankee(string rpName, string involvementInFarming)
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
        /// Function name :addLoanActionsYankee
        /// Description : Enter the below fiels to Add Loan Actions
        /// </summary>
        /// <param name="branch"></param>
        /// <param name="loanActionCode"></param>
        /// <param name="term"></param>
        /// <param name="loanAmount"></param>
        /// <param name="loanPurpose"></param>
        /// <returns></returns>
        public static Boolean addLoanActionsYankee(string branch, string loanActionCode, string term, string loanAmount, string loanPurpose)
        {
            Boolean ret = false;
            try
            {
                //Select the Loan Actions Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                //System.Threading.Thread.Sleep(2000);

                //Select Branch
                if (branch != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Branch']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Branch']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + branch + "']")).Click();
                    lib.resultUtil.AddResult("Select Branch", "Should select <<" + branch + ">> for Branch", "Selected <<" + branch + ">> for Branch", "PASS");
                }
                //Click on the + Link to add Loan Actions(Compliance Check)
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@title='Add Loan Actions (Compliance Check)']/div")).Click();
                System.Threading.Thread.Sleep(5000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title']")).Displayed)
                {
                    lib.resultUtil.AddResult("Add Loan Actions(Compliance Check) screen", "After clicking on + link Add Loan Actions(Compliance Check) screen should display", "Add Loan Actions(Compliance Check) screen displayed", "PASS");

                    //Select the Loan Action Type ( New )
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Type']/../../span/../div/div/div[1]/span/span[1]/div/label[contains(text(),'New')]")).Click();
                    System.Threading.Thread.Sleep(3000);
                    //Select Loan Action Code 
                    if (loanActionCode != "")
                    {
                        lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Code']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                        lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Loan Action Code']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanActionCode + "']")).Click();
                        lib.resultUtil.AddResult("Select Loan Action Code", "Should select <<" + loanActionCode + ">> for Loan Action Code", "Selected <<" + loanActionCode + ">> for Loan Action Code", "PASS");
                    }
                    System.Threading.Thread.Sleep(3000);
                    //Select Is borrower(s) a Natural Person or Land Trust (tax, land, or estate planning)? (Yes)
                    //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionCompliance.bComplyQuestion1']/div/div/div[1]/div[1]/div[1]/label")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionCompliance.bComplyQuestion1']/div/div/div[1]/div[3]/div[1]/label")).Click();
                    lib.resultUtil.AddResult("Select option for Question 1", "Should select option for Question 1", "Successfully selected option for Question 1", "PASS");

                    //Select Will loan proceeds be used primarily for personal, family or household use? (Yes)
                    //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionCompliance.bComplyQuestion2']/div/div/div[1]/div[1]/div[1]/label")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionCompliance.bComplyQuestion2']/div/div/div[1]/div[3]/div[1]/label")).Click();
                    lib.resultUtil.AddResult("Select option for Question 2", "Should select option for Question 2", "Successfully selected option for Question 2", "PASS");

                    //System.Threading.Thread.Sleep(3000);
                    //Select Will the proposed loan be closed-end and secured by real property? (No)
                    //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bConsumer3DLoan']/div/div/div[1]/div/div[2]/label")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='bConsumer3DLoan']/div/div/div[1]/div/div[2]/label")).Click();
                    lib.resultUtil.AddResult("Select option for Question 3", "Should select option for Question 3", "Successfully selected option for Question 3", "PASS");
                    System.Threading.Thread.Sleep(4000);

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
        /// Function Name :addinquiryDecisionYankee
        /// Description : Enter the below fields to add inquiry Decision
        /// </summary>
        /// <param name="inquiryDecision"></param>
        /// <param name="appCurrentDate"></param>
        /// <param name="inquiryComments"></param>
        /// <returns></returns>
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
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/div/span/input")).Clear();
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/div/span/input")).SendKeys(appCurrentDate);
                lib.resultUtil.AddResult("Enter Application Date", "Should enter Valid Application Date", "Entered <<" + appCurrentDate + ">> for Application Date", "PASS");

                //Enter Inquiry Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).SendKeys(inquiryComments);
                lib.resultUtil.AddResult("Enter Inquiry Comments", "Should enter Inquiry Comments", "Entered <<" + inquiryComments + ">> for inquiryComments", "PASS");

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(3000);

                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton2']")).Click();
                System.Threading.Thread.Sleep(10000);

            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Inquiry Decision", "Should Add Inquiry Decison", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function name : EditLoanActionYankee
        /// Descrription : Edit the loan Action by entering the below fields
        /// </summary>
        /// <param name="docSpl"></param>
        /// <param name="futureClosingDate"></param>
        /// <param name="newMoney"></param>
        /// <param name="consumerLoantype"></param>
        /// <param name="primaryLoan"></param>
        /// <param name="primaryLoanAmount"></param>
        /// <param name="feeType"></param>
        /// <param name="feeAmount"></param>
        /// <param name="policyAmount"></param>
        /// <param name="exceptionComment"></param>
        /// <param name="feeType2"></param>
        /// <param name="feeAmount2"></param>
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
        /// <param name="policyMargin"></param>
        /// <param name="rateExcepComm"></param>
        /// <returns></returns>
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
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entProcessing.uDocumentSpecialist']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-select-dropdown open']/ul/li[text()='" + docSpl + "']")).Click();
                    lib.resultUtil.AddResult("Select Document Specialist", "Should select <<" + docSpl + ">> for Document Specialist", "Selected <<" + docSpl + ">> for Document Specialist", "PASS");
                }

                //Scroll to view
                IWebElement lac = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sCRDescription']/span/label"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", lac);

                //Click on Edit Loan Action Button
                lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='New Loan Actions']/../../div/div/table[@class='ui-bizagi-grid-table ']/tbody/tr/td[9]/div/div/span/div/button[2]/i")).Click();
                lib.resultUtil.AddResult("Click on Edit Loan Action Button", "Should click on Edit Loan Action Button", "Clicked on <<Edit Loan Action Button>>", "PASS");
                System.Threading.Thread.Sleep(5000);
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
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/div/span/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/div/span/input")).SendKeys(futureClosingDate);
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
                // Select Payment Method (Cash)
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entPaymentMethod']/div/div/div/span/span/div/label[contains(text(),'Cash')]")).Click();
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
                System.Threading.Thread.Sleep(3000);
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
                
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']")).Click();
                System.Threading.Thread.Sleep(2000);

                // Click on the submit Button
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Edit Loan Action", "Should Edit Loan Action", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Fucntion Name : addCollateralandApplicationYankee
        /// Description : Add the Collateral
        /// </summary>
        /// <param name="appDecision"></param>
        /// <param name="appComments"></param>
        /// <returns></returns>
        public static Boolean addCollateralandApplicationYankee(string appDecision, string appComments)
        {
            Boolean ret = false;

            try
            {
                // Scroll to the view
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-id='c9c5ab0d-7560-4f6e-ad1d-dcbff28371e3']/span/label[text()='RP Name']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

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
                System.Threading.Thread.Sleep(9000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Collateral and Application", "Should Add Collateral and Application", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : addLoanActiondetailsYan
        /// Description : Shold add the Loan Action Details by giving the below fields
        /// </summary>
        /// <param name="underwritingType"></param>
        /// <param name="approvalAuthority"></param>
        /// <returns></returns>
        public static Boolean addLoanActiondetailsYan(string underwritingType, string approvalAuthority)
        {
            Boolean ret = false;
            try
            {
                //Select Loan Action Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label")).Click();
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected <<Loan Action Tab>>", "PASS");

                System.Threading.Thread.Sleep(4000);
                //Select Underwriting type
                if (underwritingType != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Underwriting Type']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Underwriting Type']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + underwritingType + "']")).Click();
                    lib.resultUtil.AddResult("Select Underwriting type", "Should select <<" + underwritingType + ">> for Underwriting type", "Selected <<" + underwritingType + ">> for Underwriting type", "PASS");
                }
                
                //Select Approval Authority
                if (approvalAuthority != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approval Authority']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + approvalAuthority + "']")).Click();
                    lib.resultUtil.AddResult("Select Approval Authority", "Should select <<" + approvalAuthority + ">> for Approval Authority", "Selected <<" + approvalAuthority + ">> for Approval Authority", "PASS");
                }
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Loan Action details in Build Loan Package", "Should Add Loan Action details in Build Loan Package", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : addLoanPackageDecision
        /// Description : Should add the Loan Package decision
        /// </summary>
        /// <param name="lenderDecision"></param>
        /// <param name="comments"></param>
        /// <returns></returns>
        public static Boolean addLoanPackageDecision(string lenderDecision, string comments)
        {
            Boolean ret = false;

            try
            {
                //Verify whether the Loan Package Tab is Displayed
                if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Package']/label")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Package']/label")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Package']/label")).Click();
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

        /// <summary>
        /// Function Name : verifyAnalysis
        /// Description : Should add values for assignedPD and assignedLGD
        /// </summary>
        /// <param name="assignedPD"></param>
        /// <param name="assignedLGD"></param>
        /// <returns></returns>
        public static Boolean verifyAnalysis(string assignedPD, string assignedLGD)
        {
            Boolean ret = false;
            try
            {
                //Select Assigned PD
                if (assignedPD != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entAssignedPD']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-select-dropdown open']/ul/li[text()='" + assignedPD + "']")).Click();
                    lib.resultUtil.AddResult("Select Assigned PD", "Should select <<" + assignedPD + ">> for Assigned PD", "Selected <<" + assignedPD + ">> for Assigned PD", "PASS");
                }
                System.Threading.Thread.Sleep(3000);

                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.sPDComments']/div/div"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);
                System.Threading.Thread.Sleep(3000);

                //Select No for Use LGC Calculator
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.bUseLGDCalculator']/div/div/div/div/div[2]/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.bUseLGDCalculator']/div/div/div/div/div[2]/label")).Click();
                lib.resultUtil.AddResult("Select No for use LGD Calculator", "Should select <<No>> for use LGD Calculator", "Succssfully selected <<No>> for use LGD Calculator", "PASS");
                System.Threading.Thread.Sleep(5000);

                //Select Assigned LGD
                if (assignedLGD != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.entCRAssignedLGD']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-select-dropdown open']/ul/li[text()='" + assignedLGD + "']")).Click();
                    lib.resultUtil.AddResult("Select Assigned LGD", "Should select <<" + assignedLGD + ">> for Assigned LGD", "Selected <<" + assignedLGD + ">> for Assigned LGD", "PASS");
                }

                //Select the checkbox "Final CDA / Loan Narrative has been Uploaded to DocHub"
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.bCDAUploadedtoDocHub']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Final CDA / Loan Narrative has been Uploaded to DocHub Check box", "Should select Final CDA / Loan Narrative has been Uploaded to DocHub Check box", "Selected <<Final CDA / Loan Narrative has been Uploaded to DocHub>> Check box", "PASS");
                System.Threading.Thread.Sleep(2000);

                // Select Recommended for Analyst Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAnalystDecision']/div/div/div[1]/span/span/div/label[text()=' Recommended  ']")).Click();
                lib.resultUtil.AddResult("Select <<Recommended>> for Analyst Decision", "Should select <<Recommended>> for Analyst Decision", "Successfully selected <<Recommended>> for Analyst Decision", "PASS");
                System.Threading.Thread.Sleep(3000);
                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(5000);

                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.sPDComments']/div/div"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);
                System.Threading.Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Assign Analyst", "Should Verify Assign Analyst", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : verifyCollateralsExceptionsandConditions
        /// Description : Verify Collateral, Exceptions and Conditions
        /// </summary>
        /// <returns></returns>
        public static Boolean verifyCollateralsExceptionsandConditions()
        {
            Boolean ret = false;
            try
            {
                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath("//div[@class='ui-bizagi-form-process-path box-description']/p"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);
                System.Threading.Thread.Sleep(3000);

                // Navigate to Exceptions Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Exceptions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Exceptions']/label")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Exceptions']/label")).Click();
                lib.resultUtil.AddResult("Click on Exceptions Tab", "Should click on Exceptions Tab", "Successfully Clicked on Exceptions Tab", "PASS");
                System.Threading.Thread.Sleep(2000);

                // Select the Exceptions Entry Complete Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entExceptions.bExceptionsReviewed']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Exceptions Entry Complete Check box", "Should select <<Exceptions Entry Complete>> Check box", "Selected <<Exceptions Entry Complete>> Check box", "PASS");
                System.Threading.Thread.Sleep(2000);
                
                // Navigate to Conditions tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Conditions']/label")).Click();
                lib.resultUtil.AddResult("Click on Conditions Tab", "Should click on Conditions Tab", "Successfully Clicked on Conditions Tab", "PASS");
                System.Threading.Thread.Sleep(2000);

                // Select the Conditions Entry Complete Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entConditions.bConditionsReviewed']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Select Conditions Entry Complete Check box", "Should select <<Conditions Entry Complete>> Check box", "Selected <<Conditions Entry Complete>> Check box", "PASS");
                System.Threading.Thread.Sleep(2000);

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
                System.Threading.Thread.Sleep(5000);

                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                System.Threading.Thread.Sleep(7000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Collateral, Exceptions and Conditions tab", "Should Verify Collateral, Exceptions and Conditions tab", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static string fetchCaseID()
        {
            string msg = null;
            string msg1 = null;
            try
            {
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='project-collapse-rightpanel']/div")).Click();
                System.Threading.Thread.Sleep(3000);
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
        /// <summary>
        /// Function Name : preDecisionReview
        /// Description : 'Sending For Decisioning' option for the Pre-Decision Review Decision
        /// </summary>
        /// <param name="approveAuth"></param>
        /// <param name="approver"></param>
        /// <returns></returns>
        public static void preDecisionReview(string approveAuth, string approver)
        {
            try
            {
                // Select the Pre-Decision Review Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Pre-Decision Review']")).Click();
                lib.resultUtil.AddResult("Select the Pre-Decision Review Tab", "Should Select the Pre-Decision Review Tab", "Selected the Pre-Decision Review Tab", "PASS");
              
                // Select the 'Sending For Decisioning' option for the Pre-Decision Review Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entPreDecisionRevDecision']/div/div/div/span/span/div/label[contains(text(),'Send for Decisioning')]")).Click();
                lib.resultUtil.AddResult("Select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Should select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Selected << Sending For Decisioning >> option for the Pre-Decision Review Decision", "PASS");

                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);
                System.Threading.Thread.Sleep(3000);

                //Click on the + symbol to add Approver for Credit request
                lib.initializeTest.driver.FindElement(By.XPath(".//li[@title='Add Approvers for Credit Request']/div")).Click();
                lib.resultUtil.AddResult("Click on the + Symbol", "Should Click on the + Symbol", "Successfully clicked on the + S", "PASS");
                System.Threading.Thread.Sleep(3000);

                //Select Approver
                if (approver != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='uApprover']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-select-dropdown open']/ul/li[text()='" + approver + "']")).Click();
                    lib.resultUtil.AddResult("Select Approver", "Should select <<" + approver + ">> for Approver", "Selected <<" + approver + ">> for Approver", "PASS");
                }

                //Click on the Save Button in the Approver Form
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Save']")).Click();
                lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");
                System.Threading.Thread.Sleep(10000);

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(10000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Pre-Decision Review", "Should Select Pre-Decision Review", "EXCEPTION: " + e, "FAIL");
            }
        }
        public static Boolean searchCase(string caseid)
        {
            Boolean ret = false;
            try
            {
                //Search case ID
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title']")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='caseInput']")).SendKeys(caseid);
                    lib.initializeTest.driver.FindElement(By.XPath(".//button[@id='btn-admin-case-search']")).Click();
                    lib.resultUtil.AddResult("Search Case ID", "Should Search Case ID ", "Successfully Searched Case ID", "PASS");
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Assign Analyst", "Should Verify Assign Analyst", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : clickApproveLoanAction
        /// Description : Click on the Approve Loan Action Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickApproveLoanAction(string username)
        {
            try
            {
                // click on the Approve Loan Action Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Approve Loan Actions')]")).Click();
                lib.resultUtil.AddResult("Select Approve Loan Action checkbox", "Should select Approve Loan Action checkbox", "Successfully selected Approve Loan Action checkbox", "PASS");
                
                // Click on the reassign Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                
                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                
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
        /// Function Name : clickPrepareDocuments
        /// Description : Click on the Prepare Documents Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickPrepareDocuments(string username)
        {
            try
            {
                // click on the Prepare Documents Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Prepare Documents')]")).Click();
                lib.resultUtil.AddResult("Select Prepare Documents checkbox", "Should select Prepare Documents checkbox", "Successfully selected Prepare Documents checkbox", "PASS");
                // Click on the reassign Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
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
        /// Function Name : clickPrintandSentDocuments
        /// Description : Click on the Print and Send Documents Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickPrintandSentDocuments(string username)
        {
            try
            {
                // click on the Print and Send Documents Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Print and Send Documents')]")).Click();
                lib.resultUtil.AddResult("Select Print and Send Documents checkbox", "Should select Print and Send Documents checkbox", "Successfully selected Print and Send Documents checkbox", "PASS");
                // Click on the reassign Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
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
        /// Function Name : clickRecieveDocsandsendforBooking
        /// Description : Click on the Recieve Docs and Send for Booking Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickRecieveDocsandsendforBooking(string username)
        {
            try
            {
                // click on the Recieve Docs and Send for Booking Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Receive Docs and Send for Booking')]")).Click();
                lib.resultUtil.AddResult("Select Recieve Docs and Send for Booking checkbox", "Should select Recieve Docs and Send for Booking checkbox", "Successfully selected Recieve Docs and Send for Booking checkbox", "PASS");
                // Click on the reassign Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
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
        /// Function Name : clickReviewAndBookLoan
        /// Description : Click on the Review and Book Loan Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickReviewAndBookLoan(string username)
        {
            try
            {
                // click on the Review and Book Loan Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Review and Book Loan')]")).Click();
                lib.resultUtil.AddResult("Select Review and Book Loan checkbox", "Should select Review and Book Loan checkbox", "Successfully selected Review and Book Loan checkbox", "PASS");
                // Click on the reassign Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
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
        /// Function Name : clickPostCloseTasks
        /// Description : Click on the Post Close tasks Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickPostCloseTasks(string username)
        {
            try
            {
                // click on the Post Close tasks Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Post Close Tasks')]")).Click();
                lib.resultUtil.AddResult("Select Post Close tasks checkbox", "Should select Post Close tasks checkbox", "Successfully selected Post Close tasks checkbox", "PASS");
                // Click on the reassign Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
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
        /// Function Name : clickFinalCreditRequestActions
        /// Description : Click on the Final Credit Request Actions Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickFinalCreditRequestActions(string username)
        {
            try
            {
                // click on the Final Credit Request Actions Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Final Credit Request Actions')]")).Click();
                lib.resultUtil.AddResult("Select Final Credit Request Actions checkbox", "Should select Final Credit Request Actions checkbox", "Successfully selected Final Credit Request Actions checkbox", "PASS");
                // Click on the reassign Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
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
        /// Function Name : clearFilesForClosing
        /// Description : Click on the clear file for closing Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clearFilesForClosing(string username)
        {
            try
            {
                // click on the clear file for closing Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Clear File for Closing')]")).Click();
                lib.resultUtil.AddResult("Select clear file for closing checkbox", "Should select clear file for closing checkbox", "Successfully selected clear file for closing checkbox", "PASS");
                // Click on the reassign Button
                lib.initializeTest.driver.FindElement(By.XPath(".//button/span[text()='Reassign']")).Click();
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
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
                lib.resultUtil.AddResult("Verify Clear File for closing", "Should Verify Clear File for closing", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : searchCaseIdWithAprroval
        /// Description : Search for the Case ID and select approve loan actions
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithAprroval(string casIn)
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
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/span[text()=' Approve Loan Actions ']")).Click();
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithPrepareDocs
        /// Description : Search for the Case ID and select Documents prepared
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithPrepareDocs(string casIn)
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
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/span[text()=' Prepare Documents ']")).Click();
                System.Threading.Thread.Sleep(3000);

                IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.PRC_ACR_CreditRequest.entLoanPackage.sGenCreditRequestComments']/div/div/div/textarea"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);

                // Select the Documents prepared Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsPrepared']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on Documents prepared Checkbox", "Should click on Documents prepared Checkbox", "Successfully clicked on Documents prepared Checkbox", "PASS");
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
        /// Function Name : searchCaseIdWithReciveDocs
        /// Description : Search for the Case ID and select Receive Docs and Send for Booking
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithReciveDocs(string casIn)
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
                //Click on the Receive Docs and Send for Booking
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/span[text()=' Receive Docs and Send for Booking ']")).Click();
                System.Threading.Thread.Sleep(3000);

                
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(15000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithReviewBookLoan
        /// Description : Search for the Case ID and select Review and Book Loan
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithReviewBookLoan(string casIn)
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
                //Click on the Review and Book Loan
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/span[text()=' Review and Book Loan ']")).Click();
                System.Threading.Thread.Sleep(3000);

                // Select the Loan Booked Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bLoanBooked']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on Loan Booked Checkbox", "Should click on Loan Booked Checkbox", "Successfully clicked on Loan Booked Checkbox", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(15000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithPostcloseTasks
        /// Description : Search for the Case ID and select Post Close Tasks
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithPostcloseTasks(string casIn)
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
                //Click on the Post Close Tasks
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/span[text()=' Post Close Tasks ']")).Click();
                System.Threading.Thread.Sleep(3000);
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithFinalCreditRequestActions
        /// Description : Final Credit Request Actions
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithFinalCreditRequestActions(string casIn)
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
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/span[text()=' Final Credit Request Actions ']")).Click();
                System.Threading.Thread.Sleep(5000);
                // Select the Upload Documenst Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Upload Documents']")).Click();
                lib.resultUtil.AddResult("Select the Upload Documenst Tab", "Should Select the Upload Documenst Tab", "Selected the Upload Documenst Tab", "PASS");
                System.Threading.Thread.Sleep(5000);

                // Select the All AgVUE Documents have been uploaded to DocHub Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entProcessing.bDocsUploadedtoDocHub']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on All AgVUE Documents have been uploaded to DocHub Checkbox", "Should click on All AgVUE Documents have been uploaded to DocHub Checkbox", "Successfully clicked on All AgVUE Documents have been uploaded to DocHub Checkbox", "PASS");
                // Select the All Documents have been uploaded to AgDocs Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entProcessing.bDocsUploadedtoAgDocs']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on All Documents have been uploaded to AgDocs Checkbox", "Should click on All Documents have been uploaded to AgDocs Checkbox", "Successfully clicked on All Documents have been uploaded to AgDocs Checkbox", "PASS");
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(5000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : selectIndependentVerification
        /// Description : Select the Independent Verification  Checkbox
        /// </summary>
        /// <returns></returns>
        public static void selectIndependentVerification()
        {
            try
            {
                // Select the Independent Verification  Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bIndependentVerified']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on Independent Verification Checkbox", "Should click on Independent Verification Checkbox", "Successfully clicked on Independent Verification Checkbox", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(15000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Independent Verification", "Should Select Independent Verification", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithPrintandSendDocs
        /// Description : Select the Documents Printed Checkbox
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithPrintandSendDocs(string casIn)
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
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/span[text()=' Print and Send Documents ']")).Click();
                System.Threading.Thread.Sleep(3000);

                // Select the Documents Printed Checkbox
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsPrinted']/div/div/div/label/input")).Click();
                lib.resultUtil.AddResult("Click on Documents Printed Checkbox", "Should click on Documents Printed Checkbox", "Successfully clicked on Documents Printed Checkbox", "PASS");
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(15000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithClearFile
        /// Description : Search Case and Click on the Clear File for Closing
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>

        public static void searchCaseIdWithClearFile(string casIn)
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
                //Click on the Clear File for Closing
                lib.initializeTest.driver.FindElement(By.XPath(".//ul/li/span[text()=' Clear File for Closing ']")).Click();
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : selectApproverDecision
        /// Description : Select Approve for Approver decision and then submit
        /// </summary>
        /// <returns></returns>
        public static Boolean selectApproverDecision( )
        {
            Boolean ret = false;

            try
            {
                //Select Approve for Approver decision
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-render-radio ']/span/div/label[text()=' Approve  ']")).Click();
                lib.resultUtil.AddResult("Select Approve for Approver decision", "Should select Approve for Approver decision", "Selected Approve for Approver decision", "PASS");
                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                System.Threading.Thread.Sleep(7000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Approver Decision", "Should Select Approver Decison", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : selectDocReviewDecision
        /// Description : Select Approve for Document Review Decision and then submit
        /// </summary>
        /// <returns></returns>
        public static void selectDocReviewDecision()
        {
            try
            {
                //Select Approve for Document Review Decision
                lib.initializeTest.driver.FindElement(By.XPath(".//label[text()=' Approved  ']")).Click();
                lib.resultUtil.AddResult("Select Approve for Document Review Decision", "Should select Approve for Document Review Decision", "Selected Approve for Document Review Decision", "PASS");
                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                System.Threading.Thread.Sleep(15000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Approver Decision", "Should Select Approver Decison", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : selectPostDecisionReview
        /// Description : Select "Submit Credit Request For Processing" for Post decision Review and then submit
        /// </summary>
        /// <returns></returns>
        public static void selectPostDecisionReview()
        {
            try
            {
                //scroll into view
                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);
                System.Threading.Thread.Sleep(3000);

                //Select "Submit Credit Request For Processing" for Post decision Review
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-render-radio ']/span/div/label[text()=' Submit Credit Request for Processing  ']")).Click();
                lib.resultUtil.AddResult("Select Post decision Review", "Should select Post decision Review", "Selected Post decision Review", "PASS");
                System.Threading.Thread.Sleep(5000);
                // Click on the submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                System.Threading.Thread.Sleep(12000);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Post Decison review", "Should Select Post Decision Review", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : selectCDSubmit
        /// Description : Select "Submit Credit Request For Processing" for Post decision Review and then submit
        /// </summary>
        /// <param name="cdProcLO"/>
        /// <param name="cdRec"/>
        /// <returns></returns>
        public static void selectCDSubmit(string cdProcLO, string cdRec)
        {
            try
            {
                //Select CD Processing LO
                if (cdProcLO != "")
                { 
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.PRC_ACR_CreditRequest.entLoanPackage.entCDProcessingLO']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-select-dropdown open']/ul/li[text()='" + cdProcLO + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Processing LO", "Should select <<" + cdProcLO + ">> for CD Processing LO", "Selected <<" + cdProcLO + ">> for CD Processing LO", "PASS");
                }
                //Select CD Rec./Serv./L/O
                if (cdRec != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.PRC_ACR_CreditRequest.entLoanPackage.entCDRecServLO']/div/div/div/div/div/input")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-select-dropdown open']/ul/li[text()='" + cdRec + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Rec./Serv./L/O", "Should select <<" + cdProcLO + ">> for CD Rec./Serv./L/O", "Selected <<" + cdProcLO + ">> for CD Rec./Serv./L/O", "PASS");
                }

                // Click on the Submit Loan to CD Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@title='Submit Loan to CD']")).Click();
                lib.resultUtil.AddResult("Click on the Submit Loan to CD Button", "Should Click on the Submit Loan to CD Button", "Clicked on the Submit Loan to CD Button", "PASS");
                System.Threading.Thread.Sleep(10000);

            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Post Decison review", "Should Select Post Decision Review", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : checkPreCloseChecklist
        /// Description : Select the Pre-Close Checklist Tab and Select the 'Complete' option for Pre-Close Status
        /// </summary>
        /// <returns></returns>
        public static void checkPreCloseChecklist()
        {
            try
            {
                // Scroll to the top of the Page
                IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']/p"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);
                System.Threading.Thread.Sleep(4000);

                // Select the Pre-Close Checklist Tab
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Pre-Close Checklist']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Pre-Close Checklist']")).Click();
                lib.resultUtil.AddResult("Select the Pre-Close Checklist Tab", "Should Select the Pre-Close Checklist Tab", "Selected the Pre-Close Checklist Tab", "PASS");
                System.Threading.Thread.Sleep(5000);
                // Select the 'Complete' option for Pre-Close Status1
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[1]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status1", "Should select << Complete >> option for Pre-Close Status1", "Selected << Complete >> option Pre-Close Status1", "PASS");
                // Select the 'Complete' option for Pre-Close Status2
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[2]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status2", "Should select << Complete >> option for Pre-Close Status2", "Selected << Complete >> option Pre-Close Status2", "PASS");
                // Select the 'Complete' option for Pre-Close Status3
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[3]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status3", "Should select << Complete >> option for Pre-Close Status3", "Selected << Complete >> option Pre-Close Status3", "PASS");
                // Select the 'Complete' option for Pre-Close Status4
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[4]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status4", "Should select << Complete >> option for Pre-Close Status4", "Selected << Complete >> option Pre-Close Status4", "PASS");

                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);
                System.Threading.Thread.Sleep(3000);

                // Select the 'Complete' option for Pre-Close Status5
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[5]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status5", "Should select << Complete >> option for Pre-Close Status5", "Selected << Complete >> option Pre-Close Status5", "PASS");
                
                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(15000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Pre Close Checklist", "Should verify Pre Close Checklist", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : checkPostCloseChecklist
        /// Description : Select the 'Complete' option for Post-Close Status and then submit
        /// </summary>
        /// <returns></returns>
        public static void checkPostCloseChecklist()
        {
            try
            {
                // Select the 'Complete' option for Post-Close Status1
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[1]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status1", "Should select << Complete >> option for Post-Close Status1", "Selected << Complete >> option Post-Close Status1", "PASS");
                // Select the 'Complete' option for Post-Close Status2
                lib.initializeTest.driver.FindElement(By.XPath("//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[2]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status2", "Should select << Complete >> option for Post-Close Status2", "Selected << Complete >> option Post-Close Status2", "PASS");
                // Select the 'Complete' option for Post-Close Status3
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[3]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status3", "Should select << Complete >> option for Post-Close Status3", "Selected << Complete >> option Post-Close Status3", "PASS");
                // Select the 'Complete' option for Post-Close Status4
                lib.initializeTest.driver.FindElement(By.XPath("//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[4]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status4", "Should select << Complete >> option for Post-Close Status4", "Selected << Complete >> option Post-Close Status4", "PASS");
                // Select the 'Complete' option for Post-Close Status5
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[5]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status5", "Should select << Complete >> option for Post-Close Status5", "Selected << Complete >> option Post-Close Status5", "PASS");

                IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);
                System.Threading.Thread.Sleep(3000);

                // Select the 'Complete' option for Post-Close Status6
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[6]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status5", "Should select << Complete >> option for Post-Close Status5", "Selected << Complete >> option Post-Close Status5", "PASS");

                //Click on the Submit Button
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton1']")).Click();
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(15000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Post Close Checklist", "Should verify Post Close Checklist", "EXCEPTION: " + e, "FAIL");
            }
        }
    }
}