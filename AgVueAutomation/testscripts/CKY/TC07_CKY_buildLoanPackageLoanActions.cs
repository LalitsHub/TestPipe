using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC07_CKY_buildApplicationLoanPackage
    {
        /// <summary>
        /// Test Case : Build loan Package - Loan Actions
        /// Test Steps :
        /// Verify the user is logged into the application and the breadcrumb is displayed as in Build Loan Package process             
        /// Navigate to "Loan Package" tab and select "Submit for Analysis" button for Lender decision
        /// Click on "Submit to Analysis" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC07CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_07>>", "<<Build loan Package - Loan Package>>", "<<Build loan Package - Loan Package>>", "PASS");
                pages.CKYCreditRequestcs.addLoanPackage_LenderDecision(dtResult[0]["TestData1"].ToString());
            }
        }
    }
}
