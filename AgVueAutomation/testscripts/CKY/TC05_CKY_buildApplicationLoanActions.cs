using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC05_CKY_buildApplicationLoanActions
    {
        /// <summary>
        /// Test Case : Build loan  - Loan Actions
        /// Test Steps :
        /// Verify the user is logged into the application and the breadcrumb is displayed as in Build Loan Package process
        /// Click on "Loan Actions" tab         
        /// Underwriting Type - Select the "AgScore" from drop down        
        /// Click on "Submit to Analysis" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC05CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_05>>", "<<Build Loan Package - Loan Actions>>", "<<Build Loan Package - Loan Actions>>", "PASS");
                // Add Loan Action details
                pages.CKYCreditRequestcs.addLoanAction_Underwriting(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString());
                System.Threading.Thread.Sleep(3000);                
            }
        }
    }
}
