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
    //North West Florida Credit Request
    class NWFCreditRequestcs
    {
        public static IWebElement breadCrumbs = lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-form-process-path box-description']/p"));
        public static IWebElement applicantTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Applicants']/label"));
        public static IWebElement loanActionsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Loan Actions']/label"));
        public static IWebElement calculatorsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Calculators']/label"));
        public static IWebElement inquiryTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Inquiry']/label"));
        public static IWebElement documentsTab = lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Documents']/label"));
        ////public static IWebElement newRPType = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'New')]"));
        ////public static IWebElement existingType = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'Existing')]"));

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
        /// Function Name : addApplicantCapeFear
        /// Description : Should Enter all the below fields to Add an applicant to the CapeFear Association
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

        public static Boolean addApplicantNWF(string customerType, string applicantRole, string applicantType, string firstName, string middleName, string lastName, string suffix, string dob, string maritalStatus, string employer, string taxIdNo, string taxExempt, string conflictOfInterest, string address1, string address2, string city, string state, string zipCode, string zipCodeExt, string popcountyname, string popCountyCode, string emailAddress, string homePhoneCode, string homePhone, string workPhoneCode, string workPhone, string workPhoneExt, string faxCode, string faxNumber, string MobilePhoneCode, string MobilePhone)
        {
            Boolean ret = false;
            string str = "";
            try
            {
                selectTab("Applicants");
                System.Threading.Thread.Sleep(3000);
                //Select New PR type
                lib.generalLib.waitAndClick("XPATH", ".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'New')]");
                lib.generalLib.waitAndClick("XPATH", ".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'New')]");
                lib.resultUtil.AddResult("Select New option of PR type", "Should select New option of PR type", "Selected New option of PR type", "PASS");

                IWebElement plusLink = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entBEType']/div/div/div/span/span/div/label[contains(text(),'New')]"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", plusLink);
                System.Threading.Thread.Sleep(3000);
                //Click on the + Link to add aplicant
                lib.generalLib.waitAndClick("XPATH", ".//*[@id='PRC_ACR_CreditRequest_entBE_colApplicants']/div/div[2]/div[3]/table/tbody/tr/th[1]/div/div/ul/li[1]/div");
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='PRC_ACR_CreditRequest_entBE_colApplicants']/div/div[2]/div[3]/table/tbody/tr/th[1]/div/div/ul/li[1]/div")).Click();
                lib.resultUtil.AddResult("Click on + icon", "Should click on + icon", "Clicked on + icon", "PASS");
                System.Threading.Thread.Sleep(2000);

                if (lib.initializeTest.driver.FindElement(By.XPath("html/body/div[6]")).Displayed)
                {
                    lib.resultUtil.AddResult("Add applicants screen", "After clicking on << + >>link Add applicants screen should display", "Add applicants screen displayed", "PASS");
                    //Select Customer Type
                    if (customerType != "")
                    {
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='37b72e42-7308-4acc-b740-a45e84b836fa']");
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='dd-37b72e42-7308-4acc-b740-a45e84b836fa']/ul/li[text()='" + customerType + "']");
                        lib.resultUtil.AddResult("Select Customer Type", "Should select <<'" + customerType + "'>> for Customer Type", "Selected <<'" + customerType + "'>> for Customer Type", "PASS");
                    }
                    //Select Applicant Role
                    if (applicantRole != "")
                    {
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='3d807d0e-4325-468c-9cc8-e859fd465660']");
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='dd-3d807d0e-4325-468c-9cc8-e859fd465660']/ul/li[text()='" + applicantRole + "']");
                        lib.resultUtil.AddResult("Select Applicant Role", "Should select <<" + applicantRole + ">> for Applicant Role", "Selected <<" + applicantRole + ">> for Applicant Role", "PASS");
                    }
                    //Select Applicant Type
                    if (applicantType != "")
                    {
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='a43db5b4-cb7d-44ab-950a-2bd51be450b5']");
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='dd-a43db5b4-cb7d-44ab-950a-2bd51be450b5']/ul/li[text()='" + applicantType + "']");
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
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='32772719-0ebf-44fa-9d3e-87ac201e31ac']");
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='dd-32772719-0ebf-44fa-9d3e-87ac201e31ac']/ul/li[text()='" + suffix + "']");
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
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='f6a21af6-a4ec-4a30-b996-14691f9c4075']");
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='dd-f6a21af6-a4ec-4a30-b996-14691f9c4075']/ul/li[text()='" + maritalStatus + "']");
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
                        lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='bIsTaxExempt']/div/div/div[1]/div/label");
                        lib.resultUtil.AddResult("Select Tax Exempt", "Should select Tax exempt check box", "Selected <<Tax exempt>> check box", "PASS");
                    }
                    //Select Conflict of Interest
                    if (conflictOfInterest != "")
                    {
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='8cbff5a0-f662-45a7-8b56-8f38d2abbef4']");
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='dd-8cbff5a0-f662-45a7-8b56-8f38d2abbef4']/ul/li[text()='" + conflictOfInterest + "']");
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
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='ab3e2734-6a33-42a1-bf63-6c20ef05db9f']");
                        lib.generalLib.waitAndClick("XPATH", ".//*[@id='dd-ab3e2734-6a33-42a1-bf63-6c20ef05db9f']/ul/li[text()='" + state + "']");
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
                    lib.generalLib.waitAndClick("XPATH", "html/body/div[6]/div[3]/div/button[1]");
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
                System.Threading.Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add applicant", "Should add applicant", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        /// <summary>
        /// Function Name : addResponsibleParty
        /// Description : Add the below fields to add the responsible party
        /// </summary>
        /// <param name="rpName"></param>
        /// <param name="involvementInFarming"></param>        
        /// <returns></returns>
        public static Boolean addResponsiblePartyNWF(string rpName, string involvementInFarming)
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
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Involvement In Farming']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Involvement In Farming']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + involvementInFarming + "']");
                    lib.resultUtil.AddResult("Select Involvement In Farming", "Should select <<" + involvementInFarming + ">> for Involvement In Farming", "Selected <<" + involvementInFarming + ">> for Involvement In Farming", "PASS");
                }

                //Select 'Official Loan' as No
                lib.generalLib.waitAndClick("XPATH", ".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bOfficialLoan']/div/div/div/div/div/label[contains(text(),'No')]");
                lib.resultUtil.AddResult("Select No option of Official Loan", "Should select No option of Official Loan", "Selected No option of Official Loan", "PASS");
                //Select 'Minority Farmer' as No
                lib.generalLib.waitAndClick("XPATH", ".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bMinorityFarmer']/div/div/div/div/div/label[contains(text(),'No')]");
                lib.resultUtil.AddResult("Select No option of Minority Farmer", "Should select No option of Minority Farmer", "Selected No option of Minority Farmer", "PASS");

                // Scroll to the top of the Page
                IWebElement allSpouse = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entAreSpousesOnLoan']/div/div/div/span/span/div/label[contains(text(),'Yes')]"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", allSpouse);

                //Select 'Are all spouses of signers and guarantors obligated on this loan' as Yes
                lib.generalLib.waitAndClick("XPATH", ".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.entAreSpousesOnLoan']/div/div/div/span/span/div/label[contains(text(),'Yes')]");
                lib.resultUtil.AddResult("Select Yes option of Are all spouses of signers and guarantors obligated on this loan", "Should select Yes option of Are all spouses of signers and guarantors obligated on this loan", "Selected Yes option of Are all spouses of signers and guarantors obligated on this loan", "PASS");
                //Select 'Out of Trade Area' as No
                lib.generalLib.waitAndClick("XPATH", ".//div[@data-render-xpath='PRC_ACR_CreditRequest.entBE.bOutofTradeArea']/div/div/div/div/div/label[contains(text(),'No')]");
                lib.resultUtil.AddResult("Select No option of Out of Trade Area", "Should select No option of Out of Trade Area", "Selected No option of Out of Trade Area", "PASS");

                // Scroll to the top of the Page
                IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']/p"));
                //IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Responsible Party", "Should add Responsible Party", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function name :addLoanActions
        /// Description : Enter the below fiels to Add Loan Actions
        /// </summary>
        /// <param name="LoanAdministrator"></param>
        /// <param name="branch"></param>
        /// <param name="loanActionCode"></param>
        /// <param name="term"></param>
        /// <param name="loanAmount"></param>
        /// <param name="loanPurpose"></param>
        /// <returns></returns>
        public static Boolean addLoanActions(string LoanAdministrator, string branch, string loanActionCode, string term, string loanAmount, string loanPurpose)
        {
            Boolean ret = false;
            try
            {
                //Select the Loan Actions Tab
                lib.generalLib.waitAndClick("XPATH", ".//a[@title='Loan Actions']/label");
                lib.resultUtil.AddResult("Select Loan Actions Tab", "Should select the Loan Actions Tab", "Loan Actions Tab selected", "PASS");

                //Select Loan Administrator
                if (LoanAdministrator != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Loan Administrator']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Loan Administrator']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + LoanAdministrator + "']");
                    lib.resultUtil.AddResult("Select Loan Administrator", "Should select <<" + LoanAdministrator + ">> for Branch", "Selected <<" + LoanAdministrator + ">> for Branch", "PASS");

                }
                //Select Branch                
                if (branch != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Branch']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Branch']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + branch + "']");
                    lib.resultUtil.AddResult("Select Branch", "Should select <<" + branch + ">> for Branch", "Selected <<" + branch + ">> for Branch", "PASS");
                }
                //Click on the + Link to add Loan Actions(Compliance Check)
                lib.generalLib.waitAndClick("XPATH", ".//li[@title='Add Loan Actions (Compliance Check)']/div");
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title']")).Displayed)
                {
                    lib.resultUtil.AddResult("Add Loan Actions(Compliance Check) screen", "After clicking on + link Add Loan Actions(Compliance Check) screen should display", "Add Loan Actions(Compliance Check) screen displayed", "PASS");

                    //Select the Loan Action Type ( New )
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Loan Action Type']/../../span/../div/div/div[1]/span/span[1]/div/label[contains(text(),'New')]");

                    //Select Loan Action Code 
                    if (loanActionCode != "")
                    {
                        lib.generalLib.waitAndClick("XPATH", ".//label[text()='Loan Action Code']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                        lib.generalLib.waitAndClick("XPATH", ".//label[text()='Loan Action Code']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanActionCode + "']");
                        lib.resultUtil.AddResult("Select Loan Action Code", "Should select <<" + loanActionCode + ">> for Loan Action Code", "Selected <<" + loanActionCode + ">> for Loan Action Code", "PASS");
                    }

                    //Select Is borrower(s) a Natural Person or Land Trust (tax, land, or estate planning)? (Yes)                    
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entLoanActionCompliance.bComplyQuestion1']/div/div/div[1]/div[3]/div[1]/label");
                    lib.resultUtil.AddResult("Select option for Question 1", "Should select option for Question 1", "Successfully selected option for Question 1", "PASS");

                    //Select Will loan proceeds be used primarily for personal, family or household use? (Yes)                    
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entLoanActionCompliance.bComplyQuestion2']/div/div/div[1]/div[3]/div[1]/label");
                    lib.resultUtil.AddResult("Select option for Question 2", "Should select option for Question 2", "Successfully selected option for Question 2", "PASS");

                    //Select Will the proposed loan be closed-end and secured by real property? (No)
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='bConsumer3DLoan']/div/div/div[1]/div/div[2]/label");
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
                        lib.generalLib.waitAndClick("XPATH", ".//label[text()='Loan Purpose']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                        lib.generalLib.waitAndClick("XPATH", ".//label[text()='Loan Purpose']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + loanPurpose + "']");
                        lib.resultUtil.AddResult("Select Loan Purpose", "Should select <<" + loanPurpose + ">> for Loan Purpose", "Selected <<" + loanPurpose + ">> for Loan Purpose", "PASS");
                    }
                    //Click on the Save Button
                    lib.generalLib.waitAndClick("XPATH", ".//span[text()='Save']");
                    lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Loan Actions", "Should add Loan Actions", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name :addinquiryDecisionNWF
        /// Description : Enter the below fields to add inquiry Decision
        /// </summary>
        /// <param name="inquiryDecision"></param>
        /// <param name="appCurrentDate"></param>
        /// <param name="inquiryComments"></param>
        /// <returns></returns>
        public static Boolean addinquiryDecisionNWF(string inquiryDecision, string appCurrentDate, string inquiryComments)
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
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Inquiry']/label");
                lib.resultUtil.AddResult("Select Inquiry Tab", "Should select Inquiry Tab", "Selected <<Inquiry Tab>>", "PASS");

                //Select Inquiry Decision
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entInquiryDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + inquiryDecision + "')]");
                lib.resultUtil.AddResult("Select option <<" + inquiryDecision + ">> for Inquiry Decision", "Should select option <<" + inquiryDecision + ">> for Inquiry Decision", "Successfully selected option <<" + inquiryDecision + ">> for Inquiry Decision", "PASS");

                //Enter Valid Application Date
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/div/span/input")).Clear();
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.dApplicationDate']/div/div/div/div/span/input")).SendKeys(appCurrentDate);
                lib.resultUtil.AddResult("Enter Application Date", "Should enter Valid Application Date", "Entered <<" + appCurrentDate + ">> for Application Date", "PASS");

                //Enter Inquiry Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).SendKeys(inquiryComments);
                lib.resultUtil.AddResult("Enter Inquiry Comments", "Should enter Inquiry Comments", "Entered <<" + inquiryComments + ">> for inquiryComments", "PASS");

                //Click on the Save Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton0']");
                lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");

                // Click on the submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton2']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(3000);
                
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Inquiry Decision", "Should Add Inquiry Decison", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function name : EditLoanActionNWF
        /// Descrription : Edit the loan Action by entering the below fields
        /// </summary>
        /// <param name="futureClosingDate"></param>
        /// <param name="newMoney"></param>
        /// <param name="consumerLoantype"></param>
        /// <param name="primaryLoan"></param>
        /// <param name="primaryLoanAmount"></param>
        /// <param name="feeType"></param>
        /// <param name="feeAmount"></param>
        /// <param name="policyAmount"></param>
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
        public static Boolean EditLoanActionNWF(string docSpl, string futureClosingDate, string newMoney, string consumerLoantype, string primaryLoan, string primaryLoanAmount, string feeType, string feeAmount, string policyAmount, string exceptionComment, string feeType2, string feeAmount2, string subsidary, string termType, string loanType, string fcaLoanType, string primSICCode, string secSICCode, string primSICDep, string secSICDep, string accSystem, string secLoan, string rateType, string stateRate, string policyMargin, string rateExcepComm)
        {
            Boolean ret = false;

            try
            {
                //Select Loan Action Tab                
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Loan Actions']/label");
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected Loan Action Tab", "PASS");
                //System.Threading.Thread.Sleep(2000);

                //Scroll to view
                IWebElement lac = lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Loan Actions']/label"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", lac);

                //Click on Edit Loan Action icon
                lib.generalLib.waitAndClick("XPATH", ".//span[text()='New Loan Actions']/../../div/div/table[@class='ui-bizagi-grid-table ']/tbody/tr/td[9]/div/div/span/div/button[2]/i");
                lib.resultUtil.AddResult("Click on Edit Loan Action icon", "Should click on Edit Loan Action icon", "Clicked on <<Edit Loan Action icon>>", "PASS");
                //System.Threading.Thread.Sleep(2000);

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
                lib.generalLib.waitAndClick("XPATH", ".//label[text()='Loan Action']");
                lib.resultUtil.AddResult("Select Loan Action Tab", "Should select Loan Action Tab", "Selected <<Loan Action Tab>>", "PASS");

                //Enter the valid Estimated closing Date
                if (futureClosingDate != "")
                {
                    //Enter the date
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/div/span/input")).Clear();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='dEstimatedClosingDate']/div/div/div/div/span/input")).SendKeys(futureClosingDate);
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entLoanActionType']/div/div");
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
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entLoanRequestType']/div/div/div/div/div/input");
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-select-dropdown open']/ul/li[text()='" + consumerLoantype + "']")).Click();
                    lib.resultUtil.AddResult("Select CD Consumer Loan type", "Should select Consumer Loan type", "Selected <<" + consumerLoantype + ">> for Consumer Loan type", "PASS");
                }

                // Check on Additional Loan Purposes
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='bAdditionalLoanPurposes']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Additional Loan Purposes", "Should click on Additional Loan Purposes", "Successfully clicked on <<Additional Loan Purposes>>", "PASS");

                //Select Primary Loan Purpose
                if (primaryLoan != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entLoanPurpose3']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-select-dropdown open']/ul/li[text()='" + primaryLoan + "']");
                    lib.resultUtil.AddResult("Select Primary Loan Purpose", "Should select Primary Loan Purpose", "Selected <<" + primaryLoan + ">> for Primary Loan Purpose", "PASS");
                }
                //Enter Primary Loan Amount
                if (primaryLoanAmount != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanPurpose3']/div/div/div/div/div/input")).SendKeys(primaryLoanAmount);
                    lib.resultUtil.AddResult("Enter Primary Loan Amount", "Should enter Primary Loan Amount", "Entered <<" + primaryLoanAmount + ">> for Primary Loan Amount", "PASS");
                }

                // NAVIGATE TO FEES TAB
                lib.generalLib.waitAndClick("XPATH", ".//a[@title='Fees']/label");
                lib.resultUtil.AddResult("Click on Fees tab", "Should Click on Fees tab", "Clicked on <<Fees tab>>", "PASS");
                // Click on Add Loan Action Fees(+ button)
                lib.generalLib.waitAndClick("XPATH", ".//li[@title='Add Loan Action Fees']");
                lib.resultUtil.AddResult("Click on Add Loan Action Fees sign", "Should Click on Add Loan Action Fees sign", "Clicked on <<Add Loan Action Fees>> sign", "PASS");

                // Select Fee Type
                if (feeType != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@id='colLoanActionFees']/div/div/div/table/tbody/tr/td[2]/div/div/span/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-select-dropdown open']/ul/li[text()='" + feeType + "']");
                    lib.resultUtil.AddResult("Select Fee Type", "Should select Fee Type", "Selected <<" + feeType + ">>Fee Type", "PASS");
                }
                // Enter Fee Amount
                if (feeAmount != "")
                {                    
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='colLoanActionFees']/div/div/div/table/tbody/tr/td[3]/div/div/span/input")).SendKeys(feeAmount);
                    lib.resultUtil.AddResult("Enter Amount", "Should enter Amount", "Entered <<" + feeAmount + ">> for Amount", "PASS");
                }
                // Select Payment Method (Financed)                
                lib.generalLib.waitAndClick("XPATH", ".//*[@id='colLoanActionFees']/div/div/div/table/tbody/tr/td[4]/div/div/span/span/span/div/label[contains(text(),'Financed')]");
                lib.resultUtil.AddResult("Select Payment Method", "Should select Payment Method", "Successfully selected <<Payment Method>>", "PASS");

                //Select the Coding Tab
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Coding']/label");
                lib.resultUtil.AddResult("Click on Coding Tab", "Should click on Coding Tab", "Clicked on <<Coding Tab>>", "PASS");

                //Select the Subsidary radio Button
                if (subsidary != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entSubsidiary']/div/div/div[1]/span/span/div/label[contains(text(),'" + subsidary + "')]");
                    lib.resultUtil.AddResult("Select option for Subsidary Radio Button", "Should select Subsidary Radio Button", "Selected <<" + subsidary + ">> for Subsidary Radio Button", "PASS");
                }
                
                //Select Term Type
                if (termType != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entTermType']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-select-dropdown open']/ul/li[text()='" + termType + "']");
                    lib.resultUtil.AddResult("Select Term Type", "Should select Term Type", "Selected <<" + termType + ">> for Term Type", "PASS");
                }
                //Select Loan Type
                if (loanType != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entLoanType']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-select-dropdown open']/ul/li[text()='" + loanType + "']");
                    lib.resultUtil.AddResult("Select Loan Type", "Should select Loan Type", "Selected <<" + loanType + ">> for Loan Type", "PASS");
                }
                
                //Select FCA Loan Type
                if (fcaLoanType != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entFCALoanType']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-select-dropdown open']/ul/li[text()='" + fcaLoanType + "']");
                    lib.resultUtil.AddResult("Select FCA Loan Type", "Should select FCA Loan Type", "Selected <<" + fcaLoanType + ">> for FCA Loan Type", "PASS");
                }
                //Select Primary SIC Code
                if (primSICCode != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entLoanPrimarySICCode']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-select-dropdown open']/ul/li[text()='" + primSICCode + "']");
                    lib.resultUtil.AddResult("Select Primary SIC Code", "Should select Primary SIC Code", "Selected <<" + primSICCode + ">> for Primary SIC Code", "PASS");
                }
                //Select Secondary SIC Code
                if (secSICCode != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entLoanSecondarySICCode']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-select-dropdown open']/ul/li[text()='" + secSICCode + "']");
                    lib.resultUtil.AddResult("Select Secondary SIC Code", "Should select Secondary SIC Code", "Selected <<" + secSICCode + ">> for Secondary SIC Code", "PASS");
                }
                //Select the Primary SIC Dependency radio Button
                if (primSICDep != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entPrimarySICDependency']/div/div/div[1]/span/span/div/label[contains(text(),'" + primSICDep + "')]");
                    lib.resultUtil.AddResult("Select option for Primary SIC Dependency Radio Button", "Should select Primary SIC Dependency Radio Button", "Selected <<" + primSICDep + ">> for Primary SIC Dependency Radio Button", "PASS");
                }
                //Select the Secondary SIC Dependency radio Button
                if (secSICDep != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entSecondarySICDependency']/div/div/div[1]/span/span/div/label[contains(text(),'" + secSICDep + "')]");
                    lib.resultUtil.AddResult("Select option for Secondary SIC Dependency Radio Button", "Should select Secondary SIC Dependency Radio Button", "Selected <<" + secSICDep + ">> for Secondary SIC Dependency Radio Button", "PASS");
                }
                //Select the Accounting System radio Button
                if (accSystem != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entACR_M_LoanActionDetails.entAccountingSystem']/div/div/div[1]/span/span/div/label[contains(text(),'" + accSystem + "')]");
                    lib.resultUtil.AddResult("Select option for Accounting System Radio Button", "Should select Accounting System Radio Button", "Selected <<" + accSystem + ">> for Accounting System Radio Button", "PASS");
                }
                //Select the Secured Loan radio Button
                if (secLoan != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='bSecuredLoan']/div/div/div/div/div/label[contains(text(),'" + secLoan + "')]");
                    lib.resultUtil.AddResult("Select option for Secured Loan Radio Button", "Should select Secured Loan Radio Button", "Selected <<" + secLoan + ">> for Secured Loan Radio Button", "PASS");
                }

                // Sroll to the view
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Rate and Terms']/label"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);

                // Select the Rate and Terms tab
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Rate and Terms']/label");
                lib.resultUtil.AddResult("Select Rate and Terms tab", "Should select Rate and Terms tab", "Selected <<Rate and Terms>> tab", "PASS");

                //Select Rate Type
                if (rateType != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='entRateType']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-select-dropdown open']/ul/li[text()='" + rateType + "']");
                    lib.resultUtil.AddResult("Select Rate Type", "Should select Rate Type", "Selected <<Rate Type>>", "PASS");
                }
                //Enter the Estimated State Rate
                if (stateRate != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='fEstimatedStatedRate']/div/div/div/input")).SendKeys(stateRate);
                    lib.resultUtil.AddResult("Enter the Estimated State Rate", "Should enter the Estimated State Rate", "Entered <<" + stateRate + ">> Estimated State Rate", "PASS");
                }

                //Click on the Save Button
                lib.generalLib.waitAndClick("XPATH", ".//div[@class='ui-dialog-buttonset']/button/span[text()='Save']");
                lib.resultUtil.AddResult("Click On Save Button", "Should click On Save Button", "Clicked On Save Button", "PASS");

                //// Click on the submit Button
                //lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton2']");
                //lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Edit Loan Action", "Should Edit Loan Action", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Fucntion Name : addApplication_Decession
        /// Description : Add the Application
        /// </summary>
        /// <param name="appDecision"></param>
        /// <param name="appComments"></param>
        /// <returns></returns>
        public static Boolean addApplication_Decession(string appDecision, string appComments)
        {
            Boolean ret = false;

            try
            {
                // Scroll to the view
                IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-id='c9c5ab0d-7560-4f6e-ad1d-dcbff28371e3']/span/label[text()='RP Name']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);
                System.Threading.Thread.Sleep(2000);

                //Select Application Tab
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Application']/label")).Click();
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Application']/label");
                lib.resultUtil.AddResult("Select Application Tab", "Should select Application Tab", "Selected Application Tab", "PASS");

                //Select Application Decision
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entApplicationDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + appDecision + "')]");
                lib.resultUtil.AddResult("Select option <<" + appDecision + ">> for Application Decision", "Should select option <<" + appDecision + ">> for Application Decision", "Successfully selected option <<" + appDecision + ">> for Application Decision", "PASS");
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entApplicationDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + appDecision + "')]")).Click();
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entApplicationDecision']/div/div/div[1]/span/span/div/label[contains(text(),'" + appDecision + "')]")).Click();

                //Enter Application Comments
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@data-render-xpath='PRC_ACR_CreditRequest.entLoanPackage.sLenderComments']/div/div/div/textarea")).SendKeys(appComments);
                lib.resultUtil.AddResult("Enter Application Comments", "Should enter Application Comments", "Entered <<" + appComments + ">> for Application Comments", "PASS");

                //Click on the Save Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton0']");
                lib.resultUtil.AddResult("Click On << Save >> Button", "Should click On << Save >> Button", "Clicked On Save Button", "PASS");
                //System.Threading.Thread.Sleep(5000);

                // Click on the submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton2']");
                lib.resultUtil.AddResult("Click On << submit >> Button", "Should click On << submit >> Button", "Clicked On submit Button", "PASS");
                //System.Threading.Thread.Sleep(9000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Application", "Should Add Application", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        // Fetch case ID
        public static string fetchCaseID()
        {
            string msg = null;
            string msg1 = null;
            try
            {
                //lib.generalLib.waitForObject("XPATH", ".//div[@id='project-collapse-rightpanel']/div");
                lib.generalLib.waitAndClick("XPATH", ".//div[@id='project-collapse-rightpanel']/div");
                System.Threading.Thread.Sleep(3000);
                if (lib.generalLib.waitForObject("XPATH", ".//h3[@class='ui-bizagi-wp-project-case-state-number']/span"))
                {
                    IWebElement caseID = lib.initializeTest.driver.FindElement(By.XPath(".//h3[@class='ui-bizagi-wp-project-case-state-number']/span"));
                    msg = caseID.Text;
                    msg1 = msg.Remove(0, 5);
                    System.Console.WriteLine(msg1);
                }
                else
                {
                    lib.generalLib.waitAndClick("XPATH", ".//div[@id='project-collapse-rightpanel']/div");
                    IWebElement caseID = lib.initializeTest.driver.FindElement(By.XPath(".//h3[@class='ui-bizagi-wp-project-case-state-number']/span"));
                    msg = caseID.Text;
                    msg1 = msg.Remove(0, 5);
                    System.Console.WriteLine(msg1);
                }
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='project-collapse-rightpanel']/div")).Click();
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Fetch Case ID", "Should Fetch Case ID", "EXCEPTION: " + e, "FAIL");
            }
            return msg1;
        }

        //Search with case ID from Admin case
        public static Boolean searchCase(string caseid)
        {
            Boolean ret = false;
            try
            {
                //Search case ID
                System.Threading.Thread.Sleep(1000);
                if (lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='ui-dialog-title']")).Displayed)
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='caseInput']")).SendKeys(caseid);
                    lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-admin-case-search']");
                    lib.resultUtil.AddResult("Search Case ID", "Should Search Case ID ", "Successfully Searched Case ID", "PASS");
                }
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Search Case ID", "Should Search Case ID", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }


        /// <summary> 
        /// Function Name : assignBuildApplication
        /// Description : Click on Build Action Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void assignBuildApplication(string username)
        {
            try
            {
                // click on the Approve Loan Action Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Build Application')]");
                lib.resultUtil.AddResult("Select 'Build Application' checkbox", "Should select 'Build Application' checkbox", "Successfully selected 'Build Application' checkbox", "PASS");

                // Click on the reassign Button
                lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");

                //Enter the full username
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");

                //click on the search button
                lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                System.Threading.Thread.Sleep(3000);

                // Click on Reassign
                lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");

                // Click on the Finish Button
                lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");

                //Close the Case Window
                lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : seacrWithCaseId
        /// Description : Search with Case ID
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void seacrWithCaseId(string casIn)
        {
            try
            {
                //if (casIn != "")
                //{
                //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).Clear();
                //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).SendKeys(casIn);
                //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).SendKeys(Keys.Enter);
                //    lib.resultUtil.AddResult("Search for the Case ID", "Enter the case ID", "Entered <<" + casIn + ">> the Case ID", "PASS");
                //}
                System.Threading.Thread.Sleep(3000);
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).Clear();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).SendKeys(casIn);
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='menuQuery']")).SendKeys(Keys.Enter);
                lib.resultUtil.AddResult("Search for the Case ID", "Enter the case ID", "Entered <<" + casIn + ">> the Case ID", "PASS");
                System.Threading.Thread.Sleep(3000);                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : selectCaseFromInboxHavingText_
        /// Description : select Case From Inbox Having Text 
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void selectCaseFromInboxHavingText_()
        {
            try
            {
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Build Application ']");
                lib.resultUtil.AddResult("Click On ", "Should click On << >> record", "Clicked On record", "PASS");
                //System.Threading.Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Case From Inbox Having Text '' ", "Should select Case From Inbox Having Text '' ", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : selectCaseFromInboxHavingText_AcceptCreditRequest
        /// Description : select Case From Inbox Having Text 
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void selectCaseFromInboxHavingText_AcceptCreditRequest()
        {
            try
            {
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Accept Credit Request ']");
                lib.resultUtil.AddResult("Click On Accept Credit Request ", "Should click On << Accept Credit Request >> record", "Clicked On Accept Credit Request record", "PASS");
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Case From Inbox Having Text 'Accept Credit Request' ", "Should select Case From Inbox Having Text 'Accept Credit Request' ", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : addLoanPackageNWF
        /// Description : Select lender decision
        /// </summary>
        /// <param name="creditAnalystType"></param>
        /// <param name="underwritingType"></param>
        /// <param name="lenderDecision"></param>
        /// <returns></returns>
        public static Boolean addLoanPackageNWF(string creditAnalystType, string underwritingType, string lenderDecision)
        {
            Boolean ret = false;
            try
            {                
                //Click on Loan Actions Tab
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Loan Actions']/label");
                lib.resultUtil.AddResult("Select Loan Actions Tab", "Should select Loan Actions Tab", "Selected <<Loan Actions Tab>>", "PASS");
                //Select Credit Analyst type
                lib.generalLib.waitAndClick("XPATH", ".//label[text()='Credit Analyst']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                lib.generalLib.waitAndClick("XPATH", ".//label[text()='Credit Analyst']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + creditAnalystType + "']");
                lib.resultUtil.AddResult("Select Credit Analyst type", "Should select <<" + creditAnalystType + ">> for Credit Analyst type", "Selected <<" + creditAnalystType + ">> for credit Analyst type", "PASS");
                //Select Underwriting type
                lib.generalLib.waitAndClick("XPATH", ".//label[text()='Underwriting Type']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                lib.generalLib.waitAndClick("XPATH", ".//label[text()='Underwriting Type']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + underwritingType + "']");
                lib.resultUtil.AddResult("Select Underwriting type", "Should select <<" + underwritingType + ">> for Underwriting type", "Selected <<" + underwritingType + ">> for Underwriting type", "PASS");
                //Click on Loan Package Tab
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Loan Package']/label");
                lib.resultUtil.AddResult("Select Loan Package Tab", "Should select Loan Package Tab", "Selected <<Loan Package Tab>>", "PASS");
                //Select 'Submit for Analysis ' of Lender Decision 
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entLenderDecision']/div/div/div[1]/span/span[1]/div/label[contains(text(),'" + lenderDecision + "')]");
                lib.resultUtil.AddResult("Select option <<" + lenderDecision + ">> for Lender Decision", "Should select option <<" + lenderDecision + ">> for Lender Decision", "Successfully selected option <<" + lenderDecision + ">> for Lender Decision", "PASS");
                //Click on the submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton2']");
                lib.resultUtil.AddResult("Click On << submit >> Button", "Should click On << submit >> Button", "Clicked On submit Button", "PASS");
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Loan Package to Build Loan Package", "Should Add Loan Package to Build Loan Package", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }


        /// <summary>
        /// Function Name : clickAcceptCreditRequest
        /// Description : Click on Accept Credit Request Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickAcceptCreditRequest()
        {
            try
            {

                // click on Accept Credit Request Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Accept Credit Request')]");
                lib.resultUtil.AddResult("Select Accept Credit Requests checkbox", "Should select Accept Credit Request checkbox", "Successfully selected Accept Credit Request checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                ////System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");
                //System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : verifyAcceptAnalysis
        /// Description : Verify Acceptance Decision as Accepted
        /// </summary>
        /// <returns></returns>
        public static Boolean verifyAcceptAnalysis()
        {
            Boolean ret = false;
            try
            {
                // Navigate to Accept Analysis Tab
                lib.generalLib.waitAndClick("XPATH", ".//a[@title='Accept Analysis']/label");
                lib.resultUtil.AddResult("Click on Accept Analysis Tab", "Should click on Accept Analysis Tab", "Successfully Clicked on Accept Analysis Tab", "PASS");
                // Select AcceptanceDecision as Accepted
                lib.generalLib.waitAndClick("XPATH", "//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAcceptanceDecision']/div/div/div/span/span/div/label[contains(text(),'Accepted')]");
                lib.resultUtil.AddResult("Select AcceptanceDecision as Accepted", "Should select AcceptanceDecision as Accepted", "Successfully selected AcceptanceDecision as Accepted", "PASS");
                // Click on the submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On << submit >> Button", "Should click On << Submit >> Button", "Clicked On submit Button", "PASS");                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify AcceptanceDecision as Accepted tab", "Should AcceptanceDecision as Accepteds tab", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : clickAnalyzeCreditRequest
        /// Description : Click on Analyze Credit Request Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickAnalyzeCreditRequest()
        {
            try
            {                                              
                // click on Accept Credit Request Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Analyze Credit Request')]");
                lib.resultUtil.AddResult("Select Accept Credit Requests checkbox", "Should select Accept Credit Request checkbox", "Successfully selected Accept Credit Request checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.generalLib.waitAndEnter("XPATH", ".//input[@id='userNameReassignInput']", username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");

                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : selectCaseFromInboxHavingText_AnalyzeCreditRequest
        /// Description : select Case From Inbox Having Text Analyze Credit Request
        /// </summary>
        public static void selectCaseFromInboxHavingText_AnalyzeCreditRequest()
        {
            try
            {
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Analyze Credit Request ']");
                lib.resultUtil.AddResult("Click On Analyze Credit Request ", "Should click On << Analyze Credit Request >> record", "Clicked On Analyze Credit Request record", "PASS");                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Case From Inbox Having Text 'Analyze Credit Request' ", "Should select Case From Inbox Having Text 'Analyze Credit Request' ", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : creditAnalysisNWF
        /// Description : Should enter the values for assigned PD and assignedLGD and start date. Then recommend it for further process
        /// </summary>
        /// <param name="assignedPD"></param>
        /// <param name="assignedLGD"></param>
        /// Select recommended for analyst decision
        /// <returns></returns>        
        public static void creditAnalysisNWF(string assignedPD, string assignedLGD)
        {
            try
            {
                // Select the Credit Analysis Tab
                System.Threading.Thread.Sleep(2000);                
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Credit Analysis']");
                lib.resultUtil.AddResult("Select the Credit Analysis Tab", "Should Select the Credit Analysis Tab", "Selected the Credit Analysis Tab", "PASS");

                //Scroll CreditAnalysis
                IWebElement CreditAnalysis = lib.initializeTest.driver.FindElement(By.XPath(".//*[@title='Credit Analysis']"));
                //IWebElement calcPD = lib.initializeTest.driver.FindElement(By.XPath(".//*[text()='Calculate PD Value']"));
                IJavaScriptExecutor jsc1 = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc1.ExecuteScript("arguments[0].scrollIntoView(true);", CreditAnalysis);
                //Select Assigned PD 
                if (assignedPD != "")
                {
                    //lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']")).Click();
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Assigned PD']//..//..//following-sibling::div/div/div/div/div[2]");
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Assigned PD']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + assignedPD + "']");
                    lib.resultUtil.AddResult("Select PD Model", "Should select <<'" + assignedPD + "'>> for Assigned PD", "Selected <b>'" + assignedPD + "'</b> for Assigned PD", "PASS");
                }

                //Scroll assignedPD
                IWebElement assignedPDField = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Assigned PD']//..//..//following-sibling::div/div/div/div/div[2]"));
                jsc1.ExecuteScript("arguments[0].scrollIntoView(true);", assignedPDField);

                //Select Assigned LGD 
                if (assignedLGD != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Assigned LGD']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Assigned LGD']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + assignedLGD + "']");
                    lib.resultUtil.AddResult("Select LGD Model", "Should select <<'" + assignedLGD + "'>> for Assigned LGD", "Selected <b>'" + assignedLGD + "'</b> for Assigned LGD", "PASS");
                }

                //Scroll Into Loan Narrative
                IWebElement LoanNarrative = lib.initializeTest.driver.FindElement(By.XPath(".//*[text()='Loan Narrative']"));
                IJavaScriptExecutor jsc = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc.ExecuteScript("arguments[0].scrollIntoView(true);", LoanNarrative);
                System.Threading.Thread.Sleep(2000);

                // Select the Recommmended option in the Analyst Decision
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entAnalystDecision']/div/div/div/span/span/div/label[text()=' Recommended  ']");
                lib.resultUtil.AddResult("Select Recommmended option in the Analyst Decision", "Should select Recommmended option in the Analyst Decision", "Selected Recommmended option in the Analyst Decision", "PASS");

                //// Scroll Into View
                //IWebElement elem3 = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='RP Name']"));
                //IJavaScriptExecutor jsc3 = (IJavaScriptExecutor)lib.initializeTest.driver;
                //jsc3.ExecuteScript("arguments[0].scrollIntoView(true);", elem3);
                
                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Enter Credit Analysis Details", "Should enter Credit Analysis Details", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : reassign
        /// Description : Reassign to the user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>

        public static void reassignUser(string username)
        {
            try
            {

                // Click on the reassign Button
                lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //Enter the username
                lib.generalLib.waitAndEnter("XPATH", ".//input[@id='userNameReassignInput']", username);
                lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                //click on the search button
                lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                // Click on Reassign
                lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                // Click on the Finish Button
                lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                //Close the Case Window
                lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Reassigned successfully", "Should able to Reassign", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : clickDecisionPrep
        /// Description : Click on Decision Prep Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickDecisionPrep()
        {
            try
            {
                // click on Accept Credit Request Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Decision Prep')]");
                lib.resultUtil.AddResult("Select Decision Prep checkbox", "Should select Decision Prep checkbox", "Successfully selected Decision Prep checkbox", "PASS");
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : selectCaseFromInboxHavingText_DecisionPrep
        /// Description : select Case From Inbox Having Text Analyze Credit Request
        /// </summary>

        public static void selectCaseFromInboxHavingText_DecisionPrep()
        {
            try
            {
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Decision Prep ']");
                lib.resultUtil.AddResult("Click On Decision Prep ", "Should click On << Decision Prep >> record", "Clicked On Decision Prep record", "PASS");
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Case 'Decision Prep' ", "Should select 'Decision Prept' ", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : preDecisionReviewNWF
        /// Description : 'Sending For Decisioning' option for the Pre-Decision Review Decision
        /// </summary>
        /// <param name="approveAuth"></param>
        /// <param name="approver"></param>
        /// <returns></returns> string 
        public static void preDecisionReviewNWF(string approveAuth, string approver)
        {
            try
            {
                // Select the Pre-Decision Review Tab
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Pre-Decision Review']");
                lib.resultUtil.AddResult("Select the Pre-Decision Review Tab", "Should Select the Pre-Decision Review Tab", "Selected the Pre-Decision Review Tab", "PASS");

                //Select Approval Authority
                if (approveAuth != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Approval Authority']//..//..//following-sibling::div/div/div/div/div");
                    System.Threading.Thread.Sleep(1000);
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Approval Authority']//..//..//div/div[@class='ui-select-dropdown open']/ul/li[text()='" + approveAuth + "']");
                    lib.resultUtil.AddResult("Select Approval Authority", "Should select <<'" + approveAuth + "'>> for Approval Authority", "Selected <b>'" + approveAuth + "'</b> for Approval Authority", "PASS");
                }
                System.Threading.Thread.Sleep(2000);

                // Select the 'Sending For Decisioning' option for the Pre-Decision Review Decision             
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.entPreDecisionRevDecision']/div/div/div/span/span/div/label[contains(text(),'Send for Decisioning')]");
                lib.resultUtil.AddResult("Select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Should select << Sending For Decisioning >> option for the Pre-Decision Review Decision", "Selected << Sending For Decisioning >> option for the Pre-Decision Review Decision", "PASS");

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton2']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(8000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Pre-Decision Review", "Should Select Pre-Decision Review", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : selectProceedWithDecision 
        /// Description : Select Proceed with Decision decision and then submit
        /// </summary>
        /// <returns></returns>
        public static Boolean selectProceedWithDecision()
        {
            Boolean ret = false;

            try
            {
                //Select Approve for Approver decision
                lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-bizagi-render-radio ']/span/div/label[text()=' Proceed with Decision  ']");
                lib.resultUtil.AddResult("Select Proceed with Decision", "Should select Proceed with Decision", "Selected Proceed with Decision decision", "PASS");

                // Scroll So Send Approval Task text
                IWebElement SendApprovalTask = lib.initializeTest.driver.FindElement(By.XPath("//*[@id='PRC_ACR_CreditRequest_colDecisionRecords']/div/div[2]/div[1]/table/thead/tr/th[2]/div/label"));
                IJavaScriptExecutor jsc3 = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsc3.ExecuteScript("arguments[0].scrollIntoView(true);", SendApprovalTask);                

                //Select last approver record and delete the rows -4
                lib.generalLib.waitAndClick("XPATH", "//*[@id='PRC_ACR_CreditRequest_colDecisionRecords']/div/div[2]/div[1]/table/tbody/tr[4]/td[4]/div/div/div");
                lib.resultUtil.AddResult("Select the record", "Should Select the record", "Successfully Select the record", "PASS");
                lib.generalLib.waitAndClick("XPATH", "//*[@id='PRC_ACR_CreditRequest_colDecisionRecords']/div/div[2]/div[3]/table/tbody/tr/th[1]/div/div/ul/li[2]/div");
                lib.resultUtil.AddResult("Click on Delete icon", "Should Click on Delete icon", "Successfully Click on Delete icon", "PASS");
                //lib.generalLib.waitForObject("XPATH", "/html/body/div[6]/div[3]/div/button[1]");
                lib.generalLib.waitAndClick("XPATH", "/html/body/div[6]/div[3]/div/button[1]/span");
                lib.resultUtil.AddResult("Click on OK button on confirmation message", "Should Click on OK button on confirmation message", "Successfully Click on OK button on confirmation message", "PASS");
                //lib.generalLib.waitAndClick("XPATH", "/html/body/div[6]/div[3]/div/button[1]/span");
                //lib.initializeTest.driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div/button[1]/span")).Click();
                //jsc3.ExecuteScript("arguments[0].scrollIntoView(true);", SendApprovalTask);
                //Select last approver record and delete the rows -3
                lib.generalLib.waitAndClick("XPATH", "//*[@id='PRC_ACR_CreditRequest_colDecisionRecords']/div/div[2]/div[1]/table/tbody/tr[3]/td[4]/div/div/div");
                lib.resultUtil.AddResult("Select the record", "Should Select the record", "Successfully Select the record", "PASS");
                lib.generalLib.waitAndClick("XPATH", "//*[@id='PRC_ACR_CreditRequest_colDecisionRecords']/div/div[2]/div[3]/table/tbody/tr/th[1]/div/div/ul/li[2]/div");
                lib.resultUtil.AddResult("Click on Delete icon", "Should Click on Delete icon", "Successfully Click on Delete icon", "PASS");
                lib.generalLib.waitAndClick("XPATH", "/html/body/div[6]/div[3]/div/button[1]/span");
                lib.resultUtil.AddResult("Click on OK button on confirmation message", "Should Click on OK button on confirmation message", "Successfully Click on OK button on confirmation message", "PASS");
                //Select last approver record and delete the rows -2
                lib.generalLib.waitAndClick("XPATH", "//*[@id='PRC_ACR_CreditRequest_colDecisionRecords']/div/div[2]/div[1]/table/tbody/tr[2]/td[4]/div/div/div");
                lib.resultUtil.AddResult("Select the record", "Should Select the record", "Successfully Select the record", "PASS");
                lib.generalLib.waitAndClick("XPATH", "//*[@id='PRC_ACR_CreditRequest_colDecisionRecords']/div/div[2]/div[3]/table/tbody/tr/th[1]/div/div/ul/li[2]/div");
                lib.resultUtil.AddResult("Click on Delete icon", "Should Click on Delete icon", "Successfully Click on Delete icon", "PASS");
                lib.generalLib.waitAndClick("XPATH", "/html/body/div[6]/div[3]/div/button[1]/span");
                lib.resultUtil.AddResult("Click on OK button on confirmation message", "Should Click on OK button on confirmation message", "Successfully Click on OK button on confirmation message", "PASS");

                // Click on the submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On << submit >> Button", "Should click On << submit >> Button", "Clicked On submit Button", "PASS");
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Approver Decision", "Should Select Approver Decison", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        /// <summary>
        /// Function Name : selectApproverDecision
        /// Description : Select Approve for Approver decision and then submit
        /// </summary>
        /// <returns></returns>
        public static Boolean selectApproverDecision()
        {
            Boolean ret = false;
            try
            {
                //Select Approve for Approver decision
                lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-bizagi-render-radio ']/span/div/label[text()=' Approve  ']");
                lib.resultUtil.AddResult("Select Approve for Approver decision", "Should select Approve for Approver decision", "Selected Approve for Approver decision", "PASS");
                // Click on the submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On << submit >> Button", "Should click On << submit >> Button", "Clicked On submit Button", "PASS");
                //System.Threading.Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Approver Decision", "Should Select Approver Decison", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }


        /// <summary>
        /// Function Name : click Decision Loan Actions
        /// Description : Click on Decision Loan Actions Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickDecisionLoanActions()
        {
            try
            {

                //scroll to Decision Loan Actions
                System.Threading.Thread.Sleep(1000);
                IWebElement DecisionLoanActions = lib.initializeTest.driver.FindElement(By.XPath(".//input[@name='workItemAdmin'][contains(@value,'Decision Loan Actions')]"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", DecisionLoanActions);
                System.Threading.Thread.Sleep(1000);

                // click on Decision Loan Actions Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Decision Loan Actions')]");
                lib.resultUtil.AddResult("Select Decision Loan Actions checkbox", "Should select Decision Loan Actions checkbox", "Successfully selected Decision Loan Actions checkbox", "PASS");
                
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Decision Loan Actions", "Should Verify Decision Loan Actions", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : selectCaseFromInboxHavingText_DecisionLoanActions
        /// Description : select Case From Inbox Having Text Decision Loan Actions
        /// </summary>

        public static void selectCaseFromInboxHavingText_DecisionLoanActions()
        {
            try
            {
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Decision Loan Actions ']");
                lib.resultUtil.AddResult("Click On Decision Loan Actions", "Should click On << Decision Loan Actions>> record", "Clicked On Decision Loan Actions record", "PASS");
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Case 'Decision Loan Actions' ", "Should select 'Decision Loan Actions' ", "EXCEPTION: " + e, "FAIL");
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

                //Select "Submit Credit Request For Processing" for Post decision Review
                lib.generalLib.waitAndClick("XPATH", ".//*[@class='ui-bizagi-render-radio ']/span/div/label[text()=' Submit Credit Request for Processing  ']");
                lib.resultUtil.AddResult("Select Submit Credit Request For Processing", "Should select Submit Credit Request For Processing", "Selected Submit Credit Request For Processing", "PASS");
                
                // Click on the submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On << submit >> Button", "Should click On << submit >> Button", "Clicked On submit Button", "PASS");
                
                //// Click on Accept Processing
                //lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                //lib.resultUtil.AddResult("Click On << Accept Processing >> Button", "Should click On << Accept Processing >> Button", "Clicked On Accept Processing Button", "PASS");                

                //// Click on the submit Button
                //lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                //lib.resultUtil.AddResult("Click On << submit >> Button", "Should click On << submit >> Button", "Clicked On submit Button", "PASS");                

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Post Decison review", "Should Select Post Decision Review", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : click clickClearFileforClosing
        /// Description : Click on Clear File for Closing Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickClearFileforClosing()
        {
            try
            {
                // click on Clear File for Closing Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Clear File for Closing')]");
                lib.resultUtil.AddResult("Select Clear File for Closing checkbox", "Should select Clear File for Closing checkbox", "Successfully selected Clear File for Closing checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.generalLib.waitAndEnter("XPATH", ".//input[@id='userNameReassignInput']", username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");

                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approved Not Accepted", "Should Verify Approved Not Accepted", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : selectCaseFromInboxHavingText_ClearFileforClosing 
        /// Description : select Clear File for Closing Case From Inbox 
        /// </summary>

        public static void selectCaseFromInboxHavingText_ClearFileforClosing()
        {
            try
            {
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Clear File for Closing ']");
                lib.resultUtil.AddResult("Click On Clear File for Closing", "Should click On <<Clear File for Closing>> record", "Clicked On Clear File for Closing record", "PASS");
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Case 'Clear File for Closing' ", "Should select 'Clear File for Closing' ", "EXCEPTION: " + e, "FAIL");
            }
        }


        ///// <summary>
        ///// Function Name : checkPreCloseChecklist
        ///// Description : Select the Pre-Close Checklist Tab and Select the 'Complete' option for Pre-Close Status
        ///// </summary>
        ///// <returns></returns>
        //public static void checkPreCloseChecklist()
        //{
        //    try
        //    {
        //        // Scroll to the top of the Page
        //        IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']/p"));
        //        IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
        //        jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);
        //        System.Threading.Thread.Sleep(4000);

        //        // Select the Pre-Close Checklist Tab
        //        lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Pre-Close Checklist']")).Click();
        //        lib.initializeTest.driver.FindElement(By.XPath(".//a[@title='Pre-Close Checklist']")).Click();
        //        lib.resultUtil.AddResult("Select the Pre-Close Checklist Tab", "Should Select the Pre-Close Checklist Tab", "Selected the Pre-Close Checklist Tab", "PASS");
        //        System.Threading.Thread.Sleep(3000);
        //        // Select the 'Complete' option for Pre-Close Status1
        //        lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[1]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
        //        lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status1", "Should select << Complete >> option for Pre-Close Status1", "Selected << Complete >> option Pre-Close Status1", "PASS");
        //        // Select the 'Complete' option for Pre-Close Status2
        //        lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[2]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
        //        lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status2", "Should select << Complete >> option for Pre-Close Status2", "Selected << Complete >> option Pre-Close Status2", "PASS");
        //        // Select the 'Complete' option for Pre-Close Status3
        //        lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[3]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
        //        lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status3", "Should select << Complete >> option for Pre-Close Status3", "Selected << Complete >> option Pre-Close Status3", "PASS");
        //        // Select the 'Complete' option for Pre-Close Status4
        //        lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[4]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
        //        lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status4", "Should select << Complete >> option for Pre-Close Status4", "Selected << Complete >> option Pre-Close Status4", "PASS");

        //        IWebElement elem2 = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
        //        IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
        //        js2.ExecuteScript("arguments[0].scrollIntoView(true);", elem2);
        //        System.Threading.Thread.Sleep(1000);

        //        // Select the 'Complete' option for Pre-Close Status5
        //        lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='ACR_M_LoanAction_colPreCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[5]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]")).Click();
        //        lib.resultUtil.AddResult("Select << Complete >> option for the Pre-Close Status5", "Should select << Complete >> option for Pre-Close Status5", "Selected << Complete >> option Pre-Close Status5", "PASS");

        //        //Click on the Save Button
        //        lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='formButton0']")).Click();
        //        lib.resultUtil.AddResult("Click On << Save >> Button", "Should click On << Save >> Button", "Clicked On Save Button", "PASS");
        //        System.Threading.Thread.Sleep(8000);
        //    }
        //    catch (Exception e)
        //    {
        //        lib.resultUtil.AddResult("Verify Pre Close Checklist", "Should verify Pre Close Checklist", "EXCEPTION: " + e, "FAIL");
        //    }
        //}


        /// <summary>
        /// Function Name : selectCDSubmit
        /// Description : Select "Submit Credit Request For Processing" for Post decision Review and then submit
        /// </summary>
        /// <param name="cdProcLO"/>
        /// <param name="cdRec"/>
        /// <param name="cdMlo"/>
        /// <returns></returns>
        public static void selectCDSubmit(string cdProcLO, string cdRec, string cdMlo)
        {
            try
            {
                // Scroll to the top of the Page
                IWebElement elemtwo = lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='ui-bizagi-form-process-path box-description']/p"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo);
                System.Threading.Thread.Sleep(4000);

                // Select Loan Action Tab
                lib.generalLib.waitAndClick("XPATH", ".//a[@title='Loan Action']");
                lib.generalLib.waitAndClick("XPATH", ".//a[@title='Loan Action']");
                lib.resultUtil.AddResult("Select theLoan Action Tab", "Should Select the Loan Action Tab", "Selected the Loan Action Tab", "PASS");
                System.Threading.Thread.Sleep(2000);

                // Scroll to the top of the Page
                IWebElement elemtwo2 = lib.initializeTest.driver.FindElement(By.XPath(".//label[text()='Approved']"));
                //IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", elemtwo2);
                System.Threading.Thread.Sleep(2000);

                //Select CD Processing LO
                if (cdProcLO != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.PRC_ACR_CreditRequest.entLoanPackage.entCDProcessingLO']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//div[@class='ui-select-dropdown open']/ul/li[text()='" + cdProcLO + "']");
                    lib.resultUtil.AddResult("Select CD Processing LO", "Should select <<" + cdProcLO + ">> for CD Processing LO", "Selected <<" + cdProcLO + ">> for CD Processing LO", "PASS");
                }
                //Select CD Rec./Serv./L/O
                if (cdRec != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.PRC_ACR_CreditRequest.entLoanPackage.entCDRecServLO']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//div[@class='ui-select-dropdown open']/ul/li[text()='" + cdRec + "']");
                    lib.resultUtil.AddResult("Select CD Rec./Serv./L/O", "Should select <<" + cdProcLO + ">> for CD Rec./Serv./L/O", "Selected <<" + cdProcLO + ">> for CD Rec./Serv./L/O", "PASS");
                }
                //Select CD MLO/S.A.F.E.
                if (cdMlo != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.PRC_ACR_CreditRequest.entLoanPackage.entCDMLOSAFE']/div/div/div/div/div/input");
                    lib.generalLib.waitAndClick("XPATH", ".//div[@class='ui-select-dropdown open']/ul/li[text()='" + cdMlo + "']");
                    lib.resultUtil.AddResult("Select CD MLO/S.A.F.E.", "Should select <<" + cdMlo + ">> for CD MLO/S.A.F.E.", "Selected <<" + cdProcLO + ">> for CD MLO/S.A.F.E.", "PASS");
                }

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Post Decison review", "Should Select Post Decision Review", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : click clickPrepareDocuments
        /// Description : Click on Prepare Documents Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickPrepareDocuments()
        {
            try
            {
                // click on Prepare Documents Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Prepare Documents')]");
                lib.resultUtil.AddResult("Select Prepare Documents checkbox", "Should select Prepare Documents checkbox", "Successfully selected Prepare Documents checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.generalLib.waitAndEnter("XPATH", ".//input[@id='userNameReassignInput']", username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");

                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Prepare Documents", "Should Verify Prepare Documents", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : selectCaseFromInboxHavingText_PrepareDocuments
        /// Description : select Prepare Documents Case From Inbox 
        /// </summary>

        public static void selectCaseFromInboxHavingText_PrepareDocuments()
        {
            try
            {
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Prepare Documents ']");
                lib.resultUtil.AddResult("Click On Prepare Documents", "Should click On <<Prepare Documents>> record", "Clicked On Prepare Documents record", "PASS");
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Select Case 'Prepare Documents' ", "Should select 'Clear File for Closing' ", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : clickDocumentsPrepared
        /// Description : Click on Documents Prepared Checkbox 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static void clickDocumentsPrepared()
        {
            try
            {
                // click on Documents Prepared Checkbox
                System.Threading.Thread.Sleep(2000);
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsPrepared']/div/div/div/label/input");
                lib.resultUtil.AddResult("Select Documents Prepared checkbox", "Should select Documents Prepared checkbox", "Successfully selected Documents Prepared checkbox", "PASS");

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                System.Threading.Thread.Sleep(5000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Documents Prepared Action", "Should Verify Documents Prepared Action", "EXCEPTION: " + e, "FAIL");
            }

        }

        /// <summary>
        /// Function Name : reviewDocuments
        /// Description : Click on Approve radio option
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static void reviewDocuments()
        {
            try
            {
                ////click on the Documents Received Checkbox
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsReceived']/div/div/div/label/input")).Click();
                //lib.resultUtil.AddResult("Select Documents Received checkbox", "Should select Documents Received checkbox", "Successfully selected Documents Received checkbox", "PASS");
                //System.Threading.Thread.Sleep(4000);

                //IWebElement elem = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.entDocReviewDec']/div/div/div/span/span/div/label"));
                //IJavaScriptExecutor js = (IJavaScriptExecutor)lib.initializeTest.driver;
                //js.ExecuteScript("arguments[0].scrollIntoView(true);", elem);
                //System.Threading.Thread.Sleep(3000);

                //click on Approved radio button              
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.entDocReviewDec']/div/div/div/span/span/div/label");
                lib.resultUtil.AddResult("Select Approved radio button ", "Should select Approved radio button", "Successfully selected Approved radio button", "PASS");
                //System.Threading.Thread.Sleep(4000);

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On << Submit >> Button", "Should click On << Submit >> Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(5000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Review Documents Action", "Should Verify Review Documents  Action", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : clickPrintandSentDocuments
        /// Description : Click on the Print and Send Documents Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickPrintandSentDocuments()
        {
            try
            {
                // click on the Print and Send Documents Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Print/Send Documents')]");
                lib.resultUtil.AddResult("Select Print and Send Documents checkbox", "Should select Print and Send Documents checkbox", "Successfully selected Print and Send Documents checkbox", "PASS");
                ////// Click on the reassign Button
                ////lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                ////lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                //////Enter the full username
                ////lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                ////lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                //////click on the search button
                ////lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                //////System.Threading.Thread.Sleep(3000);
                ////// Click on Reassign
                ////lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                ////lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                ////// Click on the Finish Button
                ////lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                ////lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                //////Close the Case Window
                ////lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                ////lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
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
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Print/Send Documents ']");
                //System.Threading.Thread.Sleep(3000);

                // Select the Documents Printed Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsPrinted']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Documents Printed Checkbox", "Should click on Documents Printed Checkbox", "Successfully clicked on Documents Printed Checkbox", "PASS");
                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : clickReceiveDocuments
        /// Description : Click on Receive Documents Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickReceiveDocuments()
        {
            try
            {
                // click on Receive Documents Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Receive Documents')]");
                lib.resultUtil.AddResult("Select Receive Documents checkbox", "Should select Receive Documents checkbox", "Successfully selected Receive Documents checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                ////System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Receive Documents", "Should Verify Receive Documents", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : searchCaseIdWithReciveDocs
        /// Description : Search for the Case ID and select Receive Docs 
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
                //Click on the Receive Docs 
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Receive Documents ']");
                //System.Threading.Thread.Sleep(3000);

                // Select the Documents Received
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bDocumentsReceived']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Documents Receivedd Checkbox", "Should click on Documents Received Checkbox", "Successfully clicked on Documents Received Checkbox", "PASS");

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case Receive Docs", "Should Search for the case Receive Docs", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : clickBookingRequest
        /// Description : Click on Booking Request Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickBookingRequest()
        {
            try
            {
                // click on Booking Request Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Booking Request')]");
                lib.resultUtil.AddResult("Select Booking Request checkbox", "Should select Booking Request checkbox", "Successfully selected Booking Request checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.initializeTest.driver.FindElement(By.XPath(".//button[@id='btn-users-table-search']/span[text()='Search']")).Click();
                //System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.initializeTest.driver.FindElement(By.XPath(".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']")).Click();
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Booking Request", "Should Verify Booking Request", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithBookingRequest
        /// Description : Search for the Case Booking Request and select Receive Docs and Send for Booking
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithBookingRequest(string casIn)
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
                //Click on the Booking Request case
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Booking Request ']");
                //System.Threading.Thread.Sleep(3000);

                // Select the Booking Request checkbox
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bBookingRequest']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Documents Receivedd Checkbox", "Should click on Documents Received Checkbox", "Successfully clicked on Documents Received Checkbox", "PASS");

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case Booking Request", "Should Search for the case Booking Request", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : clickReviewAndBookLoan
        /// Description : Click on the Review and Book Loan Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickReviewAndBookLoan()
        {
            try
            {
                // click on the Review and Book Loan Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Review and Book Loan')]");
                lib.resultUtil.AddResult("Select Review and Book Loan checkbox", "Should select Review and Book Loan checkbox", "Successfully selected Review and Book Loan checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                ////System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Approve Loan Action", "Should Verify Approve Loan Action", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithReviewBookLoan
        /// Description : Search for the Case ID and select Review and Book Loan
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithReviewBookLoan(string casIn, string NextDayReviewer)
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
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Review and Book Loan ']");
                //System.Threading.Thread.Sleep(3000);

                // Select the Loan Booked Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bLoanBooked']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Loan Booked Checkbox", "Should click on Loan Booked Checkbox", "Successfully clicked on Loan Booked Checkbox", "PASS");

                //Select Branch                
                if (NextDayReviewer != "")
                {
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Next Day Reviewer']//..//..//following-sibling::div//input[@class='ui-select-data ui-selectmenu-value']");
                    lib.generalLib.waitAndClick("XPATH", ".//label[text()='Next Day Reviewer']/../../div/div[@class='ui-select-dropdown open']/ul/li[text()='" + NextDayReviewer + "']");
                    lib.resultUtil.AddResult("Select Next Day Reviewer", "Should select <<" + NextDayReviewer + ">> for Branch", "Selected <<" + NextDayReviewer + ">> for Branch", "PASS");
                }

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : clickCreateFundingRequest
        /// Description : Click on Create Funding Request Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickCreateFundingRequest()
        {
            try
            {
                // click on the 
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Create Funding Request')]");
                lib.resultUtil.AddResult("Select Create Funding Request checkbox", "Should select Create Funding Request checkbox", "Successfully selected Create Funding Request checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                ////System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Create Funding Request", "Should Verify Create Funding Request", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : searchCaseIdWithCreateFundingRequest
        /// Description : Search for the Case Create Funding Request
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithCreateFundingRequest(string casIn, string FundingNeededBy, string FundingApproved)
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
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Create Funding Request ']");
                //System.Threading.Thread.Sleep(3000);

                //Select FundingNeededBy                    
                if (FundingNeededBy != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.dFundingNeededBy']/div/div/div/div/span[1]/input")).SendKeys(FundingNeededBy);
                    lib.resultUtil.AddResult("Enter FundingNeededBy", "Should enter FundingNeededBy", "Entered <<" + FundingNeededBy + ">> for FundingNeededBy", "PASS");
                }

                // Scroll to Loan Booked Checkbox
                IWebElement LoanBookedCheckbox = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bRequestFunding']/div/div/div/label/input"));
                IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", LoanBookedCheckbox);

                // Select the Loan Booked Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bRequestFunding']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Loan Booked Checkbox", "Should click on Loan Booked Checkbox", "Successfully clicked on Loan Booked Checkbox", "PASS");

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(8000);

                // Scroll to Funding Approved Radio button
                IWebElement FundingApprovedRadiobutton = lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bFundingApproved']/div/div/div[1]/div/div/label[contains(text(),'Yes')]"));
                //IJavaScriptExecutor jsn = (IJavaScriptExecutor)lib.initializeTest.driver;
                jsn.ExecuteScript("arguments[0].scrollIntoView(true);", FundingApprovedRadiobutton);
                
                ////Select the Funding Approved radio Button
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bFundingApproved']/div/div/div[1]/div/div/label[contains(text(),'Yes')]");
                
                //if (FundingApproved != "")
                //{
                //    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bFundingApproved']/div/div/div[1]/div/div/label[contains(text(),'Yes')]"))
                //    lib.resultUtil.AddResult("Select option for FundingApproved Radio Button", "Should select FundingApproved Radio Button", "Selected <<" + FundingApproved + ">> for Subsidary Radio Button", "PASS");
                //}

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(5000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case ID", "Should Search for the case ID", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : clickReviewAndFundLoan
        /// Description : Click on Review Funding Loan Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickReviewAndFundLoan()
        {
            try
            {
                // click on the Review and Fund Loan Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Review and Fund Loan')]");
                lib.resultUtil.AddResult("Select Create Funding Request checkbox", "Should select Create Funding Request checkbox", "Successfully selected Create Funding Request checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                ////System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Review and Fund Loan", "Should Verify Review and Fund Loan", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : searchCaseIdWithReviewandFundLoan
        /// Description : Search for the Case Review and Fund Loan
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithReviewandFundLoan(string casIn, string ReviewandFundLoan)
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
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Review and Fund Loan ']");
                //System.Threading.Thread.Sleep(3000);

                //Select the Review and Fund Loan radio Button
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bFundLoan']/div/div/div[1]/div/div[1]");
                lib.resultUtil.AddResult("Select option for Funding Approved Radio Button", "Should select FundingApproved Radio Button", "Selected <<" + ReviewandFundLoan + ">> for Subsidary Radio Button", "PASS");
                //if (ReviewandFundLoan != "")
                //{
                //    lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bFundLoan']/div/div/div[2]/div/label[contains(text(),'" + ReviewandFundLoan + "')]");
                //    lib.resultUtil.AddResult("Select option for Funding Approved Radio Button", "Should select FundingApproved Radio Button", "Selected <<" + ReviewandFundLoan + ">> for Subsidary Radio Button", "PASS");
                //}

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(5000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Case Review and Fund Loan", "Should Search for the case Review and Fund Loan", "EXCEPTION: " + e, "FAIL");
            }

        }


        /// <summary>
        /// Function Name : clickNextDayVerifications
        /// Description : Click on Next Day Verifications Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickNextDayVerifications()
        {
            try
            {
                // click on the Next Day Verifications Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Next Day Verifications')]");
                lib.resultUtil.AddResult("Select Create Funding Request checkbox", "Should select Create Funding Request checkbox", "Successfully selected Create Funding Request checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                ////System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Next Day Verifications", "Should Verify Next Day Verifications", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : searchCaseIdWithNextDayVerifications
        /// Description : Search for the Case NextDayVerifications
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithNextDayVerifications(string casIn)
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
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Next Day Verifications ']");
                //System.Threading.Thread.Sleep(3000);

                // Select the Verified Checkbox 
                //System.Threading.Thread.Sleep(2000);
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bVerified']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Verified Checkbox", "Should click on Verified Checkbox", "Successfully clicked on Verified Checkbox", "PASS");
                //System.Threading.Thread.Sleep(1000);

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(10000);
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Next Day Verifications", "Should Search for the case Next Day Verifications", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : clickReceiveAndScanDocuments
        /// Description : Click on Receive and Scan Documents Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickReceiveAndScanDocuments()
        {
            try
            {
                // click on the Receive and Scan Documents Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Receive and Scan Documents')]");
                lib.resultUtil.AddResult("Select Receive and Scan Documents checkbox", "Should select Receive and Scan Documents checkbox", "Successfully selected Receive and Scan Documents checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                ////System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Receive and Scan Documents", "Should Receive and Scan Documents", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : searchCaseIdWithReceiveandScanDocuments
        /// Description : Search for the Case Receive and Scan Documents
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithReceiveAndScanDocuments(string casIn, string ReceivedDate)
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
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Receive and Scan Documents ']");
                System.Threading.Thread.Sleep(3000);

                // Select the Documents Received and Scanned Checkbox                 
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bReceivedandScanned']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Documents Received and Scanned Checkbox", "Should click on Documents Received and Scanned Checkbox", "Successfully clicked on Documents Received and Scanned Checkbox", "PASS");
                //System.Threading.Thread.Sleep(1000);

                //Select Received Date                    
                if (ReceivedDate != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.dReceivedDate']/div/div/div/div/span/input")).SendKeys(ReceivedDate);
                    lib.resultUtil.AddResult("Enter FundingNeededBy", "Should enter FundingNeededBy", "Entered <<" + ReceivedDate + ">> for FundingNeededBy", "PASS");

                }
                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(10000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Next Day Verifications", "Should Search for the case Next Day Verifications", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// Function Name : clickPostAuditClose
        /// Description : Click on Post Audit Close Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickPostAuditClose()
        {
            try
            {
                // click on the Receive and Scan Documents Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Post Audit Close')]");
                lib.resultUtil.AddResult("Select Post Audit Close checkbox", "Should selectPost Audit Close checkbox", "Successfully selected Post Audit Closes checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                ////System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify Post Audit Close", "Should verify Post Audit Close", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : searchCaseIdWithPost Audit Close
        /// Description : Search for the Case Post Audit Close
        /// </summary>
        /// <param name="casIn"></param>
        /// <returns></returns>
        public static void searchCaseIdWithPostAuditClose(string casIn)
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
                //Click on the Post Audit Close
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Post Audit Close ']");
                //System.Threading.Thread.Sleep(3000);

                // Select the Independent Verified Checkbox               
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='ACR_M_LoanAction.entLoanActionClosing.bIndependentVerified']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on Documents Received and Scanned Checkbox", "Should click on Documents Received and Scanned Checkbox", "Successfully clicked on Documents Received and Scanned Checkbox", "PASS");
                //System.Threading.Thread.Sleep(1000);

                // CLick on Post-Close Checklist tab
                lib.generalLib.waitAndClick("XPATH", ".//*[@title='Post-Close Checklist']/label");
                //System.Threading.Thread.Sleep(2000);
                // Select the 'Complete' option for Post-Close Status1      
                lib.generalLib.waitAndClick("XPATH", ".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[1]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]");
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status1", "Should select << Complete >> option for Post-Close Status1", "Selected << Complete >> option Post-Close Status1", "PASS");
                // Select the 'Complete' option for Post-Close Status2
                lib.generalLib.waitAndClick("XPATH", "//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[2]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]");
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status2", "Should select << Complete >> option for Post-Close Status2", "Selected << Complete >> option Post-Close Status2", "PASS");

                IWebElement elema = lib.initializeTest.driver.FindElement(By.XPath(".//a[text()='History Log']"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elema);
                //System.Threading.Thread.Sleep(2000);

                // Select the 'Complete' option for Post-Close Status3
                lib.generalLib.waitAndClick("XPATH", ".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[3]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]");
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status3", "Should select << Complete >> option for Post-Close Status3", "Selected << Complete >> option Post-Close Status3", "PASS");
                // Select the 'Complete' option for Post-Close Status4
                lib.generalLib.waitAndClick("XPATH", "//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[4]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]");
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status4", "Should select << Complete >> option for Post-Close Status4", "Selected << Complete >> option Post-Close Status4", "PASS");
                // Select the 'Complete' option for Post-Close Status5
                lib.generalLib.waitAndClick("XPATH", ".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[5]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]");
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status5", "Should select << Complete >> option for Post-Close Status5", "Selected << Complete >> option Post-Close Status5", "PASS");
                // Select the 'Complete' option for Post-Close Status6
                lib.generalLib.waitAndClick("XPATH", ".//div[@id='ACR_M_LoanAction_colPostCloseChecklistItems']/div/div[2]/div/table/tbody[@class='ui-bizagi-grid-body']/tr[6]/td[4]/div/div/span/span/span/div/label[contains(text(),'Complete')]");
                lib.resultUtil.AddResult("Select << Complete >> option for the Post-Close Status5", "Should select << Complete >> option for Post-Close Status5", "Selected << Complete >> option Post-Close Status5", "PASS");

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(10000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Post Audit Close", "Should Search for the case Next Day Verifications", "EXCEPTION: " + e, "FAIL");
            }

        }


        /// <summary>
        /// Function Name : clickfinalCreditRequestActions
        /// Description : Click on finalCreditRequestActions Checkbox and reassign it
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static void clickfinalCreditRequestActions()
        {
            try
            {
                // click on the finalCreditRequestActions Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//input[@name='workItemAdmin'][contains(@value,'Final Credit Request Actions')]");
                lib.resultUtil.AddResult("Select finalCreditRequestActions checkbox", "Should select finalCreditRequestActions checkbox", "Successfully selected finalCreditRequestActions checkbox", "PASS");
                //// Click on the reassign Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Reassign']");
                //lib.resultUtil.AddResult("Click on the Reassign Button", "Should click on the Reassign Button", "Successfully clicked on the Reassign Button", "PASS");
                ////Enter the full username
                //lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='userNameReassignInput']")).SendKeys(username);
                //lib.resultUtil.AddResult("Enter the Username", "Should enter the Username", "Successfully enter the Username", "PASS");
                ////click on the search button
                //lib.generalLib.waitAndClick("XPATH", ".//button[@id='btn-users-table-search']/span[text()='Search']");
                //System.Threading.Thread.Sleep(3000);
                //// Click on Reassign
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()=' Reassign ']");
                //lib.resultUtil.AddResult("Click on Reassign", "Should click on Reassign", "Successfully clicked on Reassign", "PASS");
                //// Click on the Finish Button
                //lib.generalLib.waitAndClick("XPATH", ".//button/span[text()='Finish']");
                //lib.resultUtil.AddResult("Click on Finish", "Should click on Finish", "Successfully clicked on Finish", "PASS");
                ////Close the Case Window
                //lib.generalLib.waitAndClick("XPATH", ".//span[@class='bz-icon bz-icon-16 bz-icon-close-outline']");
                //lib.resultUtil.AddResult("Close the case window", "Should Close the case window", "Successfully Closed the case window", "PASS");

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Verify finalCreditRequestActions", "Should finalCreditRequestActions", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// Function Name : searchCaseIdWithFinalCreditRequestActions
        /// Description : Search for the Case Final Credit Request Actions
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
                //Click on Final Credit Request Actions
                lib.generalLib.waitAndClick("XPATH", ".//ul/li/span[text()=' Final Credit Request Actions ']");
                lib.resultUtil.AddResult("Click on on Final Credit Request Actions", "Should click on on Final Credit Request Actions", "Successfully clicked on on Final Credit Request Actions", "PASS");
                System.Threading.Thread.Sleep(3000);

                //Click on Upload Documents
                lib.generalLib.waitAndClick("XPATH", ".//a[@title='Upload Documents']/label");
                lib.resultUtil.AddResult("Click on Upload Documents", "Should click on Upload Documents", "Successfully clicked on Upload Documents", "PASS");
                //System.Threading.Thread.Sleep(2000);

                // Select the All AgVUE Documents have been uploaded to DocHub Checkbox 
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='PRC_ACR_CreditRequest.entProcessing.bDocsUploadedtoDocHub']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on All AgVUE Documents have been uploaded to DocHub Checkbox", "Should click on All AgVUE Documents have been uploaded to DocHub Checkbox", "Successfully clicked on All AgVUE Documents have been uploaded to DocHub Checkbox", "PASS");
                //System.Threading.Thread.Sleep(1000);

                // Select the All Documents have been uploaded to AgDocs Checkbox
                lib.generalLib.waitAndClick("XPATH", ".//*[@data-render-xpath='PRC_ACR_CreditRequest.entProcessing.bDocsUploadedtoAgDocs']/div/div/div/label/input");
                lib.resultUtil.AddResult("Click on All Documents have been uploaded to AgDocs Checkbox", "Should click on All Documents have been uploaded to AgDocs Checkbox", "Successfully clicked on All Documents have been uploaded to AgDocs Checkbox", "PASS");
                //System.Threading.Thread.Sleep(1000);


                ////Click on the Genarate Documents for Loan Officer Checklist
                //lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='PRC_ACR_CreditRequest.entProcessing.fileProcessingPrepChklist']/div/div/div/div/div/button")).Click();
                //lib.resultUtil.AddResult("Click on Genearate Documents for Loan Officer Checklist", "Should click on Genearate Documents for Loan Officer Checklist", "Clicked on Genearate Documents for Loan Officer Checklist", "PASS");
                

                //Click on generate Loan Narrative Documents button
                lib.generalLib.waitAndClick("XPATH", "//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.fileLoanNarrative']/div/div/div/div/div/button");
                //lib.generalLib.waitAndClick("XPATH", "//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.fileLoanNarrative']/div/div/div[1]/div/div/div[1]");
                lib.resultUtil.AddResult("Click on generate Loan Narrative  button", "Should click on generate Loan Narrative  button", "Successfully clicked on ", "PASS");

                IWebElement elema = lib.initializeTest.driver.FindElement(By.XPath("//*[@data-render-xpath='PRC_ACR_CreditRequest.entCreditAnalysis.fileLoanNarrative']/div/div/div/div/div/button"));
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js2.ExecuteScript("arguments[0].scrollIntoView(true);", elema);

                // Click on generate Loan Approval Documents button
                lib.generalLib.waitAndClick("XPATH", "//*[@data-render-xpath='PRC_ACR_CreditRequest.entDecision.fileApprovalDocGenerator']/div/div/div/div/div/button");
                lib.resultUtil.AddResult("Click on generate loan approval document button", "Should click on loan generate approval button", "Successfully clicked on ", "PASS");

                // Click on generate Documents button of Assign Conditions and Generate Commitment Letters
                //lib.generalLib.waitAndClick("XPATH", "/[@id='PRC_ACR_CreditRequest_colLoanActions']/div/div/div/div/div/button");
                lib.generalLib.waitAndClick("XPATH", "//*[@id='PRC_ACR_CreditRequest_colLoanActions']/div/div[2]/div[1]/table/tbody/tr/td[6]/div/div/span/div/div/button");
                lib.resultUtil.AddResult("Click on Generate document button", "Should click on Generate document button", "Successfully clicked on ", "PASS");


                IWebElement AssignConditions = lib.initializeTest.driver.FindElement(By.XPath("//*[@id='PRC_ACR_CreditRequest_colLoanActions']/div/div[2]/div[1]/table/tbody/tr/td[6]/div/div/span/div/div/button"));
                IJavaScriptExecutor js3 = (IJavaScriptExecutor)lib.initializeTest.driver;
                js3.ExecuteScript("arguments[0].scrollIntoView(true);", AssignConditions);


                //Click on edit button of Loan Action Checklist
                lib.generalLib.waitAndClick("XPATH", "//*[@title='Edit Loan Action Checklist']/i");
                lib.resultUtil.AddResult("Click on edit icon", "Should click on edit icon", "Successfully clicked on ", "PASS");

                //Click on generate document of edit loan checklist window
                lib.generalLib.waitAndClick("XPATH", "//*[@data-render-xpath='entLoanActionClosing2.fileFundingRequestDocument']/div/div/div/div/div/button");
                lib.resultUtil.AddResult("Click on Generate document button", "Should click on Generate document button", "Successfully clicked on ", "PASS");

                //Click on the Save Button
                lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='Save']")).Click();
                lib.resultUtil.AddResult("Click on Save button", "Should click on Save button", "Successfully clicked on ", "PASS");
                ////Click on the edit Loan Action Checklist
                //lib.generalLib.waitAndClick("XPATH", ".//*[@id='PRC_ACR_CreditRequest_colLoanActions']/div/div[2]/div/table/tbody/tr/td[7]/div/div/span/div/button[2]/i");


                //if (lib.initializeTest.driver.FindElement(By.XPath("html/body/div[6]")).Displayed)
                //{
                //    lib.resultUtil.AddResult("Edit Loan Action Checklist screen displayed", "After clicking on << + >>link Edit Loan Action Checklist screen should display", "Edit Loan Action Checklist screen displayed", "PASS");

                //    //Click on the Genarate Documents for Closing Checklist
                //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionClosing.filePreCloseChecklist']/div/div/div/div/div/button")).Click();
                //    lib.resultUtil.AddResult("Click on Genearate Documents for Closing Checklist", "Should click on Genearate Documents for Closing Checklist", "Clicked on Genearate Documents for Closing Checklist", "PASS");
                //    System.Threading.Thread.Sleep(5000);
                //    if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'pdf')]")).Displayed)
                //    {
                //        lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                //    }

                //    //Click on the Genarate Documents for Post-Close Checklist
                //    lib.initializeTest.driver.FindElement(By.XPath(".//*[@data-render-xpath='entLoanActionClosing.filePostCloseChecklist']/div/div/div/div/div/button")).Click();
                //    lib.resultUtil.AddResult("Click on Genearate Documents for Post-Close Checklist", "Should click on Genearate Documents for Post-Close Checklist", "Clicked on Genearate Documents for Post-Close Checklist", "PASS");
                //    System.Threading.Thread.Sleep(5000);
                //    if (lib.initializeTest.driver.FindElement(By.XPath(".//*[@class='ui-bizagi-document-upload-item' and contains(@data-filename,'pdf')]")).Displayed)
                //    {
                //        lib.resultUtil.AddResult("Document generates", "Should generate Document", "Document is generated successfully", "PASS");
                //    }
                //    //Click on the Save Button
                //    lib.initializeTest.driver.FindElement(By.XPath(".//span[text()='Save']")).Click();
                //}

                ////Click on Edit Loan Action icon
                //lib.generalLib.waitAndClick("XPATH", ".//span[text()='New Loan Actions']/../../div/div/table[@class='ui-bizagi-grid-table ']/tbody/tr/td[9]/div/div/span/div/button[2]/i");
                //lib.resultUtil.AddResult("Click on Edit Loan Action icon", "Should click on Edit Loan Action icon", "Clicked on <<Edit Loan Action icon>>", "PASS");


                //lib.generalLib.waitAndClick("XPATH", "//label[text()='Btn_PushLoanNarrativeDoc']/parent::following-sibling::div/div/div[1]/input");
                //lib.generalLib.waitAndClick("XPATH", "//label[text()='Btn_PushInApprovalDoc']/parent::*/following-sibling::div/div/div[1]/input");

                //Click on the Submit Button
                lib.generalLib.waitAndClick("XPATH", ".//input[@id='formButton1']");
                lib.resultUtil.AddResult("Click On Submit Button", "Should click On Submit Button", "Clicked On Submit Button", "PASS");
                //System.Threading.Thread.Sleep(10000);

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Search for the Final Credit Request Actions", "Should Search for the case Final Credit Request Actions", "EXCEPTION: " + e, "FAIL");
            }
        }

        

        //Search case id from Admin -> Cases tab
        public static Boolean adminsearchCasedev(string cID)
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
                lib.resultUtil.AddResult("Verify Search Case ID", "Should Verify Search Case ID", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        

        

    }
}