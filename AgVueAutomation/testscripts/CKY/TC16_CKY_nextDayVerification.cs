using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC16_CKY_nextDayVerification
    {
        /// <summary>
        /// Test Case : Credit Request Closing - Next Day verification
        /// Test Steps :
        /// Login to the application
        /// Check whether the user receives a request in the Inbox with activity Next Day Verification". Click on the request.
        /// Select "Verified Complete" checkbox
        /// Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC16CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_16>>", "<<Credit Request Closing - Next Day verification>>", "<<Credit Request Closing - Next Day verification>>", "PASS");
                pages.CKYCreditRequestcs.selectVerifiedInNextDayVerificationTab();
            }
        }
    }
}
