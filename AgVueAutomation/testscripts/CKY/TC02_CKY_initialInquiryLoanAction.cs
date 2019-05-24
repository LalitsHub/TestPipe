using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC02_CKY_initialInquiryLoanAction
    {
        /// <summary>
        /// Test Case : Initial Inquiry - Loan Action
        /// Test Steps :
        /// 1.Click on "Loan Actions" tab
        /// 2.Select "Branch" from the drop down
        /// 3.Click "+" to add Loan actions
        /// 4."Enter/Select the field values for below, [Red Vertical bars indicates mandatory fields]
        ///     a) Loan Action Type - Select ""New""
        ///     b) Loan Action Code - Select ""LNW- New Loan"" from the drop down
        ///     c) Is borrowser(s) a Natural Person or Land Trust(tax, land, or estate planning)?: Select ""Yes""
        ///     d) Will loan proceeds be used primarily for personal, family or household use?: Select ""Yes""
        ///     e) Will the proposed loan be closed-end and secured by real property?: Select ""No""
        ///     f) Term(Months) : Enter terms in months for loan(For Ex: 36)
        ///     g) Loan Amount: Enter the loan amount(For Ex: 100000)
        ///     h) Loan Purpose: Select the value from the drop down
        ///     Then click on ""Save"" button"
        /// 5.Click on "Save" button to save the credit request
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC02CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_02>>", "<<Initial Inquiry - Inquiry>>", "<<Initial Inquiry - Inquiry>>", "PASS");
                // Add Loan actions
                pages.CKYCreditRequestcs.addLoanActionsAG(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString(), dtResult[0]["TestData4"].ToString(), dtResult[0]["TestData5"].ToString());
            }
        }
    }
}
