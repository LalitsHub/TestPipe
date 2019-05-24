using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace AgVueAutomation.pages
{
    class creditApplications
    {
        public static IWebElement dealershipName = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Dealership']/div[2]/div[1]/div/div/input"));
        public static IWebElement storeLocation = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-1']"));
        public static IWebElement salesPerson = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-2']"));
        public static IWebElement creditApplicationType = lib.initializeTest.driver.FindElement(By.XPath("//*[@id='select2-chosen-3']"));
        public static IWebElement applicantType = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-4']"));

        /* 
         public static IWebElement firstName = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantFirstNameField']"));
         public static IWebElement middleName = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantMiddleNameField']"));
         public static IWebElement lastName = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantLastNameField']"));
         public static IWebElement suffix = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-50']"));
         public static IWebElement ssn = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantSSNField']"));
         public static IWebElement dob = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantDOBField1]"));
         public static IWebElement usCitizen = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-51']"));
         public static IWebElement yearBeganFarming = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-53']"));
         public static IWebElement addressLine1 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantAddressField']"));
         public static IWebElement addressLine2 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantAddress2Field']"));
         public static IWebElement addressLine3 = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-54']"));
         public static IWebElement emailAddress = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantEmailAddressField']"));
         public static IWebElement homePhone = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantHomePhoneField']"));
         public static IWebElement workPhone = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantWorkPhoneField']"));
         public static IWebElement cellPhone = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantCellPhoneField']"));
         public static IWebElement annualSalary = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantAnnualSalaryField']"));
         public static IWebElement otherIncome = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantOtherIncomeField']"));

         public static IWebElement grossAnnualFarmIncome = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='GrossAnnualFarmAndOrBusinessIncome']"));
         public static IWebElement primaryFarmType = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-16']"));
         public static IWebElement secondaryFarmType = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-17']"));
         public static IWebElement programType = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-5']"));
         public static IWebElement tradeinsIncluded = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-6']"));
         public static IWebElement totalEquipmentCost = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='TotalEquipmentCost']"));
         public static IWebElement salesTaxTags = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='SalesTaxTags']"));
         public static IWebElement dealerFee = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='DealerFee']"));
         public static IWebElement cashDownPayment = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='CashDownPayment']"));
         public static IWebElement netTradeAllowance = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='NetTradeAllowance']"));
         public static IWebElement totalDownPayment = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='TotalDownPayment']"));
         public static IWebElement amountRequested = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='AmountRequested']"));
         public static IWebElement termYears = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-7']"));
         public static IWebElement rateLockDays = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-8']"));
         public static IWebElement loanRateQuoted = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanRateQuoted']"));
         public static IWebElement paymentFrequency = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-9']"));
         public static IWebElement repaymentScheduleBegins = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-10']"));
         public static IWebElement specialProgramApply = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='select2-chosen-11']"));
         public static IWebElement insuranceAgentName = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='InsuranceAgentName']"));
         public static IWebElement phoneNumber = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='AgentPhoneNumber']"));
         public static IWebElement additionalInfoComments = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='AdditionalInformationAndOrComments']"));
         public static IWebElement acknowledgementCheckbox = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='ComplianceStatementConfirmed']"));
         public static IWebElement saveApplication = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='SaveApplication']"));
         public static IWebElement submitApplication = lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='SubmitApplication']")); */
        private static object driver;


        //public static Boolean addCreditApplication(string storelocation, string salesperson, string creditapplicationtype, string applicationtype, string grossanuualfarmincome, string primaryfarmproduct, string secondaryfarmproduct, string programtype, string tradeinsincluded, string totalequipmentcost, string salestax, string dealerfees, string cashdownpayment, string nettradeallowance, string totaldownpayment, string amountrequested, string term, string ratelockdays, string loanratequoated, string paymentfrequency, string repaymentschedule, string specialprogram, string insuranceagentname, string phoneno, string additionalinfo)
        public static Boolean addCreditApplication(string storelocation, string salesperson, string creditapplicationtype, string applicanttype, string firstname, string middlename, string lastname, string suffix, string ssn, string uscitizen, string dob, string yearbeganfarming, string addline1, string addline2, string addline3, string countyname, string email, string homePhone, string workPhone, string cellphone, string annualsal, string otherincome, string affiliation, string grossannualincome, string primaryfarmproduct, string secondryfarmproduct)
        {
            Boolean ret = false;
            try
            {
                //Select Store Location
                if (storelocation != "")
                {
                    storeLocation.Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div[contains(text(), '" + storelocation + "')]")).Click();
                    lib.resultUtil.AddResult("Select Store Location", "Should select <<" + storelocation + ">> Store Location", "Selected <<" + storelocation + ">> Store Location", "PASS");
                }
                //Select Salesperson
                if (salesperson != "")
                {
                    salesPerson.Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[contains(text(),'" + salesperson + "')]")).Click();
                    lib.resultUtil.AddResult("Select Salesperson", "Should select <<" + salesperson + ">> Salesperson", "Selected <<" + salesperson + ">> Salesperson", "PASS");
                }
                //Select Credit Application Type
                if (creditapplicationtype != "")
                {
                    creditApplicationType.Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[contains(text(),'" + creditapplicationtype + "')]")).Click();
                    lib.resultUtil.AddResult("Select Credit Application Type", "Should select <<" + creditapplicationtype + ">> Credit Application Type", "Selected <<" + creditapplicationtype + ">> Credit Application Type", "PASS");
                }
                //Select Applicant Type
                if (applicanttype != "")
                {
                    applicantType.Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div/ul[@class='select2-results']/li/div[contains(text(),'" + applicanttype + "')]")).Click();
                    lib.resultUtil.AddResult("Select Applicant Type", "Should select <<" + applicanttype + ">> Applicant Type", "Selected <<" + applicanttype + ">> Applicant Type", "PASS");
                }
                //Enter First Name
                if (firstname != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantFirstNameField']")).SendKeys(firstname);
                    lib.resultUtil.AddResult("Enter First Name", "Should enter <<" + firstname + ">> for First Name", "Entered <<" + firstname + ">> for First Name", "PASS");
                }
                //Enter Middle Name
                if (middlename != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantMiddleNameField']")).SendKeys(middlename);
                    lib.resultUtil.AddResult("Enter Middle Name", "Should enter <<" + middlename + ">> for Middle Name", "Entered <<" + middlename + ">> for Middle Name", "PASS");
                }
                //Enter Last Name
                if (lastname != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantLastNameField']")).SendKeys(lastname);
                    lib.resultUtil.AddResult("Enter Last Name", "Should enter <<" + lastname + ">> for Last Name", "Entered <<" + lastname + ">> for Last Name", "PASS");
                }
                //Select Suffix
                if (suffix != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='s2id_Applicant1ApplicantSuffixField']/a/span[2]/b")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[contains(text(),'" + suffix + "')]")).Click();
                    lib.resultUtil.AddResult("Select Suffix", "Should select <<" + suffix + ">> Suffix", "Selected <<" + suffix + ">> Suffix", "PASS");
                }
                //Enter SSN
                if (ssn != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantSSNField']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantSSNField']")).SendKeys(ssn);
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1']/div/div[2]/div[2]/label[1]")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantSSNField']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantSSNField']")).SendKeys(Keys.Control + "a");
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantSSNField']")).SendKeys(ssn);
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1']/div/div[2]/div[2]/label[1]")).Click();
                    lib.resultUtil.AddResult("Enter SSN", "Should enter <<" + ssn + ">> for Social Security Number", "Entered <<" + ssn + ">> for Social Security Number", "PASS");
                }

                //Select US Citizen
                if (uscitizen != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='s2id_Applicant1ApplicantIsUSCitizenField']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[contains(text(),'" + uscitizen + "')]")).Click();
                    lib.resultUtil.AddResult("Select US Citizen option", "Should select <<" + uscitizen + ">> to US Citizen", "Selected <<" + uscitizen + ">> to US Citizen", "PASS");
                }
                //Enter DOB
                if (dob != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//*[@id='Applicant1ApplicantDOBField']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath("//*[@id='Applicant1ApplicantDOBField']")).SendKeys(dob);
                    lib.resultUtil.AddResult("Enter Date of Birth", "Should enter <<" + dob + ">> for Date of Birth", "Entered <<" + dob + ">> for Date of Birth", "PASS");
                }

                //Select Year Began Farming
                if (yearbeganfarming != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//*[@id='Applicant1ApplicantDOBField']")).SendKeys(Keys.Tab);
                    lib.initializeTest.driver.FindElement(By.XPath(".//label[contains(text(),'Year Began Farming')]/../div[3]/div/a")).Click();
                    //System.Threading.Thread.Sleep(2000);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active select2-drop-above']/ul[@class='select2-results']/li/div[contains(text(),'" + yearbeganfarming + "')]")).Click();
                    lib.resultUtil.AddResult("Select Year Began Farming option", "Should select <<" + yearbeganfarming + ">> for Year Began Framing", "Selected <<" + yearbeganfarming + ">> for Year Began Farming", "PASS");
                }

                //Enter Address Line 1
                if (addline1 != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantAddressField']")).SendKeys(addline1);
                    lib.resultUtil.AddResult("Enter Address Line1", "Should enter <<" + addline1 + ">> for Address Line1", "Entered <<" + addline1 + ">> for Address Line1", "PASS");
                }
                //Enter Address Line 2
                if (addline2 != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='Applicant1ApplicantAddress2Field']")).SendKeys(addline2);
                    lib.resultUtil.AddResult("Enter Address Line2", "Should enter <<" + addline2 + ">> for Address Line2", "Entered <<" + addline2 + ">> for Address Line2", "PASS");
                }
                //Enter Zipcode
                if (addline3 != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-container form-control ziplookup']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='select2-drop']/div/input")).SendKeys(addline3);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='select2-drop']/ul/li/div/div/div[contains(text(),'" + countyname + "')]")).Click();
                    lib.resultUtil.AddResult("Enter Zipcode", "Should select <<" + addline3 + ">> for Zipcode", "Entered <<" + addline3 + ">> for Zipcode", "PASS");
                    System.Threading.Thread.Sleep(5000);
                }

                //Email Address
                if (email != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@id='Applicant1ApplicantEmailAddressField']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@id='Applicant1ApplicantEmailAddressField']")).SendKeys(email);
                    lib.resultUtil.AddResult("Enter emailAddress", "Should select <<" + email + ">> for emailAddress", "Entered <<" + email + ">> for emailAddress", "PASS");
                }
                //Home Phone
                if (homePhone != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@placeholder='Home Phone']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@placeholder='Home Phone']")).SendKeys(homePhone);
                    lib.resultUtil.AddResult("Enter Phone Number", "Should select <<" + homePhone + ">> for Phone Number", "Entered <<" + homePhone + ">> for Phone Number", "PASS");
                }
                //Work Phone
                if (workPhone != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@placeholder='Work Phone']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@placeholder='Work Phone']")).SendKeys(workPhone);
                    lib.resultUtil.AddResult("Enter Phone Number", "Should select <<" + workPhone + ">> for Phone Number", "Entered <<" + workPhone + ">> for Phone Number", "PASS");
                }
                //Cell Phone
                if (cellphone != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@placeholder='Cell Phone']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@placeholder='Cell Phone']")).SendKeys(cellphone);
                    lib.resultUtil.AddResult("Enter Phone Number", "Should select <<" + cellphone + ">> for Phone Number", "Entered <<" + cellphone + ">> for Phone Number", "PASS");
                }
                //Annual Salary
                if (annualsal != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@id='Applicant1ApplicantAnnualSalaryField']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@id='Applicant1ApplicantAnnualSalaryField']")).SendKeys(annualsal);
                    lib.resultUtil.AddResult("Enter Annual Salary", "Should select <<" + annualsal + ">> for Annual Salary", "Entered <<" + annualsal + ">> for Annual Salary", "PASS");
                }
                //Other Income
                if (otherincome != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@id='Applicant1ApplicantOtherIncomeField']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@id='Applicant1ApplicantOtherIncomeField']")).SendKeys(otherincome);
                    lib.resultUtil.AddResult("Enter Other Income", "Should select <<" + otherincome + ">> for Other Income", "Entered <<" + otherincome + ">> for Other Income", "PASS");
                }


                //Affiliation
                if (affiliation != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='s2id_Affiliation']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[contains(text(),'" + affiliation + "')]")).Click();
                    lib.resultUtil.AddResult("Enter Affiliation", "Should select <<" + affiliation + ">> for affiliation", "Entered <<" + affiliation + ">>for afiliation", "PASS");
                }
                //Gross Annual Income
                if (grossannualincome != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='GrossAnnualFarmAndOrBusinessIncome']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='GrossAnnualFarmAndOrBusinessIncome']")).SendKeys(grossannualincome);
                    lib.resultUtil.AddResult("Enter Gross Annual Income", "Should select <<" + grossannualincome + ">> for Gross Annual Income", "Entered <<" + grossannualincome + ">>for Gross Annual Income", "PASS");
                }
                //Primary Farm Product
                if (primaryfarmproduct != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='s2id_PrimaryFarmProductID']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[contains(text(), '" + primaryfarmproduct + "')]")).Click();
                    lib.resultUtil.AddResult("Enter Primary Farm Product", "Should select <<" + primaryfarmproduct + ">> for Primary Farm Product", "Entered <<" + primaryfarmproduct + ">>for Primary Farm Product", "PASS");
                }
                //Secondry Farm Product
                if (secondryfarmproduct != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='s2id_SecondaryFarmProductID']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[contains(text(), '" + secondryfarmproduct + "')]")).Click();
                    lib.resultUtil.AddResult("Enter Primary Farm Product", "Should select <<" + primaryfarmproduct + ">> for Primary Farm Product", "Entered <<" + primaryfarmproduct + ">>for Primary Farm Product", "PASS");
                }
                ret = true;
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add Credit Application", "Add Credit Application was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        //Applicant Verification

      /*  public static Boolean applicantType(string applicant)
        {
            Boolean ret = false;

            try
            {
                IWebElement applicantCount = lib.initializeTest.driver.FindElement(By.XPath("//a[text()='Applicants ']/span"));
                string applicant1 = applicantCount.Text;
                if(applicant1==applicant)
                {
                    lib.resultUtil.AddResult("cash down paymeent calculation", "<<" + msg2 + ">> ", "<<" + msg2 + ">>", "PASS");
                }

                ret = true;
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("cash down payment calculation", " cash down payment calculation", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }*/


        public static Boolean selectProgramType(string programtype)
        {
            Boolean ret = false;
            try
            {
                //Program Type
                if (programtype != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='s2id_ProgramTypeChoice']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[contains(text(), '" + programtype + "')]")).Click();
                    lib.resultUtil.AddResult("Enter Program Type", "Should select <<" + programtype + ">> for Program Type", "Entered <<" + programtype + ">>for Program Type", "PASS");
                    System.Threading.Thread.Sleep(1000);
                }
                ret = true;
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("Program Type", "Add Program Type was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;

        }
        public static Boolean newUsedEquipment(string type, string year, string make, string model, string serialnum, string price, string description)
        {
            Boolean ret = false;
            try
            {
                //Enter type of equipment
                if (type != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//div[@id='s2id_LoanEquipment0TypeField']/a")).Click();
                    System.Threading.Thread.Sleep(5000);
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[text()='" + type + "']")).Click();
                    lib.resultUtil.AddResult("Enter equipment Type", "Should select <<" + type + ">> for equipment Type", "Entered <<" + type + ">>for equipment Type", "PASS");
                }
                //Enter Year
                if (year != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//div[@id='s2id_LoanEquipment0YearField']/a")).Click();
                    System.Threading.Thread.Sleep(5000);
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[contains(text(), '" + year + "')]")).Click();
                    lib.resultUtil.AddResult("Enter equipment year", "Should select <<" + year + ">> for equipment year", "Entered <<" + type + ">>for equipment year", "PASS");
                }
                //Enter Make
                if (make != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='s2id_LoanEquipment0MakeField']/a")).Click();
                    System.Threading.Thread.Sleep(5000);
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[text()= '" + make + "']")).Click();
                    lib.resultUtil.AddResult("Enter equipment make", "Should select <<" + make + ">> for equipment make", "Entered <<" + make + ">>for equipment make", "PASS");
                }
                //Enter Model
                if (model != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='s2id_LoanEquipment0ModelField']/a")).Click();
                    System.Threading.Thread.Sleep(5000);
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[text()= '" + model + "']")).Click();
                    lib.resultUtil.AddResult("Enter equipment model", "Should select <<" + model + ">> for equipment model", "Entered <<" + model + ">>for equipment model", "PASS");
                }
                //Enter Serial #
                if (serialnum != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0SerialNumberField']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0SerialNumberField']")).SendKeys(serialnum);
                    lib.resultUtil.AddResult("Enter equipment serial #", "Should select <<" + serialnum + ">> for equipment serial #", "Entered <<" + serialnum + ">>for equipment serial #", "PASS");
                }
                //Enter Price
                if (price != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0PriceField']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0PriceField']")).SendKeys(price);
                    lib.resultUtil.AddResult("Enter equipment price", "Should select <<" + price + ">> for equipment price", "Entered <<" + price + ">>for equipment price", "PASS");
                }
                //Enter Description
                if (description != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0DescriptionField']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0DescriptionField']")).SendKeys(description);
                    lib.resultUtil.AddResult("Enter equipment description", "Should select <<" + description + ">> for equipment description", "Entered <<" + description + ">>for equipment description", "PASS");
                }
                ret = true;

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Equipment Type", "Add Equipment Type was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        public static Boolean precisionAgandTelematics(string type, string NewORUsed, string price, string description)
        {
            Boolean ret = false;
            try
            {
                //Enter Type
                if (type != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath("//div[@id='s2id_LoanEquipment0TypeField']/a")).Click();
                    System.Threading.Thread.Sleep(2000);
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[text()='" + type + "']")).Click();
                    lib.resultUtil.AddResult("Enter equipment Type", "Should select <<" + type + ">> for equipment Type", "Entered <<" + type + ">>for equipment Type", "PASS");
                }
                //Enter New/Used
                if (NewORUsed != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_LoanEquipment0NewUsedField']/a")).Click();
                    System.Threading.Thread.Sleep(2000);
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[text() = '" + NewORUsed + "']")).Click();
                    lib.resultUtil.AddResult("Enter New/Used", "Should select <<" + NewORUsed + ">> for New/Used", "Entered <<" + NewORUsed + ">>for New/Used", "PASS");

                }
                //Enter Price
                if (price != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0PriceField']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0PriceField']")).SendKeys(price);
                    lib.resultUtil.AddResult("Enter equipment price", "Should select <<" + price + ">> for equipment price", "Entered <<" + price + ">>for equipment price", "PASS");
                }
                //Enter Description
                if (description != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0DescriptionField']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment0DescriptionField']")).SendKeys(description);
                    lib.resultUtil.AddResult("Enter equipment description", "Should select <<" + description + ">> for equipment description", "Entered <<" + description + ">>for equipment description", "PASS");
                }
                ret = true;

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Equipment Type", "Add Equipment Type was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;

        }
        public static Boolean addEquipment()
        {
            Boolean ret = false;
            try
            {
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@class='btn btn-info add-loan-equipment']")).Click();
                lib.resultUtil.AddResult("Add additional Equipment", "Should select add additional equipment", "Clicked on add additional equipment", "PASS");
                ret = true;
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add New Equipment", "Click on add new Equipment was not successfull", "EXCEPTION: " + e, "FAIL");
            }
            return ret;

        }
        public static Boolean equipmentDescription(string type, string year, string make, string model, string serialnum, string price, string description)
        {
            Boolean ret = false;
            try
            {
                //Enter Type
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_LoanEquipment1TypeField']/a")).Click();
                System.Threading.Thread.Sleep(2000);
                lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[text()='" + type + "']")).Click();
                lib.resultUtil.AddResult("Enter equipment Type", "Should select <<" + type + ">> for equipment Type", "Entered <<" + type + ">>for equipment Type", "PASS");

                //Enter Year
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_LoanEquipment1YearField']/a")).Click();
                System.Threading.Thread.Sleep(2000);
                lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[text()='" + year + "']")).Click();
                lib.resultUtil.AddResult("Enter equipment Year", "Should select <<" + year + ">> for equipment Year", "Entered <<" + year + ">>for equipment year", "PASS");

                //Enter Make
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_LoanEquipment1MakeField']/a")).Click();
                System.Threading.Thread.Sleep(2000);
                lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[text()='" + make + "']")).Click();
                lib.resultUtil.AddResult("Enter equipment Make", "Should select <<" + make + ">> for equipment make", "Entered <<" + make + ">>for equipment make", "PASS");

                //Enter Model
                lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_LoanEquipment1ModelField']/a")).Click();
                System.Threading.Thread.Sleep(2000);
                lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div/div[text()='" + model + "']")).Click();
                lib.resultUtil.AddResult("Enter equipment model", "Should select <<" + model + ">> for equipment model", "Entered <<" + model + ">>for equipment model", "PASS");

                //Enter Serial #
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='LoanEquipment1SerialNumberField']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='LoanEquipment1SerialNumberField']")).SendKeys(serialnum);
                lib.resultUtil.AddResult("Enter Serial Number", "Should select <<" + serialnum + ">> for Serial Number", "Entered <<" + serialnum + ">>for Serial Number", "PASS");

                //Enter Price
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='LoanEquipment1PriceField']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//input[@id='LoanEquipment1PriceField']")).SendKeys(price);
                lib.resultUtil.AddResult("Enter price", "Should select <<" + price + ">> for price", "Entered <<" + price + ">>for price", "PASS");

                //Enter Description
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment1DescriptionField']")).Click();
                lib.initializeTest.driver.FindElement(By.XPath(".//*[@id='LoanEquipment1DescriptionField']")).SendKeys(description);
                lib.resultUtil.AddResult("Enter Description", "Should select <<" + description + ">> for Description", "Entered <<" + description + ">>for Description", "PASS");

                ret = true;
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Add New Equipment", "Click on add new Equipment was not successfull", "EXCEPTION: " + e, "FAIL");
            }
            return ret;

        }

        public static Boolean tradeIn(string trade)
        {
            Boolean ret = false;
            try
            {
                //Enter trade-In Included
                if (trade != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_TradeInsIncludedSelect']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li[2]/div[contains(text(), '" + trade + "')]")).Click();
                    lib.resultUtil.AddResult("Enter Trade In", "Should select <<" + trade + ">> for Trade In", "Entered <<" + trade + ">>for Trade In", "PASS");
                    ret = true;
                }
                ret = true;


            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Trade In", "Add Trade In was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;

        }
        public static Boolean transactionInformation(string terms, string ratelockdays, string paymentFrequency)
        {
            Boolean ret = false;
            try
            {

                //Enter Terms
                if (terms != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_TermYearsDropdown']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@class='select2-drop select2-display-none select2-with-searchbox select2-drop-active']/ul[@class='select2-results']/li/div[(text() = '" + terms + "')]")).Click();
                    lib.resultUtil.AddResult("Enter terms", "Should select <<" + terms + ">> for terms", "Entered <<" + terms + ">>for terms", "PASS");
                }
                //Enter Rate Lock Days
                if (ratelockdays != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_APSRateLockDaysField']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div[contains(text() , '" + ratelockdays + "')]")).Click();
                    lib.resultUtil.AddResult("Enter Rate Lock Days", "Should select <<" + terms + ">> for Rate Lock Days", "Entered <<" + terms + ">>for Rate Lock Days", "PASS");
                }
                //Payment Frequency
                if (paymentFrequency != "")
                {
                    lib.initializeTest.driver.FindElement(By.XPath(".//div[@id='s2id_PaymentFrequencyDropdown']/a")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath(".//ul[@class='select2-results']/li/div[contains(text() , '" + paymentFrequency + "')]")).Click();
                    lib.resultUtil.AddResult("Enter Payment Frequency", "Should select <<" + paymentFrequency + ">> for Payment Frequency", "Entered <<" + paymentFrequency + ">>for Rate Lock Days", "PASS");
                }
                ret = true;
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Transaction Information", "Add Transaction Information was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean downpaymentValidation(string message)
        {
            Boolean ret = false;
            try
            {
               IWebElement validationMessage =  lib.initializeTest.driver.FindElement(By.XPath("//input[@id='TotalDownPayment']/../../div/span"));
                string message1 = validationMessage.Text;
                System.Console.WriteLine("Validation message = " + message1 );
                if (message1.Contains(message))
                {
                    lib.resultUtil.AddResult("Validation message", "<<" + message + ">> validation message", "<<" + message + ">>validation Message", "PASS");
                }

                ret = true;
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Validation Message", " Validation Message was not displayed", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean PercentDownpayment()
       {
          Boolean ret = false;

          try
           {
               IWebElement downpaymentMessage = lib.initializeTest.driver.FindElement(By.XPath("//input[@id='TotalDownPayment']/../../div/span"));
               string msg = downpaymentMessage.Text;
                string msg1 = msg.Remove(0, 34);
                System.Console.WriteLine(msg1);
                if (msg1.Length > 1)
                {
                    string msg2 = msg1.Substring(0, msg1.Length - 1);
                    System.Console.WriteLine(msg2);
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@id='CashDownPayment']")).Click();
                    lib.initializeTest.driver.FindElement(By.XPath("//input[@id='CashDownPayment']")).SendKeys(msg2);
                    lib.resultUtil.AddResult("cash down paymeent calculation", "<<" + msg2 + ">> ", "<<" + msg2 + ">>", "PASS");
                }

                ret = true;
            }

            catch (Exception e)
            {
                lib.resultUtil.AddResult("cash down payment calculation", " cash down payment calculation", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }

        public static Boolean disclosureAcknowlegement()
        {
            Boolean ret = false;
            try
            {
                //click on agreement
                lib.initializeTest.driver.FindElement(By.XPath("//input[@id='ComplianceStatementConfirmed']")).Click();
                ret = true;
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Disclosure Acknowledgement", "Add Disclosure Acknowledgement was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean saveApplication()
        {
            Boolean ret = false;
            try
            {
                lib.initializeTest.driver.FindElement(By.XPath(".//a[@id='SaveApplication']")).Click();
                ret = true;
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("save application", "save application was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean successfullSaveOk()
        {
            Boolean ret = false;
            try
            {
                lib.initializeTest.driver.FindElement(By.XPath("//button[@class='btn btn-default']")).Click();

                ret = true;

            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Click ok", "click ok was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
        public static Boolean submitApplication()
        {
            Boolean ret = false;
            try
            {
                lib.initializeTest.driver.FindElement(By.XPath("//a[@id='SubmitApplication']")).Click();
                System.Threading.Thread.Sleep(20000);                

                ret = true;


            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Click Submit Application", "click Submit Applications was not successful", "EXCEPTION: " + e, "FAIL");
            }
            return ret;
        }
    }

}